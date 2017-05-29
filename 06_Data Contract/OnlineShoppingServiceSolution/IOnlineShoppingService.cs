using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.OnlineShoppingService.Contracts
{

    [ServiceContract(Namespace = "http://Rameshkartik/WCFSamples/OnlineShoppingService",
     Name = "OnlineShoppingService")]
    public interface IOnlineShoppingService
    {
        [OperationContract(Name = "StockAvailability")]
        bool IsStockAvailable(string sModelNumber);

        [OperationContract(Name = "CalculatePrice", 
         ProtectionLevel = System.Net.Security.ProtectionLevel.None)]
         double CalculatePrice(string sModelNumber, int iQuantity, string sDeliveryLocation);

        [OperationContract(Name = "GetWholeSaleDealerInfo")]
        WholeSaleDealersInfo GetwholeSaleDealerInfo(string sFilterByCity);

    }

    
    [DataContract]
    public class WholeSaleDealersInfo
    {
        private string sDealerName;
        private string sDealerLocation;
        private DateTime sDealerSince;
        private int iDealerAge;

        [DataMember]
        public string DealerName
        {
            get { return sDealerName; }
            set { sDealerName = value; }
        }

        [DataMember(Name="LocationofDealer",Order=3,IsRequired = true,EmitDefaultValue=true)]
        public string DealerLocation
        {
            get { return sDealerLocation; }
            set { sDealerLocation = value; }
        }

        [DataMember]
        public DateTime DealerSince
        {
            get { return sDealerSince; }
            set { sDealerSince = value; }
        }

        [IgnoreDataMember]
        public int DealerAge
        {
            get { return iDealerAge; }
            set { iDealerAge = value; }
        }

    }


}
    
