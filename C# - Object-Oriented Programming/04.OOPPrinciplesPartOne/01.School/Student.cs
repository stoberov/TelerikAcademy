namespace School
{
    using System.Text;
    
    public class Student : Human, IComment
    {
        public Student(string name, int identifier) : base(name)
        {
            this.UniqueClassNumber = identifier;
        }

        public int UniqueClassNumber { get; set; }

        public string AddComment(string comment)
        {
            return comment;
        }

        public override string ToString()
        {
            StringBuilder information = new StringBuilder();
            information.AppendLine(string.Format("Student name: {0}", this.Name));
            information.AppendLine(string.Format("Student ID Number: {0}", this.UniqueClassNumber));

            return information.ToString();
        }
    }
}