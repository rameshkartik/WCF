using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.Routing.LoadBalancing.Contracts
{
    [ServiceContract]
    public interface iPNRQueries
    {
        [OperationContract]
        string GetPNRQuery(string qury);

    }

    
}
