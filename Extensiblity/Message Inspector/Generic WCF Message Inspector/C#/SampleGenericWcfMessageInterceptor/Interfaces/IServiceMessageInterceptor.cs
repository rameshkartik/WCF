using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace SampleGenericWcfMessageInterceptor.Interfaces
{
    public interface IServiceMessageInterceptor
    {
        /// <summary>
        /// Interface to support Message Receive Notify
        /// </summary>
        /// <param name="request"></param>
        /// <param name="xmlMessage"></param>
        /// <param name="soapMessage"></param>
        void Receive(System.ServiceModel.Channels.Message request, XDocument soapMessage);

        /// <summary>
        /// Interface to support Message Response Notify
        /// </summary>
        /// <param name="response"></param>
        /// <param name="xmlMessage"></param>
        /// <param name="soapMessage"></param>
        void Respond(System.ServiceModel.Channels.Message response, XDocument soapMessage);
    }
}
