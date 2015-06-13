namespace BankAccounts
{
    using System;
    using System.Linq;
    
    internal class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal monthlyInterestRate, decimal balance = 0) : base(customer, monthlyInterestRate, balance)
        {
        }

        public void WithDraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ApplicationException("Not enough money.");
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override decimal CalculateInterestAmountForGivenTime(int months)
        {
            if (this.Balance >= 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmountForGivenTime(months);
        }
    }
}