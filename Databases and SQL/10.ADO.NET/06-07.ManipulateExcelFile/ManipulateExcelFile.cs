namespace _06_07.ManipulateExcelFile
{
    using System;
    using System.Data.OleDb;

    internal static class ManipulateExcelFile
    {
        private static void Main()
        {
            string connectionString = 
                "Provider= Microsoft.ACE.OLEDB.12.0;" +
                "Data Source = ../../People.xlsx;" +
                @"Extended Properties = ""Excel 12.0 Xml;HDR=YES"";";

            OleDbConnection dbCon = new OleDbConnection(connectionString);

            dbCon.Open();

            using (dbCon)
            {
                // Preview Excel
                Console.WriteLine("--- Before ---");
                GetDataFromExcelFile(dbCon);
                Console.WriteLine("--------------");

                // Add Rows
                AppendNewRow(dbCon, "Jon Snow", 50);
                AppendNewRow(dbCon, "Tyrion Lannister", 88);
                Console.WriteLine("--------------");

                // Verify Excel rows have been added
                Console.WriteLine("--- After ---");
                GetDataFromExcelFile(dbCon);
            }
        }

        private static void GetDataFromExcelFile(OleDbConnection dbCon)
        {
            string xslStringCommand = @"
                    SELECT *
                    FROM [Everyone$]";

            OleDbCommand xslCommand = new OleDbCommand(xslStringCommand, dbCon);
            OleDbDataReader reader = xslCommand.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string name = (string)reader["Name"];
                    double score = (double)reader["Score"];
                    Console.WriteLine("{0, -20} - {1}", name, score);
                }
            }
        }

        private static void AppendNewRow(OleDbConnection dbCon, string name, double score)
        {
            OleDbCommand cmd = new OleDbCommand(
               string.Format("INSERT INTO [Everyone$] (Name, Score) VALUES ('{0}', '{1}')", name, score), dbCon);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Row appended successfully.");
        }
    }
}