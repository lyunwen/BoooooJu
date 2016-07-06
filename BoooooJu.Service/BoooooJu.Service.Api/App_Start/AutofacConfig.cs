using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using System.Web.Http;

namespace BoooooJu.Service.Api
{
    public class AutofacConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).Where(t => !t.IsAbstract && typeof(ApiController).IsAssignableFrom(t));
            builder.RegisterType<Dal.Aspects.User.UserRegister>().As<Dal.Aspects.User.IUserRegister>();
            builder.RegisterType<Dal.Aspects.User.UserQuery>().As<Dal.Aspects.User.IUserQuery>();
            builder.RegisterType<Dal.Aspects.User.UserRecord>().As<Dal.Aspects.User.IUserRecord>(); 
            var container = builder.Build(); 
            var resolver = new AutofacWebApiDependencyResolver(container);
            config.DependencyResolver = resolver;
        }
    }
}