// Problem 3. Divide by 7 and 5
// 
// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int a = int.Parse(Console.ReadLine());

        bool check = (a % 35 == 0); // 35 is the least majority multiple of 5 and 7

        if (check)
        {
            Console.WriteLine("Can be divided without a remainder");
        }
        else
        {
            Console.WriteLine("Cannot be divided without a remainder");
        }
    }
}