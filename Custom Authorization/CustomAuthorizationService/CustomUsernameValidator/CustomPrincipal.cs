using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using System.Threading;
namespace Rameshkartik.WCFSamples.Authorization
{
    public class CustomPrincipal:IPrincipal
    {
        IIdentity ClientIdentity;
        string[] roles;
        public CustomPrincipal(IIdentity id )
        {
            ClientIdentity = id;
        }
        
        public IIdentity Identity
        {
            get { return ClientIdentity; }
        }

        public static CustomPrincipal Current
        {
            get
            {
                return Thread.CurrentPrincipal as CustomPrincipal;
            }
        }

        public bool IsInRole(string role)
        {
            EnsureRoles();
            return roles.Contains(role);
        }

        protected virtual void EnsureRoles()
        {

            if (Identity.Name == "Ramesh")
            {
                roles = new string[1] { "ADMIN" };
            }
            else
                roles = new string[1] { "USER" };
     
        }

    }
}
