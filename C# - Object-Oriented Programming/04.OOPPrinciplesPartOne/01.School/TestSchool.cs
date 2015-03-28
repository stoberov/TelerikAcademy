namespace School
{
    using System;
    using System.Collections.Generic;

    public class TestSchool
    {
        public static void Main()
        {
            Console.WindowHeight = 50;
            Console.BufferHeight = 60;

            var school = new School("Hogwards");
            var classes = new List<Class>();
            var disciplines = new List<Discipline>();
            var teachers = new List<Teacher>();
            var students = new List<Student>();

            // Add students
            students.Add(new Student("Harry", 1));
            students.Add(new Student("Ron", 2));
            students.Add(new Student("Hermione", 3));
            students.Add(new Student("Tom", 4));
            students.Add(new Student("Draco", 5));
            students.Add(new Student("Bellatrix", 6));
            students.Add(new Student("Sirius", 7));
            students.Add(new Student("Ginny", 8));
            students.Add(new Student("Nymphadora", 9));

            // Add disciplines
            disciplines.Add(new Discipline("Potions", 10, 4));
            disciplines.Add(new Discipline("Defence Against the Dark Arts", 20, 12));
            disciplines.Add(new Discipline("Charms", 18, 10));
            disciplines.Add(new Discipline("Muggle Studies", 12, 6));
            disciplines.Add(new Discipline("Flying", 4, 4));

            // Add teachers
            teachers.Add(new Teacher("Snape", disciplines[0]));
            teachers.Add(new Teacher("Lupin", disciplines[1]));
            teachers.Add(new Teacher("Flitwick", disciplines[2]));
            teachers.Add(new Teacher("Burbage", disciplines[3]));
            teachers.Add(new Teacher("Madam Hooch", disciplines[4]));

            // Add Class
            classes.Add(new Class("Gryffindor"));

            // Assign Students to Class
            classes[0].AddStudent(students[0]);
            classes[0].AddStudent(students[1]);
            classes[0].AddStudent(students[2]);
            classes[0].AddStudent(students[6]);
            classes[0].AddStudent(students[7]);

            // Assign Teachers to Class
            classes[0].AddTeacher(teachers[0]);
            classes[0].AddTeacher(teachers[1]);
            classes[0].AddTeacher(teachers[2]);
            classes[0].AddTeacher(teachers[3]);
            classes[0].AddTeacher(teachers[4]);

            Console.WriteLine(school.ToString());
            Console.WriteLine(new string('-', 25));
            Console.WriteLine(classes[0].ToString());
        }
    }
}