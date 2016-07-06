using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Dal.OBModels
{
    [DataContract]
    public class OBDC_Order
    {
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public int FoodId { get; set; }
        [DataMember]
        public string FoodName { get; set; }
        [DataMember]
        public DateTime OrderTime { get; set; }
        [DataMember]
        public DateTime UpdateTime { get; set; }
    }
}
