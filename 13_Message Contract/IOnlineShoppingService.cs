using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.OnlineShoppingService.Contracts
{

    [ServiceContract(Namespace = "http://Rameshkartik/WCFSamples/OnlineShoppingService", Name = "OnlineShoppingService")]
    [ServiceKnownType(typeof(WholeSaleDealersInfoDetailed))]
    public interface IOnlineShoppingService
    {
        [OperationContract(Name = "StockAvailability")]
        bool IsStockAvailable(string sModelNumber);

        [OperationContract(Name = "CalculatePrice", ProtectionLevel = System.Net.Security.ProtectionLevel.None)]                                                         //add
        double CalculatePrice(string sModelNumber, int iQuantity, string sDeliveryLocation,int iDiscountAmount);

        [OperationContract(Name = "CheckDiscountAmount")]
        double CheckDiscountAmount(string sModelNumber, int iQuantity);                                                                        //remove

        [OperationContract(Name = "GetProductInformation")]
        string GetProductInformation(int iModelNumber);                                                                                                              // parameter data type change

        [OperationContract(Name = "GetProductsAvailableinStores")]
        string GetProductsAvailableinStores(int sModelNumber, int iQuantity, string sDeliveryLocation);                                                                  // return type change

        [OperationContract(Name = "CheckDiscountAmount_NewMethod")]
        double CheckDiscountAmount_NewMethod(int sModelNumber, int iQuantity, string sDeliveryLocation);                                                                 // new method

        [OperationContract(Name = "GetWholeSaleDealerInfo")]
        [ServiceKnownType(typeof(WholeSaleDealersInfoDetailed))]
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

        [DataMember(Name="LocationofDealer",Order=3,IsRequired = true)]
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

    [DataContract]
    public class WholeSaleDealersInfoDetailed:WholeSaleDealersInfo
    {
        private string sDealerName;
        private string sDealerLocation;
        private DateTime sDealerSince;
        private int iDealerAge;
        private string sDealerAddress;
        private int iDealerNumber;
        private string sDealerEmail;

        [DataMember]
        public string DealerName
        {
            get { return sDealerName; }
            set { sDealerName = value; }
        }

        [DataMember(Name = "LocationofDealer", Order = 3, IsRequired = true)]
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

        [DataMember]
        public int DealerAge
        {
            get { return iDealerAge; }
            set { iDealerAge = value; }
        }

        [DataMember]
        public string DealerAddress
        {
            get{ return sDealerAddress;}
            set{sDealerAddress = value;}
        }

        [DataMember]
        public int DealerNumber
        {
            get{return iDealerNumber;}
            set{iDealerNumber=value;}
        }

        [DataMember]
        public string DealerEmail
        {
            get { return sDealerEmail; }
            set { sDealerEmail = value; }
        }
    }



}
    
