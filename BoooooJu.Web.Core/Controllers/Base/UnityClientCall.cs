using Autofac;
using BoooooJu.Web.Core.GetUserService;
using BoooooJu.Web.Core.SetUserService;
using System;
using System.ServiceModel;

namespace BoooooJu.Web.Core.Controllers.Base
{
    public class UnityClientCall<T> : ClientBase<T> where T : class
    {
        private const string USERNAME = "boooooju.com";
        private const string PASSWORD = "123456";
        static UnityClientCall()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SetUserClient>().As<ISetUser>();
            builder.RegisterType<GetUserClient>().As<IGetUser>();
            //  using (var container = builder.Build())
            container = builder.Build();
            // builder.RegisterModule(new ConfigurationSettingsReader("autofac"));
        }
        public UnityClientCall()
        {

        }
        public readonly static IContainer container;
        public static volatile T t = null;
        private static object syncRoot = new object();
        public static T GetClient()
        {
            if (t == null)
            {
                lock (syncRoot)
                {
                    if (t == null)
                    {
                        t = container.Resolve<T>();
                        var foo = t as ClientBase<T>;
                        if (foo == null)
                        {
                            throw new ArgumentNullException("泛型参数非WFC终结点。");
                        }
                        else
                        {
                            foo.ClientCredentials.UserName.UserName = USERNAME;
                            foo.ClientCredentials.UserName.Password = PASSWORD;
                        }
                    }
                }
            }
            return t;  
        }
    }
}
