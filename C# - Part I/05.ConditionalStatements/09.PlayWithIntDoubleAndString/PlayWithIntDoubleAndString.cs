// Problem 9. Play with Int, Double and String
// 
// Write a program that, depending on the user’s choice, inputs an int, double or / string /variable.
// If the variable is int or double, the program increases it by one.
// If the variable is a string, the program appends * at the end.
// Print the result at the console. Use switch statement.

using System;

internal class PlayWithIntDoubleAndString
{
    private static void Main()
    {
        Console.Write("Enter 1 for int, 2 for double, or 3 for string: ");
        byte inputType = byte.Parse(Console.ReadLine());

        switch (inputType)
        {
            case 1:
                Console.Write("Enter an integer: ");

                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case 2:
                Console.Write("Enter a double: ");
                double b = double.Parse(Console.ReadLine());

                Console.WriteLine(b + 1);
                break;
            case 3:
                Console.Write("Enter a string: ");
                string c = Console.ReadLine();

                Console.WriteLine(string.Format("{0}*", c));
                break;
            default:
                Console.WriteLine("Your choice is invalid!");
                break;
        }
    }
}