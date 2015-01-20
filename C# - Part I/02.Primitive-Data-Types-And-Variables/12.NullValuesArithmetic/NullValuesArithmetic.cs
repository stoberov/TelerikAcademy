// Problem 12. Null Values Arithmetic
// Create a program that assigns null values to an integer and to a double variable.
// Try to print these variables at the console.
// Try to add some number or the null literal to these variables and print the result.

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstVar = null;
        double? secondVar = null;

        Console.WriteLine("The integer and double have Null value (will not print) --> {0} <-- and here --> {1} <--", firstVar, secondVar);

        firstVar = 2015;
        secondVar = 99.95;

        Console.WriteLine("The integer and double have value (will print) --> {0} <-- and here --> {1} <--", firstVar, secondVar);
    }
}