using Autofac;
using Autofac.Integration.Mvc;
using AutoFacService.Abstract;
using AutoFacService.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AutoFacExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            //Ioc
            //Autofac için, yeni bir container oluşturuyoruz
            ContainerBuilder builder = new ContainerBuilder();
            /*
             * Controller sınıflarının constructer metotlarına
             * injection yapılabilmesi için builder nesnesi register ediyoruz.    
             */
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            //Sıra servisleri register yapmakta. Burada istediğiniz interface ile 
            // onu gerçekleyen sınıfıları arasında register işlemi yapabilirsiniz.
            builder.RegisterType<UserService>().As<IUserService>();

            //builder nesnesini build edip son olarak varsayılan resolver olarak 
            //ayarlıyoruz. Kısaca kullanımı Asp.Net MVC için açmış oluyoruz.
            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
