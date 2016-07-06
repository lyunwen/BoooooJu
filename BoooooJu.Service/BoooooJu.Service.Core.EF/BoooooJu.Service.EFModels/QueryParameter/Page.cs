using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Core.QueryParameter.Base;
using System.Runtime.Serialization;

namespace BoooooJu.Service.Core.QueryParameter
{ 
  

    [DataContract]
    public class Page<T> : IPage where T :class
    {
        [DataMember]
        public List<T> Ts { get; set; }

        [DataMember]
        public int PageIndex { get; set; }
        [DataMember]
        public int PageSize { get; set; }
        [DataMember]
        public int TotalCounts { get; set; }
        [DataMember]
        public int TotalPages { get; set; } 
        [DataMember]
        public Sort Sort { get; set; }
    }

    [DataContract]
    public class Page : IPage
    {
        public Page(int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
        }
        public Page(int pageIndex) : this(pageIndex, 10) { }
        public Page() : this(1, 10) { }

        [DataMember]
        public int PageIndex { get; set; }
        [DataMember]
        public int PageSize { get; set; }
        [DataMember]
        public int TotalCounts { get; set; }
        [DataMember]
        public int TotalPages { get; set; } 
        [DataMember]
        public Sort Sort { get; set; }
    }
}
