using BoooooJu.Service.Core.Dal.OBModels;
using BoooooJu.Service.Core.QueryParameter;
using BoooooJu.Service.DPModels;
using BoooooJu.Service.DPModels.OBModels; 
using BoooooJu.Service.ICore.AccountModule;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoooooJu.Service.DPCore.Account
{
    public class AccountService: IQueryService, IRegisterService,ISignInService,IUpdateService
    {
        #region IQuery
        public UserInfo FindUserInfoByCellPhone(string cellPhone)
        {
            UserInfo result = null;
            StringBuilder sqlCmdTextSb = new StringBuilder();
            sqlCmdTextSb.Append(@"SELECT")
                .Append(@"[User].Id AS UserId,[User].Name,[User].Sex,[User].Signature,[User].CreateTime,[UserKey].Pswd,[UserKey].PswdType,[UserKey].PswdSalt,[UserKey].CellPhone,[UserKey].CellPhoneValidate,[UserKey].EmailAddress,[UserKey].EmailAddressValidate,[UserKey].AccountName,[UserKey].AccountNameValidate,[UserKey].OpenId,[UserKey].OpenIdValidate,[UserKey].Role AS  Role")
                .Append(@" FROM [User]")
                .Append(@" LEFT JOIN [UserKey] ON [User].Id=[UserKey].UserId")
                .Append(@" WHERE CellPhoneValidate=1 AND CellPhone=@CellPhone");
            using (var conn = DBHelper.OpenConnection())
            {
                result = conn.Query<UserInfo>(sqlCmdTextSb.ToString(), new { CellPhone = cellPhone }, null, true, null, null).FirstOrDefault();
            }
            return result;
        }

        public UserInfo FindUserInfoByEmail(string email)
        {
            UserInfo result = null;
            StringBuilder sqlCmdTextSb = new StringBuilder();
            sqlCmdTextSb.Append(@"SELECT")
                .Append(@"[User].Id AS UserId,[User].Name,[User].Sex,[User].Signature,[User].CreateTime,[UserKey].Pswd,[UserKey].PswdType,[UserKey].PswdSalt,[UserKey].CellPhone,[UserKey].CellPhoneValidate,[UserKey].EmailAddress,[UserKey].EmailAddressValidate,[UserKey].AccountName,[UserKey].AccountNameValidate,[UserKey].OpenId,[UserKey].OpenIdValidate,[UserKey].Role AS  Role")
                .Append(@" FROM [User]")
                .Append(@" LEFT JOIN [UserKey] ON [User].Id=[UserKey].UserId")
                .Append(@" WHERE EmailAddressValidate=1 AND EmailAddress=@EmailAddress");
            using (var conn = DBHelper.OpenConnection())
            {
                result = conn.Query<UserInfo>(sqlCmdTextSb.ToString(), new { EmailAddress = email }, null, true, null, null).FirstOrDefault();
            }
            return result;
        }

        public UserInfo FindUserInfoById(int id)
        {
            UserInfo result = null;
            StringBuilder sqlCmdTextSb = new StringBuilder();
            sqlCmdTextSb.Append(@"SELECT")
                .Append(@"[User].Id AS UserId,[User].Name,[User].Sex,[User].Signature,[User].CreateTime,[UserKey].Pswd,[UserKey].PswdType,[UserKey].PswdSalt,[UserKey].CellPhone,[UserKey].CellPhoneValidate,[UserKey].EmailAddress,[UserKey].EmailAddressValidate,[UserKey].AccountName,[UserKey].AccountNameValidate,[UserKey].OpenId,[UserKey].OpenIdValidate,[UserKey].Role AS  Role")
                .Append(@" FROM [User]")
                .Append(@" LEFT JOIN [UserKey] ON [User].Id=[UserKey].UserId")
                .Append(@" WHERE [User].Id=@UserId");
            using (var conn = DBHelper.OpenConnection())
            {
                result = conn.Query<UserInfo>(sqlCmdTextSb.ToString(), new { UserId = id }, null, true, null, null).FirstOrDefault();
            }
            return result;
        }

        public UserInfo FindUserInfoByAccountName(string name)
        {
            UserInfo result = null;
            StringBuilder sqlCmdTextSb = new StringBuilder();
            sqlCmdTextSb.Append(@"SELECT")
                .Append(@"[User].Id AS UserId,[User].Name,[User].Sex,[User].Signature,[User].CreateTime,[UserKey].Pswd,[UserKey].PswdType,[UserKey].PswdSalt,[UserKey].CellPhone,[UserKey].CellPhoneValidate,[UserKey].EmailAddress,[UserKey].EmailAddressValidate,[UserKey].AccountName,[UserKey].AccountNameValidate,[UserKey].OpenId,[UserKey].OpenIdValidate,[UserKey].Role AS  Role")
                .Append(@" FROM [User]")
                .Append(@" LEFT JOIN [UserKey] ON [User].Id=[UserKey].UserId")
                .Append(@" WHERE AccountNameValidate=1 AND AccountName=@AccountName");
            using (var conn = DBHelper.OpenConnection())
            {
                result = conn.Query<UserInfo>(sqlCmdTextSb.ToString(), new { AccountName = name }, null, true, null, null).FirstOrDefault();
            }
            return result;
        }

        public UserInfo FindUserInfoByOpenId(string openId)
        {
            UserInfo result = null;
            StringBuilder sqlCmdTextSb = new StringBuilder();
            sqlCmdTextSb.Append(@"SELECT")
                .Append(@"[User].Id AS UserId,[User].Name,[User].Sex,[User].Signature,[User].CreateTime,[UserKey].Pswd,[UserKey].PswdType,[UserKey].PswdSalt,[UserKey].CellPhone,[UserKey].CellPhoneValidate,[UserKey].EmailAddress,[UserKey].EmailAddressValidate,[UserKey].AccountName,[UserKey].AccountNameValidate,[UserKey].OpenId,[UserKey].OpenIdValidate,[UserKey].Role AS  Role")
                .Append(@" FROM [User]")
                .Append(@" LEFT JOIN [UserKey] ON [User].Id=[UserKey].UserId")
                .Append(@" WHERE OpenIdValidate=1 AND OpenId=@OpenId");
            using (var conn = DBHelper.OpenConnection())
            {
                result = conn.Query<UserInfo>(sqlCmdTextSb.ToString(), new { OpenId = openId }, null, true, null, null).FirstOrDefault();
            }
            return result;
        }

        public KeyValuePair<Page, IEnumerable<UserInfo>> FindUserInfosByRole(Page page, int role, User_Rank rank, string nickName)
        {
            int allCounts = 0;
            IEnumerable<UserInfo> userInfos = null;
            string orderBy = "UserId asc";
            string tables = @"[User] INNER JOIN [UserKey] ON [User].Id=[UserKey].UserId";
            string returns = @"[User].Id AS UserId,[User].Name,[User].Sex,[User].Signature,[User].CreateTime,[UserKey].Pswd,[UserKey].PswdType,[UserKey].PswdSalt,[UserKey].CellPhone,[UserKey].CellPhoneValidate,[UserKey].EmailAddress,[UserKey].EmailAddressValidate,[UserKey].AccountName,[UserKey].AccountNameValidate,[UserKey].OpenId,[UserKey].OpenIdValidate,[UserKey].Role AS  Role";
            using (var conn = DBHelper.OpenConnection())
            {
                userInfos = conn.Query<UserInfo>("[dbo].[Proc_Page]", new { Tables = tables, Returns = returns, AllCounts = allCounts, OrderBy = orderBy }, null, true, null, System.Data.CommandType.StoredProcedure);
            }
            return new KeyValuePair<Page, IEnumerable<UserInfo>>(new Page { PageIndex = 1, TotalCounts = allCounts, PageSize = 10 }, userInfos);
        }
       
        #endregion

        #region Register
        public UserInfo RegisterByAccountName(User user, string accountName, string pswd)
        {
            throw new NotImplementedException();
        }

        public UserInfo RegisterByCellPhone(User user, string cellPhone, string pswd)
        {
            throw new NotImplementedException();
        }

        public UserInfo RegisterByEmailAddress(User user, string emailAddress, string pwsd)
        {
            throw new NotImplementedException();
        }

        public UserInfo RegisterByOpneId(User user, string opneId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region SignIn
        public UserInfo SignByAccountName(string accountName, string pswd)
        {
            throw new NotImplementedException();
        }

        public UserInfo SignByCellPhone(string cellPhone, string pswd)
        {
            throw new NotImplementedException();
        }

        public UserInfo SignByEmaiAddress(string emailAddresss, string pswd)
        {
            throw new NotImplementedException();
        }

        public UserInfo SignByOpenId(string openId, string pswd)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Update
        public UserInfo AlterPswdByAccountName(string accountName, string pswd)
        {
            throw new NotImplementedException();
        }

        public UserInfo AlterPswdByCellPhone(string cellPhone, string pswd)
        {
            throw new NotImplementedException();
        }

        public UserInfo AlterPswdByEmailAddress(string emailAddress, string pswd)
        {
            throw new NotImplementedException();
        }

        public UserInfo AlterPswdById(int userId, string pswd)
        {
            UserInfo result = null;
            string excuteCmdText = @"UPDATE [UserKey] SET Pswd=@Pswd WHERE UserId=@UserId";
            StringBuilder sqlCmdTextSb = new StringBuilder();
            sqlCmdTextSb.Append(@"SELECT")
                .Append(@"[User].Id AS UserId,[User].Name,[User].Sex,[User].Signature,[User].CreateTime,[UserKey].Pswd,[UserKey].PswdType,[UserKey].PswdSalt,[UserKey].CellPhone,[UserKey].CellPhoneValidate,[UserKey].EmailAddress,[UserKey].EmailAddressValidate,[UserKey].AccountName,[UserKey].AccountNameValidate,[UserKey].OpenId,[UserKey].OpenIdValidate,[UserKey].Role AS  Role")
                .Append(@" FROM [User]")
                .Append(@" LEFT JOIN [UserKey] ON [User].Id=[UserKey].UserId")
                .Append(@" WHERE [User].Id=@UserId");
            using (var conn = DBHelper.OpenConnection())
            {
                if (conn.Execute(excuteCmdText, new { Pswd = pswd, UserId = userId }) > 0)
                {
                    result = conn.Query<UserInfo>(sqlCmdTextSb.ToString(), new { UserId = userId }, null, false, null, null).FirstOrDefault();
                }
            }
            return result;
        }

        public UserInfo AlterPswdByOpenId(string openId, string pswd)
        { 
            UserInfo result = null;
            string excuteCmdText = @"UPDATE [UserKey] SET Pswd=@Pswd WHERE OpenId=@OpenId and OpenIdValidate=1";
            StringBuilder sqlCmdTextSb = new StringBuilder();
            sqlCmdTextSb.Append(@"SELECT")
                .Append(@"[User].Id AS UserId,[User].Name,[User].Sex,[User].Signature,[User].CreateTime,[UserKey].Pswd,[UserKey].PswdType,[UserKey].PswdSalt,[UserKey].CellPhone,[UserKey].CellPhoneValidate,[UserKey].EmailAddress,[UserKey].EmailAddressValidate,[UserKey].AccountName,[UserKey].AccountNameValidate,[UserKey].OpenId,[UserKey].OpenIdValidate,[UserKey].Role AS  Role")
                .Append(@" FROM [User]")
                .Append(@" LEFT JOIN [UserKey] ON [User].Id=[UserKey].UserId")
                .Append(@" WHERE [UserKey].OpenId=@OpenId");
            using (var conn = DBHelper.OpenConnection())
            {
                if (conn.Execute(excuteCmdText, new { Pswd = pswd, OpenId = openId }) > 0)
                {
                    result = conn.Query<UserInfo>(sqlCmdTextSb.ToString(), new { OpenId = openId }, null, false, null, null).FirstOrDefault();
                }
            }
            return result;
        }

        public UserInfo SignInById(int userId, string token)
        {
            throw new NotImplementedException();
        }

        public string GetTokenByAccountName(string accountName, string pswd)
        {
            throw new NotImplementedException();
        }

        public string GetTokenByCellPhone(string cellPhone, string pswd)
        {
            throw new NotImplementedException();
        }

        public string GetTokenByEmaiAddress(string emailAddresss, string pswd)
        {
            throw new NotImplementedException();
        }

        public string GetTokenByOpenId(string openId, string pswd)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}