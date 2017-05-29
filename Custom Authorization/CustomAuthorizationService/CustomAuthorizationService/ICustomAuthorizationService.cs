using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.Authorization
{
    [ServiceContract]
    public interface iCustomAuthorizationService
    {
        [OperationContract]
        void PushDataIntoServer(string value);
                 
    }

    [DataContract]
    public class MyServiceFaults
    {
        [DataMember]
        public string ErrMessage { get; set; }
    }
    
}
