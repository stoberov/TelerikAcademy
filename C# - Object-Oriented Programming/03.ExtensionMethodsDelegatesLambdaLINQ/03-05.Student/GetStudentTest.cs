namespace GetStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    internal class GetStudentTest
    {
        public static IEnumerable<Student> FindStudentsByName(Student[] students)
        {
            var result = from student in students
                         where student.FirstName.CompareTo(student.LastName) < 0
                         select student;

            return result;   // students.Where(m => m.FirstName.CompareTo(m.LastName) < 0 );
        }

        public static IEnumerable<Student> FindStudentsByAge(Student[] students)
        {
            var result = from student in students
                         where student.Age >= 18 && student.Age <= 24
                         select student;

            return result;
        }

        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine(new string('-', 30));
        }

        private static void Main(string[] args)
        {
            Student[] students = new Student[6];

            students[0] = new Student("Martin", "Petrov", 24);
            students[1] = new Student("Dimitar", "Berbatov", 23);
            students[2] = new Student("Hristo", "Stoichkov", 20);
            students[3] = new Student("Hristo", "Yovov", 9);
            students[4] = new Student("Emil", "Gargorov", 18);
            students[5] = new Student("Trifon", "Ivanov", 25);

            IEnumerable<Student> searchedStudents = FindStudentsByName(students);
            PrintStudents(searchedStudents);
            searchedStudents = FindStudentsByAge(students);
            PrintStudents(searchedStudents);

            var sortedStudents =
                students.OrderByDescending(m => m.FirstName).ThenByDescending(m => m.LastName);
            PrintStudents(sortedStudents);

            sortedStudents = from student in students
                             orderby student.FirstName descending, student.LastName descending
                             select student;
            PrintStudents(sortedStudents);
        }
    }
}