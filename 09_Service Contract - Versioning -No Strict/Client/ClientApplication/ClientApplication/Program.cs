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

            Toy toyInfo =  os.GetToyInfo("Barbie Doll");
            
            Console.WriteLine("Toy Name :" + toyInfo.Name);
            Console.WriteLine("Toy Price :" + toyInfo.Price);
            Console.WriteLine("Toy Available Stock :" + toyInfo.StockAvailableCount.ToString());
            
            Console.ReadLine(); ;
        }
    }
}
