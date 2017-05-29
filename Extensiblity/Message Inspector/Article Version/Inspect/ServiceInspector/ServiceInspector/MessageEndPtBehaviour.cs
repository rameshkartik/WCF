using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rameshkartik.WCFSamples.Inspector;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Configuration;

namespace Rameshkartik.WCFSamples.Behaviour
{
    public class MessageEndPtBehaviour : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint, 
            BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, 
            ClientRuntime clientRuntime)
        {
            return;
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint,
            EndpointDispatcher endpointDispatcher)
        {
            Console.WriteLine("Insider Apply Dispatch Behaviour");
            MessageInspector inspctor = new MessageInspector();
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(inspctor);
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            return;
        }
      
    }

    public class BehaviorExt : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(MessageEndPtBehaviour); }
        }

        protected override object CreateBehavior()
        {
            return new MessageEndPtBehaviour();
        }
    }
}
