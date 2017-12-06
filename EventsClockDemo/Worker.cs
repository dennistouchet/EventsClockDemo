using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClockDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work() { 
            Clock clock = new Clock();
            ClientDigitalClock digitalClock = new ClientDigitalClock();
            digitalClock.Subscribe(clock);
            ClientLogClock logClock = new ClientLogClock();
            logClock.Subscribe(clock);

            clock.Run();
        }
    }
}
