namespace School
{
    public abstract class Human
    {
        // Constructor
        public Human(string name)
        {
            this.Name = name;
        }

        // Properties
        public string Name { get; private set; }
    }
}