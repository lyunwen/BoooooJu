using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Dal.Rank
{
    [DataContract]
    public enum DC_OBOrder_Rank
    {
        [EnumMember]
        OrderId,
        [EnumMember]
        OrderTime,
        [EnumMember]
        UpdateTime,
        [EnumMember]
        UserId,
        [EnumMember]
        UserName,
        [EnumMember]
        FoodId, 
        [EnumMember]
        FoodName
    }
}
