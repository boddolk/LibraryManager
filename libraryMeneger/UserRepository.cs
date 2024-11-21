using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace libraryMeneger.Data.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private string dbPath;
        private SQLiteConnection connection;
        public UserRepository(string DBFileName)
        {
            dbPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), DBFileName);
            connection = new SQLiteConnection($"Data Source={dbPath};Connect Timeout=600");
        }
        
        public override bool DoesSuchUserExist(string loginToCheck)
        {
            try
            {
                connection.Open();       
                string query = "SELECT EXISTS(SELECT 1 FROM Users WHERE Login=@VALUE)";
                using ( var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VALUE", loginToCheck);
                    //Я зазвичай так роблю! Но якщо працюж - то пофігу!
                    //command.Parameters.Add( new SQLiteParameter("VALUE", loginToCheck)); 
                    var result = (long)command.ExecuteScalar();               
                    //var result = (long)command.ExecuteNonQuery();               
                    return result == 1;
                }
            }
            finally
            {
                connection.Close();
            }

        }
        public override bool IsGivenUserAdmin(string loginToCheck)
        {
            try
            {
                connection.Open();

                string query = "SELECT IsAdmin FROM Users WHERE Login = @Value";

                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Value", loginToCheck);

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
        
        public override bool IsPasswordCorrect(string loginToCheck, string Password)
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(1) FROM Users WHERE Login = @Login AND Password = @Password";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", loginToCheck);
                    command.Parameters.AddWithValue("@Password", Password);

                    var result = (long)command.ExecuteScalar();
                    return result == 1;
                }
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
