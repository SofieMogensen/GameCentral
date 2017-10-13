﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorageGUI.IGameCentralServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SoldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
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
        public double Price {
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
        public int Sold {
            get {
                return this.SoldField;
            }
            set {
                if ((this.SoldField.Equals(value) != true)) {
                    this.SoldField = value;
                    this.RaisePropertyChanged("Sold");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IGameCentralServiceReference1.IGameCentralServiceProduct")]
    public interface IGameCentralServiceProduct {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/Create", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/CreateResponse")]
        void Create(StorageGUI.IGameCentralServiceReference1.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/Create", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(StorageGUI.IGameCentralServiceReference1.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/Delete", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/Delete", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/Get", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/GetResponse")]
        StorageGUI.IGameCentralServiceReference1.Product Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/Get", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/GetResponse")]
        System.Threading.Tasks.Task<StorageGUI.IGameCentralServiceReference1.Product> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/GetAll", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/GetAllResponse")]
        System.Collections.Generic.List<StorageGUI.IGameCentralServiceReference1.Product> GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/GetAll", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/GetAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<StorageGUI.IGameCentralServiceReference1.Product>> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/Update", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/UpdateResponse")]
        void Update(StorageGUI.IGameCentralServiceReference1.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGameCentralServiceProduct/Update", ReplyAction="http://tempuri.org/IGameCentralServiceProduct/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(StorageGUI.IGameCentralServiceReference1.Product product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameCentralServiceProductChannel : StorageGUI.IGameCentralServiceReference1.IGameCentralServiceProduct, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameCentralServiceProductClient : System.ServiceModel.ClientBase<StorageGUI.IGameCentralServiceReference1.IGameCentralServiceProduct>, StorageGUI.IGameCentralServiceReference1.IGameCentralServiceProduct {
        
        public GameCentralServiceProductClient() {
        }
        
        public GameCentralServiceProductClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GameCentralServiceProductClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameCentralServiceProductClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GameCentralServiceProductClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Create(StorageGUI.IGameCentralServiceReference1.Product product) {
            base.Channel.Create(product);
        }
        
        public System.Threading.Tasks.Task CreateAsync(StorageGUI.IGameCentralServiceReference1.Product product) {
            return base.Channel.CreateAsync(product);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
        
        public StorageGUI.IGameCentralServiceReference1.Product Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<StorageGUI.IGameCentralServiceReference1.Product> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public System.Collections.Generic.List<StorageGUI.IGameCentralServiceReference1.Product> GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<StorageGUI.IGameCentralServiceReference1.Product>> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void Update(StorageGUI.IGameCentralServiceReference1.Product product) {
            base.Channel.Update(product);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(StorageGUI.IGameCentralServiceReference1.Product product) {
            return base.Channel.UpdateAsync(product);
        }
    }
}