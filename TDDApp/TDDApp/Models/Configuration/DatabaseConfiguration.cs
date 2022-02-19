using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Models
{
    public class DatabaseConfiguration
    {
        public string Host { get; set; } = "localhost";
        public string Port { get; set; } = "1433";
        public bool Encrypt { get; set; } = true;
        public string Username { get; set; } = "root";
        public string Password { get; set; } = "";
        public string Database { get; set; } = "";
        public string ConnectionString { get; set; } = "";

        public DatabaseTypes DatabaseType;
        public DatabaseConfiguration(string _host, string _port, bool _encrypt, string _username, string _password, string _database, DatabaseTypes _databaseType)
        {
            Setup(_host, _port, _encrypt, _username, _password, _database, _databaseType);
        }
        public DatabaseConfiguration(string _conncetionString, string _database, DatabaseTypes _databaseType)
        {
            Setup(_conncetionString, _database, _databaseType);
        }
        public void Setup(string _conncetionString, string _database, DatabaseTypes _databaseType)
        {
            DatabaseType = _databaseType;
            Database = _database;
            SetConnectionString(_conncetionString);
        }
        public void Setup(string _host, string _port, bool _encrypt, string _username, string _password, string _database, DatabaseTypes _databaseType)
        {
            Host = _host;
            Port = _port;
            Encrypt = _encrypt;
            Username = _username;
            Password = _password;
            DatabaseType = _databaseType;
            Database = _database;

            GetConnectionString();
        }

        public void SetConnectionString(string _connectionStrng)
        {
            ConnectionString = _connectionStrng;
        }
        public string GetConnectionString()
        {
            if(string.IsNullOrEmpty(ConnectionString))
            {
                switch (DatabaseType)
                {
                    case DatabaseTypes.PostgreSQL:
                        ConnectionString = $"Host={Host};Port={Port};Username={Username};Password={Password};Database={Database};";
                        //_connect = $"Host={Host};Port={Port};Encryption={Encrypt};Username={Username};Password={Password};Database={Database};";
                        break;
                    case DatabaseTypes.MYSQLServer:
                        ConnectionString = $"Server={Host};Encrypt={Encrypt};User ID={Username};Password={Password};Initial Catalog={Database}";
                        break;
                    default:
                        ConnectionString = $"Host={Host};Username={Username};Password={Password};";
                        break;
                }
            }

            return ConnectionString;
        }
    }
    public enum DatabaseTypes { PostgreSQL, MYSQLServer }
}
