// Problem 8. Prime Number Check
// Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        bool isPrime = true; // until proven otherwise

        Console.Write("Enter a positive integer between 0 and 100: ");
        int a = int.Parse(Console.ReadLine());

        if (a < 0)
        {
            Console.WriteLine("You have entered a negative number. Please, try again.");
        }
        else if (a > 100)
        {
            Console.WriteLine("You have entered a number larger than 100. Please, try again.");
        }
        else if (a == 0 || a == 1)
        {
            Console.WriteLine(a + " is neither prime nor composite.");
        }
        else if (a == 2)
        {
            Console.WriteLine("Prime? " + isPrime);
        }
        else
        {
            // use Math.Sqrt to cut by half the number of checks necessary
            for (int i = 2; i <= Math.Sqrt(a); i++) 
            {
                if (a % i == 0)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine("Prime? " + isPrime);
        }
    }
}