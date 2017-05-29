using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.ExtensibleDataObject
{
    [ServiceContract]
    public interface ILibrary
    {
        [OperationContract]
        Patient PatientDetails(Patient P);
    }

    [DataContract]
    public class Patient
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Location { get; set; }
    }
       
}
