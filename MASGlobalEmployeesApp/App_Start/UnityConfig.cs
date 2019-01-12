using DataLayer;
using Services;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace MASGlobalEmployeesApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IEmployeesService, EmployeesService>();
            container.RegisterType<IEmployeesRepository, EmployeesRepository>();



            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}