using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Api.Dto.Account
{
    public class UserBO
    {
        public long Id { get; set; }
        public string NickName { get; set; }
        public string AccountName { get; set; }
        public string MobilePhone { get; set; }
    }
}
