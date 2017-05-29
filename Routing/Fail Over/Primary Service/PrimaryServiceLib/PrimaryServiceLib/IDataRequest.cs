using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.Routing.PrimaryServiceLib
{
    [ServiceContract]
    public interface IDataRequest
    {
        [OperationContract]
        string GetData(int value);
    }
    
}
