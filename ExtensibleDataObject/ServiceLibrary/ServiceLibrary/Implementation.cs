using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.ExtensibleDataObject;
namespace Rameshkartik.WCFSamples.ExtensibleDataObject
{
    public class Implementation : ILibrary,IExtensibleDataObject
    {

        public Patient PatientDetails(Patient P)
        {
            if (P.Name == "Rameshkartik")
            {
                P.Location = "Chennai";
            }
            return P;
        }

        public ExtensionDataObject ExtensionData
        {
            get;
            set;
        }
    }
}