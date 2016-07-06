using BoooooJu.Service.Core.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.DPModels.OBModels
{
    [DataContract]
    public class UserInfo
    {
        public UserInfo()
        {

        }
        public UserInfo GetKey(UserKey key)
        {
            if (null != key)
            {
                Pswd = key.Pswd;
                PswdSalt = key.PswdSalt;
                PswdType = key.PswdType;
                CellPhone = key.CellPhone;
                CellPhoneValidate = key.CellPhoneValidate;
                EmailAddress = key.EmailAddress;
                EmailAddressValidate = key.EmailAddressValidate;
                AccountName = key.AccountName;
                AccountNameValidate = key.AccountNameValidate;
                OpenId = key.OpenId;
                OpenIdValidate = key.OpenIdValidate;
                Role = key.Role;
            }
            return this;
        }
        public UserInfo(User user, UserKey key)
        {
            if (user != null)
            {
                UserId = user.Id;
                UserName = user.Name;
                Sex = user.Sex;
                Signature = user.Signature;
                CreateTime = user.CreateTime;
            }
            if (null != key)
            {
                Pswd = key.Pswd;
                PswdSalt = key.PswdSalt;
                PswdType = key.PswdType;
                CellPhone = key.CellPhone;
                CellPhoneValidate = key.CellPhoneValidate;
                EmailAddress = key.EmailAddress;
                EmailAddressValidate = key.EmailAddressValidate;
                AccountName = key.AccountName;
                AccountNameValidate = key.AccountNameValidate;
                OpenId = key.OpenId;
                OpenIdValidate = key.OpenIdValidate;
                Role = key.Role;
            }
        }
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public byte Sex { get; set; }

        public string Signature { get; set; }

        [DataMember]
        public DateTime CreateTime { get; set; }

        [DataMember]
        public string Pswd { get; set; }

        [DataMember]
        public int PswdType { get; set; }

        [DataMember]
        public string PswdSalt { get; set; }

        [DataMember]
        public string CellPhone { get; set; }

        [DataMember]
        public bool CellPhoneValidate { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public bool EmailAddressValidate { get; set; }

        [DataMember]
        public string AccountName { get; set; }

        [DataMember]
        public bool AccountNameValidate { get; set; }

        [DataMember]
        public string OpenId { get; set; }

        [DataMember]
        public bool OpenIdValidate { get; set; }

        [DataMember]
        public int Role { get; set; }
    }
}
