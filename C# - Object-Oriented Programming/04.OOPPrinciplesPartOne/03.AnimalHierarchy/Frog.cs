namespace AnimalHierarchy
{
    using System.Text;
    
    public class Frog : Animal, ISound
    {
        // Fields
        private readonly string frogSound = "Kwak-kwak!";

        // Constructor
        public Frog(string name, string sex, int age, string color) : base(name, sex, age)
        {
            this.Color = color;
        }

        // Properties
        public string Color { get; private set; }

        // Methods
        public string MakeSound(string animalSound)
        {
            return this.frogSound.ToString();
        }

        public override string ToString()
        {
            StringBuilder frog = new StringBuilder();

            frog.AppendFormat("{0} ", this.Name.ToString());
            frog.AppendFormat("{0} ", this.Age.ToString());
            frog.AppendFormat("{0} ", this.Sex.ToString());
            frog.Append(this.MakeSound(this.frogSound));

            return frog.ToString();
        }
    }
}