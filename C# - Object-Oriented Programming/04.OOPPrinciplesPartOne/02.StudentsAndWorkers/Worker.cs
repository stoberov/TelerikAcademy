namespace StudentsAndWorkers
{
    using System;
    using System.Text;
    
    public class Worker : Human
    {
        // Constructor
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) : base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.MoneyPerHour = this.MoneyEarnedPerHour();
        }

        // Properties
        public double WeekSalary { get; private set; }

        public double WorkHoursPerDay { get; private set; }

        public double MoneyPerHour { get; private set; }

        // Methods
        public double MoneyEarnedPerHour()
        {
            // Assume a 5-day work week
            return Math.Round(this.WeekSalary / (this.WorkHoursPerDay * 5), 2);
        }

        public override string ToString()
        {
            StringBuilder workerInfo = new StringBuilder();

            workerInfo.AppendFormat("{0} ", this.FirstName.ToString());
            workerInfo.AppendFormat("{0}: ", this.LastName.ToString());
            workerInfo.AppendFormat("{0} hours per week; ", this.WeekSalary.ToString());
            workerInfo.AppendFormat("{0} hours per day; ", this.WorkHoursPerDay.ToString());
            workerInfo.AppendFormat("{0} per hour", this.MoneyPerHour.ToString());

            return workerInfo.ToString();
        }
    }
}