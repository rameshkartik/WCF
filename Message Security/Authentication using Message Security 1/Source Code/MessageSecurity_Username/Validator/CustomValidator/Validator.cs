using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
namespace Rameshkartik.WCFSamples.SecuredMessageService.Validator
{
    public class CustomUsernamePwdValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == "Message" && password == "Security")
            {
                Console.WriteLine("Client Authenticated");
            }
            else
                throw new SecurityTokenException("Username Password Mismatched");
        }
    }
}
