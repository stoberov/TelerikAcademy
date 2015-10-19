namespace _03.RetrieveAllProductCategoriesAndProducts
{
	using System;
	using System.Data.SqlClient;

	internal static class RetrieveAllProductCategoriesAndProducts
	{
		private static void Main()
		{
			var dbCon = new SqlConnection(
				"Server=.\\SQLEXPRESS;" +
				"Database=Northwind;" +
				"Integrated Security=true");

			dbCon.Open();

			using (dbCon)
			{
				string sqlStringCommand = @"
                        SELECT c.CategoryName, p.ProductName
                        FROM Categories c
                            JOIN Products p
                                ON c.CategoryID = p.CategoryID
                        ORDER BY c.CategoryName";

				var allCategoriesAndProducts = new SqlCommand(sqlStringCommand, dbCon);

				var reader = allCategoriesAndProducts.ExecuteReader();

				using (reader)
				{
					while (reader.Read())
					{
						string categoryName = (string)reader["CategoryName"];
						string productName = (string)reader["ProductName"];
						Console.WriteLine("{0, -15} - {1}", categoryName, productName);
					}
				}
			}
		}
	}
}