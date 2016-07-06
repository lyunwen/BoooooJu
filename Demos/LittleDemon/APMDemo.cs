using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LittleDemon
{
    public class APMDemo
    { 
        public int GetFood(string foodName)
        {
            return 10 + foodName.Length;
        }
        public IAsyncResult BeginGetFood(string foodName, AsyncCallback cb, object obj)
        { 
            Func<string, int> getFoodDg = (x) => { return this.GetFood(x); };  
            return getFoodDg.BeginInvoke("foodName", EndGetFoodDg, obj); 
        }
        public static event AsyncCallback EndGetFoodDg;
    }
}
