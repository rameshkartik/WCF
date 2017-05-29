using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rameshkartik.WCFSamples.MessageLogging.ServiceLibrary;
using System.ServiceModel;
namespace ClientBase_ConsoleApp
{
    public class ProxyUsingClientBase:DuplexClientBase<ILibrary>,ILibrary
    {

        public ProxyUsingClientBase(InstanceContext iCntxt)
            : base(iCntxt)
        {

        }

        public string GetDetailedData(string value)
        {
            return base.Channel.GetDetailedData(value);
        }

        public void UpdateData(string value)
        {
            base.Channel.UpdateData(value);
        }


       
    }

    class NotifyEvent : ICallbackContract
    {

        public void CallBackFunction(string NotifyData)
        {
            Console.WriteLine(NotifyData);
        }
    }

    public class OneWayProxyUsingClientBase : ClientBase<ILibrary_OneWay>,ILibrary_OneWay
    {
        public OneWayProxyUsingClientBase()
        {

        }

        public void LogData(string sLog)
        {
            base.Channel.LogData(sLog);
        }
    }

    public class RequestReplyProxyUsingClientBase : ClientBase<ILibrary_RequestReply>, ILibrary_RequestReply
    {
        public RequestReplyProxyUsingClientBase()
        {

        }

        public string GetData(string sData)
        {
            return base.Channel.GetData(sData);
        }
    }
}

