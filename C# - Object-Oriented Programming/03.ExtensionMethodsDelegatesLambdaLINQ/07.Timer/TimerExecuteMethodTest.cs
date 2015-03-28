namespace TimerExecuteMethod
{
    using System;
    
    internal class TimerExecuteMethodTest
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToLocalTime());
        }

        private static void Main()
        {
            Console.WriteLine("Press Esc to exit");
            Timer t = new Timer();
            t.Method = PrintTime;
            t.Start(1);
            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
            }

            t.Stop();
        }
    }
}