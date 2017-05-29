using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.MessageLogging.ServiceLibrary
{
    
    [ServiceContract(Namespace="http://localhost:8735/Rameshkartik/WCFSamples/MessageLogging/ServiceLibrary)",
        CallbackContract = typeof(ICallbackContract)) ]
    public interface ILibrary
    {
        [OperationContract]
        void UpdateData(string value);

        [OperationContract]
        string GetDetailedData(string value);
    }

    public interface ICallbackContract
    {
        [OperationContract]
        void CallBackFunction(string NotifyData);
    }

    [ServiceContract]
    public interface ILibrary_OneWay
    {
        [OperationContract(IsOneWay = true)]
        void LogData(string sLog);
    }

    [ServiceContract]
    public interface ILibrary_RequestReply
    {
        [OperationContract]
        string GetData(string sData);
    }

    
}
