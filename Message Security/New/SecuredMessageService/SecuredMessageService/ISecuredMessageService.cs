using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.SecuredMessageService.Contracts
{
    [ServiceContract]
    public interface ISecuredMessageService
    {
        [OperationContract]
        void SayHello(string value);
    }
}
