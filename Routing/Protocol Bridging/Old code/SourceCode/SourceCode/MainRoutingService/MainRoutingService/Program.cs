using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Routing;

namespace MainRoutingService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost SH = new ServiceHost(typeof(RoutingService));
            try
            {
                SH.Open();
                Console.WriteLine("Main Router Service is Up...");
                Console.ReadLine();
                SH.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
