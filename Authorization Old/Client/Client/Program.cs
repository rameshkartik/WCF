using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.AuthorizationServiceReference;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            AuthorizationServiceReference.AuthorizeClient cli = new AuthorizeClient();
            Console.WriteLine(cli.GetData(1040));
            Console.ReadKey();
        }
    }
}
