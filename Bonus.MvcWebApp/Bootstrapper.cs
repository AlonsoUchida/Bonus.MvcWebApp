using System.Web.Http;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Bonus.MvcWebApp.UnityResolver;
using System;
namespace Bonus.MvcWebApp
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            System.Web.Mvc.DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // register dependency resolver for WebAPI RC
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            //Component initialization via MEF
            ComponentLoader.LoadContainer(container, ".\\bin", "Bonus.MvcWebApp.dll");
            ComponentLoader.LoadContainer(container, ".\\bin", "Bonus.MvcWebApp.BusinessServices.dll");
        }
    }
}