// Problem 11. Bank Account Data
// A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Harry";
        string middleName = "James";
        string lastName = "Potter";

        decimal balance = 4300200.23M;
        string bankName = "Gringotts Wizarding Bank";
        string iban = "GB29 RBOS 6016 1331 9268 19";

        ulong visa = 4485202525551097;
        ulong mastercard = 5426552370057197;
        ulong americanExpress = 349660545182942;

        Console.WriteLine("Welcome back, {0} {1} {2}!", firstName, middleName, lastName);
        Console.WriteLine("Your balance today for bank account with IBAN number {0} is {1}.", iban, balance);
        Console.WriteLine("You have three credit cards: VISA ({0}), MasterCard ({1}), and AmericanExpress ({2}).", visa, mastercard,
americanExpress);
        Console.WriteLine("{0} wishes you a great day ahead!", bankName);
    }
}