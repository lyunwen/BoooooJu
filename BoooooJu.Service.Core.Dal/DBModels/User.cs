namespace BoooooJu.Service.Core.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [DataContract]
    [Table("User")]
    public partial class User
    {

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Account { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string NickName { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [DataMember]
        [Required]
        [StringLength(50)]
        public string PasswordSalt { get; set; }

        [DataMember]
        public byte PasswordSaltType { get; set; }

        [DataMember]
        public byte Sex { get; set; }

        [DataMember]
        public bool CellPhoneValidate { get; set; }

        [DataMember]
        [StringLength(20)]
        public string CellPhone { get; set; }

        [DataMember]
        public bool EmailValidate { get; set; }

        [DataMember]
        [StringLength(30)]
        public string EmailAdress { get; set; }

        [DataMember]
        [StringLength(100)]
        public string Signature { get; set; }

        [DataMember]
        public DateTime CreateTime { get; set; }
    }
}
