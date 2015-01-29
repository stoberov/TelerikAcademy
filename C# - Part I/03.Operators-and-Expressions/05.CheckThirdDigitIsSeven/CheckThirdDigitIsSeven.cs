// Problem 5. Third Digit is 7?
//
// Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class CheckThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int a = int.Parse(Console.ReadLine());

        int b = (a / 100);
        int c = (b % 10);

        bool check = (c == 7);

        Console.WriteLine("Third digit (right-to-left) equals 7? " + check);
    }
}