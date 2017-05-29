using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using ClientApp.AuthorizationServiceReference;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EndpointAddress endpoint = new
                EndpointAddress(new Uri("http://localhost:8735/Rameshkartik/WCFSamples/AuthorizationService"), EndpointIdentity.CreateDnsIdentity("WCFServer"));
            WSHttpBinding binding = new WSHttpBinding();
            binding.Security.Mode = SecurityMode.Message;
            binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;

            AuthorizationServiceReference.AuthorizeClient ProxyRefrence = new AuthorizeClient(binding, endpoint);
            //ProxyRefrence.ClientCredentials.UserName.UserName = "Message";
            //ProxyRefrence.ClientCredentials.UserName.Password = "Security";
            
            ProxyRefrence.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            //ProxyRefrence.SayHello("Ramesh");
            Console.WriteLine("Message Sent");
            bool bTemp = ProxyRefrence.GetData(100, "Message");
            Console.WriteLine("Hi");
            
        }
    }
}
