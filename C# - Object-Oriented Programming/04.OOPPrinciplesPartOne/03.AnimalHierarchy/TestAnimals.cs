namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    
    public class TestAnimals
    {
        public static void Main()
        {
            List<Animal> kittens = new List<Animal>();
            kittens.Add(new Kitten("Maca", 1));
            kittens.Add(new Kitten("Pisana", 4));
            kittens.Add(new Kitten("Kitty", 8));
            AverageAge(kittens);

            List<Animal> tomcats = new List<Animal>();
            tomcats.Add(new Tomcat("Tom", 2));
            tomcats.Add(new Tomcat("Baron", 3));
            tomcats.Add(new Tomcat("Bonbon", 6));
            AverageAge(tomcats);

            List<Animal> dogs = new List<Animal>();
            dogs.Add(new Dog("Snow", "male", 8, "huskey"));
            dogs.Add(new Dog("Jordan", "male", 6, "chihuahua"));
            dogs.Add(new Dog("Daemon", "female", 4, "rottweiler"));
            AverageAge(dogs);

            List<Animal> frogs = new List<Animal>();
            frogs.Add(new Frog("Lannister", "male", 2, "pink"));
            frogs.Add(new Frog("Stark", "male", 3, "green"));
            frogs.Add(new Frog("Arryn", "female", 4, "purple"));
            AverageAge(frogs);
        }

        public static void AverageAge(List<Animal> animals)
        {
            double sum = 0;
            string kind = string.Empty;

            foreach (var animal in animals)
            {
                sum += animal.Age;
                kind = animal.GetType().ToString();
            }

            double average = sum / animals.Count;

            Console.WriteLine("The average age of all {0}s is {1}.", kind, Math.Round(average, 2));
        }
    }
}