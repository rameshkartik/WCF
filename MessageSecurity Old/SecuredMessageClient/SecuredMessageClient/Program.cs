using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecuredMessageClient.SecuredMessageServiceReference;

namespace Rameshkartik.WCFSamples.SecuredMessageService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SecuredMessageServiceClient ClientProxy = new SecuredMessageServiceClient();
                ClientProxy.ClientCredentials.UserName.UserName = "Ramesh";
                ClientProxy.ClientCredentials.UserName.Password = "kartik";
                ClientProxy.SaySecuredMessage("Rameshkartik");
                Console.WriteLine("Message Sent to SecuredMessage Service");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
