using System.Web.Mvc;
using BloodManagmentSystem.Repositories;
using BloodManagmentSystem.Services;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;

namespace Bootstrapper
{
    public class Bootstrapper
    {
        public static IUnityContainer Initialize()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IBloodService, BloodService>();
            container.RegisterType<IBloodRepository, BloodRepository>();
            return container;
        }
    }
}