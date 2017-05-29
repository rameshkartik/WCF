using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Channels;

namespace ClientInspector
{
    public class Post
    {
        [ServiceContract]
        public interface ITest
        {
            [OperationContract]
            string Echo(string text);
        }
        public class Service : ITest
        {
            public string Echo(string text)
            {
                return text;
            }
        }
        class ServerInspectorToAddMustUnderstandHeader : IEndpointBehavior, IDispatchMessageInspector
        {
            public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
            {
            }

            public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
            {
            }

            public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
            {
                endpointDispatcher.DispatchRuntime.MessageInspectors.Add(this);
            }

            public void Validate(ServiceEndpoint endpoint)
            {
            }

            public object AfterReceiveRequest(ref Message request, IClientChannel channel, InstanceContext instanceContext)
            {
                return null;
            }

            public void BeforeSendReply(ref Message reply, object correlationState)
            {
                MessageHeader header = MessageHeader.CreateHeader("foo", "bar", "value", true);
                reply.Headers.Add(header);
            }
        }
        class ClientInspectorToRemoveMustUnderstandHeader : IEndpointBehavior, IClientMessageInspector
        {
            public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
            {
            }

            public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
            {
                clientRuntime.MessageInspectors.Add(this);
            }

            public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
            {
            }

            public void Validate(ServiceEndpoint endpoint)
            {
            }

            public void AfterReceiveReply(ref Message reply, object correlationState)
            {
                int headerIndex = reply.Headers.FindHeader("foo", "bar");
                if (headerIndex >= 0)
                {
                    Console.WriteLine("Removing \"mustUnderstand=1\" header");
                    reply.Headers.RemoveAt(headerIndex);
                }
            }

            public object BeforeSendRequest(ref Message request, IClientChannel channel)
            {
                return null;
            }
        }
        public static void Test()
        {
            string baseAddress = "http://" + Environment.MachineName + ":8000/Service";
            ServiceHost host = new ServiceHost(typeof(Service), new Uri(baseAddress));
            ServiceEndpoint endpoint = host.AddServiceEndpoint(typeof(ITest), new BasicHttpBinding(), "");
            endpoint.Behaviors.Add(new ServerInspectorToAddMustUnderstandHeader());
            host.Open();
            Console.WriteLine("Host opened");

            ChannelFactory<ITest> factory = new ChannelFactory<ITest>(new BasicHttpBinding(), new EndpointAddress(baseAddress));
            factory.Endpoint.Behaviors.Add(new ClientInspectorToRemoveMustUnderstandHeader());
            ITest proxy = factory.CreateChannel();
            Console.WriteLine(proxy.Echo("Hello"));

            ((IClientChannel)proxy).Close();
            factory.Close();

            Console.Write("Press ENTER to close the host");
            Console.ReadLine();
            host.Close();
        }
    }
}
