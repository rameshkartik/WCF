using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.Security.Authorization
{
    [ServiceContract(Namespace = "http://localhost:8735/Rameshkartik/WCFSamples/Authorization")]
    public interface IAuthorize
    {
        [OperationContract]
        bool GetData(int iRecordNumber,string username);
        
    }
        
}
