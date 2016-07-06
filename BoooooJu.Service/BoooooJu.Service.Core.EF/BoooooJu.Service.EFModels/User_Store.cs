namespace BoooooJu.Service.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Store
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int StoreId { get; set; }
    }
}
