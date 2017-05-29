using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Rameshkartik.WCFSamples.MessageExchangePatterns.ServiceLibrary;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICallbackContract CallBackInstance = new CallBackClient();
            InstanceContext ICntxt = new InstanceContext(CallBackInstance);

            Client clntObject = new Client(ICntxt);
            //clntObject.GetDetailedData("hi");
            clntObject.UpdateData("Hi Guys");
            Console.WriteLine("Client started");
            Console.ReadLine();
        }
    }
}
