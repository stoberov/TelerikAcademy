namespace AnimalHierarchy
{
    public abstract class Animal
    {
        // Constructor
        public Animal(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        // Properties
        public int Age { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        // Methods
        public override string ToString()
        {
            return string.Format("{0}{1}. It is {2}And is {3} years old.", @"This is ", this.Name.ToString(), this.Sex.ToString(), this.Age);
        }
    }
}