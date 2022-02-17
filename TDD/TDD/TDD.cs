using TDD.Models;
using TDD.Models.Databases;

namespace TDD
{
    public class TDD
    {
        public Configuration TDDConfiguration;
        public Database FromDatabase;
        public Database ToDatabase;

        public TDD(Configuration _configuration)
        {
            Setup(_configuration);
        }
        
        private void Setup(Configuration _configuration)
        {
            TDDConfiguration = _configuration;


            ConnectionToDatabase();
        }

        private void ConnectionToDatabase()
        {
            FromDatabase = new Database(TDDConfiguration.FromDatabase.GetConnectionString(), TDDConfiguration.FromDatabase.DatabaseType);
            ToDatabase = new Database(TDDConfiguration.ToDatabase.GetConnectionString(), TDDConfiguration.ToDatabase.DatabaseType);
        }
    }
}