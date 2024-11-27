using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;


using System.Configuration;
using libraryMeneger.book;
namespace libraryMeneger.Data.BookRepository
{
    public class BooksRepository: IBooksRepository
    {
        private string dbPath;
        private SQLiteConnection connection;
        public BooksRepository()           
        {
            string DBFileName = ConfigurationManager.AppSettings["DBFileName"];
            dbPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), DBFileName);
            connection = new SQLiteConnection($"Data Source={dbPath};Connect Timeout=600");
        }
        public override bool insertBook(GenBook newBook)
        {
            try
            {
                connection.Open();


                string query = "INSERT INTO Books (Article, Title, Author, Year) VALUES ( @ArticleV, @TitleV, @AuthorV, @YearV)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ArticleV", newBook.Article);
                    command.Parameters.AddWithValue("@TitleV", newBook.Title);
                    command.Parameters.AddWithValue("@AuthorV", newBook.Author);
                    command.Parameters.AddWithValue("@YearV", newBook.Year);             

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting book: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public override bool deleteBook(int article)
        {
            try
            {
                connection.Open();

                string query = "DELETE FROM Books WHERE Article = @Value";

                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Value", article);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) deleted.");
                    return rowsAffected > 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        public override bool updateBook(GenBook updatedOne)
        {
            try
            {
                connection.Open();


                string query = "UPDATE Books SET  Title = @TitleV, Author = @AuthorV, Year = @YearV  WHERE Article = @ArticleV";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ArticleV", updatedOne.Article);
                    command.Parameters.AddWithValue("@TitleV", updatedOne.Title);
                    command.Parameters.AddWithValue("@AuthorV", updatedOne.Author);
                    command.Parameters.AddWithValue("@YearV", updatedOne.Year);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} rows updated.");
                    return rowsAffected > 0;
                }
            }

            finally
            {
                connection.Close();
            }
        }
        public override GenBook getBook(int article)
        {
            GenBook  book = new GenBook();
            try
            {
                connection.Open();

                string query = "SELECT * FROM Books  WHERE Article = @ArticleV";
                
                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@ArticleV", article);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            book.Article = Convert.ToInt32(reader["Article"]);
                            book.Title = reader["Title"].ToString();
                            book.Author = reader["Author"].ToString();
                            book.Year = Convert.ToInt32(reader["Year"].ToString());                            
                            
                            return book;
                        }
                        else
                        {

                            return null;
                        }

                    }
                }
            }

            finally
            {
                connection.Close();
            }
        }
        public override List<GenBook> getAllBooks()
        {

            List<GenBook> books = new List<GenBook>();
            try
            {
                connection.Open();

                string query = "SELECT * FROM Books";

                using (var command = new SQLiteCommand(query, connection))
                {                  
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GenBook book = new GenBook
                            {
                                Article = Convert.ToInt32(reader["Article"]),
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                Year = Convert.ToInt32(reader["Year"].ToString())
                            };
                            books.Add(book);
                            
                        }                      
                        if(books.Count >0)
                        {
                            return books;
                        }
                        else
                        {
                            Console.WriteLine("Error during retriving list of books from data base");
                            return null;
                        }
                    }
                }
            }

            finally
            {
                connection.Close();
            }
        }
        public override List<GenBook> getAvailableBooksForBooking()
        {
            List<GenBook> books = new List<GenBook>();
            try
            {
                connection.Open();

                string query = "SELECT * FROM Books WHERE Article NOT IN (SELECT BookID FROM Book_status_table)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GenBook book = new GenBook
                            {
                                Article = Convert.ToInt32(reader["Article"]),
                                Title = reader["Title"].ToString(),
                                Author = reader["Author"].ToString(),
                                Year = Convert.ToInt32(reader["Year"].ToString())
                            };
                            books.Add(book);

                        }
                        if (books.Count > 0)
                        {
                            return books;
                        }
                        else
                        {
                            Console.WriteLine("Error during retriving list of books from data base");
                            return null;
                        }
                    }
                }
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
