namespace StudentsAndWorkers
{
    using System.Text;
    
    public abstract class Human
    {
        // Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Methods
        public override string ToString()
        {
            StringBuilder names = new StringBuilder();

            names.Append("Name: ");
            names.AppendFormat("{0} ", this.FirstName);
            names.AppendFormat("{0} ", this.LastName);

            return names.ToString();
        }
    }
}