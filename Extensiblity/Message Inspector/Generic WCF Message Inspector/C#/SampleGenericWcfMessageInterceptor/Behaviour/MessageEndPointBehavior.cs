using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using SampleGenericWcfMessageInterceptor.Subject;

namespace SampleGenericWcfMessageInterceptor.Behaviour
{
    /// <summary>
    /// This class will implement service end point behavior to attach Message Subject to Dispatcher
    /// </summary>
    public class MessageEndPointBehavior : IEndpointBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="bindingParameters"></param>
        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            return;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="endpoint"></param>
        /// <param name="clientRuntime"></param>
        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            return;
        }

        /// <summary>
        /// Adds Message Inspector to Dispatcher Runtime
        /// </summary>
        /// <param name="endpoint">ServiceEndpoint</param>
        /// <param name="endpointDispatcher">EndpointDispatcher</param>
        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            string schemaPath = AppDomain.CurrentDomain.BaseDirectory;
            endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new MessageSubject(endpoint.Name));
        }

        /// <summary>
        /// Validate End Point Settings
        /// </summary>
        /// <param name="endpoint">ServiceEndpoint</param>
        public void Validate(ServiceEndpoint endpoint) 
        { 
            return; 
        }

    }
}
