﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.CajOperacionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CajOperacion", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class CajOperacion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fecha_registroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_cotizacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_empresaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_estadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_statusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_tipo_operacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_usuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double montoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double monto_monedaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nro_controlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int order_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tipo_operacion_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usuario_nombreField;
        
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
        public string descripcion {
            get {
                return this.descripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.descripcionField, value) != true)) {
                    this.descripcionField = value;
                    this.RaisePropertyChanged("descripcion");
                }
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
        public int id_estado {
            get {
                return this.id_estadoField;
            }
            set {
                if ((this.id_estadoField.Equals(value) != true)) {
                    this.id_estadoField = value;
                    this.RaisePropertyChanged("id_estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_status {
            get {
                return this.id_statusField;
            }
            set {
                if ((this.id_statusField.Equals(value) != true)) {
                    this.id_statusField = value;
                    this.RaisePropertyChanged("id_status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_tipo_operacion {
            get {
                return this.id_tipo_operacionField;
            }
            set {
                if ((object.ReferenceEquals(this.id_tipo_operacionField, value) != true)) {
                    this.id_tipo_operacionField = value;
                    this.RaisePropertyChanged("id_tipo_operacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_usuario {
            get {
                return this.id_usuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.id_usuarioField, value) != true)) {
                    this.id_usuarioField = value;
                    this.RaisePropertyChanged("id_usuario");
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
        public double monto {
            get {
                return this.montoField;
            }
            set {
                if ((this.montoField.Equals(value) != true)) {
                    this.montoField = value;
                    this.RaisePropertyChanged("monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double monto_moneda {
            get {
                return this.monto_monedaField;
            }
            set {
                if ((this.monto_monedaField.Equals(value) != true)) {
                    this.monto_monedaField = value;
                    this.RaisePropertyChanged("monto_moneda");
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
        public string tipo_operacion_nombre {
            get {
                return this.tipo_operacion_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.tipo_operacion_nombreField, value) != true)) {
                    this.tipo_operacion_nombreField = value;
                    this.RaisePropertyChanged("tipo_operacion_nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string usuario_nombre {
            get {
                return this.usuario_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.usuario_nombreField, value) != true)) {
                    this.usuario_nombreField = value;
                    this.RaisePropertyChanged("usuario_nombre");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CajMovimiento", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class CajMovimiento : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string banco_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cuenta_bancoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cuenta_numeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double factorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_bancoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_cuentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_empresaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_instrumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_monedaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_operacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_tipo_operacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string instrumento_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string moneda_descripField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string moneda_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double montoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double monto_monedaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string numero_operacionField;
        
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
        public string cuenta_banco {
            get {
                return this.cuenta_bancoField;
            }
            set {
                if ((object.ReferenceEquals(this.cuenta_bancoField, value) != true)) {
                    this.cuenta_bancoField = value;
                    this.RaisePropertyChanged("cuenta_banco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string cuenta_numero {
            get {
                return this.cuenta_numeroField;
            }
            set {
                if ((object.ReferenceEquals(this.cuenta_numeroField, value) != true)) {
                    this.cuenta_numeroField = value;
                    this.RaisePropertyChanged("cuenta_numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double factor {
            get {
                return this.factorField;
            }
            set {
                if ((this.factorField.Equals(value) != true)) {
                    this.factorField = value;
                    this.RaisePropertyChanged("factor");
                }
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
        public string id_cuenta {
            get {
                return this.id_cuentaField;
            }
            set {
                if ((object.ReferenceEquals(this.id_cuentaField, value) != true)) {
                    this.id_cuentaField = value;
                    this.RaisePropertyChanged("id_cuenta");
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
        public string id_instrumento {
            get {
                return this.id_instrumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.id_instrumentoField, value) != true)) {
                    this.id_instrumentoField = value;
                    this.RaisePropertyChanged("id_instrumento");
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
        public string id_operacion {
            get {
                return this.id_operacionField;
            }
            set {
                if ((object.ReferenceEquals(this.id_operacionField, value) != true)) {
                    this.id_operacionField = value;
                    this.RaisePropertyChanged("id_operacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id_tipo_operacion {
            get {
                return this.id_tipo_operacionField;
            }
            set {
                if ((object.ReferenceEquals(this.id_tipo_operacionField, value) != true)) {
                    this.id_tipo_operacionField = value;
                    this.RaisePropertyChanged("id_tipo_operacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string instrumento_nombre {
            get {
                return this.instrumento_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.instrumento_nombreField, value) != true)) {
                    this.instrumento_nombreField = value;
                    this.RaisePropertyChanged("instrumento_nombre");
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
        public double monto {
            get {
                return this.montoField;
            }
            set {
                if ((this.montoField.Equals(value) != true)) {
                    this.montoField = value;
                    this.RaisePropertyChanged("monto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double monto_moneda {
            get {
                return this.monto_monedaField;
            }
            set {
                if ((this.monto_monedaField.Equals(value) != true)) {
                    this.monto_monedaField = value;
                    this.RaisePropertyChanged("monto_moneda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string numero_operacion {
            get {
                return this.numero_operacionField;
            }
            set {
                if ((object.ReferenceEquals(this.numero_operacionField, value) != true)) {
                    this.numero_operacionField = value;
                    this.RaisePropertyChanged("numero_operacion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CajOperacionService.ICajOperacion")]
    public interface ICajOperacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICajOperacion/GetList", ReplyAction="http://tempuri.org/ICajOperacion/GetListResponse")]
        System.Collections.Generic.List<App.CajOperacionService.CajOperacion> GetList(string idEmpresa, string idTipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICajOperacion/GetList", ReplyAction="http://tempuri.org/ICajOperacion/GetListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.CajOperacionService.CajOperacion>> GetListAsync(string idEmpresa, string idTipo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICajOperacion/GetOne", ReplyAction="http://tempuri.org/ICajOperacion/GetOneResponse")]
        App.CajOperacionService.CajOperacion GetOne(string idEmpresa, string idTipo, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICajOperacion/GetOne", ReplyAction="http://tempuri.org/ICajOperacion/GetOneResponse")]
        System.Threading.Tasks.Task<App.CajOperacionService.CajOperacion> GetOneAsync(string idEmpresa, string idTipo, string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICajOperacion/SetOne", ReplyAction="http://tempuri.org/ICajOperacion/SetOneResponse")]
        string SetOne(App.CajOperacionService.CajOperacion one, System.Collections.Generic.List<App.CajOperacionService.CajMovimiento> detail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICajOperacion/SetOne", ReplyAction="http://tempuri.org/ICajOperacion/SetOneResponse")]
        System.Threading.Tasks.Task<string> SetOneAsync(App.CajOperacionService.CajOperacion one, System.Collections.Generic.List<App.CajOperacionService.CajMovimiento> detail);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICajOperacion/NullOne", ReplyAction="http://tempuri.org/ICajOperacion/NullOneResponse")]
        string NullOne(App.CajOperacionService.CajOperacion one);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICajOperacion/NullOne", ReplyAction="http://tempuri.org/ICajOperacion/NullOneResponse")]
        System.Threading.Tasks.Task<string> NullOneAsync(App.CajOperacionService.CajOperacion one);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICajOperacionChannel : App.CajOperacionService.ICajOperacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CajOperacionClient : System.ServiceModel.ClientBase<App.CajOperacionService.ICajOperacion>, App.CajOperacionService.ICajOperacion {
        
        public CajOperacionClient() {
        }
        
        public CajOperacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CajOperacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CajOperacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CajOperacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.CajOperacionService.CajOperacion> GetList(string idEmpresa, string idTipo) {
            return base.Channel.GetList(idEmpresa, idTipo);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.CajOperacionService.CajOperacion>> GetListAsync(string idEmpresa, string idTipo) {
            return base.Channel.GetListAsync(idEmpresa, idTipo);
        }
        
        public App.CajOperacionService.CajOperacion GetOne(string idEmpresa, string idTipo, string id) {
            return base.Channel.GetOne(idEmpresa, idTipo, id);
        }
        
        public System.Threading.Tasks.Task<App.CajOperacionService.CajOperacion> GetOneAsync(string idEmpresa, string idTipo, string id) {
            return base.Channel.GetOneAsync(idEmpresa, idTipo, id);
        }
        
        public string SetOne(App.CajOperacionService.CajOperacion one, System.Collections.Generic.List<App.CajOperacionService.CajMovimiento> detail) {
            return base.Channel.SetOne(one, detail);
        }
        
        public System.Threading.Tasks.Task<string> SetOneAsync(App.CajOperacionService.CajOperacion one, System.Collections.Generic.List<App.CajOperacionService.CajMovimiento> detail) {
            return base.Channel.SetOneAsync(one, detail);
        }
        
        public string NullOne(App.CajOperacionService.CajOperacion one) {
            return base.Channel.NullOne(one);
        }
        
        public System.Threading.Tasks.Task<string> NullOneAsync(App.CajOperacionService.CajOperacion one) {
            return base.Channel.NullOneAsync(one);
        }
    }
}
