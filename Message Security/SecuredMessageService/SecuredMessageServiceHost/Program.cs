using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.IdentityModel.Selectors;
using Rameshkartik.WCFSamples.SecuredMessageService.Implementation;
namespace Rameshkartik.WCFSamples.SecuredMessageService.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost Host = new ServiceHost(typeof(ISecuredMessageServiceImpl));
            Host.Opened += Host_Opened;
            Host.Closed += Host_Closed;
            Host.Open();
            Console.ReadKey();
            Host.Close();
            Console.ReadKey();
        }

        static void Host_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Secured MessageService Host Closed");
        }

        static void Host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Secured MessageService Host Opened");
        }
    }


}
