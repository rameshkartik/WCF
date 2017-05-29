using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using Rameshkartik.WCFSamples.Security.Authorization;
namespace Rameshkartik.WCFSamples.Security.Authorization
{
    
    public class AuthorizeImpl : IAuthorize
    {
        //[PrincipalPermission(SecurityAction.Demand, Role = "Administrators")]
        public bool GetData(int iRecordNumber,string username)
        {
            Console.WriteLine("Service In");
            Console.WriteLine(ServiceSecurityContext.Current.PrimaryIdentity.Name);
            if (ServiceSecurityContext.Current.PrimaryIdentity.Name == username)
            {
                string hostIdentity = WindowsIdentity.GetCurrent().Name;
                string primaryidentity = ServiceSecurityContext.Current.PrimaryIdentity.Name;
                string windowsIdentity = ServiceSecurityContext.Current.WindowsIdentity.Name;
                string threadIdentity = Thread.CurrentPrincipal.Identity.Name;

                Console.WriteLine("inside");
                if (Thread.CurrentPrincipal.IsInRole("administrators"))
                {
                    Console.WriteLine("Service adMIN");
                    if (iRecordNumber == 100)
                    {
                        Console.WriteLine("You are Authorized!! Please get in.");
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("Service adMIN false");
                    throw new SecurityException();
                }


            }
            return false;
        }
    }
}
