﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.ServiceReferenceObject {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
        "ary", ConfigurationName="ServiceReferenceObject.ILibrary", CallbackContract=typeof(ClientApp.ServiceReferenceObject.ILibraryCallback))]
    public interface ILibrary {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/UpdateData", ReplyAction="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/UpdateDataResponse")]
        void UpdateData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/UpdateData", ReplyAction="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/UpdateDataResponse")]
        System.Threading.Tasks.Task UpdateDataAsync(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/GetDetailedData", ReplyAction="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/GetDetailedDataResponse")]
        string GetDetailedData(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/GetDetailedData", ReplyAction="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/GetDetailedDataResponse")]
        System.Threading.Tasks.Task<string> GetDetailedDataAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryCallback {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/CallBackFunction", ReplyAction="http://localhost:8735/Rameshkartik/WCFSamples/MessageExchangePatterns/ServiceLibr" +
            "ary/ILibrary/CallBackFunctionResponse")]
        void CallBackFunction();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILibraryChannel : ClientApp.ServiceReferenceObject.ILibrary, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibraryClient : System.ServiceModel.DuplexClientBase<ClientApp.ServiceReferenceObject.ILibrary>, ClientApp.ServiceReferenceObject.ILibrary {
        
        public LibraryClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public LibraryClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public LibraryClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public LibraryClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void UpdateData(string value) {
            base.Channel.UpdateData(value);
        }
        
        public System.Threading.Tasks.Task UpdateDataAsync(string value) {
            return base.Channel.UpdateDataAsync(value);
        }
        
        public string GetDetailedData(string value) {
            return base.Channel.GetDetailedData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDetailedDataAsync(string value) {
            return base.Channel.GetDetailedDataAsync(value);
        }
    }
}