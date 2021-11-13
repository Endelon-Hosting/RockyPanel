using RockyPanelBackend.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace RockyPanelBackend.Database
{
    public class DatabaseProvider
    {
        public static async Task<List<ServerModel>> GetServers()
        {
            string sql = $"SELECT * FROM {Constants.DatabaseName}.servers";
            return await MySQLProvider.LoadData<ServerModel, dynamic>(sql, new { });
        }
        public static async Task<List<NodeModel>> GetNodes()
        {
            string sql = $"SELECT * FROM {Constants.DatabaseName}.nodes";
            return await MySQLProvider.LoadData<NodeModel, dynamic>(sql, new { });
        }

        public static async Task<List<UserModel>> GetUsers()
        {
            string sql = $"SELECT * FROM {Constants.DatabaseName}.users";
            return await MySQLProvider.LoadData<UserModel, dynamic>(sql, new { });
        }
    }
}
