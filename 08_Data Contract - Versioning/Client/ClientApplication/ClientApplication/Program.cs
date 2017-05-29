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
            bool sStockAvail = os.StockAvailability("Toy_Age0-5");
            Console.WriteLine("Stock Availability :" + sStockAvail.ToString());

            //New Member added in Service                        
            double price = os.CalculatePrice("Toy_Age0-5", 1, "Chennai");
            Console.WriteLine("Total Cost :" + price);

            //New Member Deleted in service
            double discountedAmt = os.CheckDiscountAmount("Toy_Age0-5", 1, "Chennai");
            Console.WriteLine("Discounted Amount :" + discountedAmt);

            //Parameter Type Change
            string sProductInfo = os.GetProductInformation("Toy_Age0-5");
            Console.WriteLine("Product Information :" + sProductInfo);

            //Return type Change
            string sProductAvail =  os.GetProductsAvailableinStores("Toy_Age0-5", 1, "Chennai");
            Console.WriteLine("Product Available :" + sProductAvail);

            Console.ReadLine(); ;
        }
    }
}
