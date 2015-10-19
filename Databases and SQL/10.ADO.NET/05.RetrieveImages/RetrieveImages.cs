namespace _05.RetrieveImages
{
    using System;
    using System.Data.SqlClient;
    using System.IO;

    internal static class RetrieveImages
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
                string sqlStringCommand = "SELECT CategoryName, Picture FROM Categories";

                SqlCommand allPictures = new SqlCommand(sqlStringCommand, dbCon);
                SqlDataReader reader = allPictures.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = (string)reader["CategoryName"];
                        categoryName = categoryName.Replace('/', '_');
                        byte[] fileContent = (byte[])reader["Picture"];

                        string fileName = string.Format("{0}.jpg", categoryName);

                        FileStream stream = File.OpenWrite(fileName);
                        using (stream)
                        {
                            stream.Write(fileContent, 78, fileContent.Length - 78);
                        }
                    }
                }
            }

            Console.WriteLine("Images downloaded successfully in bin/DEBUG");
        }
    }
}