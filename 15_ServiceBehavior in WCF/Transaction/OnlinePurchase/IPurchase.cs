using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace Rameshkartik.WCFSamples.Transactions.Contracts
{
    [ServiceContract]
    public interface IPurchase
    {
        [OperationContract]
        decimal PurchaseToys(int iQty);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void UpdateStock(int iQty);
    }
    
}
