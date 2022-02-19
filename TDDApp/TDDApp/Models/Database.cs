using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TDD.Models.Databases;

namespace TDD.Models
{
    public class Database
    {
        private PostgressSQL postgressSQL;
        private MSSQLServer  msSSQLServer;
        private DatabaseTypes type;
    
        public Database(string connString, DatabaseTypes _type)
        {
            Setup(connString, _type);
        }
        private void Setup(string connString, DatabaseTypes _type)
        {
            type = _type;

            switch (type)
            {
                case DatabaseTypes.PostgreSQL:
                    postgressSQL = new PostgressSQL(connString);
                    break;
                case DatabaseTypes.MYSQLServer:
                    msSSQLServer = new MSSQLServer(connString);
                    break;
                default:
                    break;
            }
        }

        public async Task ExexCommand(string cmdData)
        {
            switch (type)
            {
                case DatabaseTypes.PostgreSQL:
                    await postgressSQL.ExexCommandAsync(cmdData);
                    break;
                case DatabaseTypes.MYSQLServer:
                    await msSSQLServer.ExexCommandAsync(cmdData);
                    break;
                default:
                    break;
            }
        }
    }
}
