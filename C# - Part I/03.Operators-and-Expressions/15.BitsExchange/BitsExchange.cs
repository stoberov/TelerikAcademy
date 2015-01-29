// Problem 15.* Bits Exchange
// 
// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());

        int position1 = 3;
        int position2 = 24;

        int mask1 = 7 << position1;
        int mask2 = 7 << position2;

        int getNumbers1 = (int)n & mask1;
        int getNumbers2 = (int)n & mask2;
        int change = ((int)n & ~mask1) & ~mask2;

        int mask3 = (getNumbers1 >> position1) << position2;
        int mask4 = (getNumbers2 >> position2) << position1;
        int result = (change | mask3) | mask4;

        Console.WriteLine(result);
    }
}