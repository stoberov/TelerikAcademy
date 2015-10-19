namespace _02.RetrieveNameAndDescriptionAllCategories
{
    using System;
    using System.Data.SqlClient;

    internal static class RetrieveNameAndDescriptionAllCategories
    {
        public static void Main()
        {
            var dbCon = new SqlConnection(
                "Server=.\\SQLEXPRESS;" +
                "Database=Northwind;" +
                "Integrated Security=true");

            dbCon.Open();

            using (dbCon)
            {
                string sqlStringCommand = "SELECT CategoryName, Description FROM Categories";
                var cmdAllCategories = new SqlCommand(sqlStringCommand, dbCon);

                SqlDataReader reader = cmdAllCategories.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        string description = (string)reader["Description"];
                        Console.WriteLine("{0, -15} - {1}", categoryName, description);
                    }
                }
            }
        }
    }
}