using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.Transactions.Contracts
{
    [ServiceContract]
    public interface ICardTransactionService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void DebitTheAmountFromAccount(int cardnumber, decimal amtToBeDebited);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Allowed)]
        void IsEligibletoBuy(decimal amtToBeDebited);

    }

    
}
