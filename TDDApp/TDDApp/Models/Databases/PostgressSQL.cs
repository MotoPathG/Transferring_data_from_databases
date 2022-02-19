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
            TDD.logger.Info("[Database->Postgress SQL] Start Setup");

            using (conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();

                    TDD.logger.Info("[Database->Postgress SQL] Подключение открыто");

                    // Вывод информации о подключении
                    TDD.logger.Info("Свойства подключения:");
                    TDD.logger.Info("\tСтрока подключения: {0}", conn.ConnectionString);
                    TDD.logger.Info("\tБаза данных: {0}", conn.Database);
                    TDD.logger.Info("\tСервер: {0}", conn.DataSource);
                    TDD.logger.Info("\tВерсия сервера: {0}", conn.ServerVersion);
                    TDD.logger.Info("\tСостояние: {0}", conn.State);

                    conn.Close();
                    TDD.logger.Info("[Database->Postgress SQL] Подключение закрыто...");

                }
                catch (Exception ex)
                {
                    TDD.logger.Info($"[Database->Postgress SQL] Не удалось подключиться к базе данных [{conn.Database}]!\n[ERROR MASSAGE => {ex.Message}]");
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
                    foreach (var item in reader) TDD.logger.Info(item.ToString()); // For Testing
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
