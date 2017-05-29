using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.CafeShopServiceReference;
using System.Threading;
using System.ServiceModel;
using System.Security;
using System.Security.Cryptography.X509Certificates;
namespace Client
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CallBackClient callBackobj = new CallBackClient();
            InstanceContext cntxt = new InstanceContext(callBackobj);
            CafeShopServiceClient clientproxy = new CafeShopServiceClient(cntxt);
            Random rd = new Random(5000);
            
            
            clientproxy.RegistermyCofeeShop("Cafe Centre " + rd.Next().ToString());
            for (int iCofee = 0; iCofee < 100; iCofee++)
            {
                clientproxy.SellCofee(1);
            }
            Console.ReadLine();
        }   

        /// <summary>
        /// 
        /// </summary>
   
    }

    public class CallBackClient : ICafeShopServiceCallback
    {

        public void OnCallBack(CurrentData latestData)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Cofee Shop Name :" + latestData.RegisterMyCofeeShop);
            Console.WriteLine("Number of Cofees Sold :" + latestData.CofeesSold.ToString());
            Console.WriteLine("Total Sales on Cofee Rs:" + latestData.TotalSaleonCofee.ToString());
            Console.WriteLine("Executed on :" + latestData.DateWhenExecuted.ToString());
            Console.WriteLine("Thread ID :" + latestData.ThreadID);
            Console.WriteLine("Instance Number :" + latestData.InstanceNumber.ToString());            
            Console.WriteLine("----------------------------------------------");
        }
    }

}

