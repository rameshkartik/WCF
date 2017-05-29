using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ServiceModel.Channels;

namespace SampleWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            StringBuilder outP = new StringBuilder();

            foreach(KeyValuePair<string,object> myK in System.ServiceModel.OperationContext.Current.IncomingMessageProperties)
            {
                if(myK.Key.StartsWith("MY"))
                    outP.AppendLine(myK.Key + " : " + myK.Value);
            }

            return  outP.ToString();
        }
    }
}
