using RelationsClient.PMS_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsClient.Classes
{
    public class User
    {
        private int Id;
        private string Type;
        private DateTime CreationData;
        private PMS_API.UserManagementClient userManagementClient;
        
        public User()
        {
            userManagementClient = new UserManagementClient();
        }

        public void Login(string username, string password)
        {
            try
            {
                Console.WriteLine(userManagementClient.Login(username, password));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
