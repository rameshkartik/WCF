using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.ExposeMetaData
{
    [ServiceContract]
    public interface ILibrary
    {
        [OperationContract]
        string GetData(int value);
    }
}
