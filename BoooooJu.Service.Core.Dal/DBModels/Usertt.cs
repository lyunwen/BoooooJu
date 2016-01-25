//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Runtime.Serialization;
//using System.Text;
//using System.Threading.Tasks;

//namespace BoooooJu.Service.Core.Dal.DBModels
//{
//    [DataContract]
//    [Table("Usertt")]
//    public class Usertt
//    {
//        [DataMember]
//        [Column(Order = 0)]
//        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        public int Id { get; set; }

//        [DataMember]
//        [Column(Order = 1)]
//        [Required, MaxLength(20),Key]
//        public string Account { get; set; }
//        [MaxLength(100)]
//        [Column(Order = 2)]
//        public string Signature { get; set; }

//        [DataMember]
//        [Column(Order = 3)]
//        [Required,MaxLength(10)]
//        public string NickName { get; set; }

//        [DataMember]
//        [Column(Order = 4)]
//        [Required, MaxLength(20)]
//        public string Password { get; set; }
//        [DataMember]
//        [Column(Order = 5)]
//        [Required]
//        public string PasswordSalt { get; set; }
//        [DataMember]
//        [Column(Order = 6)]
//        [Required]
//        public int PasswordSaltType { get; set; }

//        [DataMember]
//        [Column(Order = 7)]
//        /// <summary>
//        /// 0：未知 1：男 2：女
//        /// </summary>
//        //   [Required,DefaultValue(0)]
//        [Required]
//        public int Sex { get; set; }
         
//        [DataMember]
//        [Column(Order = 8)]
//        [Required, DefaultValue(false)]
//        public bool CellPhoneValidate { get; set; }

//        [DataMember]
//        [Column(Order = 9)]
//        public string CellPhone { get; set; }

//        [DataMember]
//       // [Required,DefaultValue(false)]
//        [Required]
//        [Column(Order = 10)]
//        public bool EmailValidate { get; set; }
//        [DataMember]
//        [MaxLength(20)]
//        [Column(Order = 11)]
//        public string EmailAdress { get; set; }

//        [DataMember]
//        [Column(Order = 12)]
//        public string LastLoginIp { get; set; }
//    }
//}
