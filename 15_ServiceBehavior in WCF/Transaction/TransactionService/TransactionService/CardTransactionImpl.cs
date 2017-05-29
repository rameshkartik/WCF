using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using Rameshkartik.WCFSamples.Transactions.Contracts;
namespace Rameshkartik.WCFSamples.Transactions.Implementation
{
    public class CardTransactionImpl : ICardTransactionService
    {
        Decimal dAmountAvailable = 5000;
        //[OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [OperationBehavior(TransactionScopeRequired = true)]
        public void DebitTheAmountFromAccount(int iCardNumber, decimal amtToBeDebited)
        {
            if (iCardNumber == 0608)
            {
                dAmountAvailable = dAmountAvailable - amtToBeDebited;
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("Card Transaction Service ");
            Console.WriteLine("------------------------");
            Console.WriteLine("Amount Balance :" +dAmountAvailable.ToString());
            Console.WriteLine("------------------------");
        }

      //  [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        [OperationBehavior(TransactionScopeRequired = true)]
        public void IsEligibletoBuy(decimal amtToBeDebited)
        {
            SqlConnection conn = new SqlConnection("Password=SF.Net2009;Persist Security Info=True;" +
            "User ID=euroNet.Net;Initial Catalog=onlinepurchase;Data Source=localhost");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into PurchaseToys values(2jj,5000,100)", conn);
            cmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            Console.WriteLine("CommandExecuted");
            TransactionInformation info = Transaction.Current.TransactionInformation;
            Console.WriteLine("Local Identifier" + info.LocalIdentifier);
        }
    }
}
