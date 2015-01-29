// Problem 10. Fibonacci Numbers
// 
// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and  space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        BigInteger a = 1;
        BigInteger b = 1;
        BigInteger next;
        
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("0,  1,  1,  ");
        
        for (int i = 1; i <= n; i++)
        {
            next = a + b;
            Console.Write(next);
            Console.Write(",  ");

            a = b;
            b = next;
        }
    }
}