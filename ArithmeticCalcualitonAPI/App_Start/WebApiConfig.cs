using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using ArithmeticCalcualitonAPI.Calculation;
using ArithmeticCalcualitonAPI.Controllers;

namespace ArithmeticCalcualitonAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            //AUTOFAC

            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var configs = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<OperationController>();

            RegisterMathOperations(builder);

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(configs);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();



            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}/{id2}"
            );
        }

        private static void RegisterMathOperations(ContainerBuilder builder)
        {
            builder.RegisterType<AddModel>().As<IAddModel>().InstancePerLifetimeScope();
            builder.RegisterType<DifferenceModel>().As<IDifferenceModel>().InstancePerLifetimeScope();
            builder.RegisterType<ProductModel>().As<IProductModel>().InstancePerLifetimeScope();
            builder.RegisterType<DivideModel>().As<IDivideModel>().InstancePerLifetimeScope();
        }
    }
}
