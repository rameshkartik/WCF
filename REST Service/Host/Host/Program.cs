using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Web;
using Rameshkartik.WCFSamples.REST;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri httpURL = new Uri("http://localhost:8735/MyService/BookService");
            WebServiceHost Host = new WebServiceHost(typeof(Rameshkartik.WCFSamples.REST.Implementation));
            Host.Open();
            foreach (ServiceEndpoint endpoint in Host.Description.Endpoints)
            {
                Console.WriteLine("Service Hosted at: " + endpoint.Address.ToString());
                
            }
            
            Console.WriteLine("Host Opened");
            Console.ReadLine();
            

        }
    }
}