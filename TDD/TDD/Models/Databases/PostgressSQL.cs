using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TDD.Models.Databases
{
    public class PostgressSQL
    {
        public NpgsqlConnection conn;
        public PostgressSQL(string connString)
        {
            Setup(connString);
        }

        public void Setup(string connString)
        {
            using (conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    Console.WriteLine("[Database->Postgress SQL] Подключение открыто");

                    // Вывод информации о подключении
                    Console.WriteLine("Свойства подключения:");
                    Console.WriteLine("\tСтрока подключения: {0}", conn.ConnectionString);
                    Console.WriteLine("\tБаза данных: {0}", conn.Database);
                    Console.WriteLine("\tСервер: {0}", conn.DataSource);
                    Console.WriteLine("\tВерсия сервера: {0}", conn.ServerVersion);
                    Console.WriteLine("\tСостояние: {0}", conn.State);

                    conn.Close();
                    Console.WriteLine("[Database->Postgress SQL] Подключение закрыто...");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Database->Postgress SQL] Не удалось подключиться к базе данных [{conn.Database}]!\n[ERROR MASSAGE => {ex.Message}]");
                }
            }

        }

        public async Task ExexCommandAsync(string cmdData)
        {
            await conn.OpenAsync();

            using (var cmd = new NpgsqlCommand(cmdData, conn))
            using (var reader = await cmd.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    foreach (var item in reader) Console.WriteLine(item.ToString()); // For Testing
                }
            }

            await conn.CloseAsync();
        }

        public async Task Example()
        {
            await ExexCommandAsync("INSERT INTO data (some_field) VALUES ($1)");
        }
    }
}
