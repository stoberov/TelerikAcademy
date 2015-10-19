namespace _01.RetrieveNumberOfRows
{
    using System;
    using System.Data.SqlClient;

    public static class RetrieveNumberOfRows
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
                string sqlStringCommand = "SELECT COUNT(*) FROM Categories";
                var cmdCount = new SqlCommand(sqlStringCommand, dbCon);

                int rowsCount = (int)cmdCount.ExecuteScalar();

                Console.WriteLine("Rows in CATEGORIES: {0}", rowsCount);
            }
        }
    }
}