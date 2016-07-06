using System;

namespace BoooooJu.Service.Api.Dal.DBModels
{

    public class User
    {
        public long Id { get; set; }

        public long Role { get; set; }

        public string NickName { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public string MobilePhone { get; set; }

        public string OpenId { get; set; }

        public string Password { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastLoginTime { get; set; }

        public SexEnum Sex { get; set; }
    }
    public enum SexEnum
    {
        UnKown = 1,
        Man = 2,
        Female = 4
    }
}
