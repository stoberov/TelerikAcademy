namespace BankAccounts
{
    using System;
    using System.Linq;
    
    internal class CompanyCustomer : Customer
    {
        public CompanyCustomer(string companyName, string bulstat, string address, string telephoneNumber) : base(companyName, address, telephoneNumber)
        {
            this.Bulstat = bulstat;
        }

        public string Bulstat { get; set; }

        public override string ToString()
        {
            string companyInfo = string.Format("{0}Bulstat: {1}{2}", base.ToString(), this.Bulstat, Environment.NewLine);
            return companyInfo;
        }
    }
}