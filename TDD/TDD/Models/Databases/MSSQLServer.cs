using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace TDD.Models.Databases
{
    public class MSSQLServer
    {
        public SqlConnection conn;
        public MSSQLServer(string connString)
        {
            Setup(connString);
        }
        public void Setup(string connString)
        {
            using (conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    Console.WriteLine("[Database->MY SQL Server] Подключение открыто");

                    // Вывод информации о подключении
                    Console.WriteLine("Свойства подключения:");
                    Console.WriteLine("\tСтрока подключения: {0}", conn.ConnectionString);
                    Console.WriteLine("\tБаза данных: {0}", conn.Database);
                    Console.WriteLine("\tСервер: {0}", conn.DataSource);
                    Console.WriteLine("\tВерсия сервера: {0}", conn.ServerVersion);
                    Console.WriteLine("\tСостояние: {0}", conn.State);
                    Console.WriteLine("\tWorkstationld: {0}", conn.WorkstationId);

                    conn.Close();
                    Console.WriteLine("[Database->MY SQL Server] Подключение закрыто...");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Database->MY SQL Server] Не удалось подключиться к базе данных [{conn.Database}]!\n[ERROR MASSAGE => {ex.Message}]");
                }
            }
        }

        public async Task ExexCommandAsync(string cmdData)
        {            
            await conn.OpenAsync();

            using (var cmd = new SqlCommand(cmdData, conn))
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    foreach(var item in reader) Console.WriteLine(item.ToString()); // For Testing
                }
            }

            conn.Close();
        }

        public async Task ExexReadDataAsync(string cmdData)
        {

            string sqlExpression = "SELECT * FROM Users";

            await conn.OpenAsync();
            SqlCommand command = new SqlCommand(sqlExpression, conn);
            SqlDataReader reader = await command.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                // выводим названия столбцов
                Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

                while (await reader.ReadAsync())
                {
                    object id = reader.GetValue(0);
                    object name = reader.GetValue(1);
                    object age = reader.GetValue(2);
                    Console.WriteLine("{0} \t{1} \t{2}", id, name, age);
                }
            }
            reader.Close();
        }
    }
}
