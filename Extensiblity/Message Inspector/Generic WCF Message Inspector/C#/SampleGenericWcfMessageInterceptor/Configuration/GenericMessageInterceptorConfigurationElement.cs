using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SampleGenericWcfMessageInterceptor.Configuration
{
    /// <summary>
    /// GenericMessageInterceptorConfigurationElement Holds Information Related to MessageInterceptor Object
    /// </summary>
    public class GenericMessageInterceptorConfigurationElement : ConfigurationElement
    {
        /// <summary>
        /// Message Behavior Index
        /// </summary>
        [ConfigurationProperty("MessageInterceptorIndex", IsKey = true, IsRequired = true)]
        public string MessageBehaviorIndex
        {
            get { return (string)this["MessageInterceptorIndex"]; }
            set { this["MessageInterceptorIndex"] = value; }
        }

        /// <summary>
        /// Message Behavior Assembly
        /// </summary>
        [ConfigurationProperty("MessageInterceptorAssembly", IsKey = false, IsRequired = true)]
        public string MessageInterceptorAssembly
        {
            get { return (string)this["MessageInterceptorAssembly"]; }
            set { this["MessageInterceptorAssembly"] = value; }
        }

        /// <summary>
        /// Message Interceptor Class Name
        /// </summary>
        [ConfigurationProperty("MessageInterceptor", IsKey = false, IsRequired = true)]
        public string MessageInterceptor
        {
            get { return (string)this["MessageInterceptor"]; }
            set { this["MessageInterceptor"] = value; }
        }

        /// <summary>
        /// Message Interceptor Contract Name
        /// </summary>
        [ConfigurationProperty("MessageInterceptorEndPointName", IsKey = false, IsRequired = true)]
        public string MessageInterceptorEndPointName
        {
            get { return (string)this["MessageInterceptorEndPointName"]; }
            set { this["MessageInterceptorEndPointName"] = value; }
        }
    }
}
