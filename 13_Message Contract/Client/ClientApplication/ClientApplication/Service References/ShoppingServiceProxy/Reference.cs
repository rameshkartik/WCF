﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApplication.ShoppingServiceProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderInfo", Namespace="http://schemas.datacontract.org/2004/07/Rameshkartik.WCFSamples.OnlineShoppingSer" +
        "vice.Contracts")]
    [System.SerializableAttribute()]
    public partial class OrderInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool DiscountAvailedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime OrderDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrderIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PaidByCardField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PurchasedProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QualityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool DiscountAvailed {
            get {
                return this.DiscountAvailedField;
            }
            set {
                if ((this.DiscountAvailedField.Equals(value) != true)) {
                    this.DiscountAvailedField = value;
                    this.RaisePropertyChanged("DiscountAvailed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime OrderDate {
            get {
                return this.OrderDateField;
            }
            set {
                if ((this.OrderDateField.Equals(value) != true)) {
                    this.OrderDateField = value;
                    this.RaisePropertyChanged("OrderDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OrderId {
            get {
                return this.OrderIdField;
            }
            set {
                if ((this.OrderIdField.Equals(value) != true)) {
                    this.OrderIdField = value;
                    this.RaisePropertyChanged("OrderId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PaidByCard {
            get {
                return this.PaidByCardField;
            }
            set {
                if ((this.PaidByCardField.Equals(value) != true)) {
                    this.PaidByCardField = value;
                    this.RaisePropertyChanged("PaidByCard");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PurchasedProductName {
            get {
                return this.PurchasedProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PurchasedProductNameField, value) != true)) {
                    this.PurchasedProductNameField = value;
                    this.RaisePropertyChanged("PurchasedProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quality {
            get {
                return this.QualityField;
            }
            set {
                if ((this.QualityField.Equals(value) != true)) {
                    this.QualityField = value;
                    this.RaisePropertyChanged("Quality");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Rameshkartik/WCFSamples/OnlineShoppingService", ConfigurationName="ShoppingServiceProxy.OnlineShoppingService")]
    public interface OnlineShoppingService {
        
        // CODEGEN: Generating message contract since the operation GetOrderDetails is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetOrd" +
            "erDetails", ReplyAction="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetOrd" +
            "erDetailsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetOrd" +
            "erDetailsStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        ClientApplication.ShoppingServiceProxy.OrderResponse GetOrderDetails(ClientApplication.ShoppingServiceProxy.OrderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetOrd" +
            "erDetails", ReplyAction="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetOrd" +
            "erDetailsResponse")]
        System.Threading.Tasks.Task<ClientApplication.ShoppingServiceProxy.OrderResponse> GetOrderDetailsAsync(ClientApplication.ShoppingServiceProxy.OrderRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OrderRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://Rameshkartik/WCFSamples/OnlineShoppingService")]
        public int OrderID;
        
        public OrderRequest() {
        }
        
        public OrderRequest(int OrderID) {
            this.OrderID = OrderID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OrderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Rameshkartik/WCFSamples/OnlineShoppingService", Order=0)]
        public ClientApplication.ShoppingServiceProxy.OrderInfo OrderInfoObject;
        
        public OrderResponse() {
        }
        
        public OrderResponse(ClientApplication.ShoppingServiceProxy.OrderInfo OrderInfoObject) {
            this.OrderInfoObject = OrderInfoObject;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface OnlineShoppingServiceChannel : ClientApplication.ShoppingServiceProxy.OnlineShoppingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OnlineShoppingServiceClient : System.ServiceModel.ClientBase<ClientApplication.ShoppingServiceProxy.OnlineShoppingService>, ClientApplication.ShoppingServiceProxy.OnlineShoppingService {
        
        public OnlineShoppingServiceClient() {
        }
        
        public OnlineShoppingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OnlineShoppingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OnlineShoppingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OnlineShoppingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApplication.ShoppingServiceProxy.OrderResponse ClientApplication.ShoppingServiceProxy.OnlineShoppingService.GetOrderDetails(ClientApplication.ShoppingServiceProxy.OrderRequest request) {
            return base.Channel.GetOrderDetails(request);
        }
        
        public ClientApplication.ShoppingServiceProxy.OrderInfo GetOrderDetails(int OrderID) {
            ClientApplication.ShoppingServiceProxy.OrderRequest inValue = new ClientApplication.ShoppingServiceProxy.OrderRequest();
            inValue.OrderID = OrderID;
            ClientApplication.ShoppingServiceProxy.OrderResponse retVal = ((ClientApplication.ShoppingServiceProxy.OnlineShoppingService)(this)).GetOrderDetails(inValue);
            return retVal.OrderInfoObject;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApplication.ShoppingServiceProxy.OrderResponse> ClientApplication.ShoppingServiceProxy.OnlineShoppingService.GetOrderDetailsAsync(ClientApplication.ShoppingServiceProxy.OrderRequest request) {
            return base.Channel.GetOrderDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ShoppingServiceProxy.OrderResponse> GetOrderDetailsAsync(int OrderID) {
            ClientApplication.ShoppingServiceProxy.OrderRequest inValue = new ClientApplication.ShoppingServiceProxy.OrderRequest();
            inValue.OrderID = OrderID;
            return ((ClientApplication.ShoppingServiceProxy.OnlineShoppingService)(this)).GetOrderDetailsAsync(inValue);
        }
    }
}