using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.FoodInventory;
namespace Rameshkartik.WCFSamples.FoodInventory 
{
    public class IFoodInventoryImpl : IFoodInventory
    {
        public string GetFoodInventoryData(string sFoodType)
        {
            return "100 numbers";
        }
    }
}
