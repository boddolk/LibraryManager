using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.IO;

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
    }
    
    }
