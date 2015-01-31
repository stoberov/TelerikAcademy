// Problem 15. Hexadecimal to Decimal Number
// 
// Using loops write a program that converts a hexadecimal integer number to its decimal form.
// The input is entered as string. The output should be a variable of type long.
// Do not use the built-in .NET functionality.

using System;

internal class HexadecimalToDecimalNumber
{
    private static void Main()
    {
        Console.Write("Hexadecimal: ");
        string input = Console.ReadLine();

        long convertedToDecimal = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    convertedToDecimal += long.Parse(input[i].ToString()) * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'A':
                    convertedToDecimal += 10 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'B':
                    convertedToDecimal += 11 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'C':
                    convertedToDecimal += 12 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'D':
                    convertedToDecimal += 13 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'E':
                    convertedToDecimal += 14 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'F':
                    convertedToDecimal += 15 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
            }
        }

        Console.WriteLine(string.Format("Decimal: {0}", convertedToDecimal));
    }
}