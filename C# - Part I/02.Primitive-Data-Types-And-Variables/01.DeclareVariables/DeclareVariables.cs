// Problem 1. Declare Variables
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort firstVariable = 52130;
        sbyte secondVariable = -115;
        int thirdVariable = 4825932;
        byte fourthVariable = 97;
        short fifthVariable = -10000;

        Console.WriteLine("First variable: {0}", firstVariable);
        Console.WriteLine("Second variable: {0}", secondVariable);
        Console.WriteLine("Third variable: {0}", thirdVariable);
        Console.WriteLine("Fourth variable: {0}", fourthVariable);
        Console.WriteLine("Fifth variable: {0}", fifthVariable);
    }
}