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

        public DatabaseTypes DatabaseType;
        public DatabaseConfiguration(string _host, string _port, bool _encrypt, string _username, string _password, string _database, DatabaseTypes _databaseType)
        {
            Setup(_host, _port, _encrypt, _username, _password, _database, _databaseType);
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
        }

        public string GetConnectionString() {
            string _connect = DatabaseType switch
            {
                DatabaseTypes.PostgreSQL => $"Host={Host};Port={Port};Encryption={Encrypt};Username={Username};Password={Password};Database={Database};",
                DatabaseTypes.SQLServer => $"Server={Host};Encrypt={Encrypt};User ID={Username};Password={Password};Initial Catalog={Database}",
                _ => $"Host={Host};Username={Username};Password={Password};",
            };
            return _connect;
        }
    }
    public enum DatabaseTypes { PostgreSQL, SQLServer }
}
