﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IConvertedUnits")]
    public interface IConvertedUnits {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConvertedUnits/LinearMeasure", ReplyAction="http://tempuri.org/IConvertedUnits/LinearMeasureResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="inch")]
        double LinearMeasure(out double foot, out double yard, double meters);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConvertedUnits/CelsiusToFahrenheit", ReplyAction="http://tempuri.org/IConvertedUnits/CelsiusToFahrenheitResponse")]
        double CelsiusToFahrenheit(double c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConvertedUnits/FahrenheitToCelsius", ReplyAction="http://tempuri.org/IConvertedUnits/FahrenheitToCelsiusResponse")]
        double FahrenheitToCelsius(double f);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConvertedUnitsChannel : WindowsFormsApplication1.ServiceReference1.IConvertedUnits, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConvertedUnitsClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.IConvertedUnits>, WindowsFormsApplication1.ServiceReference1.IConvertedUnits {
        
        public ConvertedUnitsClient() {
        }
        
        public ConvertedUnitsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConvertedUnitsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertedUnitsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertedUnitsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double LinearMeasure(out double foot, out double yard, double meters) {
            return base.Channel.LinearMeasure(out foot, out yard, meters);
        }
        
        public double CelsiusToFahrenheit(double c) {
            return base.Channel.CelsiusToFahrenheit(c);
        }
        
        public double FahrenheitToCelsius(double f) {
            return base.Channel.FahrenheitToCelsius(f);
        }
    }
}
