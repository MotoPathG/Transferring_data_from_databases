using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDApp.Models.Databases
{
    public class DatabaseTypes
    {
        public DataTypes Types;
        public DatabaseTypes(TDD.Models.DatabaseTypes dbType)
        {
            Setup(dbType);
        }

        public class DataTypes
        {
            public string DATA_BIT { get; set; } = "BIT";
            public string DATA_TINYINT { get; set; } = "TINYINT";
            public string DATA_SMALLINT { get; set; } = "SMALLINT";
            public string DATA_INT { get; set; } = "INT";
            public string DATA_BIGINT { get; set; } = "BIGINT";
            public string DATA_DECIMAL { get; set; } = "DECIMAL";
            public string DATA_NUMERIC { get; set; } = "NUMERIC";
            public string DATA_SMALLMONEY { get; set; } = "SMALLMONEY";
            public string DATA_MONEY { get; set; } = "MONEY";

            public string DATA_FLOAT { get; set; } = "FLOAT";
            public string DATA_REAL { get; set; } = "REAL";

            public string DATA_DATE { get; set; } = "DATE";
            public string DATA_TIME { get; set; } = "TIME";
            public string DATA_DATETIME { get; set; } = "DATETIME";
            public string DATA_DATETIME2 { get; set; } = "DATETIME2";
            public string DATA_SMALLDATETIME { get; set; } = "SMALLDATETIME";
            public string DATA_DATETIMEOFFSET { get; set; } = "DATETIMEOFFSET";

            public string DATA_CHAR { get; set; } = "CHAR";
            public string DATA_VARCHAR { get; set; } = "VARCHAR";
            public string DATA_NCHAR { get; set; } = "NCHAR";
            public string DATA_NVARCHAR { get; set; } = "NVARCHAR";

            public string DATA_BINARY { get; set; } = "BINARY";
            public string DATA_VARBINARY { get; set; } = "VARBINARY";


            public string DATA_UNIQUEIDENTIFIER { get; set; } = "UNIQUEIDENTIFIER";
            public string DATA_TIMESTAMP { get; set; } = "TIMESTAMP";
            public string DATA_CURSOR { get; set; } = "CURSOR";
            public string DATA_HIERARCHYID { get; set; } = "HIERARCHYID";
            public string DATA_SQL_VARIANT { get; set; } = "SQL_VARIANT";
            public string DATA_XML { get; set; } = "XML";
            public string DATA_TABLE { get; set; } = "TABLE";
            public string DATA_GEOGRAPHY { get; set; } = "GEOGRAPHY";
            public string DATA_GEOMETRY { get; set; } = "GEOMETRY";
        }

        public void Setup(TDD.Models.DatabaseTypes dbType)
        {
            switch (dbType)
            {
                case TDD.Models.DatabaseTypes.PostgreSQL:
                    Types = new DataTypes()
                    {
                        DATA_BIT = "BIT", /*NO SET*/
                        DATA_TINYINT = "TINYINT", /*NO SET*/
                        DATA_SMALLINT = "smallint",
                        DATA_INT = "integer",
                        DATA_BIGINT = "bigint",
                        DATA_DECIMAL = "decimal",
                        DATA_NUMERIC = "numeric",
                        DATA_SMALLMONEY = "SMALLMONEY", /*NO SET*/
                        DATA_MONEY = "MONEY", /*NO SET*/

                        DATA_FLOAT = "FLOAT", /*NO SET*/
                        DATA_REAL = "real",

                        DATA_DATE = "date",
                        DATA_TIME = "time",
                        DATA_DATETIME = "DATETIME", /*NO SET*/
                        DATA_DATETIME2 = "DATETIME2", /*NO SET*/
                        DATA_SMALLDATETIME = "SMALLDATETIME", /*NO SET*/
                        DATA_DATETIMEOFFSET = "DATETIMEOFFSET", /*NO SET*/

                        DATA_CHAR = "char",
                        DATA_VARCHAR = "varchar",
                        DATA_NCHAR = "NCHAR", /*NO SET*/
                        DATA_NVARCHAR = "NVARCHAR", /*NO SET*/

                        DATA_BINARY = "BINARY", /*NO SET*/
                        DATA_VARBINARY = "VARBINARY", /*NO SET*/

                        DATA_UNIQUEIDENTIFIER = "UNIQUEIDENTIFIER", /*NO SET*/
                        DATA_TIMESTAMP = "timestamp",
                        DATA_CURSOR = "CURSOR", /*NO SET*/
                        DATA_HIERARCHYID = "HIERARCHYID", /*NO SET*/
                        DATA_SQL_VARIANT = "SQL_VARIANT", /*NO SET*/
                        DATA_XML = "xml",
                        DATA_TABLE = "TABLE", /*NO SET*/
                        DATA_GEOGRAPHY = "GEOGRAPHY", /*NO SET*/
                        DATA_GEOMETRY = "GEOMETRY", /*NO SET*/
                    };
                    break;

                case TDD.Models.DatabaseTypes.MYSQLServer:
                    Types = new DataTypes()
                    {
                        DATA_BIT = "BIT",
                        DATA_TINYINT = "TINYINT",
                        DATA_SMALLINT = "SMALLINT",
                        DATA_INT = "INT",
                        DATA_BIGINT = "BIGINT",
                        DATA_DECIMAL = "DECIMAL",
                        DATA_NUMERIC = "NUMERIC",
                        DATA_SMALLMONEY = "SMALLMONEY",
                        DATA_MONEY = "MONEY",

                        DATA_FLOAT = "FLOAT",
                        DATA_REAL = "REAL",

                        DATA_DATE = "DATE",
                        DATA_TIME = "TIME",
                        DATA_DATETIME = "DATETIME",
                        DATA_DATETIME2 = "DATETIME2",
                        DATA_SMALLDATETIME = "SMALLDATETIME",
                        DATA_DATETIMEOFFSET = "DATETIMEOFFSET",

                        DATA_CHAR = "CHAR",
                        DATA_VARCHAR = "VARCHAR",
                        DATA_NCHAR = "NCHAR",
                        DATA_NVARCHAR = "NVARCHAR",

                        DATA_BINARY = "BINARY",
                        DATA_VARBINARY = "VARBINARY",


                        DATA_UNIQUEIDENTIFIER = "UNIQUEIDENTIFIER",
                        DATA_TIMESTAMP = "TIMESTAMP",
                        DATA_CURSOR = "CURSOR",
                        DATA_HIERARCHYID = "HIERARCHYID",
                        DATA_SQL_VARIANT = "SQL_VARIANT",
                        DATA_XML = "XML",
                        DATA_TABLE = "TABLE",
                        DATA_GEOGRAPHY = "GEOGRAPHY",
                        DATA_GEOMETRY = "GEOMETRY",
                    };
                    break;
                default:
                    Types = new DataTypes()
                    {
                        DATA_BIT = "BIT",
                        DATA_TINYINT = "TINYINT",
                        DATA_SMALLINT = "SMALLINT",
                        DATA_INT = "INT",
                        DATA_BIGINT = "BIGINT",
                        DATA_DECIMAL = "DECIMAL",
                        DATA_NUMERIC = "NUMERIC",
                        DATA_SMALLMONEY = "SMALLMONEY",
                        DATA_MONEY = "MONEY",

                        DATA_FLOAT = "FLOAT",
                        DATA_REAL = "REAL",

                        DATA_DATE = "DATE",
                        DATA_TIME = "TIME",
                        DATA_DATETIME = "DATETIME",
                        DATA_DATETIME2 = "DATETIME2",
                        DATA_SMALLDATETIME = "SMALLDATETIME",
                        DATA_DATETIMEOFFSET = "DATETIMEOFFSET",

                        DATA_CHAR = "CHAR",
                        DATA_VARCHAR = "VARCHAR",
                        DATA_NCHAR = "NCHAR",
                        DATA_NVARCHAR = "NVARCHAR",

                        DATA_BINARY = "BINARY",
                        DATA_VARBINARY = "VARBINARY",


                        DATA_UNIQUEIDENTIFIER = "UNIQUEIDENTIFIER",
                        DATA_TIMESTAMP = "TIMESTAMP",
                        DATA_CURSOR = "CURSOR",
                        DATA_HIERARCHYID = "HIERARCHYID",
                        DATA_SQL_VARIANT = "SQL_VARIANT",
                        DATA_XML = "XML",
                        DATA_TABLE = "TABLE",
                        DATA_GEOGRAPHY = "GEOGRAPHY",
                        DATA_GEOMETRY = "GEOMETRY",
                    };
                    break;
            }
        }
    }
}
