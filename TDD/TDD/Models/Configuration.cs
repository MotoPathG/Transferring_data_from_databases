using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Models
{
    public class Configuration
    {
        public DatabaseConfiguration? FromDatabase { get; set; }
        public DatabaseConfiguration? ToDatabase { get; set; }
        public TransferTypes TransferType { get; set; }
        public Configuration(DatabaseConfiguration _fromDatabase, DatabaseConfiguration _toDatabase)
        {
            Setup(_fromDatabase, _toDatabase);
        }
        public void Setup(DatabaseConfiguration _fromDatabase, DatabaseConfiguration _toDatabase)
        {
            FromDatabase = _fromDatabase;
            ToDatabase = _toDatabase;
        }
    }
    public enum TransferTypes:int { None, SQLServerToPostgreSQL }
}
