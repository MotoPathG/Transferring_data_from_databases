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
        public bool UseSSL { get; set; } = true;
        public string Username { get; set; } = "root";
        public string Password { get; set; } = "";

        public DatabaseConfiguration(string _host, string _port, bool _useSSL, string _username, string _password)
        {
            Setup(_host, _port, _useSSL, _username, _password);
        }
        public void Setup(string _host, string _port, bool _useSSL, string _username, string _password)
        {
            Host =_host;
            Port = _port;
            UseSSL = _useSSL;
            Username = _username;
            Password = _password;   
        }
    }
}
