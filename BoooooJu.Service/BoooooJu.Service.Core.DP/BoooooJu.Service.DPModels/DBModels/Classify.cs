using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{ 
     [DataContract]
    public partial class Classify
    { 
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int ParentId { get; set; }
    }
}
