using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.FaultContract;
namespace Rameshkartik.WCFSamples.FaultContract
{
    public class Implementation : ILibrary
    {
        public bool Validate(string key, string value)
        {
            if (key == string.Empty || value.StartsWith(key))
            {
                ValidateKeyValue FaultValidate = new ValidateKeyValue();
                FaultValidate.Result = false;
                FaultValidate.Message = "Key is Empty or The Value and Key should not be the same";
                FaultValidate.Description = "Invalid Input";
                throw new FaultException<ValidateKeyValue>(FaultValidate);

            }
            else
            {
                Console.WriteLine("Validated");
                return true;
            }
        }
    }
}