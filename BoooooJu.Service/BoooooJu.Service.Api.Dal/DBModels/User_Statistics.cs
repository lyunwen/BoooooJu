namespace BoooooJu.Service.Api.Dal.DBModels
{ 
    public partial class User_Statistics
    { 
        public long Id { get; set; }
         
        public int UserId { get; set; }
         
        public int LoginOnCounts { get; set; }
         
        public int OnlineMinutes { get; set; }
    }
}
