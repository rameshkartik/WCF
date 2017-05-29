using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.OnlineShoppingService.Contracts;

namespace Rameshkartik.WCFSamples.OnlineShoppingService.Implementation
{

    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class OnlineShoppingServiceImpl : IOnlineShoppingService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sModelNumber"></param>
        /// <returns></returns>
        public bool IsStockAvailable(string sModelNumber)
        {
            switch (sModelNumber)
            {
                case "Toy_Age0-5":
                    // Business Logic can be written by checking the stock availablity from the DB. Since we are not
                    // going to concentrate too much in the business logic implementation, i just return True by concluding 
                    // the stock is available
                    return true;
                    break;
            }
            return false;

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sModelNumber"></param>
        /// <param name="iQuantity"></param>
        /// <param name="sDeliveryLocation"></param>
        /// <returns></returns>
        public double CalculatePrice(string sModelNumber, int iQuantity, string sDeliveryLocation, int iDiscountedAmount)
        {
            switch (sModelNumber)
            {
                case "Toy_Age0-5":

                    if (sDeliveryLocation.Equals("Chennai"))
                    {
                        return iQuantity * 350 + 200 - iDiscountedAmount;
                    }
                    break;
            }

            return 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sFilterByCity"></param>
        /// <returns></returns>
        public WholeSaleDealersInfo GetwholeSaleDealerInfo(string sFilterByCity)
        {
            switch (sFilterByCity)
            {
                case "Chennai":
                    if (sFilterByCity.Equals("Chennai"))
                    {
                        //Ideally the business logic should be written like fetching the data from the DB. Since we are not concerntrating much in these areas
                        // am giving a hard code values
                        WholeSaleDealersInfoDetailed wsDealerDetailed = new WholeSaleDealersInfoDetailed();
                        wsDealerDetailed.DealerName = "Rameshkartik";
                        wsDealerDetailed.DealerLocation = "Chennai";
                        wsDealerDetailed.DealerSince = DateTime.Now;
                        wsDealerDetailed.DealerEmail = "rameshkartik@gmail.com";
                        wsDealerDetailed.DealerAddress = "North Street,Chennai";
                        return wsDealerDetailed;
                    }
                    break;

                    return null;
            }

            return null;
        }
    }
}
