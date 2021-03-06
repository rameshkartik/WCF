﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.SecuredMessageServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SecuredMessageServiceReference.ISecuredMessageService")]
    public interface ISecuredMessageService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecuredMessageService/SayHello", ReplyAction="http://tempuri.org/ISecuredMessageService/SayHelloResponse")]
        void SayHello(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISecuredMessageService/SayHello", ReplyAction="http://tempuri.org/ISecuredMessageService/SayHelloResponse")]
        System.Threading.Tasks.Task SayHelloAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISecuredMessageServiceChannel : ClientApp.SecuredMessageServiceReference.ISecuredMessageService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SecuredMessageServiceClient : System.ServiceModel.ClientBase<ClientApp.SecuredMessageServiceReference.ISecuredMessageService>, ClientApp.SecuredMessageServiceReference.ISecuredMessageService {
        
        public SecuredMessageServiceClient() {
        }
        
        public SecuredMessageServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SecuredMessageServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecuredMessageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecuredMessageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SayHello(string value) {
            base.Channel.SayHello(value);
        }
        
        public System.Threading.Tasks.Task SayHelloAsync(string value) {
            return base.Channel.SayHelloAsync(value);
        }
    }
}
