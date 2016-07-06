namespace BoooooJu.Service.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dynamic")]
    public partial class Dynamic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Value { get; set; }

        public DateTime LoseTime { get; set; }
    }
}
