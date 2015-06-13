namespace Student
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            Student ivan = new Student("Ivan", "Ivanov", "Ivanov", "0000", "Sofia", "+359*********",
                "ivan@ivan.com", 2, University.NewBulgarianUniversity, Faculty.MathmetaticsInformatics, Speciality.ComputerScience);

            Console.WriteLine(ivan);

            Student ivancho = new Student("Ivan", "Ivanov", "Ivanov", "0000", "Varna", "+359*********",
                "ivancho@ivan.com", 2, University.SofiaUniversity, Faculty.Marketing, Speciality.Tourism);

            Console.WriteLine(ivancho);
            Console.WriteLine("Ivan == Ivancho -> {0}", ivan == ivancho);
            Console.WriteLine("Ivancho equals ivan -> {0}", ivancho.Equals(ivan));

            Student ivan2 = ivan.Clone();

            ivan.LastName = "Ivanovski";

            Console.WriteLine("ivan == ivan2 -> {0}", ivan == ivan2);

            Console.WriteLine("Comparing ivan2 with ivan -> {0}", ivan2.CompareTo(ivan));
        }
    }
}