namespace BankAccounts
{
    using System;
    using System.Linq;

    internal class BankTest
    {
        private static void Main()
        {
            CompanyCustomer companyBBC = new CompanyCustomer("BBC", "UK123456", "Manchester", "0123456");
            LoanAccount loanAccount = new LoanAccount(companyBBC, 0.5m, 10000);
            
            loanAccount.AddDeposit(10000);
            int months = 12;

            Console.WriteLine(
                "{0} have interest for {1} months: {2}%  ",
                loanAccount.Customer, 
                months,
                loanAccount.CalculateInterestAmountForGivenTime(months));

            loanAccount.Customer = new IndividualCustomer("Stilyan Petrov", 12345, "Random", "0888 123 456");

            Console.WriteLine(
                "{0} Interest for {1} months: {2}%  ", 
                loanAccount.Customer, 
                months,
                loanAccount.CalculateInterestAmountForGivenTime(months));
        }
    }
}