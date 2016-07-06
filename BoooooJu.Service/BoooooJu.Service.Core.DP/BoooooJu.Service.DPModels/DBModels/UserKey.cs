using System;
using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{
    [DataContract]
    public partial class UserKey
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int UserId { get; set; }

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

        [DataMember]
        public string Token { get; set; }

        [DataMember]
        public DateTime ValidTime { get; set; }

        [DataMember]
        public byte ErrorCount { get; set; }

        [DataMember]
        public bool Frozen { get; set; }
    }
}
