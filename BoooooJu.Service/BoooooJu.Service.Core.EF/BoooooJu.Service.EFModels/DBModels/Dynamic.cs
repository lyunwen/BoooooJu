namespace BoooooJu.Service.Core.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dynamic")]
    public partial class Dynamic
    {
        [Key]
        [StringLength(50)]
        public string Key { get; set; }

        [Required]
        [StringLength(200)]
        public string Value { get; set; }
    }
}
