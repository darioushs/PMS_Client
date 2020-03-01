using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelationsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.DatabaseConnectorClient databaseConnectorClient = new ServiceReference1.DatabaseConnectorClient();
            Console.WriteLine(databaseConnectorClient.hi("dario"));
            Console.ReadLine();

        }
    }
}
