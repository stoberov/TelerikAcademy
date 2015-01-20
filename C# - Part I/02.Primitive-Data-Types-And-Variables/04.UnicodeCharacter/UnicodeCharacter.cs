// Problem 4. Unicode Character
// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
// Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

using System;

class UnicodeCharacter
{
    static void Main()
    {
        // The hexadecimal representation of 42 is 2A
        char sampleVariable = '\u002A';

        Console.WriteLine("The \\u00XX representation of Unicode symbol with code 42 is \\u002A ---> " + sampleVariable);
    }
}
