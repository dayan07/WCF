

namespace Converter
{
    public class ConvertedUnits : IConvertedUnits
    {
        private double celsius;
        private double fahrenheit;
        private const double inchInMeters= 39.3701;
        private const double footInMeters = 3.28084;
        private const double yardInMeters = 1.09361;
        private const double farInCel = 0.555555555;
        public double CelsiusToFahrenheit(double c)
        {
            fahrenheit = c/farInCel;
            fahrenheit += 32;
            return fahrenheit;
        }

        public double FahrenheitToCelsius(double f)
        {
            f -= 32;
            celsius = f * farInCel;
            return celsius;
        }

        public void LinearMeasure(double meters, out double inch, out double foot, out double yard)
        {
            inch=meters* inchInMeters;
            foot = meters* footInMeters;
            yard = meters* yardInMeters;
          
        }
    }
}
