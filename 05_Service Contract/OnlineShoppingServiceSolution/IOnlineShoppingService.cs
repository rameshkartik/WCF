using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.OnlineShoppingService.Contracts
{

    [ServiceContract (Namespace = "http://Rameshkartik/WCFSamples/OnlineShoppingService", Name = "OnlineShoppingService")]
    public interface IOnlineShoppingService
    {
        [OperationContract(Name = "StockAvailability")]
        bool IsStockAvailable(string sModelNumber);

        [OperationContract(Name = "CalculatePrice", ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
        double CalculatePrice(string sModelNumber, int iQuantity, string sDeliveryLocation);


    }


}

