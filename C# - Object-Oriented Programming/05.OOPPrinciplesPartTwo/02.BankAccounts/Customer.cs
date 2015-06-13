namespace BankAccounts
{
    using System;
    using System.Linq;
    
    public abstract class Customer
    {
        protected Customer(string name, string address, string telephoneNumber)
        {
            this.Name = name;
            this.Address = address;
            this.TelephoneNumber = telephoneNumber;
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public string TelephoneNumber { get; set; }

        public override string ToString()
        {
            string customerInfo = string.Format(
                "Name: {0}\nAddress: {1}\nTel. number: {2}\n",
                this.Name, 
                this.Address, 
                this.TelephoneNumber);

            return customerInfo;
        }
    }
}