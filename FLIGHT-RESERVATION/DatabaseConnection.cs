using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FLIGHT_RESERVATION
{
    public class DatabaseConnection
    {
        private static DatabaseConnection _instance;
        private static readonly object _lock = new object();

        private MySqlConnection _connection;
        private MySqlTransaction _transaction;
        private readonly string DataBaseName = "airplaneticketingsystem2024";
        private readonly string UserName = "root";
        private readonly string Password = "";

        private DatabaseConnection()
        {
            string connectionString = $"Server=localhost;Database={this.DataBaseName};User ID={this.UserName};Password={this.Password};";
            _connection = new MySqlConnection(connectionString);
        }

        // Singleton instance accessor
        public static DatabaseConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock) // Ensure thread safety
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseConnection();
                        }
                    }
                }
                return _instance;
            }
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

        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
