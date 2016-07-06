using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.ServiceContracts.SMSService
{
    public interface ISMSService
    {
        string Send(List<string> cellPhones, string content); 
    }
}
