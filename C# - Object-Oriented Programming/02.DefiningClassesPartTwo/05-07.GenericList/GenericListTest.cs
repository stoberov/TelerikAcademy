namespace GenericList
{
    using System;
    using System.Linq;
    
    public class GenericListTest
    {
        public static void Main()
        {
            GenericList<int> testList = new GenericList<int>(5);

            testList.AddElement(10);
            testList.AddElement(20);
            testList.AddElement(30);
            testList.AddElement(40);
            testList.AddElement(50);
            testList.InsertElementAt(0, 60);
            testList.RemoveElementAt(0);
            testList.AddElement(60);
            testList.AddElement(70);
            testList.AddElement(0);

            Console.WriteLine(testList.Count);
            Console.WriteLine("Min: {0}", testList.Min());
            Console.WriteLine("Max: {0}", testList.Max());
        }
    }
}