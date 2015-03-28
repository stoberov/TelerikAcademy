namespace StringMaxLength
{
    using System;
    using System.Linq;
    
    public class StringMaxLength
    {
        private static int LongestElement = 0;

        public static void Main()
        {
            string[] stringArray = GenerateRandomStrings();

            string answerWithExtension = stringArray.Aggregate(string.Empty, (max, cur) => max.Length > cur.Length ? max : cur);

            Console.WriteLine(answerWithExtension);

            var answerWithQuery = from st in stringArray
                                  where GetLongerStr(st)
                                  select st;

            Console.WriteLine(answerWithQuery.Last());
        }

        private static bool GetLongerStr(string st)
        {
            if (st.Length > LongestElement)
            {
                LongestElement = st.Length;
                return true;
            }

            return false;
        }

        private static string[] GenerateRandomStrings()
        {
            Random rnd = new Random();

            string[] array = new string[rnd.Next(20, 31)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new string((char)rnd.Next(65, 94), rnd.Next(1, 50));
            }

            return array;
        }
    }
}