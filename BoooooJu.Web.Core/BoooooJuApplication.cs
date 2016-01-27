using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Configuration;
using BoooooJu.Web.Core.SetUserService;
using BoooooJu.Web.Core.GetUserService;
using FluentValidation;
using FluentValidation.Mvc;

namespace BoooooJu.Web.Core
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ValidatorOptions.CascadeMode = CascadeMode.StopOnFirstFailure;
            FluentValidationModelValidatorProvider.Configure();

            DependencyResolver.SetResolver(new App_Start.IOCContainerConfig().Config());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
 
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new App_Start.BoooJuViewEngine());





        }
        private void SetupResolveRules(ContainerBuilder builder)
        { 
            builder.RegisterType<SetUserClient>().As<ISetUser>();
            builder.RegisterType<GetUserClient>().As<IGetUser>(); 
        }
    }
}