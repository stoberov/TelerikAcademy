namespace NorthwindTwin
{
    using System;
    using EntityFramework.Models;

    public static class NorthwindTwin
    {
        private static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                // Change the 'initial catalog' property in <connectionStrings> in App.config to generate a clone of Northwind
                // Do not forget to refresh SQL Server to see the new database
                bool flag = db.Database.CreateIfNotExists();
                Console.WriteLine(flag);
            }
        }
    }
}