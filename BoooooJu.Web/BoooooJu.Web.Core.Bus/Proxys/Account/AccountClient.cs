using BoooooJu.Service.Api.Dto.Account;
using BoooooJu.Web.Core.Bus.Clients.Account.Command.Register;
using BoooooJu.Web.Core.Bus.Proxys.Account.Command.Record;
using BoooooJu.Web.Core.DB.Aspects.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Bus.Proxys.Account
{
    public class AccountClient : Proxy
    {
        private readonly IAccountRegister _accountRegisterDal;
        private readonly IAccountQuery _accountQueryDal;
        private readonly IAccountRecord _accountRecordDal;
        public AccountClient(IAccountRegister accountRegisterDal, IAccountQuery accountQueryDal, IAccountRecord accountRecordDal)
        {
            _accountRegisterDal = accountRegisterDal;
            _accountQueryDal = accountQueryDal;
            _accountRecordDal = accountRecordDal;
        }

        #region UserRegister
        public long Register(RegisterByPhoneCommand command)
        {
            return _accountRegisterDal.RegisterByMobilePhone(command.MobilePhone, command.Password);
        }

        public long Register(RegisterByEmailCommand command)
        {
            return _accountRegisterDal.RegisterByEmail(command.Email, command.Password);
        }
        #endregion

        #region UserQuery
        public UserBO UserBOGetById(long id)
        {
            return _accountQueryDal.UserBOGetById(id);
        } 
        #endregion

        #region UserRecord
        public int UserRecordInsert(AccountRecordCommand command)
        {
            return _accountRecordDal.User_loginRecordInsert(command.UserId, command.LoginTime, command.LoginIp, command.Equipment);
        }
        #endregion
    }
}
