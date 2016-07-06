using System;
using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{ 
    [DataContract]
    public partial class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public byte Sex { get; set; }

        [DataMember]
        public string Signature { get; set; }

        [DataMember]
        public DateTime CreateTime { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; } 
    }
}
