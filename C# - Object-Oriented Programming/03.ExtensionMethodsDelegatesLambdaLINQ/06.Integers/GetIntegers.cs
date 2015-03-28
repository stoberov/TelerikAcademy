namespace GetIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    internal class GetIntegers
    {
        public static void PrintArray(IEnumerable<int> array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 30));
        }

        private static void Main(string[] args)
        {
            int arrayLength = 101;
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = i;
            }

            var divisibleInts = array.Where(m => (m % 3 == 0 || m % 7 == 0));
            PrintArray(divisibleInts);

            divisibleInts = from number in array
                            where number % 3 == 0 || number % 7 == 0
                            select number;
            PrintArray(divisibleInts);
        }
    }
}