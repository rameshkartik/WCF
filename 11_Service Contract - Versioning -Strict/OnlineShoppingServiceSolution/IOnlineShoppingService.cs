using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Collections;
using System.Text;

namespace Rameshkartik.WCFSamples.OnlineShoppingService.Contracts
{

    [ServiceContract(Namespace = "http://Rameshkartik/WCFSamples/OnlineShoppingService", Name = "OnlineShoppingService")]
    public interface IOnlineShoppingService
    {
        [OperationContract(Name = "GetWholeSaleDealerInfo")]
        WholeSaleDealersInfo GetwholeSaleDealerInfo(string sFilterByCity);
                         
    }

    [ServiceContract(Namespace = "http://Rameshkartik/WCFSamples/OnlineShoppingServiceExtended", Name = "OnlineShoppingServiceExtended")]
    public interface IOnlineShoppingServiceExtended:IOnlineShoppingService
    {
        [OperationContract(Name = "GetWholeSaleDealerInfoExtended")]
        WholeSaleDealersInfo GetwholeSaleDealerInfo(string sFilterByCity);

        [OperationContract(Name = "GetToyInfo")]
        Toy GetToyInfo(string sToyName);
    }


    [DataContract]
    public class Toy
    {
        private string sToyName;
        private int iToyPrice;
        private int iInStock;

        [DataMember]
        public string Name
        {
            get{ return sToyName;}
            set{ sToyName = value;}
        }

        [DataMember]
        public int Price
        {
            get{ return iToyPrice; }
            set { iToyPrice = value; }
        }

        [DataMember]
        public int StockAvailableCount
        {
            get{ return iInStock;}
            set{ iInStock = value; }
        }
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

    



}
    
