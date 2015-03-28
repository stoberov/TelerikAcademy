namespace School
{
    using System.Collections.Generic;
    using System.Text;
    
    public class Class : IComment
    {
        // Fields
        private List<Teacher> setOfTeachers = new List<Teacher>();
        private List<Student> enrolledStudents = new List<Student>();

        // Constructor
        public Class(string identifier)
        {
            this.UniqueTextIdentifier = identifier;
        }

        // Properties
        public string UniqueTextIdentifier { get; private set; }

        public List<Student> EnrolledStudents
        {
            get
            {
                return this.enrolledStudents;
            }

            private set
            {
                this.enrolledStudents = new List<Student>();
            }
        }

        public List<Teacher> SetOfTeachers
        {
            get
            {
                return this.setOfTeachers;
            }

            private set
            {
                this.setOfTeachers = new List<Teacher>();
            }
        }

        // Methods
        public void AddStudent(Student student)
        {
            this.enrolledStudents.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.setOfTeachers.Add(teacher);
        }

        public string AddComment(string comment)
        {
            return comment;
        }

        public override string ToString()
        {
            var information = new StringBuilder();

            information.AppendLine(string.Format("CLASS: {0}", this.UniqueTextIdentifier));
            information.AppendLine(new string('-', 25));
            information.AppendLine("TEACHERS: \n");

            foreach (var teacher in this.setOfTeachers)
            {
                information.AppendLine(teacher.ToString());
            }
            
            information.AppendLine(new string('-', 25));

            information.AppendLine("STUDENTS: \n");
            foreach (var student in this.enrolledStudents)
            {
                information.AppendLine(student.ToString());
            }

            return information.ToString();
        }
    }
}