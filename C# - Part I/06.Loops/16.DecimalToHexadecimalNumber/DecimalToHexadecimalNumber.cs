// Problem 16. Decimal to Hexadecimal Number
// 
// Using loops write a program that converts an integer number to its hexadecimal representation.
// The input is entered as long. The output should be a variable of type string.
// Do not use the built-in .NET functionality.

using System;

internal class DecimalToHexadecimalNumber
{
    private static void Main()
    {
        Console.Write("Decimal: ");
        long input = long.Parse(Console.ReadLine());

        string convertedToHexadecimal = string.Empty;

        while (input > 0)
        {
            switch (input % 16)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    convertedToHexadecimal += input % 16;
                    break;
                case 10:
                    convertedToHexadecimal += "A";
                    break;
                case 11:
                    convertedToHexadecimal += "B";
                    break;
                case 12:
                    convertedToHexadecimal += "C";
                    break;
                case 13:
                    convertedToHexadecimal += "D";
                    break;
                case 14:
                    convertedToHexadecimal += "E";
                    break;
                case 15:
                    convertedToHexadecimal += "F";
                    break;
            }

            input /= 16;
        }

        string result = string.Empty;

        for (int i = convertedToHexadecimal.Length - 1; i >= 0; i--)
        {
            result += convertedToHexadecimal[i];
        }

        Console.WriteLine(string.Format("Hexadecimal: {0}", result));
    }
}