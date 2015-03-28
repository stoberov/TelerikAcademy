namespace TimerExecuteMethodWithEvents
{
    using System;
    using System.Linq;
    
    internal class TimerTest
    {
        private static Timer timer = null;

        private static void Main(string[] args)
        {
            timer = new Timer();
            timer.TimerEvent += timer_TimerEvent;
            timer.KeyPressedEvent += timer_KeyPressedEvent;
            timer.Start(3);
        }

        private static void timer_KeyPressedEvent(object sender, KeyEventsArgs e)
        {
            if (e.PressedKey == 's')
            {
                timer.Stop();
            }
        }

        private static void timer_TimerEvent(object sender, TimerEventsArgs e)
        {
            Console.WriteLine("If you want to stop press 'a'");
        }
    }
}