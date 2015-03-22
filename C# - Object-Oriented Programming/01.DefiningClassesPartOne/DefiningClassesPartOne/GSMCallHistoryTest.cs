namespace MobilePhone
{
    using System;
    
    public class GSMCallHistoryTest
    {
        public static void CallHistorySimulation()
        {
            GSM htcMini = new GSM("One mini", "HTC", 400, "Ivan", new Battery(BatteryType.LiPol, null, 400, 60), new Display(4.3, "16M"));
            htcMini.AddCall(DateTime.Today, DateTime.Today.AddMinutes(10), "1234567890");
            htcMini.AddCall(DateTime.Today, DateTime.Today.AddMinutes(20), "1234567890");
            htcMini.AddCall(DateTime.Today, DateTime.Today.AddSeconds(10), "1234567890");
            htcMini.AddCall(DateTime.Today, DateTime.Today.AddSeconds(0), "1234567890");
            htcMini.AddCall(DateTime.Today, DateTime.Today.AddSeconds(48), "1234567890");

            Console.WriteLine("Call history\n");
            Console.WriteLine(htcMini);
            Console.WriteLine("Total price: {0:F2}\n", htcMini.TotalAmountOfCalls(0.37));
            htcMini.DeleteLongestCall();
            Console.WriteLine("After remove longest call\n");
            Console.WriteLine(htcMini);
            Console.WriteLine("Total price: {0:F2}\n", htcMini.TotalAmountOfCalls(0.37));
            Console.WriteLine("After clear call history\n");
            htcMini.DeleteAllCalls();
            Console.WriteLine(htcMini);
        }
    }
}