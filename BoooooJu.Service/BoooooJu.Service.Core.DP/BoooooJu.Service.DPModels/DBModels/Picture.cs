using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{ 
    [DataContract]
    public partial class Picture
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public byte[] Content { get; set; }
    }
}
