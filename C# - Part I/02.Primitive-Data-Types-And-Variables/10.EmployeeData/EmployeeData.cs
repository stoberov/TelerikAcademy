// Problem 10. Employee Data
// A marketing company wants to keep record of its employees. Each record would have the following characteristics:
// First name
// Last name
// Age (0...100)
// Gender (m or f)
// Personal ID number (e.g. 8306112507)
// Unique employee number (27560000…27569999)
// Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Harry";
        string lastName = "Potter";
        byte age = 18;
        char gender = 'm';
        ulong identificationNumber = 8306112507; // cannot have a negative ID 
        uint employeeNumber = 27569999; // cannot have a negative employee number 

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender", gender);
        Console.WriteLine("Personal ID number: {0}", identificationNumber);
        Console.WriteLine("Unique employee number: {0}", employeeNumber);
    }
}
