namespace BoooooJu.Service.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CICUser")]
    public partial class CICUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CICUser()
        {
            CICUserRoles = new HashSet<CICUserRole>();
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(256)]
        public string Username { get; set; }

        [StringLength(500)]
        public string PasswordHash { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        public bool IsFirstTimeLogin { get; set; }

        public int AccessFailedCount { get; set; }

        public DateTime CreationDate { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CICUserRole> CICUserRoles { get; set; }
    }
}
