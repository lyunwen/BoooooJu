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
        public string NickName { get; set; }

        public byte Sex { get; set; }

        [StringLength(100)]
        public string Signature { get; set; }

        public DateTime CreateTime { get; set; }

        public int Role { get; set; }
    }
}
