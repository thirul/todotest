/// <reference path="models/personViewModel.js" />

$(document).ready(function () {
    ko.applyBindings(new PersonViewModel());
})