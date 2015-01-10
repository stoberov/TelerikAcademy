// Problem 15.* Age after 10 Years
// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("How old are you now? ");

        int currentAge = int.Parse(Console.ReadLine());
        currentAge += 10;

        Console.WriteLine("You will be " + currentAge + " in ten years.");
    }
}