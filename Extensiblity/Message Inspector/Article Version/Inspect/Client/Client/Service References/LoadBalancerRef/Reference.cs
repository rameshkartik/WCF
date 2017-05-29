﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.LoadBalancerRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoadBalancerRef.IRailServices")]
    public interface IRailServices {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iPNRQueries/GetPNRQuery", ReplyAction="http://tempuri.org/iPNRQueries/GetPNRQueryResponse")]
        string GetPNRQuery(string qury);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iPNRQueries/GetPNRQuery", ReplyAction="http://tempuri.org/iPNRQueries/GetPNRQueryResponse")]
        System.Threading.Tasks.Task<string> GetPNRQueryAsync(string qury);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iSeatBook/BookTicket", ReplyAction="http://tempuri.org/iSeatBook/BookTicketResponse")]
        string BookTicket(int NoOfSeats);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iSeatBook/BookTicket", ReplyAction="http://tempuri.org/iSeatBook/BookTicketResponse")]
        System.Threading.Tasks.Task<string> BookTicketAsync(int NoOfSeats);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRailServicesChannel : Client.LoadBalancerRef.IRailServices, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RailServicesClient : System.ServiceModel.ClientBase<Client.LoadBalancerRef.IRailServices>, Client.LoadBalancerRef.IRailServices {
        
        public RailServicesClient() {
        }
        
        public RailServicesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RailServicesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RailServicesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RailServicesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPNRQuery(string qury) {
            return base.Channel.GetPNRQuery(qury);
        }
        
        public System.Threading.Tasks.Task<string> GetPNRQueryAsync(string qury) {
            return base.Channel.GetPNRQueryAsync(qury);
        }
        
        public string BookTicket(int NoOfSeats) {
            return base.Channel.BookTicket(NoOfSeats);
        }
        
        public System.Threading.Tasks.Task<string> BookTicketAsync(int NoOfSeats) {
            return base.Channel.BookTicketAsync(NoOfSeats);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoadBalancerRef.iPNRQueries")]
    public interface iPNRQueries {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iPNRQueries/GetPNRQuery", ReplyAction="http://tempuri.org/iPNRQueries/GetPNRQueryResponse")]
        string GetPNRQuery(string qury);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iPNRQueries/GetPNRQuery", ReplyAction="http://tempuri.org/iPNRQueries/GetPNRQueryResponse")]
        System.Threading.Tasks.Task<string> GetPNRQueryAsync(string qury);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface iPNRQueriesChannel : Client.LoadBalancerRef.iPNRQueries, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class iPNRQueriesClient : System.ServiceModel.ClientBase<Client.LoadBalancerRef.iPNRQueries>, Client.LoadBalancerRef.iPNRQueries {
        
        public iPNRQueriesClient() {
        }
        
        public iPNRQueriesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public iPNRQueriesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public iPNRQueriesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public iPNRQueriesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetPNRQuery(string qury) {
            return base.Channel.GetPNRQuery(qury);
        }
        
        public System.Threading.Tasks.Task<string> GetPNRQueryAsync(string qury) {
            return base.Channel.GetPNRQueryAsync(qury);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoadBalancerRef.iSeatBook")]
    public interface iSeatBook {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iSeatBook/BookTicket", ReplyAction="http://tempuri.org/iSeatBook/BookTicketResponse")]
        string BookTicket(int NoOfSeats);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/iSeatBook/BookTicket", ReplyAction="http://tempuri.org/iSeatBook/BookTicketResponse")]
        System.Threading.Tasks.Task<string> BookTicketAsync(int NoOfSeats);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface iSeatBookChannel : Client.LoadBalancerRef.iSeatBook, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class iSeatBookClient : System.ServiceModel.ClientBase<Client.LoadBalancerRef.iSeatBook>, Client.LoadBalancerRef.iSeatBook {
        
        public iSeatBookClient() {
        }
        
        public iSeatBookClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public iSeatBookClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public iSeatBookClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public iSeatBookClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string BookTicket(int NoOfSeats) {
            return base.Channel.BookTicket(NoOfSeats);
        }
        
        public System.Threading.Tasks.Task<string> BookTicketAsync(int NoOfSeats) {
            return base.Channel.BookTicketAsync(NoOfSeats);
        }
    }
}
