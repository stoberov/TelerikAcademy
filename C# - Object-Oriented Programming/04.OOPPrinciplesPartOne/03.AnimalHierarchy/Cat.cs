namespace AnimalHierarchy
{
    using System;
    
    public abstract class Cat : Animal, ISound
    {
        // Constructor
        public Cat(string name, string sex, int age) : base(name, sex, age)
        {
        }

        // Methods
        public abstract string MakeSound(string sound);
    }
}