using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using Rameshkartik.WCFSamples.Inspector;
using Rameshkartik.WCFSamples.Behaviour;
using Rameshkartik.WCFSamples.Routing.LoadBalancing.Implementation;
namespace RailInformationHost
{
    class Program
    {
        static string address = string.Empty;

        static void Main(string[] args)
        {
            string a = string.Empty;
            ServiceHost SH = new ServiceHost(typeof(RailImpl));
            foreach (var ep in SH.Description.Endpoints)
            {
                foreach (OperationDescription OD in ep.Contract.Operations)
                {
                    a =OD.Name.ToString();
                    OD.OperationBehaviors.Add(new OprationBehaviour());
                }
            }
            address = SH.BaseAddresses[0].ToString();
            SH.Opened += SH_Opened;
            SH.Closed += SH_Closed;
            SH.Open();
            Console.ReadLine();

        }

        static void SH_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Host Down...");
        }

        static void SH_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Host up at {0}", address);
        }
    }
}

