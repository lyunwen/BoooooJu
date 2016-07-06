using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BoooooJu.CommonService.Core
{
    public class ActionExecutor
    {
        static ActionExecutor()
        {
            _timers = new List<Timer>();
        }
        private static List<Timer> _timers;
        public static void AddTimer(Timer timer)
        {
            _timers.Add(timer);
        }
        public static void AddCircleAction(ElapsedEventHandler handler, CircleTimeSpan span)
        {
            foreach (var foo in _timers)
            {
                if (foo.Interval == (double)span)
                {
                    foo.Elapsed += handler;
                }
            }
        }
        public static void AddCircleAction(ElapsedEventHandler handler, double span,object sender)
        {
            var timer = _timers.FirstOrDefault(x => x.Interval == span);
            if (timer == null)
            {
                var thTime = new Timer
                {
                    Interval = span,
                    AutoReset = true,
                    Enabled = true
                };
                thTime.Elapsed += new ElapsedEventHandler(handler);
            }
            else
            {
                timer.Elapsed += handler;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="timings">{"12:00,3:00"}</param>
        public static void AddTimingAction(ElapsedEventHandler handler, List<string> timings)
        {

        }
    }
    public enum CircleTimeSpan
    {
        /// <summary>
        /// 半小时
        /// </summary>
        HalfHour = 1000 * 60 * 30,
        /// <summary>
        /// 一小时
        /// </summary>
        OneHour = 1000 * 60 * 60,
        /// <summary>
        /// 两小时
        /// </summary>
        TwoHour = 1000 * 60 * 60 * 2,
        /// <summary>
        /// 三小时
        /// </summary>
        ThreeHour = 1000 * 60 * 60 * 3,
        /// <summary>
        /// 六小时
        /// </summary>
        FiveHour = 1000 * 60 * 60 * 6,
        /// <summary>
        /// 半天
        /// </summary>
        HalfDay = 1000 * 60 * 60 * 12,
        /// <summary>
        /// 一天
        /// </summary>
        OneDay = 1000 * 60 * 60 * 24,
    }
    public enum TimingTime
    {

    }
}