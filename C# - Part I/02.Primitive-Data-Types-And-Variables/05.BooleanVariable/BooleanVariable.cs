// Problem 5. Boolean Variable
// Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
// Print it on the console.

using System;

class BooleanVariable
{
    static void Main()
    {
        bool isFemale = false; // I am a male

        Console.Write("Am I male or female (please, enter M or F): ");
        string gender = Console.ReadLine();

        if (gender == "F")
        {
            Console.WriteLine("I am a male? " + isFemale + " => pass me the wine & salad.");
        }
        else
        {
            isFemale = true;
            Console.WriteLine("I am a male? " + isFemale + " => pass me the beer & pizza.");
        }
    }
}