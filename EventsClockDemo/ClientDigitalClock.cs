using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClockDemo
{
    public class ClientDigitalClock
    {
        public void Subscribe(Clock theClock)
        {
            theClock.SecondChanged += NewTime;
        }

        public void NewTime(object o, TimeInfoEventArgs e)
        {
            Console.WriteLine($"Current time: {e.Hour.ToString()}:{e.Minute.ToString()}:{e.Second.ToString()}");
        }
    }
}
