using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.FaultContract
{
    [ServiceContract]
    public interface ILibrary
    {
        [OperationContract]
        [FaultContract(typeof(ValidateKeyValue))]
        bool Validate(string key,string value);
    }

    [DataContract]
    public class ValidateKeyValue
    {
        [DataMember]
        public bool Result { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
       
}
