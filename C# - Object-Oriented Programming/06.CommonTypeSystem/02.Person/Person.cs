namespace Person
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Person
    {
        private int? age;

        public Person(string name, int? age)
        {
            this.Age = age;
            this.Name = name;
        }

        public Person(string name) : this(name, null)
        {
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }

        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Person's name is {0}. ", this.Name);
            if (this.Age == null)
            {
                sb.Append("Person's age is unspecified. ");
            }
            else
            {
                sb.AppendFormat("Person's age is {0}. ", this.Age);
            }

            return sb.ToString();
        }
    }
}