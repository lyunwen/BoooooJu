namespace BoooooJu.Service.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods_Size
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods_Size()
        {
            Goods_Count = new HashSet<Goods_Count>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Value { get; set; }

        public int GoodsId { get; set; }

        public virtual Good Good { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods_Count> Goods_Count { get; set; }
    }
}
