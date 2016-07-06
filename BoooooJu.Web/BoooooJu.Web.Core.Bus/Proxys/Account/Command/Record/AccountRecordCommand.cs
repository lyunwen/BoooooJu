using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.Bus.Proxys.Account.Command.Record
{
    public class AccountRecordCommand
    {
        public AccountRecordCommand() { }
        public AccountRecordCommand(long userId, DateTime loginTime, string loginIp, string equipment)
        {
            this.UserId = userId;
            this.LoginTime = loginTime;
            this.LoginIp = loginIp;
            this.Equipment = equipment;
        }
        public long UserId { get; set; }

        public DateTime LoginTime { get; set; }

        public string LoginIp { get; set; }

        public string Equipment { get; set; }
    }
}
