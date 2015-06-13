namespace BankAccounts
{
    using System;
    using System.Linq;

    internal class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal monthlyInterestRate, decimal balance = 0) : base(customer, monthlyInterestRate, balance)
        {
        }

        public override decimal CalculateInterestAmountForGivenTime(int months)
        {
            if ((this.Customer is IndividualCustomer && months <= 3) ||
                (this.Customer is CompanyCustomer && months <= 2))
            {
                return 0;
            }

            months = this.Customer is IndividualCustomer ? months - 3 : months - 2;

            return base.CalculateInterestAmountForGivenTime(months);
        }
    }
}