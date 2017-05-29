using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Transactions;
using Rameshkartik.WCFSamples.Transactions.Contracts;
namespace Rameshkartik.WCFSamples.Transactions.Implementation
{
    public class PurchaseImpl : IPurchase
    {
        private decimal dPricePerToy = 500;
        private int iToysAvailableinStock = 100;

        [OperationBehavior(TransactionScopeRequired=true,TransactionAutoComplete=true)]
        public decimal PurchaseToys(int iQty)
        {
            decimal dTotalPrice = iQty * dPricePerToy;
            iToysAvailableinStock = iToysAvailableinStock - iQty;
            Console.WriteLine("------------------------");
            Console.WriteLine("Online Purchase Service ");
            Console.WriteLine("------------------------");
            Console.WriteLine("Quantity :" +iQty.ToString());
            Console.WriteLine("Price/Toy :" + dPricePerToy.ToString());
            Console.WriteLine("TotalBill :" + dTotalPrice.ToString());
            Console.WriteLine("Stock Update :" + iToysAvailableinStock.ToString());
            Console.WriteLine("------------------------");
            SqlConnection conn = new SqlConnection("Password=SF.Net2009;Persist Security Info=True;" +
                 "User ID=euroNet.Net;Initial Catalog=onlinepurchase;Data Source=localhost");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into PurchaseToys values(2,5000,100)", conn);
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            Console.WriteLine("CommandExecuted");
            TransactionInformation info = Transaction.Current.TransactionInformation;
            Console.WriteLine("Local Identifier" + info.DistributedIdentifier.ToString());
            //UpdateDataInTable();
            return dTotalPrice;
        }


        public void UpdateStock(int iQty)
        {
            //iToysAvailableinStock = iToysAvailableinStock - iQty;
            Console.WriteLine("Stock Update :" + iToysAvailableinStock.ToString());

        }

      //  [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [OperationBehavior(TransactionScopeRequired = true)]
        private void UpdateDataInTable()
        {
            SqlConnection conn = new SqlConnection("Password=SF.Net2009;Persist Security Info=True;" +
                  "User ID=euroNet.Net;Initial Catalog=onlinepurchase;Data Source=localhost");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into PurchaseToys values(2,5000,100)",conn);
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            Console.WriteLine("CommandExecuted");

        }
    }
}
