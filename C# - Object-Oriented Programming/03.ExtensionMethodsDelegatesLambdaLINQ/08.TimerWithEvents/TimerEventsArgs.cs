namespace TimerExecuteMethodWithEvents
{
    using System;
    
    public class TimerEventsArgs : EventArgs
    {
        public TimerEventsArgs(DateTime time)
        {
            this.Time = time;
        }

        public DateTime Time { get; private set; }
    }
}