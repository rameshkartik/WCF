using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using InventoryService.Implementation;

namespace InventoryService.Host
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ServiceHost SH = new ServiceHost(typeof(InventoryService.Implementation.StockImpl));
            try
            {
                SH.Opened += SH_Opened;
                SH.Closed += SH_Closed;
                SH.Open();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }

        static void SH_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Host Closed");
        }

        static void SH_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Host Opened");
        }
    }
}
