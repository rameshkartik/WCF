using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Rameshkartik.WCFSamples.Routing.LoadBalancing.Contracts
{
    
    [ServiceContract]
    public interface iSeatBook
    {
        [OperationContract]
        string BookTicket(int NoOfSeats);
    }
}
