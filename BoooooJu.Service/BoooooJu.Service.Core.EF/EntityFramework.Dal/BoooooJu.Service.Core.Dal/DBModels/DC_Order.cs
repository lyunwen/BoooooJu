namespace BoooooJu.Service.Core.Dal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DC_Order
    {
        public int Id { get; set; }

        public DateTime OrderTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int UserId { get; set; }

        public int FoodId { get; set; }

    }
}
