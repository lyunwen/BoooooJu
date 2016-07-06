using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.Dal.OBModels
{
    [DataContract]
    public enum User_Rank
    {
        [EnumMember]
        Id,
        [EnumMember]
        NickName,
        [EnumMember]
        Sex,
        [EnumMember]
        CreateTime,
        [EnumMember]
        Role
    }
}
