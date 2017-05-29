using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Rameshkartik.WCFSamples.Routing.BackupService1Imp;
namespace PrimaryServiceHost
{
    class Program
    {
        static string address = string.Empty;

        static void Main(string[] args)
        {
            ServiceHost SH = new ServiceHost(typeof(Implementation));
            address = SH.BaseAddresses[0].ToString();
            SH.Opened += SH_Opened;
            SH.Closed += SH_Closed;
            SH.Open();
            Console.ReadLine();
        }

        static void SH_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Backup Service1 Down...");
        }

        static void SH_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("Backup Service1 Up at {0}", address);
        }
    }
}
