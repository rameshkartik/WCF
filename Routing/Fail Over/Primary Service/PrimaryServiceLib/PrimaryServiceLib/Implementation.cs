using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.Routing.PrimaryServiceLib;
namespace Rameshkartik.WCFSamples.Routing.PrimaryServiceImp
{
    public class Implementation : IDataRequest
    {
        public string GetData(int value)
        {
            return string.Format("You are in Primary Service and the Value You entered is: {0}", value);
        }

        
    }
}
