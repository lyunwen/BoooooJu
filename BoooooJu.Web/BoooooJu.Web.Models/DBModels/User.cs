using System;
using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{
    [DataContract]
    public partial class User
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long Role { get; set; }
        public string NickName { get; set; }
        [DataMember]
        public string AccountName { get; set; }
        [DataMember]
        public string MobilePhone { get; set; }
        [DataMember]
        public ValidateEnum MobilePhoneValidate { get; set; }
        public string Password { get; set; }

        [DataMember]
        public byte Sex { get; set; }

        [DataMember]
        public string Signature { get; set; }

        [DataMember]
        public DateTime CreateTime { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
    }
    public enum ValidateEnum
    {
        /// <summary>
        /// 未验证
        /// </summary>
        UnValidate = 1,
        /// <summary>
        /// 已验证
        /// </summary>
        Validated = 2,
    }
}
