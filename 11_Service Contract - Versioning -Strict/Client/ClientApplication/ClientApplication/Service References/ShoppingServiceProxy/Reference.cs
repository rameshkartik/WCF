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
    [System.Runtime.Serialization.DataContractAttribute(Name="WholeSaleDealersInfo", Namespace="http://schemas.datacontract.org/2004/07/Rameshkartik.WCFSamples.OnlineShoppingSer" +
        "vice.Contracts")]
    [System.SerializableAttribute()]
    public partial class WholeSaleDealersInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DealerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DealerSinceField;
        
        private string LocationofDealerField;
        
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
        public string DealerName {
            get {
                return this.DealerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DealerNameField, value) != true)) {
                    this.DealerNameField = value;
                    this.RaisePropertyChanged("DealerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DealerSince {
            get {
                return this.DealerSinceField;
            }
            set {
                if ((this.DealerSinceField.Equals(value) != true)) {
                    this.DealerSinceField = value;
                    this.RaisePropertyChanged("DealerSince");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string LocationofDealer {
            get {
                return this.LocationofDealerField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationofDealerField, value) != true)) {
                    this.LocationofDealerField = value;
                    this.RaisePropertyChanged("LocationofDealer");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Toy", Namespace="http://schemas.datacontract.org/2004/07/Rameshkartik.WCFSamples.OnlineShoppingSer" +
        "vice.Contracts")]
    [System.SerializableAttribute()]
    public partial class Toy : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockAvailableCountField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StockAvailableCount {
            get {
                return this.StockAvailableCountField;
            }
            set {
                if ((this.StockAvailableCountField.Equals(value) != true)) {
                    this.StockAvailableCountField = value;
                    this.RaisePropertyChanged("StockAvailableCount");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetWho" +
            "leSaleDealerInfo", ReplyAction="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetWho" +
            "leSaleDealerInfoResponse")]
        ClientApplication.ShoppingServiceProxy.WholeSaleDealersInfo GetWholeSaleDealerInfo(string sFilterByCity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetWho" +
            "leSaleDealerInfo", ReplyAction="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetWho" +
            "leSaleDealerInfoResponse")]
        System.Threading.Tasks.Task<ClientApplication.ShoppingServiceProxy.WholeSaleDealersInfo> GetWholeSaleDealerInfoAsync(string sFilterByCity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetToy" +
            "Info", ReplyAction="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetToy" +
            "InfoResponse")]
        ClientApplication.ShoppingServiceProxy.Toy GetToyInfo(string sToyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetToy" +
            "Info", ReplyAction="http://Rameshkartik/WCFSamples/OnlineShoppingService/OnlineShoppingService/GetToy" +
            "InfoResponse")]
        System.Threading.Tasks.Task<ClientApplication.ShoppingServiceProxy.Toy> GetToyInfoAsync(string sToyName);
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
        
        public ClientApplication.ShoppingServiceProxy.WholeSaleDealersInfo GetWholeSaleDealerInfo(string sFilterByCity) {
            return base.Channel.GetWholeSaleDealerInfo(sFilterByCity);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ShoppingServiceProxy.WholeSaleDealersInfo> GetWholeSaleDealerInfoAsync(string sFilterByCity) {
            return base.Channel.GetWholeSaleDealerInfoAsync(sFilterByCity);
        }
        
        public ClientApplication.ShoppingServiceProxy.Toy GetToyInfo(string sToyName) {
            return base.Channel.GetToyInfo(sToyName);
        }
        
        public System.Threading.Tasks.Task<ClientApplication.ShoppingServiceProxy.Toy> GetToyInfoAsync(string sToyName) {
            return base.Channel.GetToyInfoAsync(sToyName);
        }
    }
}
