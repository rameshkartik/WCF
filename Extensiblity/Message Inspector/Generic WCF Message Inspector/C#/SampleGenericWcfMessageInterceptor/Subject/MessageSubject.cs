using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Dispatcher;
using System.Xml.Linq;
using System.Configuration;
using SampleGenericWcfMessageInterceptor.Interfaces;
using SampleGenericWcfMessageInterceptor.Configuration;

namespace SampleGenericWcfMessageInterceptor.Subject
{
    /// <summary>
    /// GIAMS Message Inspector Subject. Can attach observers at runtime or using config
    /// </summary>
    public class MessageSubject : IDispatchMessageInspector
    {
        List<IServiceMessageInterceptor> _observers = new List<IServiceMessageInterceptor>();
        static GenericMessageInterceptorRegistration _messageConfig = null;

        /// <summary>
        /// GAMessageSubject
        /// </summary>
        public MessageSubject(string contractName)
        {
            //Get observers from config file and attach
            foreach (GenericMessageInterceptorConfigurationElement element in MessageBehaviorConfig)
            {
                if (contractName == element.MessageInterceptorEndPointName)
                    Attach((IServiceMessageInterceptor)System.Activator.CreateInstance(Type.GetType(element.MessageInterceptor + "," + element.MessageInterceptorAssembly)));
            }
        }

        /// <summary>
        /// GAMessageBehaviorConfigurationCollection, Reads Config Section messageBehaviorRegistrationConfiguration
        /// </summary>
        protected static GenericMessageInterceptorConfigurationCollection MessageBehaviorConfig
        {
            get
            {
                if (_messageConfig == null)
                {
                    object configSec = ConfigurationManager.GetSection("MessageInterceptorRegistrationConfiguration");
                    if (configSec != null)
                    {
                        _messageConfig = configSec as GenericMessageInterceptorRegistration;
                    }
                }

                if (_messageConfig != null)
                    return _messageConfig.GenericMessageInterceptorConfigurationElements;
                return null;
            }
        }
        
        /// <summary>
        /// Attach Message Interceptor at Runtime
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(IServiceMessageInterceptor observer)
        {
            _observers.Add(observer);
        }

        /// <summary>
        /// Detach Message Interceptor at Runtime
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(IServiceMessageInterceptor observer)
        {
            _observers.Remove(observer);
        }

        /// <summary>
        /// Find Observers at Runtime
        /// </summary>
        /// <param name="t">Type of Observer</param>
        /// <returns>Message Observer</returns>
        public IServiceMessageInterceptor FindObserver(Type t)
        {
            foreach (IServiceMessageInterceptor msgObserver in _observers)
            {
                if (msgObserver.GetType() == t)
                {
                    return msgObserver;
                }
            }
            return null;
        }

        /// <summary>
        /// Message Inspector Recieve Request Event Handler
        /// </summary>
        /// <param name="request">Message Request</param>
        /// <param name="channel">WCF Channel</param>
        /// <param name="instanceContext">Context</param>
        /// <returns>Tag Object</returns>
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            XDocument xDoc = XDocument.Parse(request.ToString());
            foreach (IServiceMessageInterceptor msgObserver in _observers)
            {
                msgObserver.Receive(request, xDoc);
            }

            return null;
        }

        /// <summary>
        /// Message Inspector Respond Response Event Handler
        /// </summary>
        /// <param name="reply">SOAP Message</param>
        /// <param name="correlationState">Stat</param>
        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            XDocument xDoc = XDocument.Parse(reply.ToString());
            foreach (IServiceMessageInterceptor msgObserver in _observers)
            {
                msgObserver.Respond(reply, xDoc);
            }
        }

        /// <summary>
        /// Current Message Subject
        /// </summary>
        public static MessageSubject CurrentMessageContext
        {
            get
            {
                if (System.ServiceModel.OperationContext.Current != null)
                    foreach (IDispatchMessageInspector msgInspector in System.ServiceModel.OperationContext.Current.EndpointDispatcher.DispatchRuntime.MessageInspectors)
                    {
                        if (msgInspector.GetType() == typeof(MessageSubject))
                        {
                            return (MessageSubject)msgInspector;
                        }
                    }
                return null;
            }
        }
    }
}