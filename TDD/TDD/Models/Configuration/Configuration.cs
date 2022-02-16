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
        public Configuration(DatabaseConfiguration _fromDatabase, DatabaseConfiguration _toDatabase, TransferTypes _transferType)
        {
            Setup(_fromDatabase, _toDatabase, _transferType);
        }
        public void Setup(DatabaseConfiguration _fromDatabase, DatabaseConfiguration _toDatabase, TransferTypes _transferType)
        {
            FromDatabase = _fromDatabase;
            ToDatabase = _toDatabase;
            TransferType = _transferType;
        }
    }
    public enum TransferTypes:int { None, SQLServerToPostgreSQL }
}
