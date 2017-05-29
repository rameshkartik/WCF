using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.RouterServiceReference;
namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataRequestClient DRC = new DataRequestClient("NetTcpBinding_IDataRequest");
            string address = DRC.Endpoint.Address.ToString();
            string response = DRC.GetData(100);
            Console.WriteLine("Response : {0} ", response);
            Console.ReadLine();
        }
    }
}
