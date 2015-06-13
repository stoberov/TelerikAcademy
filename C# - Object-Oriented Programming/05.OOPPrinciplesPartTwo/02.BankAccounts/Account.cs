namespace BankAccounts
{
    using System;
    using System.Linq;
    
    public abstract class Account
    {
        private decimal monthlyInterestRate;

        public Account(Customer customer, decimal monthlyInterestRate, decimal balance = 0)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance { get; protected set; }

        public decimal MonthlyInterestRate
        {
            get
            {
                return this.monthlyInterestRate;
            }

            set
            {
                if (value > 100)
                {
                    throw new ApplicationException("Monathly interest rate must be 0-100 percent.");
                }
                else
                {
                    this.monthlyInterestRate = value;
                }
            }
        }

        public void AddDeposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ApplicationException("Deposit amount can't be negative.");
            }
            else
            {
                this.Balance += amount;
            }
        }

        public virtual decimal CalculateInterestAmountForGivenTime(int months)
        {
            return months * this.monthlyInterestRate;
        }
    }
}