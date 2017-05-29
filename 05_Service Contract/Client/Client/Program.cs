using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ProxyReference;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineShoppingServiceClient clientObject = new OnlineShoppingServiceClient();
            Console.WriteLine(clientObject.CalculatePrice("Toy_Age0-5", 2, "Chennai"));
            Console.ReadKey();
        }
    }
}
