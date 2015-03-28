namespace School
{
    using System.Text;
    
    public class Discipline : IComment
    {
        // Constructor
        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercises = exercises; 
        }

        // Properties
        public string Name { get; private set; }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExercises { get; private set; }

        // Methods
        public string AddComment(string comment)
        {
            return comment;
        }

        public override string ToString()
        {
            StringBuilder information = new StringBuilder();

            information.AppendLine(string.Format("Discipline: {0}", this.Name));
            information.AppendLine(string.Format("Number of lectures: {0}", this.NumberOfLectures));
            information.AppendFormat("Number of exercises: {0}", this.NumberOfExercises);

            return information.ToString();
        }
    }
}