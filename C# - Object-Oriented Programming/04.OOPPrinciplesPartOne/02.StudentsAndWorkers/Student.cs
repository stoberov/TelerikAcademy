namespace StudentsAndWorkers
{
    using System.Text;
    
    public class Student : Human
    {
        // Constructor
        public Student(string firstName, string lastName, int grade) : base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        // Property
        public int Grade { get; set; }

        // Methods
        public override string ToString()
        {
            StringBuilder studentInfo = new StringBuilder();

            studentInfo.AppendFormat("{0} ", this.FirstName.ToString());
            studentInfo.AppendFormat("{0}: ", this.LastName.ToString());
            studentInfo.Append(this.Grade.ToString());

            return studentInfo.ToString();
        }
    }
}