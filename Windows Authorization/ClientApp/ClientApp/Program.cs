using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.SecuredMessageServiceReference;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.IdentityModel;
using System.IdentityModel.Selectors;
namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EndpointAddress endpoint = new EndpointAddress("http://localhost:8735/Rameshkartik/WCFSamples/SecuredMessageService");
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
            SecuredMessageServiceClient ProxyRefrence = new SecuredMessageServiceClient(binding, endpoint);
            ProxyRefrence.Open();
            System.AppDomain.CurrentDomain.SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy.WindowsPrincipal);
            ProxyRefrence.SaySecuredMessage("Ramesh");
            Console.WriteLine("Message Sent");
            Console.ReadKey();
            ProxyRefrence.Close();
        }
    }
}
