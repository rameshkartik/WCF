﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.CafeShopServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CurrentData", Namespace="http://schemas.datacontract.org/2004/07/Rameshkartik.WCFSamples.CafeShopService.C" +
        "ontracts")]
    [System.SerializableAttribute()]
    public partial class CurrentData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CofeesSoldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateWhenExecutedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InstanceNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegisterMyCofeeShopField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ThreadIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TotalSaleonCofeeField;
        
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
        public int CofeesSold {
            get {
                return this.CofeesSoldField;
            }
            set {
                if ((this.CofeesSoldField.Equals(value) != true)) {
                    this.CofeesSoldField = value;
                    this.RaisePropertyChanged("CofeesSold");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateWhenExecuted {
            get {
                return this.DateWhenExecutedField;
            }
            set {
                if ((this.DateWhenExecutedField.Equals(value) != true)) {
                    this.DateWhenExecutedField = value;
                    this.RaisePropertyChanged("DateWhenExecuted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InstanceNumber {
            get {
                return this.InstanceNumberField;
            }
            set {
                if ((this.InstanceNumberField.Equals(value) != true)) {
                    this.InstanceNumberField = value;
                    this.RaisePropertyChanged("InstanceNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegisterMyCofeeShop {
            get {
                return this.RegisterMyCofeeShopField;
            }
            set {
                if ((object.ReferenceEquals(this.RegisterMyCofeeShopField, value) != true)) {
                    this.RegisterMyCofeeShopField = value;
                    this.RaisePropertyChanged("RegisterMyCofeeShop");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ThreadID {
            get {
                return this.ThreadIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ThreadIDField, value) != true)) {
                    this.ThreadIDField = value;
                    this.RaisePropertyChanged("ThreadID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TotalSaleonCofee {
            get {
                return this.TotalSaleonCofeeField;
            }
            set {
                if ((this.TotalSaleonCofeeField.Equals(value) != true)) {
                    this.TotalSaleonCofeeField = value;
                    this.RaisePropertyChanged("TotalSaleonCofee");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService", ConfigurationName="CafeShopServiceReference.ICafeShopService", CallbackContract=typeof(Client.CafeShopServiceReference.ICafeShopServiceCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ICafeShopService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService/ICafeShopService/Se" +
            "llCofee")]
        void SellCofee(int quantity);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService/ICafeShopService/Se" +
            "llCofee")]
        System.Threading.Tasks.Task SellCofeeAsync(int quantity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService/ICafeShopService/Re" +
            "gistermyCofeeShop", ReplyAction="http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService/ICafeShopService/Re" +
            "gistermyCofeeShopResponse")]
        void RegistermyCofeeShop(string sCofeeShop);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService/ICafeShopService/Re" +
            "gistermyCofeeShop", ReplyAction="http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService/ICafeShopService/Re" +
            "gistermyCofeeShopResponse")]
        System.Threading.Tasks.Task RegistermyCofeeShopAsync(string sCofeeShop);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICafeShopServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://localhost:8733/Rameshkartik/WCFSamples/CafeShopService/ICafeShopService/On" +
            "CallBack")]
        void OnCallBack(Client.CafeShopServiceReference.CurrentData latestData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICafeShopServiceChannel : Client.CafeShopServiceReference.ICafeShopService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CafeShopServiceClient : System.ServiceModel.DuplexClientBase<Client.CafeShopServiceReference.ICafeShopService>, Client.CafeShopServiceReference.ICafeShopService {
        
        public CafeShopServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CafeShopServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CafeShopServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CafeShopServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CafeShopServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SellCofee(int quantity) {
            base.Channel.SellCofee(quantity);
        }
        
        public System.Threading.Tasks.Task SellCofeeAsync(int quantity) {
            return base.Channel.SellCofeeAsync(quantity);
        }
        
        public void RegistermyCofeeShop(string sCofeeShop) {
            base.Channel.RegistermyCofeeShop(sCofeeShop);
        }
        
        public System.Threading.Tasks.Task RegistermyCofeeShopAsync(string sCofeeShop) {
            return base.Channel.RegistermyCofeeShopAsync(sCofeeShop);
        }
    }
}