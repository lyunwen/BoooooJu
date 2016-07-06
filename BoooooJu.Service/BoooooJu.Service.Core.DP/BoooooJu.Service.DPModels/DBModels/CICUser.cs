using System;
using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{
    [DataContract]
    public partial class CICUser
    {

        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember] 
        public string PasswordHash { get; set; }
        [DataMember] 
        public string Email { get; set; }
        [DataMember] 
        public string PhoneNumber { get; set; }
        [DataMember] 
        public bool IsFirstTimeLogin { get; set; }
        [DataMember] 
        public int AccessFailedCount { get; set; }
        [DataMember] 
        public DateTime CreationDate { get; set; }
        [DataMember] 
        public bool IsActive { get; set; }
    }
}
