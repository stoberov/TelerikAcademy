namespace IEnumarambleTools
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    internal class IEnumarambleToolsTest
    {
        private static void Main(string[] args)
        {
            List<int> p = new List<int>();
            p.Add(150);
            p.Add(120);
            p.Add(-100);
            p.Add(0);
            p.Add(50);
            Console.WriteLine(p.CustomSum());
            Console.WriteLine(p.Min());
            Console.WriteLine(p.Max());
            Console.WriteLine(p.CustomProduct());
            Console.WriteLine(p.CustomAverage());
        }
    }
}