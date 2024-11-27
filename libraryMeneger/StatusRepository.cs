using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.IO;
using libraryMeneger.user;
using libraryMeneger.book;

namespace libraryMeneger.Data.StatusRepository
{
    public class StatusRepository: IStatusRepository
    {
        private string dbPath;
        private SQLiteConnection connection;
        public StatusRepository() 
        {
            string DBFileName = ConfigurationManager.AppSettings["DBFileName"];

            dbPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), DBFileName);
            connection = new SQLiteConnection($"Data Source={dbPath};Connect Timeout=600");
        }
        public override bool IsIssued(int article)
        {
            try
            {
                connection.Open();
                string query = "SELECT IssueStatus  FROM Book_status_table WHERE BookID=@VALUE ";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VALUE", article);

                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToBoolean(result);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }
        public override bool IsPresentInTable(int article)
        {
            try
            {
                connection.Open();
                string query = "SELECT EXISTS(SELECT 1 FROM Book_status_table WHERE BookID=@VALUE)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VALUE", article);

                    var result = (long)command.ExecuteScalar();

                    return result == 1;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        public override bool IsReserved(int article)
        {
            try
            {
                connection.Open();
                string query = "SELECT ReserveStatus FROM Book_status_table WHERE BookID=@VALUE ";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VALUE", article);                 

                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToBoolean(result);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }
        public override bool addBookWithItsStatus(string userID, BookStatManager manager)
        {
            try
            {
                connection.Open();


                string query = "INSERT INTO Book_status_table (BookID, UserID, StartDate, EndDate, ReserveStatus, IssueStatus) VALUES ( @BookIDV, @UserIDV, @StartDateV, @EndDateV, @ReserveStatusV, @IssueStatusV)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserIDV", userID);
                    command.Parameters.AddWithValue("@BookIDV", manager.CurrentBook.Article);                   
                    command.Parameters.AddWithValue("@StartDateV", manager.StartDate);
                    command.Parameters.AddWithValue("@EndDateV", manager.EndDate);
                    command.Parameters.AddWithValue("@ReserveStatusV", manager.ReserveStatus);
                    command.Parameters.AddWithValue("@IssueStatusV", manager.IssueStatus);
             

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting book with particular status: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public override bool removeBookWithItsStatus(int article)
        {
            try
            {
                connection.Open();

                string query = "DELETE FROM Book_status_table WHERE BookID = @Value";

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
        public override string getUserIDByArticle(int article)
        {
            try
            {
                connection.Open();

                string query = "SELECT UserID FROM Book_status_table WHERE BookID = @Value";

                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Value", article);

                    var result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToString(result);
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }
        public override List<BookStatManager> getIssuedBookInfo()
        {
           
        }
        public override List<BookStatManager> getReservedBookInfo()
        {

        }
    }
    
    }
