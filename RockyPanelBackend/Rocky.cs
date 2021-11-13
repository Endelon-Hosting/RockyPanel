using System.Collections.Generic;

using RockyPanelBackend.Database;
using RockyPanelBackend.Models;

namespace RockyPanelBackend
{
    public class Rocky
    {
        public static List<UserModel> Users { get; set; }

        public static void LoadDataFromDB()
        {
            Users = DatabaseProvider.GetUsers().Result;
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
    }
}