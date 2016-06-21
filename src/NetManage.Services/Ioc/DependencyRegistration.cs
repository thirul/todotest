using System.Reflection;
using System.Web.Compilation;
using System.Web.Http.Dependencies;
using Autofac;
using Autofac.Integration.WebApi;
using NetManage.Services.Core;


namespace Watson.Client.Services.Ioc
{
    public static class DependencyRegistration
    {
        public static IDependencyResolver BuildResolver()
        {
            var container = BuildContainer();
            return new AutofacWebApiDependencyResolver(container);
        }

        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            Register(builder);

            var container = builder.Build();
            return container;
        }

        private static void Register(ContainerBuilder builder)
        {
            RegisterTypes(builder);
            RegisterControllers(builder);
        }

        private static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().As<IProductService>();
            
        }

        private static void RegisterControllers(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }
    }
}