using Autofac;
using Autofac.Integration.Mvc;
using BoooooJu.Web.Core.GetUserService;
using BoooooJu.Web.Core.SetUserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.App_Start
{
    public class IOCContainerConfig
    {
        public IDependencyResolver Config()
        {
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            return new AutofacDependencyResolver(container);
        }
        private void SetupResolveRules(ContainerBuilder builder)
        {
            builder.RegisterType<SetUserClient>().As<ISetUser>();
            builder.RegisterType<GetUserClient>().As<IGetUser>();
        }
    }
}
