﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RelationsClient.PMS_API {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PMS_API.IPMS_API")]
    public interface IPMS_API {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPMS_API/Ping", ReplyAction="http://tempuri.org/IPMS_API/PingResponse")]
        void Ping();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPMS_API/Ping", ReplyAction="http://tempuri.org/IPMS_API/PingResponse")]
        System.Threading.Tasks.Task PingAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPMS_APIChannel : RelationsClient.PMS_API.IPMS_API, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PMS_APIClient : System.ServiceModel.ClientBase<RelationsClient.PMS_API.IPMS_API>, RelationsClient.PMS_API.IPMS_API {
        
        public PMS_APIClient() {
        }
        
        public PMS_APIClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PMS_APIClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PMS_APIClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PMS_APIClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Ping() {
            base.Channel.Ping();
        }
        
        public System.Threading.Tasks.Task PingAsync() {
            return base.Channel.PingAsync();
        }
    }
}
