using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rameshkartik.WCFSamples.Authorization;
using System.Security.Principal;
using System.Security.Permissions;
using System.Threading;
namespace Rameshkartik.WCFSamples.Authorization
{
    [PrincipalPermission(SecurityAction.Demand, Role = "ADMIN")]
    public class CustomAuthorizationImpl : iCustomAuthorizationService
    {
        public void PushDataIntoServer(string value)
        {
            try
            {
                string hostIdentity = WindowsIdentity.GetCurrent().Name;
                string primaryidentity = ServiceSecurityContext.Current.PrimaryIdentity.Name;
                string windowsIdentity = ServiceSecurityContext.Current.WindowsIdentity.Name;
                string threadIdentity = Thread.CurrentPrincipal.Identity.Name;
                Console.WriteLine("Hello, Information from client" + value);

                Console.WriteLine("hostIdentity" + hostIdentity);
                Console.WriteLine("primaryidentity" + primaryidentity);
                Console.WriteLine("windowsIdentity" + windowsIdentity);
                Console.WriteLine("threadIdentity" + threadIdentity);
            }
            catch (Exception exp)
            {
                MyServiceFaults theFault = new MyServiceFaults();
                theFault.ErrMessage = "Some Error " + exp.Message.ToString();
                throw new FaultException<MyServiceFaults>(theFault);
            }
        }
    }
}
