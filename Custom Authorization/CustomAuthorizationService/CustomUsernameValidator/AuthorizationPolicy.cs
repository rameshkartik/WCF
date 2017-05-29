using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Policy;
using System.IdentityModel.Claims;
using System.Security.Principal;

namespace Rameshkartik.WCFSamples.Authorization
{
    class AuthorizationPolicy:IAuthorizationPolicy
    {
        Guid _id = Guid.NewGuid();
        public bool Evaluate(EvaluationContext evaluationContext, ref object state)
        {
            Console.WriteLine("Inside Evaluation");
            IIdentity clientIdentity = GetClientIdentity(evaluationContext);
            evaluationContext.Properties["Principal"] = new CustomPrincipal(clientIdentity);
            return true;
        }


        private IIdentity GetClientIdentity(EvaluationContext ec)
        {
            Console.WriteLine("Fetching Identity");
            object obj;
            if(!ec.Properties.TryGetValue("Identities",out obj))
                throw new Exception("No Identities found");

            IList<IIdentity> identities = obj as IList<IIdentity>;
            if(identities == null || identities.Count <=0)
                throw new Exception("No Identity Found");

            return identities[0];
        }

        public System.IdentityModel.Claims.ClaimSet Issuer
        {
            get { return ClaimSet.System; }
        }

        public string Id
        {
            get { return _id.ToString(); }
        }
    }
}
