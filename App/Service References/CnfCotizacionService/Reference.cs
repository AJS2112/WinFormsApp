﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.CnfCotizacionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CnfCotizacionDetalle", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class CnfCotizacionDetalle : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_cotizacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_monedaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string moneda_descripField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string moneda_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int order_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double valorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double valor_anteriorField;
        
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
        public string id_cotizacion {
            get {
                return this.id_cotizacionField;
            }
            set {
                if ((object.ReferenceEquals(this.id_cotizacionField, value) != true)) {
                    this.id_cotizacionField = value;
                    this.RaisePropertyChanged("id_cotizacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_moneda {
            get {
                return this.id_monedaField;
            }
            set {
                if ((object.ReferenceEquals(this.id_monedaField, value) != true)) {
                    this.id_monedaField = value;
                    this.RaisePropertyChanged("id_moneda");
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
        public string moneda_descrip {
            get {
                return this.moneda_descripField;
            }
            set {
                if ((object.ReferenceEquals(this.moneda_descripField, value) != true)) {
                    this.moneda_descripField = value;
                    this.RaisePropertyChanged("moneda_descrip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string moneda_nombre {
            get {
                return this.moneda_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.moneda_nombreField, value) != true)) {
                    this.moneda_nombreField = value;
                    this.RaisePropertyChanged("moneda_nombre");
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
        public double valor_anterior {
            get {
                return this.valor_anteriorField;
            }
            set {
                if ((this.valor_anteriorField.Equals(value) != true)) {
                    this.valor_anteriorField = value;
                    this.RaisePropertyChanged("valor_anterior");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CnfCotizacion", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class CnfCotizacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecha_registroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_empresaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nro_controlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string observacionField;
        
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
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime fecha_registro {
            get {
                return this.fecha_registroField;
            }
            set {
                if ((this.fecha_registroField.Equals(value) != true)) {
                    this.fecha_registroField = value;
                    this.RaisePropertyChanged("fecha_registro");
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
        public string nro_control {
            get {
                return this.nro_controlField;
            }
            set {
                if ((object.ReferenceEquals(this.nro_controlField, value) != true)) {
                    this.nro_controlField = value;
                    this.RaisePropertyChanged("nro_control");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numero {
            get {
                return this.numeroField;
            }
            set {
                if ((this.numeroField.Equals(value) != true)) {
                    this.numeroField = value;
                    this.RaisePropertyChanged("numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string observacion {
            get {
                return this.observacionField;
            }
            set {
                if ((object.ReferenceEquals(this.observacionField, value) != true)) {
                    this.observacionField = value;
                    this.RaisePropertyChanged("observacion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CnfCotizacionService.ICnfCotizacion")]
    public interface ICnfCotizacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/GetLast", ReplyAction="http://tempuri.org/ICnfCotizacion/GetLastResponse")]
        System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle> GetLast(string idEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/GetLast", ReplyAction="http://tempuri.org/ICnfCotizacion/GetLastResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle>> GetLastAsync(string idEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/GetList", ReplyAction="http://tempuri.org/ICnfCotizacion/GetListResponse")]
        System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacion> GetList(string idEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/GetList", ReplyAction="http://tempuri.org/ICnfCotizacion/GetListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacion>> GetListAsync(string idEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/GetOne", ReplyAction="http://tempuri.org/ICnfCotizacion/GetOneResponse")]
        App.CnfCotizacionService.CnfCotizacion GetOne(string idEmpresa, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/GetOne", ReplyAction="http://tempuri.org/ICnfCotizacion/GetOneResponse")]
        System.Threading.Tasks.Task<App.CnfCotizacionService.CnfCotizacion> GetOneAsync(string idEmpresa, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/GetListDetail", ReplyAction="http://tempuri.org/ICnfCotizacion/GetListDetailResponse")]
        System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle> GetListDetail(string idCotizacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/GetListDetail", ReplyAction="http://tempuri.org/ICnfCotizacion/GetListDetailResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle>> GetListDetailAsync(string idCotizacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/SetOne", ReplyAction="http://tempuri.org/ICnfCotizacion/SetOneResponse")]
        string SetOne(App.CnfCotizacionService.CnfCotizacion one, System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle> detail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICnfCotizacion/SetOne", ReplyAction="http://tempuri.org/ICnfCotizacion/SetOneResponse")]
        System.Threading.Tasks.Task<string> SetOneAsync(App.CnfCotizacionService.CnfCotizacion one, System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle> detail);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICnfCotizacionChannel : App.CnfCotizacionService.ICnfCotizacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CnfCotizacionClient : System.ServiceModel.ClientBase<App.CnfCotizacionService.ICnfCotizacion>, App.CnfCotizacionService.ICnfCotizacion {
        
        public CnfCotizacionClient() {
        }
        
        public CnfCotizacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CnfCotizacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CnfCotizacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CnfCotizacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle> GetLast(string idEmpresa) {
            return base.Channel.GetLast(idEmpresa);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle>> GetLastAsync(string idEmpresa) {
            return base.Channel.GetLastAsync(idEmpresa);
        }
        
        public System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacion> GetList(string idEmpresa) {
            return base.Channel.GetList(idEmpresa);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacion>> GetListAsync(string idEmpresa) {
            return base.Channel.GetListAsync(idEmpresa);
        }
        
        public App.CnfCotizacionService.CnfCotizacion GetOne(string idEmpresa, string id) {
            return base.Channel.GetOne(idEmpresa, id);
        }
        
        public System.Threading.Tasks.Task<App.CnfCotizacionService.CnfCotizacion> GetOneAsync(string idEmpresa, string id) {
            return base.Channel.GetOneAsync(idEmpresa, id);
        }
        
        public System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle> GetListDetail(string idCotizacion) {
            return base.Channel.GetListDetail(idCotizacion);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle>> GetListDetailAsync(string idCotizacion) {
            return base.Channel.GetListDetailAsync(idCotizacion);
        }
        
        public string SetOne(App.CnfCotizacionService.CnfCotizacion one, System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle> detail) {
            return base.Channel.SetOne(one, detail);
        }
        
        public System.Threading.Tasks.Task<string> SetOneAsync(App.CnfCotizacionService.CnfCotizacion one, System.Collections.Generic.List<App.CnfCotizacionService.CnfCotizacionDetalle> detail) {
            return base.Channel.SetOneAsync(one, detail);
        }
    }
}
