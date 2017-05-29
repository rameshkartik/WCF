using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.MaterialsInventory;
namespace Rameshkartik.WCFSamples.MaterialsInventory
{
    public class MaterialInventoryImpl : IMaterialInventoryLib
    {
        public string GetMaterialInventoryData(string Type)
        {
            return "200 numbers";
        }
    }
}
