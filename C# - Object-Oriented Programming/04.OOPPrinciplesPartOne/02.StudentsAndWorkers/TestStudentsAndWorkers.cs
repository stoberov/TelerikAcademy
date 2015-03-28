namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class TestStudentsAndWorkers
    {
        public static void Main()
        {
            Console.BufferHeight = 100;
            Console.WindowHeight = 50;

            var listOfStudents = new List<Student>();
            var listOfWorkers = new List<Worker>();
            
            // Initialize the students
            listOfStudents.Add(new Student("Harry", "Potter", 5));
            listOfStudents.Add(new Student("Sherlock", "Holmes", 6));
            listOfStudents.Add(new Student("Michael", "Jackson", 6));
            listOfStudents.Add(new Student("Tom", "Cruise", 2));
            listOfStudents.Add(new Student("Antonio", "Banderas", 3));
            listOfStudents.Add(new Student("Bruce", "Wayne", 4));
            listOfStudents.Add(new Student("Wonder", "Woman", 4));
            listOfStudents.Add(new Student("Yu-Gi", "Oh", 4));
            listOfStudents.Add(new Student("Adam", "d'Angelo", 5));
            listOfStudents.Add(new Student("Fred", "Flintstone", 6));
            
            // Initialize the workers
            listOfWorkers.Add(new Worker("Brad", "Pitt", 250, 8));
            listOfWorkers.Add(new Worker("Marlon", "Brando", 300, 8));
            listOfWorkers.Add(new Worker("Bruce", "Willis", 200, 6));
            listOfWorkers.Add(new Worker("Jennifer", "Lawrence", 150, 4));
            listOfWorkers.Add(new Worker("Scarlett", "Johansson", 200, 8));
            listOfWorkers.Add(new Worker("Jennifer", "Aniston", 350, 8));
            listOfWorkers.Add(new Worker("Julia", "Roberts", 220, 6));
            listOfWorkers.Add(new Worker("Anne", "Hathaway", 280, 6));
            listOfWorkers.Add(new Worker("Emma", "Watson", 190, 4));
            listOfWorkers.Add(new Worker("Meryl", "Streep", 100, 4));
 
            Console.WriteLine("Students ordered by grade (ascending): \n");
            OrderStudentsByGradeAsc(listOfStudents);
            
            Console.WriteLine("\nWorkers ordered by money per hour (descending): \n");
            OrderWorkersByMoneyDesc(listOfWorkers);

            Console.WriteLine("\nMerged and Ordered by names: \n");
            MergeAndSortLists(listOfStudents, listOfWorkers);
        }
        
        public static void OrderStudentsByGradeAsc(List<Student> unorderedStudents)
        {
            // Use OrderBy extension method
            var orderedStudents = unorderedStudents.OrderBy(x => x.Grade);
            
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
        
        public static void OrderWorkersByMoneyDesc(List<Worker> unorderedWorkers)
        {
            // Use LINQ
            var orderedWorkers = from worker in unorderedWorkers
                                 orderby worker.MoneyPerHour.ToString() descending
                                 select worker;
            
            foreach (var worker in orderedWorkers)
            {
                Console.WriteLine(worker.ToString());
            }
        }

        public static void MergeAndSortLists(List<Student> students, List<Worker> workers)
        {
            var mergedList = new List<Human>();
            
            foreach (var student in students)
            {
                mergedList.Add(student);
            }
            
            foreach (var worker in workers)
            {
                mergedList.Add(worker);
            }

            var mergedAndOrderedList = from human in mergedList
                                       orderby human.FirstName ascending, human.LastName ascending
                                       select human;
            
            foreach (var human in mergedAndOrderedList)
            {
                Console.WriteLine(string.Format("{0} {1}", human.FirstName, human.LastName));
            }
        }
    }
}