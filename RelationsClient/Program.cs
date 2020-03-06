using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelationsClient.Classes;

namespace RelationsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Login("", "");
            Console.ReadLine();
        }
    }
}
