using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;
using UnityService.Abstract;
using UnityService.Concrete;

namespace UnityExample.Ioc
{
    public static class IocContainer
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            container.RegisterType<IPersonService, PersonService>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}