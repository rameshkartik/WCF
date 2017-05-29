using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApplication.ShoppingServiceProxy;
namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientApplication.ShoppingServiceProxy.OnlineShoppingServiceClient os = new OnlineShoppingServiceClient();
            WholeSaleDealersInfo wObject = os.GetWholeSaleDealerInfo("Chennai");
            Console.WriteLine("Dealer Name :" + wObject.DealerName);
            Console.WriteLine("Dealer Location :" + wObject.LocationofDealer);
            Console.WriteLine("Dealer Since :" + wObject.DealerSince.ToString());
            WholeSaleDealersInfo wObject1 = os.GetWholeSaleDealerInfo("Chennai");
            Console.ReadLine();
        }
    }
}
