namespace BoooooJu.Service.Api.Dal.DBModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_LoginRecord
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public DateTime LoginTime { get; set; }

        [StringLength(20)]
        public string LoginIp { get; set; }

        [StringLength(50)]
        public string Equipment { get; set; }
    }
}
