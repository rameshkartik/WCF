using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using Rameshkartik.WCFSamples.Security.Authorization;
namespace AuthorizationHost
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ServiceHost Hst = new ServiceHost(typeof(AuthorizeImpl));
            ServiceMetadataBehavior mb = Hst.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (mb != null)
            {
                mb.HttpGetEnabled = true;
            }
            Hst.Opened += Hst_Opened;
            Hst.Closed += Hst_Closed;
            Hst.Open();
            Console.ReadKey();
            Hst.Close();
            Console.ReadKey();
            
        }

        static void Hst_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Host Closed");
        }

        static void Hst_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Host Opened");
        }
    }
}
