﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.SisOperacionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SisOperacion", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class SisOperacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool es_autorizadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool es_derivadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool es_fiscalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool es_transporteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool es_visibleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_tipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombre_displayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int order_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string signo_cajaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string signo_inventarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipo_nombreField;
        
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
        public string descrip {
            get {
                return this.descripField;
            }
            set {
                if ((object.ReferenceEquals(this.descripField, value) != true)) {
                    this.descripField = value;
                    this.RaisePropertyChanged("descrip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool es_autorizado {
            get {
                return this.es_autorizadoField;
            }
            set {
                if ((this.es_autorizadoField.Equals(value) != true)) {
                    this.es_autorizadoField = value;
                    this.RaisePropertyChanged("es_autorizado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool es_derivado {
            get {
                return this.es_derivadoField;
            }
            set {
                if ((this.es_derivadoField.Equals(value) != true)) {
                    this.es_derivadoField = value;
                    this.RaisePropertyChanged("es_derivado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool es_fiscal {
            get {
                return this.es_fiscalField;
            }
            set {
                if ((this.es_fiscalField.Equals(value) != true)) {
                    this.es_fiscalField = value;
                    this.RaisePropertyChanged("es_fiscal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool es_transporte {
            get {
                return this.es_transporteField;
            }
            set {
                if ((this.es_transporteField.Equals(value) != true)) {
                    this.es_transporteField = value;
                    this.RaisePropertyChanged("es_transporte");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool es_visible {
            get {
                return this.es_visibleField;
            }
            set {
                if ((this.es_visibleField.Equals(value) != true)) {
                    this.es_visibleField = value;
                    this.RaisePropertyChanged("es_visible");
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
        public string nombre_display {
            get {
                return this.nombre_displayField;
            }
            set {
                if ((object.ReferenceEquals(this.nombre_displayField, value) != true)) {
                    this.nombre_displayField = value;
                    this.RaisePropertyChanged("nombre_display");
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
        public string signo_caja {
            get {
                return this.signo_cajaField;
            }
            set {
                if ((object.ReferenceEquals(this.signo_cajaField, value) != true)) {
                    this.signo_cajaField = value;
                    this.RaisePropertyChanged("signo_caja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string signo_inventario {
            get {
                return this.signo_inventarioField;
            }
            set {
                if ((object.ReferenceEquals(this.signo_inventarioField, value) != true)) {
                    this.signo_inventarioField = value;
                    this.RaisePropertyChanged("signo_inventario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tipo_nombre {
            get {
                return this.tipo_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.tipo_nombreField, value) != true)) {
                    this.tipo_nombreField = value;
                    this.RaisePropertyChanged("tipo_nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SisOperacionService.ISisOperacion")]
    public interface ISisOperacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisOperacion/GetList", ReplyAction="http://tempuri.org/ISisOperacion/GetListResponse")]
        System.Collections.Generic.List<App.SisOperacionService.SisOperacion> GetList(string idTipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisOperacion/GetList", ReplyAction="http://tempuri.org/ISisOperacion/GetListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.SisOperacionService.SisOperacion>> GetListAsync(string idTipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisOperacion/GetOne", ReplyAction="http://tempuri.org/ISisOperacion/GetOneResponse")]
        App.SisOperacionService.SisOperacion GetOne(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisOperacion/GetOne", ReplyAction="http://tempuri.org/ISisOperacion/GetOneResponse")]
        System.Threading.Tasks.Task<App.SisOperacionService.SisOperacion> GetOneAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisOperacion/SetOne", ReplyAction="http://tempuri.org/ISisOperacion/SetOneResponse")]
        string SetOne(App.SisOperacionService.SisOperacion one);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisOperacion/SetOne", ReplyAction="http://tempuri.org/ISisOperacion/SetOneResponse")]
        System.Threading.Tasks.Task<string> SetOneAsync(App.SisOperacionService.SisOperacion one);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISisOperacionChannel : App.SisOperacionService.ISisOperacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SisOperacionClient : System.ServiceModel.ClientBase<App.SisOperacionService.ISisOperacion>, App.SisOperacionService.ISisOperacion {
        
        public SisOperacionClient() {
        }
        
        public SisOperacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SisOperacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SisOperacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SisOperacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.SisOperacionService.SisOperacion> GetList(string idTipo) {
            return base.Channel.GetList(idTipo);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.SisOperacionService.SisOperacion>> GetListAsync(string idTipo) {
            return base.Channel.GetListAsync(idTipo);
        }
        
        public App.SisOperacionService.SisOperacion GetOne(string id) {
            return base.Channel.GetOne(id);
        }
        
        public System.Threading.Tasks.Task<App.SisOperacionService.SisOperacion> GetOneAsync(string id) {
            return base.Channel.GetOneAsync(id);
        }
        
        public string SetOne(App.SisOperacionService.SisOperacion one) {
            return base.Channel.SetOne(one);
        }
        
        public System.Threading.Tasks.Task<string> SetOneAsync(App.SisOperacionService.SisOperacion one) {
            return base.Channel.SetOneAsync(one);
        }
    }
}
