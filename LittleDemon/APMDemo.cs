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
        delegate int getFoodDelegate(string foodName);
        public int GetFood(string foodName)
        {
            return 10 + foodName.Length;
        }
        public IAsyncResult BeginGetFood(string foodName, AsyncCallback cb, object obj)
        {
            getFoodDelegate getFoodDg = new getFoodDelegate(GetFood);
            return getFoodDg.BeginInvoke("foodName", EndGetFood, "");
        }
        public void EndGetFood(IAsyncResult ar)
        {
            AsyncResult result = (AsyncResult)ar;
            getFoodDelegate dd = result.AsyncDelegate as getFoodDelegate;
            int money = dd.EndInvoke(ar);
        }
    }
}
