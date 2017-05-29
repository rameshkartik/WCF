using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
namespace Rameshkartik.WCFSamples.Authorization
{
    public class CustomUsernameValidator:UserNamePasswordValidator
    {

        public override void Validate(string userName, string password)
        {
            if (userName == "Ramesh" && password == "Kartik")
            {
                Console.WriteLine("Client Authenticated");
            }
            else
            {
                throw new SecurityTokenException("Username Password Mismatched");
            }
        }
    }
}
