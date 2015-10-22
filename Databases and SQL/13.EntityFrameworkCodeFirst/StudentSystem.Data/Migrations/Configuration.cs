namespace StudentSystem.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using StudentSystem.Models;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = false;
            this.ContextKey = "StudentSystem.Data.StudentSystemContext";
        }

        protected override void Seed(StudentSystemContext context)
        {
            context.Courses
                .AddOrUpdate(
                    c => c.Name,
                    new Course
                    {
                        Name = "JavaScript (Seeded)",
                        Description = "The one and only",
                        Materials = "JavaScript: The Good Parts"
                    },
                    new Course
                    {
                        Name = "C# (Seeded)",
                        Description = "A Powerhorse",
                        Materials = "Intro to Programming by Nakov and Co."
                    });
        }
    }
}