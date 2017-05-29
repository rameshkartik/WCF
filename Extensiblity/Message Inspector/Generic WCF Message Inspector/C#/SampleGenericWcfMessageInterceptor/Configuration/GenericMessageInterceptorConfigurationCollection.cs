using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SampleGenericWcfMessageInterceptor.Configuration
{
    /// <summary>
    /// GAMessageBehaviorConfigurationCollection Configuration Section Element Collection
    /// </summary>
    public class GenericMessageInterceptorConfigurationCollection : ConfigurationElementCollection
    {
        /// <summary>
        /// Provides new ConfigurationElement
        /// </summary>
        /// <returns>Configuration Element</returns>
        protected override ConfigurationElement CreateNewElement()
        {
            return new GenericMessageInterceptorConfigurationElement();
        }

        /// <summary>
        /// Returns Element Key
        /// </summary>
        /// <param name="element">Config Element</param>
        /// <returns>Element Key</returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((GenericMessageInterceptorConfigurationElement)element).MessageBehaviorIndex;
        }

        /// <summary>
        /// Element Name
        /// </summary>
        protected override string ElementName
        {
            get
            {
                return "GenericMessageInterceptorConfigurationElement";
            }
        }

        /// <summary>
        /// Configuration Collection Type
        /// </summary>
        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        /// <summary>
        /// Indexer to return Config Element
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public GenericMessageInterceptorConfigurationElement this[int index]
        {
            get { return this.BaseGet(index) as GenericMessageInterceptorConfigurationElement; }

            set
            {
                if (this.BaseGet(index) != null)
                {
                    this.BaseRemoveAt(index);

                }
                this.BaseAdd(index, value);
            }
        }

        /// <summary>
        /// Indexer To Return Config Element. Index Is the Key
        /// </summary>
        /// <param name="messageBehaviorIndex">Index</param>
        /// <returns>Config Element</returns>
        public new GenericMessageInterceptorConfigurationElement this[string messageBehaviorIndex]
        {
            get { return this.BaseGet(messageBehaviorIndex) as GenericMessageInterceptorConfigurationElement; }
        }
    }
}