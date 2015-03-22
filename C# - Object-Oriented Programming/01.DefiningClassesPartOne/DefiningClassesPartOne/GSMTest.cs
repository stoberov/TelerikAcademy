namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    
    internal class GSMTest
    {
        public static void PrintHandysInformation()
        {
            List<GSM> handys = CreateHandys();
            foreach (GSM item in handys)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintIPhone4S()
        {
            Console.WriteLine(GSM.IPhone4S);
        }

        private static List<GSM> CreateHandys()
        {
            List<GSM> handys = new List<GSM>();
            handys.Add(new GSM("One mini", "HTC", 400, "Ivan", new Battery(BatteryType.LiPol, null, 400, 60), new Display(4.3, "16M")));
            handys.Add(new GSM("Lumia 720", "Nokia", 300, "Stamat", new Battery(BatteryType.LiPol, null, 350, 50), new Display(4.2, "16M")));
            handys.Add(new GSM("A820", "Lenovo", 150, "Jivko", new Battery(BatteryType.LiPol, null, 500, 100)));
            return handys;
        }
    }
}