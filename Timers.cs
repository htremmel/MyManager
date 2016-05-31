using MyManager.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MyManager
{
    public class PomodoroTimer: Timer
    {
        List<Timer> timers;

        public Timer CurrentTimer { get; private set; }

        public DateTime EndTime { get; private set; }        

        public bool IsContinuous { get; set; }

        public DateTime StartTime { get; private set; }
                
        public void Add(Timer timer)
        {
            timers.Add(timer);
        }

        public void Pause()
        {
            EndTime = DateTime.Now;
        }

        public void Reset()
        {
            EndTime = DateTime.Now;
        }

        public void Start()
        {
            StartTime = DateTime.Now;
            base.Start();
        }

        public Log ToLog(MyManager.Database.Task task)
        {
            return new Log() { TaskKey = task.Key, StartTime = StartTime, EndTime = EndTime };
        }        
    }

    public class Timer: System.Timers.Timer
    {

        public string Name { get; set; }  
   

        
    }
}
