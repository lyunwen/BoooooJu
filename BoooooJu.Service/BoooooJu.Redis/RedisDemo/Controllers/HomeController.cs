using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace RedisDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var redisClient = new RedisClient("127.0.0.1:6379");
            redisClient.Set("location", "helloword"); 
            string location = Encoding.Default.GetString(redisClient.Get("location"));
            redisClient.AddItemToList("aguue", "1uu2");
            var t = redisClient.Get("age");
            return Content("hello word!");
        }
    }
    public class Car
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Make Make { get; set; }
        public Model Model { get; set; }
    }

    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Model
    {
        public int Id { get; set; }
        public Make Make { get; set; }
        public string Name { get; set; }
    }
}