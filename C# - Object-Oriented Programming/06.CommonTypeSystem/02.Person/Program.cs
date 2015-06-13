namespace Person
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20);
            Person gosho = new Person("Gosho");

            Console.WriteLine(pesho);
            Console.WriteLine(gosho);
        }
    }
}