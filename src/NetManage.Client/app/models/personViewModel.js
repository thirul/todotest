var PersonViewModel = function () {
    var vm = this;
    vm.firstName = ko.observable("Thirupathi");
    vm.lastName = ko.observable("Sudagoni");
    vm.movies = ko.observableArray([]);
    vm.products = ko.observableArray([]);
    vm.isLoading = ko.observable(false);
    vm.noResults = ko.observable("");
    vm.searchKeyword = ko.observable("frozen");
    vm.addProductResult = ko.observable("");
    vm.searchMovies = function () {

        var keyWord = vm.searchKeyword();
        var url = "http://www.omdbapi.com/?y=&plot=short&r=json&s=" + keyWord;
        vm.movies([]);
        vm.isLoading(true);
        $.ajax({
            url:url,
            type: "GET",            
            //contentType: "application/json",
            success: function (result) {
                vm.isLoading(false);
                if (result.Search) {
                    vm.movies(result.Search);
                    
                }
                else {
                    vm.noResults("no results found");
                }
            },
            error: function () {
                vm.isLoading(false);
                alert('error');
            }
        });

    }

    vm.getProducts = function () {
        var url = "http://localhost:60570/api/products";
        $.ajax({
            url: url,
            type: "GET",
            contentType: "application/json",
            success: function (result) {
                    vm.products(result);
            },
            error: function () {
                alert('error');
            }
        });
    }

    vm.addProduct = function () {
        var url = "http://localhost:60570/api/product";
        var model = { id: 1, name: "hello", price: 12.21 };

        $.ajax({
            type: 'POST',
            url: url,
            data: JSON.stringify(model),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (result) {
                vm.addProductResult(JSON.stringify( result));
            }
        });
    }
}

var MovieViewModel = function (title,year) {
    var vm = this;
    vm.Title = ko.observable(title);
    vm.Year = ko.observable(year);

}

