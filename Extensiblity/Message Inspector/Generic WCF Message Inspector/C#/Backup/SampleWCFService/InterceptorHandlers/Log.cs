using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleGenericWcfMessageInterceptor.Interfaces;

namespace SampleWCFService.InterceptorHandlers
{
    public class Log : IServiceMessageInterceptor
    {
        #region IServiceMessageInterceptor Members

        public void Receive(System.ServiceModel.Channels.Message request, System.Xml.Linq.XDocument soapMessage)
        {
            System.ServiceModel.OperationContext.Current.IncomingMessageProperties.Add("MY.LOG", "This is from LOG " + request.ToString());
        }

        public void Respond(System.ServiceModel.Channels.Message response, System.Xml.Linq.XDocument soapMessage)
        {
        }

        #endregion
    }
}