using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

using Dapper;

using MySql.Data.MySqlClient;

namespace RockyPanelBackend.Database
{
    public class MySQLProvider
    {
        public static async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            using (IDbConnection connection = new MySqlConnection(Constants.DatabaseConnectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public static async Task SaveData<T>(string sql, T parameters)
        {
            using (IDbConnection connection = new MySqlConnection(Constants.DatabaseConnectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
