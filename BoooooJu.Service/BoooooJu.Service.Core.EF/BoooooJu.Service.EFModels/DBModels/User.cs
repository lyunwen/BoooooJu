namespace BoooooJu.Service.Core.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    { 
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public byte Sex { get; set; }

        [StringLength(255)]
        public string Signature { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsDeleted { get; set; }

    }
}
