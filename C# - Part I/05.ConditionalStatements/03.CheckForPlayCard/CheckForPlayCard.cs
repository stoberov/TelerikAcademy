// Problem 3. Check for a Play Card
//
// Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.

using System;

internal class CheckForPlayCard
{
    private static void Main()
    {
        string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        Console.Write("Enter card: ");
        string card = Console.ReadLine().Trim();

        bool isValid = Array.IndexOf(cards, card) != -1;

        if (isValid)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}