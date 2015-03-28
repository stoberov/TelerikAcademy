namespace AnimalHierarchy
{
    using System;
    using System.Text;
    
    public class Kitten : Cat, ISound
    {
        // Fields
        private readonly string kittenSound = "Meow-meow";

        // Constructor
        public Kitten(string name, int age) : base(name, "female", age)
        { 
        }

        // Methods
        public override string MakeSound(string animalSound)
        {
            return this.kittenSound.ToString();
        }

        public override string ToString()
        {
            StringBuilder kitten = new StringBuilder();

            kitten.AppendFormat("{0} ", this.Name.ToString());
            kitten.AppendFormat("{0} ", this.Age.ToString());
            kitten.AppendFormat("{0} ", this.Sex.ToString());
            kitten.Append(this.MakeSound(this.kittenSound));

            return kitten.ToString();
        }
    }
}