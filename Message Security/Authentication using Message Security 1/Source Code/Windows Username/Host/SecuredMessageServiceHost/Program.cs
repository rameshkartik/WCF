using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Rameshkartik.WCFSamples.SecuredMessageService.Implementation;

namespace SecuredMessageServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(SecuredMessageServiceImpl));
            sh.Opened += sh_Opened;
            sh.Closed += sh_Closed;
            sh.Open();
            Console.ReadKey();
        }

        static void sh_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Secured Message Service Closed");
        }

        static void sh_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Secured Message Service Hosted");
        }
    }
}
