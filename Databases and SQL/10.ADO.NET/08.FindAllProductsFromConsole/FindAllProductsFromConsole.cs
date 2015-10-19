namespace _08.FindAllProductsFromConsole
{
    using System;
    using System.Data.SqlClient;

    internal static class FindAllProductsFromConsole
    {
        private static void Main()
        {
            Console.Write("Search for: ");
            string searchWord = Console.ReadLine();

            LookupProduct(searchWord);
        }

        private static void LookupProduct(string searchWord)
        {
            SqlConnection dbCon = new SqlConnection(
                "Server=.\\SQLEXPRESS;" +
                "Database=Northwind;" +
                "Integrated Security=true");

            using (dbCon)
            {
                dbCon.Open();

                SqlCommand cmd = SearchByPattern(dbCon, searchWord);

                SqlDataReader reader = cmd.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        object productName = reader["ProductName"];
                        Console.WriteLine(" - " + productName);
                    }
                }
            }
        }

        private static SqlCommand SearchByPattern(SqlConnection sqlConnection, string pattern)
        {
            SqlCommand sqlStringCommand = new SqlCommand(@"SELECT ProductName
                                                           FROM Products
                                                           WHERE CHARINDEX(@pattern, ProductName) > 0", sqlConnection);
            sqlStringCommand.Parameters.AddWithValue("@pattern", pattern);

            return sqlStringCommand;
        }
    }
}