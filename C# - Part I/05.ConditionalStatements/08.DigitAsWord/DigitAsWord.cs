// Problem 8. Digit as Word
// 
// Write a program that asks for a digit (0-9), and depending on the input, shows  the //digit as a word (in English).
// Print “not a digit” in case of invalid input.
// Use a switch statement.

using System;

internal class DigitAsWord
{
    private static void Main()
    {
        Console.Write("Enter a digit from 0 to 9: ");
        byte digit = byte.Parse(Console.ReadLine());        // we use byte because we have only 10 digits

        string name = string.Empty;

        switch (digit)
        {
            case 0:
                name = "You entered Zero";
                break;
            case 1:
                name = "One";
                break;
            case 2:
                name = "Two";
                break;
            case 3:
                name = "Three";
                break;
            case 4:
                name = "Four";
                break;
            case 5:
                name = "Five";
                break;
            case 6:
                name = "Six";
                break;
            case 7:
                name = "Seven";
                break;
            case 8:
                name = "Eight";
                break;
            case 9:
                name = "Nine";
                break;
            default:
                Console.WriteLine("Not a digit");
                break;
        }

        Console.WriteLine("You entered {0} - {1}", digit, name);
    }
}