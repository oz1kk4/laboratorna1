using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace lab1task1
{
    public class Timer
    {
        private TimerDelegate timerDelegate;
        private int interval;
        private Thread thread;
        private bool running;

        public Timer(TimerDelegate timerDelegate, int interval)
        {
            this.timerDelegate = timerDelegate;
            this.interval = interval;

            //потік, який викликає метод Run
            this.thread = new Thread(Run);
        }

        public void Start()
        {
            running = true;
            thread.Start();
        }

        public void Stop()
        {
            running = false;
        }

        private void Run()
        {
            while (running)
            {
                timerDelegate(interval);
                Thread.Sleep(interval * 1000);
            }
        }
    }
}
