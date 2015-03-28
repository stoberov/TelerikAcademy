namespace SubstringStringBuilder
{
    using System;
    using System.Text;
    
    internal class SubstringStringBuilderTest
    {
        private static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder("Get up, Get up, Balkan Superman!");
            StringBuilder substring = test.Substring(16, 6);
            Console.WriteLine(substring);
        }
    }
}