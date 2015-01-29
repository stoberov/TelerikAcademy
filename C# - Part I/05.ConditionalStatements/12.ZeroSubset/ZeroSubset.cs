// Problem 12.* Zero Subset
// 
// We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
// Assume that repeating the same subset several times is not a problem.

using System;

internal class ZeroSubset
{
    private static void Main()
    {
        bool subset = false;

        Console.Write("A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("C: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("D: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("E: ");
        int e = int.Parse(Console.ReadLine());

        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
            subset = true;
        }

        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            subset = true;
        }

        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            subset = true;
        }

        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            subset = true;
        }

        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, c);
            subset = true;
        }

        if (b + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, d);
            subset = true;
        }

        if (b + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", b, e);
            subset = true;
        }

        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            subset = true;
        }

        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            subset = true;
        }

        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
            subset = true;
        }

        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            subset = true;
        }

        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            subset = true;
        }

        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            subset = true;
        }

        if (a + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, d);
            subset = true;
        }

        if (a + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, c, e);
            subset = true;
        }

        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            subset = true;
        }

        if (b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
            subset = true;
        }

        if (b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
            subset = true;
        }

        if (b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
            subset = true;
        }

        if (c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
            subset = true;
        }

        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            subset = true;
        }

        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            subset = true;
        }

        if (a + b + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, d, e);
            subset = true;
        }

        if (a + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, c, d, e);
            subset = true;
        }

        if (b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", b, c, d, e);
            subset = true;
        }

        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            subset = true;
        }

        if (!subset)
        {
            Console.WriteLine("No zero subset.");
        }
    }
}