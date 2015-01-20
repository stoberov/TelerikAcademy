// Problem 2. Float or Double?
// Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
// Write a program to assign the numbers in variables and print them to ensure no precision is lost.

using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstVariable = 34.567839023;
        float secondVariable = 12.345F;
        double thirdVariable = 8923.1234857;
        float fourthVariable = 3456.091F;

        Console.WriteLine("Double variables: {0} and {1}", firstVariable, thirdVariable);
        Console.WriteLine("Float variables: {0} and {1}", secondVariable, fourthVariable);
    }
}
