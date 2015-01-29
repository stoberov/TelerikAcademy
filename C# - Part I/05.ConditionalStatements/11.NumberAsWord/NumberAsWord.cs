// Problem 11.* Number as Words
// 
// Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

internal class NumberAsWord
{
    private static void Main()
    {
        bool correctNumber;
        int number;
        int resultHundreds = 0;
        int resultTens = 0;
        int resultOnes = 0;

        do
        {
            Console.Write("Write an integer between 0 and 999: ");

            string strNumber = Console.ReadLine();
            correctNumber = int.TryParse(strNumber, out number);
        }
        while (correctNumber == false);

        if (number > 99)
        {
            resultHundreds = number / 100;
            switch (resultHundreds)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
            }

            if (number % 100 != 0)
            {
                Console.Write("and ");
            }
        }

        if ((number % 100) > 19)
        {
            resultTens = (number % 100) / 10;
            switch (resultTens)
            {
                case 2:
                    Console.Write("Twenty ");
                    break;
                case 3:
                    Console.Write("Thirty ");
                    break;
                case 4:
                    Console.Write("Forty ");
                    break;
                case 5:
                    Console.Write("Fifty ");
                    break;
                case 6:
                    Console.Write("Sixty");
                    break;
                case 7:
                    Console.Write("Seventy ");
                    break;
                case 8:
                    Console.Write("Eighty ");
                    break;
                case 9:
                    Console.Write("Ninety ");
                    break;
            }
        }

        if (((number % 100) < 10) || ((number % 100) > 19))
        {
            resultOnes = number % 10;

            switch (resultOnes)
            {
                case 1:
                    Console.Write("One");
                    break;
                case 2:
                    Console.Write("Two");
                    break;
                case 3:
                    Console.Write("Three");
                    break;
                case 4:
                    Console.Write("Four");
                    break;
                case 5:
                    Console.Write("Five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("Seven");
                    break;
                case 8:
                    Console.Write("Eight");
                    break;
                case 9:
                    Console.Write("Nine");
                    break;
            }
        }
        else
        {
            resultTens = number % 100;
            switch (resultTens)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;
            }
        }

        if (number == 0)
        {
            Console.WriteLine("Zero");
        }

        Console.WriteLine();
    }
}