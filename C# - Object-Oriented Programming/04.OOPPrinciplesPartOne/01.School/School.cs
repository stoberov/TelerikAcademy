namespace School
{
    using System.Collections.Generic;
    using System.Text;
    
    public class School
    {
        // Fields
        private List<Class> schoolClasses;
        
        // Constructor
        public School(string name)
        {
            this.Name = name;
        }

        // Properties
        public string Name
        {
            get;

            private set;
        }

        public List<Class> SchoolClasses
        {
            get
            {
                return this.schoolClasses;
            }

            set
            {
                this.schoolClasses = new List<Class>();
            }
        }

        // Methods
        public void AddClass(List<Class> schoolClasses, Class singleClass)
        {
            this.schoolClasses.Add(singleClass);
        }

        public override string ToString()
        {
            return "Welcome to: " + this.Name.ToString();
        }
    }
}