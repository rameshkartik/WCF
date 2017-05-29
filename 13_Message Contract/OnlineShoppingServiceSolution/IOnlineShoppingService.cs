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
        [OperationContract(Name="GetOrderDetails")]
        [FaultContract(typeof(string))]
        OrderResponse GetOrderHistory(OrderRequest OrderReq);
    }

    [MessageContract(IsWrapped=false)]
    public class OrderRequest
    {
        private int iOrderID;

        [MessageHeader]
        public int OrderID
        {
            get { return iOrderID; }
            set { iOrderID = value; }
        }
    }

    [MessageContract(IsWrapped = false)]
    public class OrderResponse
    {
        private OrderInfo OrderInfoObj;

        [MessageBodyMember]
        public OrderInfo OrderInfoObject
        {
            get { return OrderInfoObj; }
            set { OrderInfoObj = value; }
        }
    }


    [DataContract]
    public class OrderInfo
    {
        private int iOrderId;
        private DateTime dOrderDate;
        private string sPurchasedProductName;
        private int iQuantity;
        private bool bDiscountAvailed;
        private bool bPaidByCard;

        [DataMember]
        public int OrderId
        {
            get { return iOrderId; }
            set { iOrderId = value; }
        }

        [DataMember]
        public DateTime OrderDate
        {
            get { return dOrderDate; }
            set { dOrderDate = value; }
        }

        [DataMember]
        public string PurchasedProductName
        {
            get { return sPurchasedProductName; }
            set { sPurchasedProductName = value; }
        }

        [DataMember]
        public int Quality
        {
            get { return iQuantity; }
            set { iQuantity = value; }
        }

        [DataMember]
        public bool DiscountAvailed
        {
            get { return bDiscountAvailed; }
            set { bDiscountAvailed = true; }
        }

        [DataMember]
        public bool PaidByCard
        {
            get { return bPaidByCard; }
            set { bPaidByCard = value; }
        }
    }



}
    
