namespace AnimalHierarchy
{
    using System;
    
    public class Dog : Animal, ISound
    {
        private readonly string dogSound = "Bow-wow!";

        // Constructor
        public Dog(string name, string sex, int age, string breed) : base(name, sex, age)
        {
            this.Breed = breed;
        }

        // Properties
        public string Breed { get; private set; }

        // Methods
        public string MakeSound(string animalSound)
        {
            return this.dogSound.ToString();
        }
    }
}