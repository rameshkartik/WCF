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
                        //Ideally the business logic should be written like fetching the data from the DB. Since we are not concerntrating much in these areas
                        // am giving a hard code values
                        WholeSaleDealersInfo wsDealerDetailed = new WholeSaleDealersInfo();
                        wsDealerDetailed.DealerName = "Rameshkartik";
                        wsDealerDetailed.DealerLocation = "Chennai";
                        wsDealerDetailed.DealerSince = DateTime.Now;
                        return wsDealerDetailed;
                  break;

                    return null;
            }

            return null;
        }

        

        public Toy GetToyInfo(string sToyName)
        {
            Toy T = new Toy();
            T.Name = "Barbie Doll";
            T.Price = 100;
            T.StockAvailableCount = 50;
            return T;   
        }
    }
}
