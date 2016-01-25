using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Core.QueryParameter.Base;

namespace BoooooJu.Service.Core.QueryParameter
{
    public class Page : Base.IPage
    { 
        bool IPage.IsPage { get; set; }
        int IPage.PageIndex { get; set; }
        int IPage.PageSize { get; set; }
        int IPage.TotalCounts { get; set; }
        int IPage.TotalPages { get; set; }
        string IPage.OrderBy { get; set; } 
        Sort IPage.Sort { get; set; }
    }
}
