using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BoooooJu.CommonService.Core
{
    class Test
    {
        private void method()
        {
            Timer _timer;
            int _Interval = 30000;
            _timer = new Timer();
            _timer.Enabled = true;
            _timer.Interval = _Interval;
            _timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //todo something
        }
    }
}
