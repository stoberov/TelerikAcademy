namespace BankAccounts
{
    using System;
    using System.Linq;
    
    internal class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name, int egn, string address, string telephoneNumber) : base(name, address, telephoneNumber)
        {
            this.EGN = egn;
        }

        public long EGN { get; set; }

        public override string ToString()
        {
            string individualInfo = string.Format("{0}EGN: {1}{2}", base.ToString(), this.EGN, Environment.NewLine);
            return individualInfo;
        }
    }
}