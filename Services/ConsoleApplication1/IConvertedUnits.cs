
using System.ServiceModel;


namespace Converter
{
    [ServiceContract]
    interface IConvertedUnits
    {
        [OperationContract]
        void LinearMeasure(double meters, out double inch, out double foot, out double yard);
        [OperationContract]
        double CelsiusToFahrenheit(double c);
        [OperationContract]
        double FahrenheitToCelsius(double f);
    }
}
