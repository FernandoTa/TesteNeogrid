﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.Service_api2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service_api2.IService_Api2")]
    public interface IService_Api2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Api2/calculaJuros", ReplyAction="http://tempuri.org/IService_Api2/calculaJurosResponse")]
        float calculaJuros();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Api2/calculaJuros", ReplyAction="http://tempuri.org/IService_Api2/calculaJurosResponse")]
        System.Threading.Tasks.Task<float> calculaJurosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Api2/showMeTheCode", ReplyAction="http://tempuri.org/IService_Api2/showMeTheCodeResponse")]
        string showMeTheCode();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Api2/showMeTheCode", ReplyAction="http://tempuri.org/IService_Api2/showMeTheCodeResponse")]
        System.Threading.Tasks.Task<string> showMeTheCodeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_Api2Channel : Client.Service_api2.IService_Api2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_Api2Client : System.ServiceModel.ClientBase<Client.Service_api2.IService_Api2>, Client.Service_api2.IService_Api2 {
        
        public Service_Api2Client() {
        }
        
        public Service_Api2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_Api2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_Api2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_Api2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float calculaJuros() {
            return base.Channel.calculaJuros();
        }
        
        public System.Threading.Tasks.Task<float> calculaJurosAsync() {
            return base.Channel.calculaJurosAsync();
        }
        
        public string showMeTheCode() {
            return base.Channel.showMeTheCode();
        }
        
        public System.Threading.Tasks.Task<string> showMeTheCodeAsync() {
            return base.Channel.showMeTheCodeAsync();
        }
    }
}
