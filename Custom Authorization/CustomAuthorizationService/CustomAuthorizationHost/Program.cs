using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Rameshkartik.WCFSamples.Authorization;
namespace CustomAuthorizationHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost Host = new ServiceHost(typeof(CustomAuthorizationImpl));
            Host.Opened += Host_Opened;
            Host.Closed += Host_Closed;
            Host.Open();
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
