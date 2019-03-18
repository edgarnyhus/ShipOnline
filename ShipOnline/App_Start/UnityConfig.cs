using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ShipOnline.Core;
using ShipOnline.Models;
using ShipOnline.Persistence;
using ShipOnline.ViewModels;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace ShipOnline
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>();
            //container.RegisterType<ApplicationDbContext>(new InjectionConstructor());
            container.RegisterType<Controllers.AccountController>(new InjectionConstructor());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}