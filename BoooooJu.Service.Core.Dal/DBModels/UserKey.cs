namespace BoooooJu.Service.Core.Dal
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
        public string OpenId { get; set; }
    }
}
