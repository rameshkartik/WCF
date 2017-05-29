using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SampleGenericWcfMessageInterceptor.Configuration
{
    /// <summary>
    /// GAMessageBehaviorConfiguration Configuration Section
    /// </summary>
    public class GenericMessageInterceptorRegistration : ConfigurationSection
    {
        /// <summary>
        /// Collection Of Config Elements
        /// </summary>
        [ConfigurationProperty("GenericMessageInterceptorConfigurationElements", IsDefaultCollection = true)]
        public GenericMessageInterceptorConfigurationCollection GenericMessageInterceptorConfigurationElements
        {
            get { return (GenericMessageInterceptorConfigurationCollection)base["GenericMessageInterceptorConfigurationElements"]; }
        }
    }
}