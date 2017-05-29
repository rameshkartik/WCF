﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IdentityModel.Selectors;
using System.Web;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;
using Rameshkartik.WCFSamples.SecuredMessageService.Contracts;


namespace Rameshkartik.WCFSamples.SecuredMessageService.Implementation
{
    //[PrincipalPermission(SecurityAction.Demand, Role="Kiruthika-PC\\Kiruthika")]
    public class ISecuredMessageServiceImpl : ISecuredMessageService
    {

        //System.Security.Principal.WindowsIdentity wi =  System.Security.Principal.WindowsIdentity.GetCurrent();
        //System.Security.Principal.WindowsPrincipal wp = new System.Security.Principal.WindowsPrincipal(wi);

        WindowsIdentity idty = WindowsIdentity.GetCurrent();
        //WindowsPrincipal prin = new WindowsPrincipal(idt


        string hostIdentity = WindowsIdentity.GetCurrent().Name;
        string primaryidentity = ServiceSecurityContext.Current.PrimaryIdentity.Name;
        string windowsIdentity = ServiceSecurityContext.Current.WindowsIdentity.Name;
        string threadIdentity = Thread.CurrentPrincipal.Identity.Name;

        
        
        public void SaySecuredMessage(string value)
        {
            Console.WriteLine("Hello from " +value);
            Console.WriteLine("Host Identity " + hostIdentity);
            Console.WriteLine("Primary Identity " + primaryidentity);
            Console.WriteLine("Thread Identity " + threadIdentity);

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
