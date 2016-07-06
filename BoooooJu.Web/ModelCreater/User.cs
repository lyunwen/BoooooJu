namespace BoooooJu.Web.Core.Dal.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Role { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string NickName { get; set; }

        [StringLength(20)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(20)]
        public string MobilePhone { get; set; }

        [StringLength(50)]
        public string OpenId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Password { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime CreateTime { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime LastLoginTime { get; set; }

        [Key]
        [Column(Order = 6)]
        public byte Sex { get; set; }
    }
}
