// Problem 9. Exchange Variable Values
// Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
// Print the variable values before and after the exchange.

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before: a = {0}", a);
        Console.WriteLine("Before: b = {0}", b);
        Console.WriteLine(new string('=', 15));

        // Avoid third variable
        a = a + b; // a = 15;
        b = a - b; // b = 5;
        a = a - b; // a = 10;

        Console.WriteLine("After: a = {0}", a);
        Console.WriteLine("After: b = {0}", b);
        Console.WriteLine(new string('=', 15));
    }
}