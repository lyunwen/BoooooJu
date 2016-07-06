using Autofac;
using BoooooJu.WeChat.Core.Clients.Base;
using Common.Logger;

namespace BoooooJu.WeChat.Core.Clients
{
    public class UnityLogerCall<T> : UnityServicerCall<T> where T : class
    {
        static UnityLogerCall()
        {
            container = new LogerContainerConfig().GetContainer();
        }
    }
    internal class LogerContainerConfig : ServicerContainerConfig
    {
        internal override void RegisterType(ContainerBuilder builder)
        { 
            builder.RegisterType<DefaultLogger>().As<ILogger>();
        }
    }
}