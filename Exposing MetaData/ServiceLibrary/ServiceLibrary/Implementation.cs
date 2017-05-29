using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.ExposeMetaData;

namespace Rameshkartik.WCFSamples.ExposeMetaData        
{
    public class Implementation : ILibrary
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

    }
}
