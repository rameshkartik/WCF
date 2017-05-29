using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using Rameshkartik.WCFSamples.Transactions.Implementation;
namespace PurchaseServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sHost = new ServiceHost(typeof(PurchaseImpl));
            WSHttpBinding bind = new WSHttpBinding();
            sHost.AddServiceEndpoint(typeof(CardTransactionImpl), 
                bind, "http://localhost:8731/OnlineShoppingService");


            sHost.Opened += sHost_Opened;
            sHost.Closed += sHost_Closed;
            sHost.Open();
            ServiceMetadataBehavior meta = sHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
            meta.HttpGetEnabled = true;

            ServiceHost HostTrans = new ServiceHost(typeof(CardTransactionImpl));
            HostTrans.Opened += HostTrans_Opened;
            HostTrans.Closed += HostTrans_Closed;
            HostTrans.Open();
            Console.ReadLine();
        }

        static void HostTrans_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Host Closed");
        }

        static void HostTrans_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Host Opened for Card Transaction Operations.");
        }

        static void sHost_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Host Closed");
        }

        static void sHost_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Host Opened for Online Purchase Operations.");
        }
    }
}
