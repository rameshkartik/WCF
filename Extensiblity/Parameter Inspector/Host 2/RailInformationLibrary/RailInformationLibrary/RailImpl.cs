using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.Routing.LoadBalancing.Contracts;

namespace Rameshkartik.WCFSamples.Routing.LoadBalancing.Implementation
{
    public class RailImpl : IRailServices
    {

        public string GetPNRQuery(string qury)
        {
            Console.WriteLine("PNR Query processing ..");
            Console.WriteLine("PNR Query Processed");
            return "Your PNR Query will be resolved in another 24 hours";
        }

        public string BookTicket(int NoOfSeats)
        {
            Console.WriteLine("Ticket Booking Process Started..");
            Console.WriteLine("Ticket Booking Process Completed");
            return "Ticket Confirmed"; 
        }
    }
}
