using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Rameshkartik.WCFSamples.CafeShopService.Implementation;
using System.ServiceModel.Description;
namespace CafeShopServiceHost
{
    class Program
    {
        private static ServiceHost Host = null;
        static void Main(string[] args)
        {
            Host = new ServiceHost(typeof(CafeShopServiceImpl));
            ServiceMetadataBehavior metaData = Host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (metaData != null)
            {
                metaData.HttpGetEnabled = true;
            }
            Host.Opened += Host_Opened;
            Host.Closed += Host_Closed; 
            Host.Open();
            Console.ReadKey();
            Host.Close();
            Console.ReadKey();
        }

        static void Host_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Host Closed");
        }

        static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Host Opened");
        }
    }
}
