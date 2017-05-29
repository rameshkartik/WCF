using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.FoodInventoryServiceRef;
using ClientApp.MaterialInventoryServiceRef;
namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodInventoryClient FoodInv_Client = new FoodInventoryClient("BasicHttpBinding_IFoodInventory");
            string stock = FoodInv_Client.GetFoodInventoryData("Any");
            Console.WriteLine("Food Stock : {0} ", stock);

            MaterialInventoryLibClient MatInv_Client = new MaterialInventoryLibClient("BasicHttpBinding_IMaterialInventoryLib");
            stock = MatInv_Client.GetMaterialInventoryData("Any");
            Console.WriteLine("Food Stock : {0} ", stock);

            Console.ReadLine();
        }

    }
}
