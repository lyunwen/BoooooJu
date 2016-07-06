using Autofac;
using BoooooJu.Web.Core.Bus.Proxys.Account;
using BoooooJu.Web.Core.DB.Aspects.Account;

namespace BoooooJu.Web.Core.Bus.Clients
{
    public class UnityAccountClient : Base.UnityBaseClient<AccountClient>
    { 
        static UnityAccountClient()
        {
            container = new AccountClientConfig().GetContainer();
        }
    }
    internal class AccountClientConfig : Base.ServicerContainerConfig
    {
        internal override void RegisterType(ContainerBuilder builder)
        {
            builder.RegisterType<AccountClient>(); 
            builder.RegisterType<AccountRegister>().As<IAccountRegister>();
            builder.RegisterType<AccountQuery>().As<IAccountQuery>();
            builder.RegisterType<AccountRecord>().As<IAccountRecord>();
        }
    }
}
