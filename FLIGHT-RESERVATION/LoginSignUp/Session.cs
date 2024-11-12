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

namespace FLIGHT_RESERVATION.LoginSignUp
{
    public class Session
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static string CurrentUser { get; set; } = string.Empty;

        private MySqlConnection _connection;
        private MySqlTransaction _transaction;
        private String _DataBaseName = "airplaneticketingsystem2024";
        private String _UserName = "root";
        private String _Password = "";

        public Session()
        {
            string connectionString = $"Server=localhost;Database={this._DataBaseName};User ID={this._UserName};Password={this._Password};";
            _connection = new MySqlConnection(connectionString);
        }

        public bool AuthenticateUser(string email, string password)
        {
            try
            {
                _connection.Open();
                string query = $"SELECT * FROM accounts WHERE Email=@Email AND Password=@Password";
                MySqlCommand command = new MySqlCommand(query, _connection);

                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    using (reader)
                    {
                        reader.Read();
                        string firstName = reader.GetString("FirstName");
                        string lastName = reader.GetString("LastName");
                        CurrentUser = $"{firstName} {lastName}";
                    }

                    return true;
                }
                else
                {
                    CurrentUser = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An Error has Occured{ex.Message}");
                return false;
            }
            finally
            {
                _connection.Close();
            }
        }


    }
}
