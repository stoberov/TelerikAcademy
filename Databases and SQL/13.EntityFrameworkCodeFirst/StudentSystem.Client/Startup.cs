namespace StudentSystem.Client
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Data.Migrations;
    using StudentSystem.Models;

    internal static class Startup
    {
        private static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());

            var db = new StudentSystemContext();

            var student = new Student
            {
                FirstName = "Jon",
                LastName = "Snow",
                Number = 1955
            };

            var course = new Course
            {
                Name = "High-Quality Code",
                Description = "It can be done!",
                Materials = "All you can read x 3"
            };

            var homework = new Homework
            {
                Content = "Zip file uploaded",
                TimeSent = DateTime.Now,
                StudentId = 1,
                CourseId = 1
            };

            db.Students.Add(student);
            db.Courses.Add(course);
            db.Homeworks.Add(homework);

            db.SaveChanges();

            Console.WriteLine(db.Students.Count());
            Console.WriteLine(db.Courses.Count());
            Console.WriteLine(db.Homeworks.Count());
        }
    }
}