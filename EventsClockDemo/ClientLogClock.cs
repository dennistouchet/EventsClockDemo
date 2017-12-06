using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClockDemo
{
    public class ClientLogClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += LogTime;
        }

        public void LogTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Logging: {e.Hour.ToString()}:{e.Minute.ToString()}:{e.Second.ToString()}");
        }
    }
}
