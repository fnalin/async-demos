﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoAsyncSis.DemoWeb.CensoWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UF", Namespace="http://schemas.datacontract.org/2004/07/DemoAsyncSis.CensoDemograficoWS")]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Populacao", Namespace="http://schemas.datacontract.org/2004/07/DemoAsyncSis.CensoDemograficoWS")]
    [System.SerializableAttribute()]
    public partial class Populacao : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QtdeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private DemoAsyncSis.DemoWeb.CensoWS.UF UFField;
        
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
        public int Qtde {
            get {
                return this.QtdeField;
            }
            set {
                if ((this.QtdeField.Equals(value) != true)) {
                    this.QtdeField = value;
                    this.RaisePropertyChanged("Qtde");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DemoAsyncSis.DemoWeb.CensoWS.UF UF {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CensoWS.ICensoDemograficoService")]
    public interface ICensoDemograficoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICensoDemograficoService/ObterTotalPopulacaoPorUF", ReplyAction="http://tempuri.org/ICensoDemograficoService/ObterTotalPopulacaoPorUFResponse")]
        DemoAsyncSis.DemoWeb.CensoWS.Populacao ObterTotalPopulacaoPorUF(DemoAsyncSis.DemoWeb.CensoWS.UF uf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICensoDemograficoService/ObterTotalPopulacaoPorUF", ReplyAction="http://tempuri.org/ICensoDemograficoService/ObterTotalPopulacaoPorUFResponse")]
        System.Threading.Tasks.Task<DemoAsyncSis.DemoWeb.CensoWS.Populacao> ObterTotalPopulacaoPorUFAsync(DemoAsyncSis.DemoWeb.CensoWS.UF uf);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICensoDemograficoServiceChannel : DemoAsyncSis.DemoWeb.CensoWS.ICensoDemograficoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CensoDemograficoServiceClient : System.ServiceModel.ClientBase<DemoAsyncSis.DemoWeb.CensoWS.ICensoDemograficoService>, DemoAsyncSis.DemoWeb.CensoWS.ICensoDemograficoService {
        
        public CensoDemograficoServiceClient() {
        }
        
        public CensoDemograficoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CensoDemograficoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CensoDemograficoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CensoDemograficoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DemoAsyncSis.DemoWeb.CensoWS.Populacao ObterTotalPopulacaoPorUF(DemoAsyncSis.DemoWeb.CensoWS.UF uf) {
            return base.Channel.ObterTotalPopulacaoPorUF(uf);
        }
        
        public System.Threading.Tasks.Task<DemoAsyncSis.DemoWeb.CensoWS.Populacao> ObterTotalPopulacaoPorUFAsync(DemoAsyncSis.DemoWeb.CensoWS.UF uf) {
            return base.Channel.ObterTotalPopulacaoPorUFAsync(uf);
        }
    }
}