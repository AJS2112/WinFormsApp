﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.RepDashboardService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RepDashboard", Namespace="http://schemas.datacontract.org/2004/07/WCF.Entities")]
    [System.SerializableAttribute()]
    public partial class RepDashboard : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double cantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double entradaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double entrada_monedaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double salidaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double salida_monedaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double totalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double total_monedaField;
        
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
        public double cantidad {
            get {
                return this.cantidadField;
            }
            set {
                if ((this.cantidadField.Equals(value) != true)) {
                    this.cantidadField = value;
                    this.RaisePropertyChanged("cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double entrada {
            get {
                return this.entradaField;
            }
            set {
                if ((this.entradaField.Equals(value) != true)) {
                    this.entradaField = value;
                    this.RaisePropertyChanged("entrada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double entrada_moneda {
            get {
                return this.entrada_monedaField;
            }
            set {
                if ((this.entrada_monedaField.Equals(value) != true)) {
                    this.entrada_monedaField = value;
                    this.RaisePropertyChanged("entrada_moneda");
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
        public double salida {
            get {
                return this.salidaField;
            }
            set {
                if ((this.salidaField.Equals(value) != true)) {
                    this.salidaField = value;
                    this.RaisePropertyChanged("salida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double salida_moneda {
            get {
                return this.salida_monedaField;
            }
            set {
                if ((this.salida_monedaField.Equals(value) != true)) {
                    this.salida_monedaField = value;
                    this.RaisePropertyChanged("salida_moneda");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double total {
            get {
                return this.totalField;
            }
            set {
                if ((this.totalField.Equals(value) != true)) {
                    this.totalField = value;
                    this.RaisePropertyChanged("total");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double total_moneda {
            get {
                return this.total_monedaField;
            }
            set {
                if ((this.total_monedaField.Equals(value) != true)) {
                    this.total_monedaField = value;
                    this.RaisePropertyChanged("total_moneda");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RepDashboardService.IRepDashboard")]
    public interface IRepDashboard {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepDashboard/GetResumenCaja", ReplyAction="http://tempuri.org/IRepDashboard/GetResumenCajaResponse")]
        System.Collections.Generic.List<App.RepDashboardService.RepDashboard> GetResumenCaja(string idEmpresa, string desde, string hasta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepDashboard/GetResumenCaja", ReplyAction="http://tempuri.org/IRepDashboard/GetResumenCajaResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.RepDashboardService.RepDashboard>> GetResumenCajaAsync(string idEmpresa, string desde, string hasta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepDashboard/GetResumenGeneral", ReplyAction="http://tempuri.org/IRepDashboard/GetResumenGeneralResponse")]
        System.Collections.Generic.List<App.RepDashboardService.RepDashboard> GetResumenGeneral(string idEmpresa, string desde, string hasta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepDashboard/GetResumenGeneral", ReplyAction="http://tempuri.org/IRepDashboard/GetResumenGeneralResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<App.RepDashboardService.RepDashboard>> GetResumenGeneralAsync(string idEmpresa, string desde, string hasta);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRepDashboardChannel : App.RepDashboardService.IRepDashboard, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RepDashboardClient : System.ServiceModel.ClientBase<App.RepDashboardService.IRepDashboard>, App.RepDashboardService.IRepDashboard {
        
        public RepDashboardClient() {
        }
        
        public RepDashboardClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RepDashboardClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RepDashboardClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RepDashboardClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<App.RepDashboardService.RepDashboard> GetResumenCaja(string idEmpresa, string desde, string hasta) {
            return base.Channel.GetResumenCaja(idEmpresa, desde, hasta);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.RepDashboardService.RepDashboard>> GetResumenCajaAsync(string idEmpresa, string desde, string hasta) {
            return base.Channel.GetResumenCajaAsync(idEmpresa, desde, hasta);
        }
        
        public System.Collections.Generic.List<App.RepDashboardService.RepDashboard> GetResumenGeneral(string idEmpresa, string desde, string hasta) {
            return base.Channel.GetResumenGeneral(idEmpresa, desde, hasta);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<App.RepDashboardService.RepDashboard>> GetResumenGeneralAsync(string idEmpresa, string desde, string hasta) {
            return base.Channel.GetResumenGeneralAsync(idEmpresa, desde, hasta);
        }
    }
}
