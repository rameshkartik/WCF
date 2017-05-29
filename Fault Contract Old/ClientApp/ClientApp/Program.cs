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
            try
            {
                LibraryClient cl = new LibraryClient();
                bool bValidate = cl.Validate("Ramesh", "RameshKartik");
                if (bValidate)
                {
                    Console.WriteLine("Key and Value are validate and approved");
                }
            }
            catch (FaultException<ValidateKeyValue> fault)
            {
                Console.WriteLine(fault.Detail.Message);
            }
            Console.ReadKey();
        }
    }
}

