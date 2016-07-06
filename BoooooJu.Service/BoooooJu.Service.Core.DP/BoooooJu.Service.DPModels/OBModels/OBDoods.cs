using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.DPModels.OBModels
{
    public class OBGoods : Goods
    {
        public OBGoods()
        {
            Sizes = new Collection<Goods_Size>();
            Styles = new Collection<Goods_Style>();
        }
        public ICollection<Goods_Size> Sizes { get; set; }
        public ICollection<Goods_Style> Styles { get; set; }
    }
}
