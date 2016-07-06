namespace BoooooJu.Service.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime PublishTime { get; set; }

        [StringLength(50)]
        public string ReferUrl { get; set; }

        [StringLength(50)]
        public string ReferName { get; set; }

        public int LikeCount { get; set; }

        public int LookCount { get; set; }

        public int DisLikeCount { get; set; }

        [StringLength(50)]
        public string KeyWords { get; set; }

        public int UserId { get; set; }
    }
}
