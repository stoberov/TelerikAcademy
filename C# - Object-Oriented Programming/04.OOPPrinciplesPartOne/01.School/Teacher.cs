namespace School
{
    using System.Collections.Generic;
    using System.Text;
    
    public class Teacher : Human, IComment
    {
        private List<Discipline> setOfDisciplines;

        public Teacher(string name, Discipline discipline) : base(name)
        {
            this.SetOfDisciplines = new List<Discipline>();
            this.SetOfDisciplines.Add(discipline);
        }

        public List<Discipline> SetOfDisciplines
        {
            get
            {
                return this.setOfDisciplines;
            }

            set
            {
                this.setOfDisciplines = new List<Discipline>();
            }
        }

        public string AddComment(string comment)
        {
            return comment;
        }

        public override string ToString()
        {
            var information = new StringBuilder();

            information.AppendLine(string.Format("Teacher: {0}", this.Name));

            foreach (var discipline in this.setOfDisciplines)
            {
                information.AppendLine(discipline.ToString());
            }

            return information.ToString();
        }
    }
}