// Problem 4. Print a Deck of 52 Cards
// 
// Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
// The card faces should start from 2 to A.
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

using System;

internal class PrintDeckOfCards
{
    private static void Main()
    {
        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };

        for (int i = 0; i < suits.Length; i++)
        {
            for (int card = 2; card <= 14; card++)
            {
                switch (card)
                {
                    case 2:
                        Console.WriteLine("Two of {0}", suits[i]);
                        break;
                    case 3:
                        Console.WriteLine("Three of {0}", suits[i]);
                        break;
                    case 4:
                        Console.WriteLine("Four of {0}", suits[i]);
                        break;
                    case 5:
                        Console.WriteLine("Five of {0}", suits[i]);
                        break;
                    case 6:
                        Console.WriteLine("Six of {0}", suits[i]);
                        break;
                    case 7:
                        Console.WriteLine("Seven of {0}", suits[i]);
                        break;
                    case 8:
                        Console.WriteLine("Eight of {0}", suits[i]);
                        break;
                    case 9:
                        Console.WriteLine("Nine of {0}", suits[i]);
                        break;
                    case 10:
                        Console.WriteLine("Ten of {0}", suits[i]);
                        break;
                    case 11:
                        Console.WriteLine("Jack of {0}", suits[i]);
                        break;
                    case 12:
                        Console.WriteLine("Queen of {0}", suits[i]);
                        break;
                    case 13:
                        Console.WriteLine("King of {0}", suits[i]);
                        break;
                    case 14:
                        Console.WriteLine("Ace of {0}", suits[i]);
                        break;
                }
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}