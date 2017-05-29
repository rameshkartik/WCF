using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IdentityModel.Selectors;
using Rameshkartik.WCFSamples.SecuredMessageService.Contracts;

namespace Rameshkartik.WCFSamples.SecuredMessageService.Implementation
{
    public class ISecuredMessageServiceImpl : ISecuredMessageService
    {
        public void SaySecuredMessage(string value)
        {
            Console.WriteLine("Hello from " +value);
        }
    }

    public class MyCustomUserNamePasswordValidator : UserNamePasswordValidator
    {
        public MyCustomUserNamePasswordValidator():base()
        {
        }

        public override void Validate(string userName, string password)
        {
            if (password == "kartik")
            {
                Console.WriteLine("Client Authenticated");

            }
            else
            {
                Console.WriteLine("Client Not Authenticated");
            }
        }
    }


}
