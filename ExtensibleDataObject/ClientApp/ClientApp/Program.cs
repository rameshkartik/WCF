using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.ServiceReferenceObject;
using System.ServiceModel;
namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
                LibraryClient cl = new LibraryClient();
                Patient p = new Patient();
                p.ID = 1;
                p.Name = "Rameshkartik";
                Console.WriteLine("Sending input to Service..");
                Patient pOut =cl.PatientDetails(p);
                Console.WriteLine("Output Data");
                Console.WriteLine("ID : " + pOut.ID.ToString());
                Console.WriteLine("Name : " + pOut.Name);
                Console.ReadLine();
        }
    }
}


