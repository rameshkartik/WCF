using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Client.LoadBalancerRef;
using Rameshkartik.WCFSamples.Inspector;
using Rameshkartik.WCFSamples.Behaviour;
using System.ServiceModel.Description;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //iPNRQueriesClient Cln = new iPNRQueriesClient("BasicHttpBinding_iPNRQueries");
            //Console.WriteLine("PNR Status Request given");
            //string str = Cln.GetPNRQuery("Check PNR status of PNR100223232");
            //if (str != "")
            //{
            //    Console.WriteLine("PNR Status Request Processed");
            //}

            string str = string.Empty;
            var ChnlFactory = new ChannelFactory<iPNRQueries>(new BasicHttpBinding());
            iPNRQueries ip = ChnlFactory.CreateChannel(new EndpointAddress("http://localhost:8651/RailServices/PNR"));

            OprationBehaviour cl = new OprationBehaviour();
            //
           // ChnlFactory.Endpoint.Contract.Operations.Find("GetPNRQuery").OperationBehaviors.Add(cl);
            foreach (OperationDescription OD in ChnlFactory.Endpoint.Contract.Operations)
            {
                str = OD.Name.ToString();
                OD.OperationBehaviors.Add(new OprationBehaviour());
            }
            Console.WriteLine("PNR Status Request given");
            str = ip.GetPNRQuery("Check PNR status of PNR100223232");
            if (str != "")
            {
                Console.WriteLine("PNR Status Request Processed");
            }


            //for (int iCount = 0; iCount <= 10; iCount++)
            //{
            //    iSeatBookClient clnSeat = new iSeatBookClient("BasicHttpBinding_iSeatBook");
            //    Console.WriteLine("Ticket Booking Request given");
            //    str = clnSeat.BookTicket(4);
            //    Console.WriteLine("Ticket Booking Request Processed");
                
            //}

            Console.ReadLine();
        }
    }
}
