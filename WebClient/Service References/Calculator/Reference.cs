﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36373
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.Calculator {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Request", Namespace="http://schemas.datacontract.org/2004/07/ContractDemo")]
    [System.SerializableAttribute()]
    public partial class Request : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Value1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Value2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebClient.Calculator.Operation operationField;
        
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
        public int Value1 {
            get {
                return this.Value1Field;
            }
            set {
                if ((this.Value1Field.Equals(value) != true)) {
                    this.Value1Field = value;
                    this.RaisePropertyChanged("Value1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Value2 {
            get {
                return this.Value2Field;
            }
            set {
                if ((this.Value2Field.Equals(value) != true)) {
                    this.Value2Field = value;
                    this.RaisePropertyChanged("Value2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebClient.Calculator.Operation operation {
            get {
                return this.operationField;
            }
            set {
                if ((this.operationField.Equals(value) != true)) {
                    this.operationField = value;
                    this.RaisePropertyChanged("operation");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Operation", Namespace="http://schemas.datacontract.org/2004/07/ContractDemo")]
    public enum Operation : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NONE = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ADD = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SUB = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        DIV = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MUL = 4,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/ContractDemo")]
    [System.SerializableAttribute()]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebClient.Calculator.Status statusField;
        
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
        public int Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebClient.Calculator.Status status {
            get {
                return this.statusField;
            }
            set {
                if ((this.statusField.Equals(value) != true)) {
                    this.statusField = value;
                    this.RaisePropertyChanged("status");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Status", Namespace="http://schemas.datacontract.org/2004/07/ContractDemo")]
    public enum Status : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SUCCESS = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FAILURE = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calculator.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Operation", ReplyAction="http://tempuri.org/ICalculator/OperationResponse")]
        WebClient.Calculator.Response Operation(WebClient.Calculator.Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Operation", ReplyAction="http://tempuri.org/ICalculator/OperationResponse")]
        System.Threading.Tasks.Task<WebClient.Calculator.Response> OperationAsync(WebClient.Calculator.Request request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : WebClient.Calculator.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<WebClient.Calculator.ICalculator>, WebClient.Calculator.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebClient.Calculator.Response Operation(WebClient.Calculator.Request request) {
            return base.Channel.Operation(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.Calculator.Response> OperationAsync(WebClient.Calculator.Request request) {
            return base.Channel.OperationAsync(request);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Calculator.ICooler")]
    public interface ICooler {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooler/CalculateCoolnes", ReplyAction="http://tempuri.org/ICooler/CalculateCoolnesResponse")]
        bool CalculateCoolnes(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICooler/CalculateCoolnes", ReplyAction="http://tempuri.org/ICooler/CalculateCoolnesResponse")]
        System.Threading.Tasks.Task<bool> CalculateCoolnesAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICoolerChannel : WebClient.Calculator.ICooler, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CoolerClient : System.ServiceModel.ClientBase<WebClient.Calculator.ICooler>, WebClient.Calculator.ICooler {
        
        public CoolerClient() {
        }
        
        public CoolerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CoolerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoolerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoolerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CalculateCoolnes(string name) {
            return base.Channel.CalculateCoolnes(name);
        }
        
        public System.Threading.Tasks.Task<bool> CalculateCoolnesAsync(string name) {
            return base.Channel.CalculateCoolnesAsync(name);
        }
    }
}