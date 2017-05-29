using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Configuration;
using System.IO;
using System.Xml;

namespace Rameshkartik.WCFSamples.Inspector
{
    public class ParamInspector : IParameterInspector
    {


        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            Console.WriteLine("Executed Operation Name : {0}",operationName);
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Operation To be Executed at Server");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Operation Name {0}", operationName);
            Console.WriteLine("Inputs to the Service {0}", inputs[0]);
            Console.WriteLine("----------------------------------------------------------");
            return null;
            
        }
    }
}
