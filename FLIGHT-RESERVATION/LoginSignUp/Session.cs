using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace FLIGHT_RESERVATION
{
    public class Session
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static int CurrentUser { get; set; } = 0;
        public static string Password { get; set; } = string.Empty;

        private MySqlConnection _connection;
        private MySqlTransaction _transaction;
        private readonly String _databaseName = "airplaneticketingsystem2024";
        private readonly String _userName = "root";
        private readonly String _password = "";

        public Session()
        {
            string connectionString =
                $"Server=localhost;Database={this._databaseName};User ID={this._userName};Password={this._password};";
            _connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public bool AuthenticateUser(string email, string password)
        {
            OpenConnection();

            try
            {
                string query = $"SELECT * FROM accounts WHERE Email = @Email AND Password = SHA2(@Password, 256)";
                MySqlCommand command = new MySqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    using (reader)
                    {
                        reader.Read();
                        int currentUser = (int) reader["AccountID"];
                        Password = password;
                        CurrentUser = currentUser;

                    }
                    return true;
                }
                else
                {
                    CurrentUser = -1;
                    return false;
                }
            }
            // Uncomment if debugging
            //catch (MySqlException ex)
            //{
            //    _transaction?.Rollback();
            //    MessageBox.Show($"Database Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            catch (Exception ex)
            {
                Console.WriteLine($"An Error has Occured: {ex.Message}");
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ChangePassword(string email, string password)
        {
            OpenConnection();

            try
            {
                _transaction = _connection.BeginTransaction();
                string updateQuery = @"
                    UPDATE accounts 
                    SET Password = SHA2(@Password, 256) 
                    WHERE Email = @Email";

                using (var command = new MySqlCommand(updateQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        _transaction.Commit();
                        return true;
                    }
                    else
                    {
                        _transaction.Rollback();
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                _transaction?.Rollback();
                MessageBox.Show($"Database Error: {ex.Message}",
                    "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                _transaction?.Rollback();
                MessageBox.Show($"An error occurred: {ex.Message}",
                    "Password Change Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool RegisterUser (User user)
        {
            OpenConnection();

            try
            {
                if (IsEmailInDatabase(user.Email))
                {
                    return false;
                }

                // ------ Insert into the accounts table
                _transaction = _connection.BeginTransaction();
                string insertQuery = @"
                    INSERT INTO accounts(FirstName, LastName, Email, Password) 
                    VALUES (@FirstName, @LastName, @Email, SHA2(@Password, 256))";

                using (var command = new MySqlCommand(insertQuery, _connection, _transaction))
                {
                    command.Parameters.AddWithValue("@FirstName", user.FirstName);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Password", user.Password);

                    command.ExecuteNonQuery();
                    _transaction.Commit();
                    return true;
                }
            }
            // Uncomment if debugging
            //catch (MySqlException ex)
            //{
            //    _transaction?.Rollback();
            //MessageBox.Show($"Database Error: {ex.Message}",
                    //"Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
            catch (Exception ex)
            {
                _transaction?.Rollback();
                Console.WriteLine($"An Error has Occured: {ex.Message}");
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool IsEmailInDatabase(string email)
        {
            OpenConnection();

            try
            {
                string checkEmailQuery = @"
                    SELECT Email 
                    FROM accounts 
                    WHERE Email = @Email";

                using (var checkCommand = new MySqlCommand(checkEmailQuery, _connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    using (var reader = checkCommand.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            return true;
                        }

                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error:\nNumber: {ex.Number}\nMessage: {ex.Message}\nSQL State: {ex.SqlState}",
                    "MySQL Error");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}\nStack Trace: {ex.StackTrace}",
                    "General Error");
                return false;
            }     
        }

        public User GetAccountInfo()
        {
            OpenConnection();
            try
            {
                string query = $"SELECT * FROM accounts WHERE AccountID = @CurrentUserID";
                MySqlCommand command = new MySqlCommand(query, _connection);
                command.Parameters.AddWithValue("@CurrentUserID", CurrentUser);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string firstName = reader.GetString("FirstName");
                        string lastName = reader.GetString("LastName");
                        string email = reader.GetString("Email");

                        return new User(firstName, lastName, email, Password);
                    }
                }

                return null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Error:\nNumber: {ex.Number}\nMessage: {ex.Message}\nSQL State: {ex.SqlState}",
                    "MySQL Error");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General Error: {ex.Message}\nStack Trace: {ex.StackTrace}",
                    "General Error");
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
    }

    public class User
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

    }

    public class Validation
    {
        public static bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                    RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        
    }
}
