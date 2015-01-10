// Problem 14.* Current Date and Time
// Create a console application that prints the current date and time. 

using System;

class CurrentDateAndTime
{
    static void Main()
    {
        DateTime currentDateAndTime = DateTime.Now;
  
        Console.WriteLine("The current Date and Time is:");
        Console.WriteLine(currentDateAndTime.ToString("d MMM yyyy HH:mm"));
    }
}