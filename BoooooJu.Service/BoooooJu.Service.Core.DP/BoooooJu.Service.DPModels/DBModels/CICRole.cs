using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{ 
  [DataContract]   
    public partial class CICRole
    { 
        [DataMember]
        public int RoleId { get; set; }

        [DataMember]
        public string RoleName { get; set; } 
    }
}
