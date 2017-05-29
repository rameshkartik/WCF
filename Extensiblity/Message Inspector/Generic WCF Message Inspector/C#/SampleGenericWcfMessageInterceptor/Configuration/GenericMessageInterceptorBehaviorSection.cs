using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Configuration;
using SampleGenericWcfMessageInterceptor.Behaviour;

namespace SampleGenericWcfMessageInterceptor.Configuration
{
    public class GenericMessageInterceptorBehaviorSection : BehaviorExtensionElement
    {
        /// <summary>
        /// Creates MessageEndPointBehavior
        /// </summary>
        /// <returns></returns>
        protected override object CreateBehavior()
        {
            return new MessageEndPointBehavior();
        }

        /// <summary>
        /// BehaviorType : MessageEndPointBehavior
        /// </summary>
        public override Type BehaviorType
        {
            get { return typeof(MessageEndPointBehavior); }

        }
    }
}
