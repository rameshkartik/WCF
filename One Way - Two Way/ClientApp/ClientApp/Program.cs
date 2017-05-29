using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ClientApp.ServiceReferenceObject;
namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibraryCallback CallBackObject = new CallBackHost();
            InstanceContext objContext = new InstanceContext(CallBackObject);
            LibraryClient cl = new LibraryClient(objContext);
            cl.UpdateData("Hi,Hello");
            Console.WriteLine("Message Sent to Client");
            Console.ReadKey();

            
            
        }
    }

    class CallBackHost :ILibraryCallback
    {
        public void CallBackFunction()
        {
            Console.WriteLine("Notification from Server");
        }
    }
    
    
}

