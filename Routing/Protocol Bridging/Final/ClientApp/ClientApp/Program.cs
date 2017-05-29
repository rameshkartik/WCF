using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.RouteReference;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            eStockClient stock_Clnt = new StockClient("NetTcpBinding_IStock");
            string address = stock_Clnt.Endpoint.Address.ToString();
            string stock = stock_Clnt.GetData(100);
            Console.WriteLine("Food Stock : {0} ", stock);
            Console.ReadLine();
        }
    }
}
