﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.CnfCuentaBancariaService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CnfCuentaBancaria", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class CnfCuentaBancaria : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string banco_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_bancoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_empresaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string numeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int order_idField;
        
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
        public string banco_nombre {
            get {
                return this.banco_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.banco_nombreField, value) != true)) {
                    this.banco_nombreField = value;
                    this.RaisePropertyChanged("banco_nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                if ((object.ReferenceEquals(this.idField, value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_banco {
            get {
                return this.id_bancoField;
            }
            set {
                if ((object.ReferenceEquals(this.id_bancoField, value) != true)) {
                    this.id_bancoField = value;
                    this.RaisePropertyChanged("id_banco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_empresa {
            get {
                return this.id_empresaField;
            }
            set {
                if ((object.ReferenceEquals(this.id_empresaField, value) != true)) {
                    this.id_empresaField = value;
                    this.RaisePropertyChanged("id_empresa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int last_update {
            get {
                return this.last_updateField;
            }
            set {
                if ((this.last_updateField.Equals(value) != true)) {
                    this.last_updateField = value;
                    this.RaisePropertyChanged("last_update");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numero {
            get {
                return this.numeroField;
            }
            set {
                if ((object.ReferenceEquals(this.numeroField, value) != true)) {
                    this.numeroField = value;
                    this.RaisePropertyChanged("numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int order_id {
            get {
                return this.order_idField;
            }
            set {
                if ((this.order_idField.Equals(value) != true)) {
                    this.order_idField = value;
                    this.RaisePropertyChanged("order_id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CnfCuentaBancariaService.ICnfCuentaBancaria")]
    public interface ICnfCuentaBancaria {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCuentaBancaria/GetList", ReplyAction="http://tempuri.org/ICnfCuentaBancaria/GetListResponse")]
        System.Collections.Generic.List<App.CnfCuentaBancariaService.CnfCuentaBancaria> GetList(string idEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCuentaBancaria/GetList", ReplyAction="http://tempuri.org/ICnfCuentaBancaria/GetListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.CnfCuentaBancariaService.CnfCuentaBancaria>> GetListAsync(string idEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCuentaBancaria/GetOne", ReplyAction="http://tempuri.org/ICnfCuentaBancaria/GetOneResponse")]
        App.CnfCuentaBancariaService.CnfCuentaBancaria GetOne(string idEmpresa, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCuentaBancaria/GetOne", ReplyAction="http://tempuri.org/ICnfCuentaBancaria/GetOneResponse")]
        System.Threading.Tasks.Task<App.CnfCuentaBancariaService.CnfCuentaBancaria> GetOneAsync(string idEmpresa, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCuentaBancaria/SetOne", ReplyAction="http://tempuri.org/ICnfCuentaBancaria/SetOneResponse")]
        string SetOne(App.CnfCuentaBancariaService.CnfCuentaBancaria one);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCuentaBancaria/SetOne", ReplyAction="http://tempuri.org/ICnfCuentaBancaria/SetOneResponse")]
        System.Threading.Tasks.Task<string> SetOneAsync(App.CnfCuentaBancariaService.CnfCuentaBancaria one);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICnfCuentaBancariaChannel : App.CnfCuentaBancariaService.ICnfCuentaBancaria, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CnfCuentaBancariaClient : System.ServiceModel.ClientBase<App.CnfCuentaBancariaService.ICnfCuentaBancaria>, App.CnfCuentaBancariaService.ICnfCuentaBancaria {
        
        public CnfCuentaBancariaClient() {
        }
        
        public CnfCuentaBancariaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CnfCuentaBancariaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CnfCuentaBancariaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CnfCuentaBancariaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.CnfCuentaBancariaService.CnfCuentaBancaria> GetList(string idEmpresa) {
            return base.Channel.GetList(idEmpresa);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.CnfCuentaBancariaService.CnfCuentaBancaria>> GetListAsync(string idEmpresa) {
            return base.Channel.GetListAsync(idEmpresa);
        }
        
        public App.CnfCuentaBancariaService.CnfCuentaBancaria GetOne(string idEmpresa, string id) {
            return base.Channel.GetOne(idEmpresa, id);
        }
        
        public System.Threading.Tasks.Task<App.CnfCuentaBancariaService.CnfCuentaBancaria> GetOneAsync(string idEmpresa, string id) {
            return base.Channel.GetOneAsync(idEmpresa, id);
        }
        
        public string SetOne(App.CnfCuentaBancariaService.CnfCuentaBancaria one) {
            return base.Channel.SetOne(one);
        }
        
        public System.Threading.Tasks.Task<string> SetOneAsync(App.CnfCuentaBancariaService.CnfCuentaBancaria one) {
            return base.Channel.SetOneAsync(one);
        }
    }
}
