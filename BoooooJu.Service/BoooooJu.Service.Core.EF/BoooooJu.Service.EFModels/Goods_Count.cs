namespace BoooooJu.Service.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods_Count
    {
        public int Id { get; set; }

        public int Counts { get; set; }

        public int GoodsSizeId { get; set; }

        public int GoodsStyleId { get; set; }

        public virtual Goods_Size Goods_Size { get; set; }

        public virtual Goods_Style Goods_Style { get; set; }
    }
}
