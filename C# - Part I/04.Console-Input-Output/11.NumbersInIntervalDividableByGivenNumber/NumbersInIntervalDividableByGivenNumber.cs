// Problem 11.* Numbers in Interval Dividable by Given Number
// Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter Start of Interval: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter End of Interval: ");
        int end = int.Parse(Console.ReadLine());

        int count = 0;

        if (end % 5 == 0 && start % 5 == 0)
        {
            count++;
        }

        end /= 5;
        start /= 5;
        count += Math.Abs(end - start);

        Console.WriteLine(count);
    }
}