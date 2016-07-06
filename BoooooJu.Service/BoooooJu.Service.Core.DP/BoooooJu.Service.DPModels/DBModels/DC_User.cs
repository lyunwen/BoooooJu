using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{ 
    [DataContract]
    public partial class DC_User
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PCAddress { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }
         
    }
}
