using System;

namespace BoooooJu.Service.Api.Dal.DBModels
{ 

    public partial class User_LoginRecord
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public DateTime LoginTime { get; set; }
         
        public string LoginIp { get; set; }
         
        public string Equipment { get; set; }
    }
}
