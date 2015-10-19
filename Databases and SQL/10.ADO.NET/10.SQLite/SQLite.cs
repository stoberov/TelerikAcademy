namespace _10.SQLite
{
    using System;
    using System.Data.SQLite;
    using System.Globalization;

    internal static class SQLite
    {
        /// <summary>
        /// Some ideas from user "dchakov"
        /// </summary>
        public static void Main()
        {
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=../../library.db;Version=3;");

            dbCon.Open();
            using (dbCon)
            {
                long newBook = AddNewBookToDbTable(dbCon, "Harry Potter", "J. K. Rowling", DateTime.Parse("2015.01.01"), 1234567890123);
                long newBook1 = AddNewBookToDbTable(dbCon, "Lord of the Rings", "J. R. R. Tolkien", DateTime.Parse("2015.01.01"), 1234567890123);
                long newBook2 = AddNewBookToDbTable(dbCon, "A Song of Ice and Fire", "George R. R. Marting", DateTime.Parse("2015.01.01"), 1234567890123);

                Console.WriteLine("Added new book - Id:{0}", newBook);
                Console.WriteLine("Added new book - Id:{0}", newBook1);
                Console.WriteLine("Added new book - Id:{0}", newBook2);
                Console.WriteLine(new string('-', 30));

                ListAllBooksFromDbTable(dbCon);
                Console.WriteLine(new string('-', 30));

                Console.Write("Enter text to search:");
                string input = Console.ReadLine();
                Console.WriteLine(new string('-', 30));

                Console.WriteLine("Books that contain: {0}", input);
                SearchAllBooksThatContainString(dbCon, input);
            }
        }

        private static void SearchAllBooksThatContainString(SQLiteConnection dbConnection, string input)
        {
            input = EscapeInputString(input);

            string sqlStringCommand = string.Format(@"
                    SELECT title
                    FROM Books
                    WHERE title LIKE '%{0}%'", input);

            SQLiteCommand allProducts = new SQLiteCommand(sqlStringCommand, dbConnection);
            SQLiteDataReader reader = allProducts.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string bookName = (string)reader["title"];
                    Console.WriteLine("{0}", bookName);
                }
            }
        }

        private static string EscapeInputString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '\'')
                {
                    input = input.Substring(0, i) + "'" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '_')
                {
                    input = input.Substring(0, i) + "/" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '%')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }

                if (input[i] == '&')
                {
                    input = input.Substring(0, i) + "\\" + input.Substring(i, input.Length - i);
                    i++;
                }
            }

            return input;
        }

        private static void ListAllBooksFromDbTable(SQLiteConnection dbConnection)
        {
            string sqlStringCommand = @"
                    SELECT * FROM Books";

            SQLiteCommand allBooks = new SQLiteCommand(sqlStringCommand, dbConnection);
            SQLiteDataReader reader = allBooks.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string title = (string)reader["title"];
                    string author = (string)reader["author"];
                    DateTime publishDate = (DateTime)reader["publishDate"];
                    Console.WriteLine("{0} -> {1}, {2}, {3}", title, author, publishDate.ToString(CultureInfo.InvariantCulture), reader["isbn"]);
                }
            }
        }

        private static long AddNewBookToDbTable(SQLiteConnection dbConnection, string title, string author, DateTime publishDate, ulong isbn)
        {
            string sqlStringCommand = @"
                    INSERT INTO Books(title, author, publishDate, isbn)
                    VALUES (@title, @author, @publishDate, @isbn)";

            SQLiteCommand insertBook = new SQLiteCommand(sqlStringCommand, dbConnection);
            insertBook.Parameters.AddWithValue("@title", title);
            insertBook.Parameters.AddWithValue("@author", author);
            insertBook.Parameters.AddWithValue("@publishDate", publishDate);
            insertBook.Parameters.AddWithValue("@isbn", isbn);

            insertBook.ExecuteNonQuery();
            SQLiteCommand cmdCount = new SQLiteCommand("select last_insert_rowid();", dbConnection);
            long rowsCount = (long)cmdCount.ExecuteScalar();

            return rowsCount;
        }
    }
}