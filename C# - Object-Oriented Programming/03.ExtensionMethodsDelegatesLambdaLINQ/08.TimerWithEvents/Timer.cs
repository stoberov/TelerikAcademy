namespace TimerExecuteMethodWithEvents
{
    using System;
    using System.Threading;
    
    public class Timer
    {
        private volatile bool isRunning;
        private Thread newThread = null;

        public Timer()
        {
            this.isRunning = false;
        }

        public delegate void TimerEventHandler(object sender, TimerEventsArgs e);

        public delegate void KeyPressedEventHandler(object sender, KeyEventsArgs e);

        public event TimerEventHandler TimerEvent;

        public event KeyPressedEventHandler KeyPressedEvent;

        public void Start(uint delay)
        {
            this.isRunning = true;
            this.CheckPressedKey();
            this.newThread = new Thread(() =>
            {
                while (true)
                {
                    this.OnTimerEvent(new TimerEventsArgs(DateTime.Now));
                    Thread.Sleep((int)delay * 1000);
                }
            });
            this.newThread.Start();
        }

        public void Stop()
        {
            this.isRunning = false;
            this.newThread.Abort();
        }

        protected void OnTimerEvent(TimerEventsArgs e)
        {
            TimerEventHandler handler = this.TimerEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected void OnKeyPressedEvent(KeyEventsArgs e)
        {
            KeyPressedEventHandler handler = this.KeyPressedEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void CheckPressedKey()
        {
            Thread newThread = new Thread(() =>
            {
                while (this.isRunning)
                {
                    if (Console.KeyAvailable)
                    {
                        this.OnKeyPressedEvent(new KeyEventsArgs(Console.ReadKey(true).KeyChar));
                    }

                    Thread.Sleep(1);
                }
            });
            newThread.Start();
        }
    }
}