﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoAsyncSis.DemoWeb.TempWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UF", Namespace="http://schemas.datacontract.org/2004/07/DemoAsyncSis.TemperaturaWS")]
    public enum UF : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SP = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        RJ = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MG = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AM = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Temperatura", Namespace="http://schemas.datacontract.org/2004/07/DemoAsyncSis.TemperaturaWS")]
    [System.SerializableAttribute()]
    public partial class Temperatura : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double TempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemoAsyncSis.DemoWeb.TempWS.UF UFField;
        
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
        public double Temp {
            get {
                return this.TempField;
            }
            set {
                if ((this.TempField.Equals(value) != true)) {
                    this.TempField = value;
                    this.RaisePropertyChanged("Temp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DemoAsyncSis.DemoWeb.TempWS.UF UF {
            get {
                return this.UFField;
            }
            set {
                if ((this.UFField.Equals(value) != true)) {
                    this.UFField = value;
                    this.RaisePropertyChanged("UF");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TempWS.ITempService")]
    public interface ITempService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempService/ObterTemperatura", ReplyAction="http://tempuri.org/ITempService/ObterTemperaturaResponse")]
        DemoAsyncSis.DemoWeb.TempWS.Temperatura ObterTemperatura(DemoAsyncSis.DemoWeb.TempWS.UF uf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITempService/ObterTemperatura", ReplyAction="http://tempuri.org/ITempService/ObterTemperaturaResponse")]
        System.Threading.Tasks.Task<DemoAsyncSis.DemoWeb.TempWS.Temperatura> ObterTemperaturaAsync(DemoAsyncSis.DemoWeb.TempWS.UF uf);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITempServiceChannel : DemoAsyncSis.DemoWeb.TempWS.ITempService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TempServiceClient : System.ServiceModel.ClientBase<DemoAsyncSis.DemoWeb.TempWS.ITempService>, DemoAsyncSis.DemoWeb.TempWS.ITempService {
        
        public TempServiceClient() {
        }
        
        public TempServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TempServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TempServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TempServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DemoAsyncSis.DemoWeb.TempWS.Temperatura ObterTemperatura(DemoAsyncSis.DemoWeb.TempWS.UF uf) {
            return base.Channel.ObterTemperatura(uf);
        }
        
        public System.Threading.Tasks.Task<DemoAsyncSis.DemoWeb.TempWS.Temperatura> ObterTemperaturaAsync(DemoAsyncSis.DemoWeb.TempWS.UF uf) {
            return base.Channel.ObterTemperaturaAsync(uf);
        }
    }
}
