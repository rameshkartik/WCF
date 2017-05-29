using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.ServiceModel.Security;
using Client.CustomAuthorizationServiceReference;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomAuthorizationServiceReference.iCustomAuthorizationServiceClient ProxyRef = 
                new iCustomAuthorizationServiceClient();
            ProxyRef.ClientCredentials.UserName.UserName = "Ramesh";
            ProxyRef.ClientCredentials.UserName.Password = "Kartik";
            ProxyRef.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            ProxyRef.PushDataIntoServer("Hai from Client");
            Console.WriteLine("Message Sent");
            Console.ReadKey();
        }
    }
}
