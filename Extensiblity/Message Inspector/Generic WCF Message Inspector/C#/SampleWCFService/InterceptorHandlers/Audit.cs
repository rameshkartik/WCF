using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleGenericWcfMessageInterceptor.Interfaces;

namespace SampleWCFService.InterceptorHandlers
{
    public class Audit : IServiceMessageInterceptor
    {
        #region IServiceMessageInterceptor Members

        public void Receive(System.ServiceModel.Channels.Message request, System.Xml.Linq.XDocument soapMessage)
        {
            System.ServiceModel.OperationContext.Current.IncomingMessageProperties.Add("MY.AUDIT", "This is from AUDIT");
            //Write Some Code To Audit
        }

        public void Respond(System.ServiceModel.Channels.Message response, System.Xml.Linq.XDocument soapMessage)
        {
        }

        #endregion
    }
}