namespace AnimalHierarchy
{
    using System;
    using System.Text;

    public class Tomcat : Cat, ISound
    {
        // Fields
        private readonly string tomcatSound = "MEEEEOW!";

        // Constructor
        public Tomcat(string name, int age) : base(name, "male", age)
        {
        }

        // Methods
        public override string MakeSound(string animalSound)
        {
            return this.tomcatSound.ToString();
        }

        public override string ToString()
        {
            StringBuilder tomcat = new StringBuilder();

            tomcat.AppendFormat("{0} ", this.Name.ToString());
            tomcat.AppendFormat("{0} ", this.Age.ToString());
            tomcat.AppendFormat("{0} ", this.Sex.ToString());
            tomcat.Append(this.MakeSound(this.tomcatSound));

            return tomcat.ToString();
        }
    }
}