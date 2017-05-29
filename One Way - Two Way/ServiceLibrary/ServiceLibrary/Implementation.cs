using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.MessageExchangePatterns.ServiceLibrary;
namespace Rameshkartik.WCFSamples.MessageExchangePatterns.ServiceLibrary
{

    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class Implementation : ILibrary,ILibrary_OneWay,ILibrary_RequestReply
    {
        
        
        public string GetDetailedData(string value)
        {
            Console.WriteLine("Data Type Arrived : {0}", "String");
            return string.Format("You entered {0}", "String Data");
            
        }

        
        public void UpdateData(string value)
        {
            Console.WriteLine("Data Arrived to update in DB: " + value);
            ICallbackContract CallBackInstance = OperationContext.Current.GetCallbackChannel<ICallbackContract>();
            CallBackInstance.CallBackFunction("Notification: Data Updated in DB");
        }


        public void LogData(string sLog)
        {
            Console.WriteLine("Logged Data : {0}", sLog);
        }

        public string GetData(string sData)
        {
            return "Output Data";
        }
    }

    
    

}
