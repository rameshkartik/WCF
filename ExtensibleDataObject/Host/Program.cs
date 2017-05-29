using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using Rameshkartik.WCFSamples.ExtensibleDataObject;
namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hst = new ServiceHost(typeof(Implementation));
            ServiceMetadataBehavior mb = hst.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (mb!= null)
            {
                mb.HttpGetEnabled = true;
            }
            hst.Opened += hst_Opened;
            hst.Closed += hst_Closed;
            hst.Open();
            Console.ReadKey();

        }

        static void hst_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Host Closed");
        }


        static void hst_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Host Openend");
        }
    }
}
