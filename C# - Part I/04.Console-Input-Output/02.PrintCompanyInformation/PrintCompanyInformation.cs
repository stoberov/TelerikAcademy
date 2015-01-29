// Problem 2. Print Company Information
// 
// A company has name, address, phone number, fax number, web site and manager.  The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter Company Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter Company Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Enter Fax Number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Enter Web-Site: ");
        string webSite = Console.ReadLine();

        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter Manager Phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("Company name: " + companyName);
        Console.WriteLine("Company address: " + companyAddress);
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Fax Number: " + faxNumber);
        Console.WriteLine("Web-Site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
    }
}