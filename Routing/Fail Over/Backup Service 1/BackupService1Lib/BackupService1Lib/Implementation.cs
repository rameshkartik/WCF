using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.Routing.BackupService1Lib;
namespace Rameshkartik.WCFSamples.Routing.BackupService1Imp
{
    public class Implementation : IDataRequest
    {
        public string GetData(int value)
        {
            return string.Format("You are in Backup Service 1 and the Value You entered is: {0}", value);
        }

        
    }
}
