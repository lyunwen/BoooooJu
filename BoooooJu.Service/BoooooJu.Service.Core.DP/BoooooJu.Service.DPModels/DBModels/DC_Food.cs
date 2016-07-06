using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{  
    [DataContract]
    public partial class DC_Food
    { 
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public bool Enable { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; } 
    }
}
