﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.SisImpuestoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SisImpuesto", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class SisImpuesto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string codigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_tipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int order_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double valorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string valor_displayField;
        
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
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                if ((object.ReferenceEquals(this.codigoField, value) != true)) {
                    this.codigoField = value;
                    this.RaisePropertyChanged("codigo");
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
        public string id_tipo {
            get {
                return this.id_tipoField;
            }
            set {
                if ((object.ReferenceEquals(this.id_tipoField, value) != true)) {
                    this.id_tipoField = value;
                    this.RaisePropertyChanged("id_tipo");
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
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double valor {
            get {
                return this.valorField;
            }
            set {
                if ((this.valorField.Equals(value) != true)) {
                    this.valorField = value;
                    this.RaisePropertyChanged("valor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string valor_display {
            get {
                return this.valor_displayField;
            }
            set {
                if ((object.ReferenceEquals(this.valor_displayField, value) != true)) {
                    this.valor_displayField = value;
                    this.RaisePropertyChanged("valor_display");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SisImpuestoService.ISisImpuesto")]
    public interface ISisImpuesto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisImpuesto/GetList", ReplyAction="http://tempuri.org/ISisImpuesto/GetListResponse")]
        System.Collections.Generic.List<App.SisImpuestoService.SisImpuesto> GetList(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisImpuesto/GetList", ReplyAction="http://tempuri.org/ISisImpuesto/GetListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.SisImpuestoService.SisImpuesto>> GetListAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISisImpuestoChannel : App.SisImpuestoService.ISisImpuesto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SisImpuestoClient : System.ServiceModel.ClientBase<App.SisImpuestoService.ISisImpuesto>, App.SisImpuestoService.ISisImpuesto {
        
        public SisImpuestoClient() {
        }
        
        public SisImpuestoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SisImpuestoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SisImpuestoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SisImpuestoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.SisImpuestoService.SisImpuesto> GetList(string id) {
            return base.Channel.GetList(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.SisImpuestoService.SisImpuesto>> GetListAsync(string id) {
            return base.Channel.GetListAsync(id);
        }
    }
}
