using System;
using System.Collections.Generic;

using RockyPanelBackend.Database;
using RockyPanelBackend.Models;

namespace RockyPanelBackend
{
    public class Rocky
    {
        public static List<UserModel> Users { get; set; }
        public static List<ServerModel> Servers { get; set; }

        public static void LoadDataFromDB()
        {
            Users = DatabaseProvider.GetUsers().Result;
            Servers = DatabaseProvider.GetServers().Result;
            Console.WriteLine($"Loaded {Servers.Count} servers");
        }

        public class UserActions
        {
            public static UserModel SearchForUser(string email)
            {
                UserModel result = null;

                foreach(UserModel userModel in DatabaseProvider.GetUsers().Result)
                {
                    if(userModel.Email == email)
                    {
                        result = userModel;
                        break;
                    }
                }

                return result;
            }
        }

        public class ServerActions
        {
            public static ServerModel[] GetServers(int startIndex = 0, int lenght = -1)
            {
                List<ServerModel> result = new List<ServerModel>();

                for(int i = startIndex; i <= startIndex + lenght; i++)
                {
                    result.Add(Servers[i]);
                }

                return result.ToArray();
            }
        }
    }
}