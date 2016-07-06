using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{ 
    [DataContract]
    public partial class CICUserRole
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int RoleId { get; set; } 
    }
}
