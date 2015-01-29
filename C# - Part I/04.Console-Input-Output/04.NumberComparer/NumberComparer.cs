// Problem 4. Number Comparer
// 
// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("The smaller number is: " + Math.Min(firstNumber, secondNumber));
        Console.WriteLine("The greater number is: " + Math.Max(firstNumber, secondNumber));
    }
}