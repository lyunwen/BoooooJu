using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Core.QueryParameter.Base;

namespace BoooooJu.Service.Core.QueryParameter
{
    public class Page : IPage
    {
        public bool IsPage { get; set; }
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCounts { get; set; }
        public int TotalPages { get; set; }
        public string OrderBy { get; set; }
        public Sort Sort { get; set; }
    }
}
