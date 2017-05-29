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
                        
            OrderInfo OI = os.GetOrderDetails(0608);
            Console.WriteLine("----------- ");
            Console.WriteLine("Header :" +OI.OrderId);
            Console.WriteLine("----------- ");
            Console.WriteLine("Body Message ");
            Console.WriteLine("----------- ");
            Console.WriteLine("Discount Availed :" +OI.DiscountAvailed);
            Console.WriteLine("Order Date :" + OI.OrderDate);
            Console.WriteLine("PaidByCreditCard :" + OI.PaidByCard);
            Console.WriteLine("Product Description :" + OI.PurchasedProductName);
            Console.WriteLine("Quantity :" + OI.Quality); 
            Console.ReadLine();
        }
    }
}
