using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SampleWCFService
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(string value);
    }
}
