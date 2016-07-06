using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Dal.DBModels
{
    [DataContract]
    public partial class User
    {
        [DataMember]
        public long Id { get; set; }
        [DataMember]
        public long Role { get; set; }
        [DataMember]
        public string NickName { get; set; }
        [DataMember]
        public string UserName { get; set; }
        public string Email { get; set; }
        [DataMember]
        public string MobilePhone { get; set; }
        [DataMember]
        public string OpenId { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public CommonEnum.SexEnum Sex { get; set; }
        [DataMember]
        public DateTime CreateTime { get; set; }
        [DataMember]
        public DateTime LastLoginTime { get; set; }
    }
}
