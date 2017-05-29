﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.CardTransactionServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CardTransactionServiceReference.ICardTransactionService")]
    public interface ICardTransactionService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardTransactionService/DebitTheAmountFromAccount", ReplyAction="http://tempuri.org/ICardTransactionService/DebitTheAmountFromAccountResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void DebitTheAmountFromAccount(int cardnumber, decimal amtToBeDebited);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardTransactionService/DebitTheAmountFromAccount", ReplyAction="http://tempuri.org/ICardTransactionService/DebitTheAmountFromAccountResponse")]
        System.Threading.Tasks.Task DebitTheAmountFromAccountAsync(int cardnumber, decimal amtToBeDebited);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardTransactionService/IsEligibletoBuy", ReplyAction="http://tempuri.org/ICardTransactionService/IsEligibletoBuyResponse")]
        [System.ServiceModel.TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption.Allowed)]
        void IsEligibletoBuy(decimal amtToBeDebited);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardTransactionService/IsEligibletoBuy", ReplyAction="http://tempuri.org/ICardTransactionService/IsEligibletoBuyResponse")]
        System.Threading.Tasks.Task IsEligibletoBuyAsync(decimal amtToBeDebited);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICardTransactionServiceChannel : ClientApp.CardTransactionServiceReference.ICardTransactionService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CardTransactionServiceClient : System.ServiceModel.ClientBase<ClientApp.CardTransactionServiceReference.ICardTransactionService>, ClientApp.CardTransactionServiceReference.ICardTransactionService {
        
        public CardTransactionServiceClient() {
        }
        
        public CardTransactionServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CardTransactionServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardTransactionServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardTransactionServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DebitTheAmountFromAccount(int cardnumber, decimal amtToBeDebited) {
            base.Channel.DebitTheAmountFromAccount(cardnumber, amtToBeDebited);
        }
        
        public System.Threading.Tasks.Task DebitTheAmountFromAccountAsync(int cardnumber, decimal amtToBeDebited) {
            return base.Channel.DebitTheAmountFromAccountAsync(cardnumber, amtToBeDebited);
        }
        
        public void IsEligibletoBuy(decimal amtToBeDebited) {
            base.Channel.IsEligibletoBuy(amtToBeDebited);
        }
        
        public System.Threading.Tasks.Task IsEligibletoBuyAsync(decimal amtToBeDebited) {
            return base.Channel.IsEligibletoBuyAsync(amtToBeDebited);
        }
    }
}