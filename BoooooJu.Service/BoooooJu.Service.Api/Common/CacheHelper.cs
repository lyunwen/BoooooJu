using BoooooJu.Service.Api.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoooooJu.Service.Api.Common
{
    public class ApiProxyCacheHelper<T> where T : class
    {
        public static T Get(string key,bool addToRedis=true)
        {
            T result = null;
            using (var redisClient = RedisManager.GetClient())
            {
                result = redisClient.Get<T>(key);
                if (result != null&&addToRedis)
                {
                    redisClient.Add(key, result);
                }
            }
            return result;
        }
    }
}