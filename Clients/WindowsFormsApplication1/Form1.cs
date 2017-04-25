using System;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

namespace ClientConverter
{
    public partial class Form1 : Form
    {
        double meters;
        double foot;
        double yard;
        double celsius;
        double farenheit;
        ConvertedUnitsClient proxy = new ConvertedUnitsClient();
        public Form1()
        {
           
            InitializeComponent();
        }

        private void tbMet_TextChanged(object sender, EventArgs e)
        {
           
            if (Double.TryParse(tbMet.Text,out meters))
            {
                tbInch.Text=proxy.LinearMeasure(out foot, out yard, meters).ToString();
                tbFoot.Text = foot.ToString();
                tbYard.Text = yard.ToString();
            }
       }
        private void tbCel_TextChanged(object sender, EventArgs e)
        {
           
            if (Double.TryParse(tbCel.Text, out celsius))
            {
              tbFar.Text = proxy.CelsiusToFahrenheit(celsius).ToString();
            }
        }

        private void tbFar_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(tbFar.Text, out farenheit))
            {
              tbCel.Text = proxy.FahrenheitToCelsius(farenheit).ToString();
            }
        }
    }
}
