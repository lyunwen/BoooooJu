using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Core.QueryParameter.Base
{
    public interface IPage
    {
        int PageIndex { get; set; }
        int PageSize { get; set; }
        int TotalPages { get; set; }
        int TotalCounts { get; set; }  
        Sort Sort { get; set; }

    } 
    [DataContract]
    public enum Sort
    {
        //升序
        [EnumMember]
        Asc =0,
        //降序
        [EnumMember]
        Desc=1
    }
}
