namespace _09.MySQL
{
    using System;
    using System.Configuration;
    using System.Globalization;
    using MySql.Data.MySqlClient;

    internal static class MySQL
    {
        /// <summary>
        /// Some ideas from user "dchakov"
        /// </summary>
        public static void Main()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["library"].ConnectionString;
            MySqlConnection dbCon = new MySqlConnection(connectionString);

            // MySqlConnection dbConnection = new MySqlConnection("Server=localhost; Port=3306;Database=library; Uid = root; Pwd = root; pooling = true");
            dbCon.Open();

            using (dbCon)
            {
                int newBook = AddNewBookToDbTable(dbCon, "Harry Potter", "J. K. Rowling", DateTime.Parse("2015.01.01"), 1234567890123);
                int newBook1 = AddNewBookToDbTable(dbCon, "Lord of the Rings", "J. R. R. Tolkien", DateTime.Parse("2015.01.01"), 1234567890123);
                int newBook2 = AddNewBookToDbTable(dbCon, "A Song of Ice and Fire", "George R. R. Marting", DateTime.Parse("2015.01.01"), 1234567890123);

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

        private static void SearchAllBooksThatContainString(MySqlConnection dbConnection, string input)
        {
            input = EscapeInputString(input);

            string sqlStringCommand = string.Format(@"
                    SELECT title
                    FROM Books
                    WHERE title LIKE '%{0}%'", input);

            MySqlCommand allProducts = new MySqlCommand(sqlStringCommand, dbConnection);
            MySqlDataReader reader = allProducts.ExecuteReader();

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

        private static void ListAllBooksFromDbTable(MySqlConnection dbConnection)
        {
            string sqlStringCommand = @"
                    SELECT * FROM Books";

            MySqlCommand allBooks = new MySqlCommand(sqlStringCommand, dbConnection);
            MySqlDataReader reader = allBooks.ExecuteReader();

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

        private static int AddNewBookToDbTable(MySqlConnection dbConnection, string title, string author, DateTime publishDate, ulong isbn)
        {
            string sqlStringCommand = @"
                    INSERT INTO Books(title, author, publishDate, isbn)
                    VALUES (@title, @author, @publishDate, @isbn)";

            MySqlCommand insertBook = new MySqlCommand(sqlStringCommand, dbConnection);
            insertBook.Parameters.AddWithValue("@title", title);
            insertBook.Parameters.AddWithValue("@author", author);
            insertBook.Parameters.AddWithValue("@publishDate", publishDate);
            insertBook.Parameters.AddWithValue("@isbn", isbn);

            insertBook.ExecuteNonQuery();

            return (int)insertBook.LastInsertedId;
        }
    }
}