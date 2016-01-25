using System;
using System.Collections.Generic;
using System.Linq;
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
        bool IsPage { get; set; }
        string OrderBy { get; set; }
        Sort Sort { get; set; }

    }
    public enum Sort
    {
        //降序
        Desc=1,
        //升序
        Asc=2
    }
}
