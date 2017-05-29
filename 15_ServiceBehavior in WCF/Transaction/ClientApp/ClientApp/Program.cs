using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using ClientApp.OnlinePurchaseServiceReference;
using ClientApp.CardTransactionServiceReference;
namespace Rameshkartik.WCFSamples.Transactions.Client
{
    class Program
    {
        static void Main(string[] args)
        {
           

               using (TransactionScope ts = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    try
                    {
                        PurchaseClient PurchaseClientObject = new PurchaseClient();
                        decimal dTotalBillAmt = PurchaseClientObject.PurchaseToys(11);
                        CardTransactionServiceClient CardTransClientObject = new CardTransactionServiceClient();
                        TransactionInformation info = Transaction.Current.TransactionInformation;
                        Console.WriteLine("Local Identifier" + info.LocalIdentifier);
                        CardTransClientObject.IsEligibletoBuy(dTotalBillAmt);
                     

                        //if (!CardTransClientObject.IsEligibletoBuy(dTotalBillAmt))
                        //{
                        //    throw new Exception("Sorry!! Bill value exceeded your Account Balance");
                        //}
                     //   CardTransClientObject.DebitTheAmountFromAccount(0608, 1000);
                        //PurchaseClientObject.UpdateStock(2);
                        ts.Complete();
                        Console.ReadLine();
                    }
                    catch (Exception ex)
                    {
                        ts.Dispose();
                        Console.ReadLine();
                        //PurchaseClientObject.UpdateStock(2);
                    }

                }
        }
    }
}
