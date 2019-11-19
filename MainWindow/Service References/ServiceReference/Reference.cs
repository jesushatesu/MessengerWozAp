﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainWindow.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService", CallbackContract=typeof(MainWindow.ServiceReference.IServiceCallback))]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Connect", ReplyAction="http://tempuri.org/IService/ConnectResponse")]
        string[] Connect(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Connect", ReplyAction="http://tempuri.org/IService/ConnectResponse")]
        System.Threading.Tasks.Task<string[]> ConnectAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Disconnect", ReplyAction="http://tempuri.org/IService/DisconnectResponse")]
        void Disconnect(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Disconnect", ReplyAction="http://tempuri.org/IService/DisconnectResponse")]
        System.Threading.Tasks.Task DisconnectAsync(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/SendMsg")]
        void SendMsg(string fromUserName, string toUserName, string msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/SendMsg")]
        System.Threading.Tasks.Task SendMsgAsync(string fromUserName, string toUserName, string msg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUnsentMsg", ReplyAction="http://tempuri.org/IService/GetUnsentMsgResponse")]
        string[] GetUnsentMsg(string userNameFrom, string userNameTo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetUnsentMsg", ReplyAction="http://tempuri.org/IService/GetUnsentMsgResponse")]
        System.Threading.Tasks.Task<string[]> GetUnsentMsgAsync(string userNameFrom, string userNameTo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/MsgCallback")]
        void MsgCallback(string fromUser, string msg);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/ConnectUserCallback")]
        void ConnectUserCallback(string userName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/DisconnectUserCallback")]
        void DisconnectUserCallback(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MainWindow.ServiceReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.DuplexClientBase<MainWindow.ServiceReference.IService>, MainWindow.ServiceReference.IService {
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string[] Connect(string userName) {
            return base.Channel.Connect(userName);
        }
        
        public System.Threading.Tasks.Task<string[]> ConnectAsync(string userName) {
            return base.Channel.ConnectAsync(userName);
        }
        
        public void Disconnect(string userName) {
            base.Channel.Disconnect(userName);
        }
        
        public System.Threading.Tasks.Task DisconnectAsync(string userName) {
            return base.Channel.DisconnectAsync(userName);
        }
        
        public void SendMsg(string fromUserName, string toUserName, string msg) {
            base.Channel.SendMsg(fromUserName, toUserName, msg);
        }
        
        public System.Threading.Tasks.Task SendMsgAsync(string fromUserName, string toUserName, string msg) {
            return base.Channel.SendMsgAsync(fromUserName, toUserName, msg);
        }
        
        public string[] GetUnsentMsg(string userNameFrom, string userNameTo) {
            return base.Channel.GetUnsentMsg(userNameFrom, userNameTo);
        }
        
        public System.Threading.Tasks.Task<string[]> GetUnsentMsgAsync(string userNameFrom, string userNameTo) {
            return base.Channel.GetUnsentMsgAsync(userNameFrom, userNameTo);
        }
    }
}
