using System;
using System.IO;
using System.Data.SQLite;
using System.Configuration;
using System.Xml;

namespace libraryMeneger.Data
{
    public static class DataAccess
    {
        public static string PPath = "";
        public static void TestDatabaseConnection()
        {
            string DBFileName = ConfigurationManager.AppSettings["DBFileName"];

            PPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            
            string dbPath = Path.Combine(PPath, DBFileName);          
            try
            {
                using (var connection = new SQLiteConnection($"Data Source={dbPath};Connect Timeout=600"))
                {
                    connection.Open();
                    
                    string query = "SELECT name FROM sqlite_master WHERE type='table';";

                    using (var command = new SQLiteCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Таблиці в базі даних:");
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0)); 
                        }
                    }

                    Console.WriteLine("Підключення до бази успішне!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка підключення до бази:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
