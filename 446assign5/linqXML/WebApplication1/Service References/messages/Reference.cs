﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.messages {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="messages.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sendMessage", ReplyAction="http://tempuri.org/IService1/sendMessageResponse")]
        void sendMessage(string message, string from, string to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/sendMessage", ReplyAction="http://tempuri.org/IService1/sendMessageResponse")]
        System.Threading.Tasks.Task sendMessageAsync(string message, string from, string to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/recieveMessage", ReplyAction="http://tempuri.org/IService1/recieveMessageResponse")]
        string[] recieveMessage(string recieverID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/recieveMessage", ReplyAction="http://tempuri.org/IService1/recieveMessageResponse")]
        System.Threading.Tasks.Task<string[]> recieveMessageAsync(string recieverID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WebApplication1.messages.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WebApplication1.messages.IService1>, WebApplication1.messages.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void sendMessage(string message, string from, string to) {
            base.Channel.sendMessage(message, from, to);
        }
        
        public System.Threading.Tasks.Task sendMessageAsync(string message, string from, string to) {
            return base.Channel.sendMessageAsync(message, from, to);
        }
        
        public string[] recieveMessage(string recieverID) {
            return base.Channel.recieveMessage(recieverID);
        }
        
        public System.Threading.Tasks.Task<string[]> recieveMessageAsync(string recieverID) {
            return base.Channel.recieveMessageAsync(recieverID);
        }
    }
}