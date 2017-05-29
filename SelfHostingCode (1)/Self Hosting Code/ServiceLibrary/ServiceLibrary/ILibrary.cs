using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.Security.ProtectionLevel.ServiceLibrary
{
    
    [ServiceContract(Namespace="http://http://localhost:8735/Rameshkartik/WCFSamples/Security/Principal/ServiceLibrary",ProtectionLevel=
        System.Net.Security.ProtectionLevel.EncryptAndSign)]
    public interface ILibrary
    {
        [OperationContract(ProtectionLevel=System.Net.Security.ProtectionLevel.None)]
        string GetStringData(string value);

        [OperationContract]
        string GetIntData(int value);
    }
       
}
