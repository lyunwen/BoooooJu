namespace BoooooJu.Service.Core.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DC_User
    { 
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string PCAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public bool IsDeleted { get; set; }
         
    }
}
