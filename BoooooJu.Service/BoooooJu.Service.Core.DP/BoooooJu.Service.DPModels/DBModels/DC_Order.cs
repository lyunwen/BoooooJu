using System;
using System.Runtime.Serialization;

namespace BoooooJu.Service.DPModels
{ 
    [DataContract]
    public partial class DC_Order
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public DateTime OrderTime { get; set; }

        [DataMember]
        public DateTime UpdateTime { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int FoodId { get; set; }
         
    }
}
