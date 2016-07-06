using BoooooJu.Service.Api.Cache;
using BoooooJu.Service.Api.Dal.Aspects.User;
using BoooooJu.Service.Api.Dto.Account;
using System;
using System.Web.Http;

namespace BoooooJu.Service.Api.Controllers
{
    [RoutePrefix("user")]
    public class UserController : BaseApiController
    {
        private readonly IUserQuery _userQueryDal;
        private readonly IUserRecord _userRecordDal;
        private readonly IUserRegister _userRegisterDal;
        public UserController(IUserQuery userQueryDal, IUserRecord userRecordDal, IUserRegister userRegisterDal)
        {
            _userQueryDal = userQueryDal;
            _userRecordDal = userRecordDal;
            _userRegisterDal = userRegisterDal;
        }

        [Route("getUserBOById/{id}"), HttpGet]
        public UserBO GetUserBOById(long id,bool fromCache=true)
        {
            UserBO result = null;
            if (fromCache)
            {
                result= Common.ApiProxyCacheHelper<UserBO>.Get(id.ToString());
            }
            if (result == null)
            {
                result = _userQueryDal.UserBOGetById(id);
            }
            return result;
        }

        [Route("loginRecordInsert/{id}")]
        public int User_loginRecordInsert(long userId, string ip, string equipment)
        {
            return _userRecordDal.User_loginRecordInsert(userId, DateTime.Now, ip, equipment);
        }

        #region register
        [Route("registerByMobilePhone")]
        public int RegisterByMobilePhone(string phone, string password, string fromType = null)
        {
            return _userRegisterDal.RegisterByMobilePhone(phone, password, fromType);
        }
        [Route("registerByEmial")]
        public int RegisterByEmail(string email, string password, string fromType = null)
        {
            return _userRegisterDal.RegisterByEmail(email, password, fromType);
        }
        [Route("ResgiterByUserName")]
        public int ResgiterByUserName([FromBody]ResgiterByUserNameCommand command)
        {
            return _userRegisterDal.ResgiterByUserName(command);
        }
        #endregion
    }
}
