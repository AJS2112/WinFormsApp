﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.SisUsuariosService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SisUsuarios", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class SisUsuarios : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cedulaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool empresa_inactivaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string empresa_nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool es_inactivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string id_empresaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private sbyte id_tipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int last_updateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lognameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string numeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int order_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string permisosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string telefonoField;
        
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
        public string cedula {
            get {
                return this.cedulaField;
            }
            set {
                if ((object.ReferenceEquals(this.cedulaField, value) != true)) {
                    this.cedulaField = value;
                    this.RaisePropertyChanged("cedula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool empresa_inactiva {
            get {
                return this.empresa_inactivaField;
            }
            set {
                if ((this.empresa_inactivaField.Equals(value) != true)) {
                    this.empresa_inactivaField = value;
                    this.RaisePropertyChanged("empresa_inactiva");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string empresa_nombre {
            get {
                return this.empresa_nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.empresa_nombreField, value) != true)) {
                    this.empresa_nombreField = value;
                    this.RaisePropertyChanged("empresa_nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool es_inactivo {
            get {
                return this.es_inactivoField;
            }
            set {
                if ((this.es_inactivoField.Equals(value) != true)) {
                    this.es_inactivoField = value;
                    this.RaisePropertyChanged("es_inactivo");
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
        public sbyte id_tipo {
            get {
                return this.id_tipoField;
            }
            set {
                if ((this.id_tipoField.Equals(value) != true)) {
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
        public string logname {
            get {
                return this.lognameField;
            }
            set {
                if ((object.ReferenceEquals(this.lognameField, value) != true)) {
                    this.lognameField = value;
                    this.RaisePropertyChanged("logname");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string pass {
            get {
                return this.passField;
            }
            set {
                if ((object.ReferenceEquals(this.passField, value) != true)) {
                    this.passField = value;
                    this.RaisePropertyChanged("pass");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string permisos {
            get {
                return this.permisosField;
            }
            set {
                if ((object.ReferenceEquals(this.permisosField, value) != true)) {
                    this.permisosField = value;
                    this.RaisePropertyChanged("permisos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string telefono {
            get {
                return this.telefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.telefonoField, value) != true)) {
                    this.telefonoField = value;
                    this.RaisePropertyChanged("telefono");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SisUsuariosService.ISisUsuarios")]
    public interface ISisUsuarios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisUsuarios/GetList", ReplyAction="http://tempuri.org/ISisUsuarios/GetListResponse")]
        System.Collections.Generic.List<App.SisUsuariosService.SisUsuarios> GetList(string idEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisUsuarios/GetList", ReplyAction="http://tempuri.org/ISisUsuarios/GetListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.SisUsuariosService.SisUsuarios>> GetListAsync(string idEmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisUsuarios/Login", ReplyAction="http://tempuri.org/ISisUsuarios/LoginResponse")]
        App.SisUsuariosService.SisUsuarios Login(string logname, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISisUsuarios/Login", ReplyAction="http://tempuri.org/ISisUsuarios/LoginResponse")]
        System.Threading.Tasks.Task<App.SisUsuariosService.SisUsuarios> LoginAsync(string logname, string pass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISisUsuariosChannel : App.SisUsuariosService.ISisUsuarios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SisUsuariosClient : System.ServiceModel.ClientBase<App.SisUsuariosService.ISisUsuarios>, App.SisUsuariosService.ISisUsuarios {
        
        public SisUsuariosClient() {
        }
        
        public SisUsuariosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SisUsuariosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SisUsuariosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SisUsuariosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.SisUsuariosService.SisUsuarios> GetList(string idEmpresa) {
            return base.Channel.GetList(idEmpresa);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.SisUsuariosService.SisUsuarios>> GetListAsync(string idEmpresa) {
            return base.Channel.GetListAsync(idEmpresa);
        }
        
        public App.SisUsuariosService.SisUsuarios Login(string logname, string pass) {
            return base.Channel.Login(logname, pass);
        }
        
        public System.Threading.Tasks.Task<App.SisUsuariosService.SisUsuarios> LoginAsync(string logname, string pass) {
            return base.Channel.LoginAsync(logname, pass);
        }
    }
}
