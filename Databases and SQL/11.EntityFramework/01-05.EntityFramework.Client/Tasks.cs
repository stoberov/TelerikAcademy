namespace EntityFramework.Client
{
	using System;
	using System.Linq;
	using EntityFramework.Models;

	public static class Tasks
	{
		public static void Main()
		{
			// 1. Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database
			// 2. Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers.
			InsertNewCustomer("AVNG", "The Avengers", "Hawk-eye");

			ModifyCustomer("Hawk-eye", "Nick Fury");

			DeleteCustomer("AVNG");

			// 3. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
			FindCanadaCustomersFrom1997();

			// 4. Implement previous by using native SQL query and executing it through the DbContext.
			FindCanadaCustomersFrom1997Sql();

			// 5. Write a method that finds all the sales by specified region and period (start / end dates).
			FindSalesByRegionAndPeriod("SP", new DateTime(1995, 1, 1), new DateTime(1998, 1, 1));
		}

		private static void InsertNewCustomer(string customerId, string companyName, string contactName)
		{
			using (var dbContext = new NorthwindEntities())
			{
				var customer = new Customer
				{
					CustomerID = customerId,
					CompanyName = companyName,
					ContactName = contactName
				};

				dbContext.Customers.Add(customer);
				dbContext.SaveChanges();
			}

			Console.WriteLine("Added — {0}", companyName);
		}

		private static void ModifyCustomer(string oldContactName, string newContactName)
		{
			using (var dbContext = new NorthwindEntities())
			{
				var customer = dbContext.Customers.FirstOrDefault(c => c.ContactName == oldContactName);

				if (customer != null)
				{
					customer.ContactName = newContactName;
				}

				dbContext.SaveChanges();
			}

			Console.WriteLine("Modified — {0} is now {1}", oldContactName, newContactName);
		}

		private static void DeleteCustomer(string customerId)
		{
			using (var dbContext = new NorthwindEntities())
			{
				var customer = dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerId);

				dbContext.Customers.Remove(customer);
				dbContext.SaveChanges();
			}

			Console.WriteLine("Deleted — {0}", customerId);
		}

		private static void FindCanadaCustomersFrom1997()
		{
			using (var dbContext = new NorthwindEntities())
			{
				var customers =
					from customer in dbContext.Customers
					join order in dbContext.Orders
						on customer.CustomerID equals order.CustomerID
					where
						(order.ShipCountry == "Canada") &&
						(order.OrderDate.Value.Year == 1997)
					select customer;

				foreach (var customer in customers)
				{
					Console.WriteLine(customer.CompanyName);
				}
			}
		}

		private static void FindCanadaCustomersFrom1997Sql()
		{
			using (var dbContext = new NorthwindEntities())
			{
				string nativeQuery = @"
									SELECT *
									FROM Orders o, Customers c
									WHERE 
										o.CustomerID = c.CustomerID AND
										o.ShipCountry = 'Canada' AND
										YEAR(o.OrderDate) = 1997";

				var queryResult = dbContext.Database.SqlQuery<Customer>(nativeQuery);

				foreach (var customer in queryResult)
				{
					Console.WriteLine(customer.CompanyName);
				}
			}
		}

		private static void FindSalesByRegionAndPeriod(string shipRegion, DateTime startDate, DateTime endDate)
		{
			using (var dbContext = new NorthwindEntities())
			{
				var sales =
					from order in dbContext.Orders
					where
						order.ShipRegion == shipRegion &&
						order.OrderDate >= startDate &&
						order.OrderDate <= endDate
					select new
					{
						Company = order.Customer.CompanyName,
						Date = order.OrderDate,
						Order = order.OrderID
					};

				foreach (var sale in sales)
				{
					Console.WriteLine("{0} - {1:dd-MMM-yyyy} - Order {2}", sale.Company, sale.Date, sale.Order);
				}
			}
		}
	}
}