namespace BoooooJu.Service.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserKey")]
    public partial class UserKey
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Pswd { get; set; }

        public int PswdType { get; set; }

        [Required]
        [StringLength(50)]
        public string PswdSalt { get; set; }

        [StringLength(50)]
        public string CellPhone { get; set; }

        public bool CellPhoneValidate { get; set; }

        [StringLength(50)]
        public string EmailAddress { get; set; }

        public bool EmailAddressValidate { get; set; }

        [StringLength(50)]
        public string AccountName { get; set; }

        public bool AccountNameValidate { get; set; }

        [StringLength(50)]
        public string OpenId { get; set; }

        public bool OpenIdValidate { get; set; }

        public int Role { get; set; }

        [Required]
        [StringLength(15)]
        public string Token { get; set; }

        public DateTime ValidTime { get; set; }

        public byte ErrorCount { get; set; }

        public bool Frozen { get; set; }

        public virtual User User { get; set; }
    }
}
