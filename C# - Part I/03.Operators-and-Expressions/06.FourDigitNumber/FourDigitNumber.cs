// Problem 6. Four-Digit Number
// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) / and/ performs the following:
// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
// Prints on the console the number in reversed order: dcba (in our example 1102).
// Puts the last digit in the first position: dabc (in our example 1201).
// Exchanges the second and the third digits: acbd (in our example 2101).
// The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit integer: ");
        int number = int.Parse(Console.ReadLine());

        int a = (number / 1000) % 10; // first digit (left-to-right)
        int b = (number / 100) % 10; // second digit
        int c = (number / 10) % 10; // third digit
        int d = number % 10; // last digit

        Console.WriteLine("Sum of digits: " + (a + b + c + d));
        Console.WriteLine("The number in reverse: " + d + c + b + a);
        Console.WriteLine("Last digit in the first position: " + d + a + b + c);
        Console.WriteLine("Second and third digits exchanged: " + a + c + b + d);
    }
}