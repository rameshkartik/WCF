using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client sClient = new ServiceReference1.Service1Client();
            Console.WriteLine(sClient.GetData("1234"));
            Console.ReadKey();
        }
    }
}
