﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientHomeWork2.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IGetDisk")]
    public interface IGetDisk {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetDisk/GetDiskInfo", ReplyAction="http://tempuri.org/IGetDisk/GetDiskInfoResponse")]
        string[] GetDiskInfo(string path);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetDiskChannel : ClientHomeWork2.ServiceReference1.IGetDisk, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetDiskClient : System.ServiceModel.ClientBase<ClientHomeWork2.ServiceReference1.IGetDisk>, ClientHomeWork2.ServiceReference1.IGetDisk {
        
        public GetDiskClient() {
        }
        
        public GetDiskClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetDiskClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetDiskClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetDiskClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetDiskInfo(string path) {
            return base.Channel.GetDiskInfo(path);
        }
    }
}