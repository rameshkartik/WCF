using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Rameshkartik.WCFSamples.MessageLogging.ServiceLibrary;
namespace ClientBase_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ICallbackContract iCallBackObject = new NotifyEvent();
            InstanceContext insCntxt = new InstanceContext(iCallBackObject);
            ProxyUsingClientBase ClientProxy = new ProxyUsingClientBase(insCntxt);
            Console.WriteLine("Detail of Data : " + ClientProxy.GetDetailedData("String Data"));

            ClientProxy.UpdateData("Data");
            Console.WriteLine("Data Sent to Service to Update in DB");

            OneWayProxyUsingClientBase ClientProxy_OneWay = new OneWayProxyUsingClientBase();
            ClientProxy_OneWay.LogData("Log Information");
            Console.WriteLine("Log Information sent to Service");

            RequestReplyProxyUsingClientBase ClientProxy_RequestReply = new RequestReplyProxyUsingClientBase();
            ClientProxy_RequestReply.GetData("Input");
            Console.WriteLine("Request-Reply Pattern Call to Service");

            Console.ReadLine();
        }
    }

    
}
