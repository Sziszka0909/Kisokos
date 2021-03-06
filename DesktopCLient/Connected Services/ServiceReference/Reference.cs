﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopCLient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IMyService")]
    public interface IMyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Login", ReplyAction="http://tempuri.org/IMyService/LoginResponse")]
        bool Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Login", ReplyAction="http://tempuri.org/IMyService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Logout", ReplyAction="http://tempuri.org/IMyService/LogoutResponse")]
        void Logout(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/Logout", ReplyAction="http://tempuri.org/IMyService/LogoutResponse")]
        System.Threading.Tasks.Task LogoutAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/addContact", ReplyAction="http://tempuri.org/IMyService/addContactResponse")]
        string addContact(string username, string phonenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/addContact", ReplyAction="http://tempuri.org/IMyService/addContactResponse")]
        System.Threading.Tasks.Task<string> addContactAsync(string username, string phonenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/deleteContact", ReplyAction="http://tempuri.org/IMyService/deleteContactResponse")]
        string deleteContact(string username, string phonenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/deleteContact", ReplyAction="http://tempuri.org/IMyService/deleteContactResponse")]
        System.Threading.Tasks.Task<string> deleteContactAsync(string username, string phonenumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/showContact", ReplyAction="http://tempuri.org/IMyService/showContactResponse")]
        string[] showContact();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService/showContact", ReplyAction="http://tempuri.org/IMyService/showContactResponse")]
        System.Threading.Tasks.Task<string[]> showContactAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyServiceChannel : DesktopCLient.ServiceReference.IMyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<DesktopCLient.ServiceReference.IMyService>, DesktopCLient.ServiceReference.IMyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public void Logout(string username) {
            base.Channel.Logout(username);
        }
        
        public System.Threading.Tasks.Task LogoutAsync(string username) {
            return base.Channel.LogoutAsync(username);
        }
        
        public string addContact(string username, string phonenumber) {
            return base.Channel.addContact(username, phonenumber);
        }
        
        public System.Threading.Tasks.Task<string> addContactAsync(string username, string phonenumber) {
            return base.Channel.addContactAsync(username, phonenumber);
        }
        
        public string deleteContact(string username, string phonenumber) {
            return base.Channel.deleteContact(username, phonenumber);
        }
        
        public System.Threading.Tasks.Task<string> deleteContactAsync(string username, string phonenumber) {
            return base.Channel.deleteContactAsync(username, phonenumber);
        }
        
        public string[] showContact() {
            return base.Channel.showContact();
        }
        
        public System.Threading.Tasks.Task<string[]> showContactAsync() {
            return base.Channel.showContactAsync();
        }
    }
}
