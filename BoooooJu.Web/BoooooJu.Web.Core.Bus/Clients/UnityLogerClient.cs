//using Autofac;
//using BoooooJu.Web.Core.Clients.Base;
//using Common.Logger;

//namespace BoooooJu.Web.Core.Clients
//{
//    public class UnityLogerClient : UnityBaseClient<ILoggerFactory>
//    {
//        static UnityLogerClient()
//        {
//            container = new LogerContainerConfig().GetContainer();
//        }
//    }
//    internal class LogerContainerConfig : ServicerContainerConfig
//    {
//        internal override void RegisterType(ContainerBuilder builder)
//        {
//            builder.RegisterType<DefaultLoggerFactory>().As<ILoggerFactory>();
//            builder.RegisterType<DefaultLoggerManager>().As<ILoggerManager>();
//        }
//    }
//}