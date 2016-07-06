using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{
    [DataContract]
    public partial class Dynamic
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public System.DateTime LoseTime { get; set; }
    }
}
