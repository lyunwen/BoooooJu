using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrager
{
    public interface IGrabber
    {
        string PostWebRequest(string url, string paraData, Encoding dataEncode, string Method);
        string GetWebRequest(string url, string paraData, Encoding dataEncode, string Method);
    }
}
