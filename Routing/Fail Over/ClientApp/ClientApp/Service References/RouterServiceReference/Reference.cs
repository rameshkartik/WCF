﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.RouterServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RouterServiceReference.IDataRequest")]
    public interface IDataRequest {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataRequest/GetData", ReplyAction="http://tempuri.org/IDataRequest/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataRequest/GetData", ReplyAction="http://tempuri.org/IDataRequest/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataRequestChannel : ClientApp.RouterServiceReference.IDataRequest, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataRequestClient : System.ServiceModel.ClientBase<ClientApp.RouterServiceReference.IDataRequest>, ClientApp.RouterServiceReference.IDataRequest {
        
        public DataRequestClient() {
        }
        
        public DataRequestClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataRequestClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataRequestClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataRequestClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
    }
}
