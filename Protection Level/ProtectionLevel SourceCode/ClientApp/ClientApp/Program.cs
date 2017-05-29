using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.ServiceReferenceObject;
namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryClient cl = new LibraryClient();
            Console.WriteLine(cl.GetStringData("100"));
            Console.WriteLine(cl.GetIntData(100));
            Console.ReadKey();
        }
    }
}

