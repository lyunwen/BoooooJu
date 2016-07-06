//using Autofac;
//using BoooooJu.Web.Core.AccountService;
//using System;
//using System.ServiceModel;
//using BoooooJu.Web.Core.Clients.Base;
//using BoooooJu.Web.Core.DiancanService;

//namespace BoooooJu.WeChat.Core.Clients
//{
//    public sealed class UnityBaseService<T> : UnityServicerCall<T> where T : class
//    {
//        private const string USERNAME = "boooooju.com";
//        private const string PASSWORD = "123456";
//        static UnityBaseService()
//        {
//            container = new BaseServiceContainerConfig().GetContainer();
//        }

//        public override T GetStaticClient()
//        {
//            {
//                if (t == null)
//                {
//                    lock (syncRoot)
//                    {
//                        if (t == null)
//                        {
//                            t = container.Resolve<T>();
//                            var foo = t as ClientBase<T>;
//                            if (foo == null)
//                            {
//                                throw new ArgumentNullException("泛型参数非WFC终结点。");
//                            }
//                            else
//                            {
//                                foo.ClientCredentials.UserName.UserName = USERNAME;
//                                foo.ClientCredentials.UserName.Password = PASSWORD;
//                            }
//                        }
//                    }
//                }
//                else
//                {
//                    var foo = t as ClientBase<T>;
//                    if (foo.State == CommunicationState.Faulted)
//                    {
//                        t = GetClient();
//                    }
//                }
//                return t;
//            }
//        }

//        public override T GetClient()
//        {
//            var client = container.Resolve<T>();
//            var foo = client as ClientBase<T>;
//            if (foo == null)
//            {
//                throw new ArgumentNullException("泛型参数非WFC终结点。");
//            }
//            else
//            {
//                foo.ClientCredentials.UserName.UserName = USERNAME;
//                foo.ClientCredentials.UserName.Password = PASSWORD;
//            }
//            return client;
//        }
//    }
//    internal class BaseServiceContainerConfig : ServicerContainerConfig
//    {
//        internal override void RegisterType(ContainerBuilder builder)
//        {
//            builder.RegisterType<QueryServiceClient>().As<IQueryService>();
//            builder.RegisterType<UpdateServiceClient>().As<IUpdateService>();
//            builder.RegisterType<SignInServiceClient>().As<ISignInService>();
//            builder.RegisterType<RegisterServiceClient>().As<IRegisterService>();
//            builder.RegisterType<DiancanServiceClient>().As<IDiancanService>();
//        }
//    }
//}