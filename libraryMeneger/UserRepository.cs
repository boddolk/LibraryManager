using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using libraryMeneger.user;

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
                    
                    var result = (long)command.ExecuteScalar();               
                             
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
        public override string getEmail(string loginToCheck)
        {
            try
            {
                connection.Open();

                string query = "SELECT Email FROM Users WHERE Login = @Value";

                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Value", loginToCheck);

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
        public override string getName(string loginToCheck)
        {
            try
            {
                connection.Open();

                string query = "SELECT Name FROM Users WHERE Login = @Value";

                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Value", loginToCheck);

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
        public override string getSurname(string loginToCheck)
        {
            try
            {
                connection.Open();

                string query = "SELECT Surname FROM Users WHERE Login = @Value";

                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Value", loginToCheck);

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
        public override string getPhoneNumber(string loginToCheck)
        {
            try
            {
                connection.Open();

                string query = "SELECT Number FROM Users WHERE Login = @Value";

                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Value", loginToCheck);

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
        public override string getPassword(string loginToCheck)
        {
            try
            {
                connection.Open();

                string query = "SELECT Password FROM Users WHERE Login = @Value";

                using (var command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Value", loginToCheck);

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
        public override bool updateUser(RegularUser updatedOne)
        {
           
            try
            {
                connection.Open();

             
                string query = "UPDATE Users SET Name = @NAME, Surname = @SURNAME , Email = @EMAIL , Number =@NUMBER WHERE Login = @LOGIN";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NAME", updatedOne.Name);
                    command.Parameters.AddWithValue("@SURNAME", updatedOne.Surname);
                    command.Parameters.AddWithValue("@EMAIL",updatedOne.Email);
                    command.Parameters.AddWithValue("@LOGIN", updatedOne.Login);
                    command.Parameters.AddWithValue("@NUMBER", updatedOne.PhoneNumber);

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
        public override bool insertNewUser(RegularUser newOne)
        {
            try
            {
                connection.Open();


                string query = "INSERT INTO Users (Login, Name, Surname, Password, Email, Number, IsAdmin) VALUES ( @LoginV, @NameV, @SurnameV, @PasswordV, @EmailV, @NumberV, @IsAdminV)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NameV", newOne.Name);
                    command.Parameters.AddWithValue("@SurnameV", newOne.Surname);
                    command.Parameters.AddWithValue("@NumberV", newOne.PhoneNumber);
                    command.Parameters.AddWithValue("@PasswordV", newOne.Password);
                    command.Parameters.AddWithValue("@LoginV", newOne.Login);
                    command.Parameters.AddWithValue("@EmailV", newOne.Email);
                    command.Parameters.AddWithValue("@IsAdminV", newOne.IsAdmin);

                    int rowsAffected = command.ExecuteNonQuery();                    
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting user: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
