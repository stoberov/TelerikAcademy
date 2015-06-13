namespace Student
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Student : ICloneable, IComparable<Student>
    {
        /* 
        * Override the standard methods, inherited by  
        * System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
        */
        private int course;

        public Student(
            string firstName, string middleName, string lastName, string ssn, string permanentAddress, string phone, string email, int course, University university,
            Faculty faculty, Speciality speciality)
        {
            this.Faculty = faculty;
            this.University = university;
            this.Speciality = speciality;
            this.Course = course;
            this.Email = email;
            this.Phone = phone;
            this.PermanentAddress = permanentAddress;
            this.SSN = ssn;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.FirstName = firstName;
        }

        public Faculty Faculty { get; set; }

        public University University { get; set; }

        public Speciality Speciality { get; set; }

        public int Course
        {
            get
            {
                return this.course;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.course = value;
            }
        }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string PermanentAddress { get; set; }

        public string SSN { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string FirstName { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student student = obj as Student;
            if (student.FirstName != this.FirstName || student.LastName != this.LastName ||
                student.MiddleName != this.MiddleName || student.SSN != this.SSN)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.course;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Student's name is : {0} {1} {2}. ", this.FirstName, this.MiddleName, this.LastName);
            sb.AppendFormat("Student's SSN is : {0}. ", this.SSN);
            sb.AppendFormat("Student's phone is : {0}. ", this.Phone);
            sb.AppendFormat("Student's email is : {0}. ", this.PermanentAddress);
            sb.AppendFormat("Student is in : {0} course, speciality {1}, faculty {2}, university {3}.",
                this.Course,
                this.Speciality,
                this.Faculty,
                this.University);

            return sb.ToString();
        }

        public Student Clone()
        {
            return new Student(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.SSN,
                this.PermanentAddress,
                this.Phone,
                this.Email,
                this.Course,
                this.University,
                this.Faculty,
                this.Speciality);
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            if (this.SSN != other.SSN)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return 0;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public static bool operator ==(Student a, Student b)
        {
            // If both are null, or both are same instance, return true.
            if (object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Using Equals() - both are equals if they have same name and ssn
            return a.Equals(b);
        }

        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }
    }
}