using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.SecuredMessageService.Contracts;

namespace Rameshkartik.WCFSamples.SecuredMessageService.Implementation
{
    public class SecuredMessageServiceImpl : ISecuredMessageService
    {
        public void SayHello(string value)
        {
            Console.WriteLine("Hello from " + value);
        }
    }
}
