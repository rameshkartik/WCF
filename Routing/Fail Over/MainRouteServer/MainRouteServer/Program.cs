using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Routing;
namespace MainRouteServer
{
    class Program
    {
        static string address = string.Empty;
        static void Main(string[] args)
        {
            ServiceHost SH = new ServiceHost(typeof(RoutingService));
            try
            {
                SH.Opened += SH_Opened;
                SH.Closed += SH_Closed;
                address = SH.BaseAddresses[0].ToString();
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
            Console.WriteLine("Router Up.. at {0} ", address);
        }
    }
}
