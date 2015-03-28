namespace TimerExecuteMethod
{
    using System;
    using System.Threading;
    
    internal class Timer
    {
        private Thread newThread;
        private volatile bool isRunning;

        public Timer()
        {
            this.Method = this.PrintExecutesTime;
            this.newThread = null;
            this.isRunning = false;
        }

        public delegate void RunMethod();

        public RunMethod Method { get; set; }

        public void Start(uint delay)
        {
            this.isRunning = true;
            this.newThread = new Thread(() =>
            {
                while (this.isRunning)
                {
                    this.Method.Invoke();
                    Thread.Sleep((int)delay * 1000);
                }
            });
            this.newThread.Start();
        }

        public void Stop()
        {
            this.isRunning = false;
        }

        private void PrintExecutesTime()
        {
            Console.WriteLine("Delegate invoked: {0}", DateTime.Now.ToLocalTime());
        }
    }
}