// Problem 10.* Beer Time
// 
// A beer time is after 1:00 PM and before 3:00 AM.
// Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;

internal class BeerTime
{
    private static void Main()
    {
        bool correctTime;
        DateTime time;

        Console.WriteLine("Enter a time in format hh:mm tt");
        string inputTime = Console.ReadLine();

        DateTime later = DateTime.Parse("1:00 PM");
        DateTime earlier = DateTime.Parse("3:00 AM");

        correctTime = DateTime.TryParse(inputTime, out time);

        if (correctTime)
        {
            if (time >= later || time < earlier)
            {
                Console.WriteLine("Beer Time!");
            }
            else
            {
                Console.WriteLine("Non-beer Time!");
            }
        }
        else
        {
            Console.WriteLine("Invalid Time");
        }
    }
}