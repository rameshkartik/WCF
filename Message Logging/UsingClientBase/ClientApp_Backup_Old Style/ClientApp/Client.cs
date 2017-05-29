using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using Rameshkartik.WCFSamples.MessageExchangePatterns.ServiceLibrary;

namespace ClientApp
{
    class Client:DuplexClientBase<ILibrary>,ILibrary 
    {
        public Client(InstanceContext CallBackContxt)
            : base(CallBackContxt)
        {
            //WSDualHttpBinding binding = new WSDualHttpBinding();
            //EndpointAddress endptadr = new EndpointAddress("http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibrary");
            //binding.ClientBaseAddress = new Uri("http://localhost:8000/DuplexTestUsingCode/Client/");
        }
     
        public string GetDetailedData(string value)
        {
            return base.Channel.GetDetailedData("hi");
        }

        public void UpdateData(string value)
        {
            base.Channel.UpdateData(value);
        }

    }

    class CallBackClient : ICallbackContract
    {

        public void CallBackFunction()
        {
            Console.WriteLine("CallBack from Service");
        }
    }
}
