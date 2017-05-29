using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections;
using Rameshkartik.WCFSamples.OnlineShoppingService.Contracts;

namespace Rameshkartik.WCFSamples.OnlineShoppingService.Implementation
{

    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class OnlineShoppingServiceImpl : IOnlineShoppingService
    {

        private int OrderID
        {
            get
            {
                return 0608;
            }
        }


        public OrderResponse GetOrderHistory(OrderRequest OrderReq)
        {

            if (OrderReq.OrderID.Equals(OrderID)) //In this example am just hardcoding the orderID,in real case
            {                                   //we should check with the DB.
                OrderResponse response = new OrderResponse();
                OrderInfo OI = new OrderInfo();
                OI.OrderId = OrderID;
                OI.OrderDate = DateTime.Now;
                OI.PaidByCard = true;
                OI.PurchasedProductName = "Barbie Doll";
                OI.Quality = 5;
                response.OrderInfoObject = OI;
                return response;
            }
            else
            {
                throw new FaultException<string>("Order Detail Not Found",new FaultReason("Order Detail Not Found"));
            }
        }
    }
}
