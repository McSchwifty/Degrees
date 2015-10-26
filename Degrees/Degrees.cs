// Andrew Mackinnon
// October 26 2015
// ICS3UR
// Converts celsius to fahrenheit
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degrees
{
    public partial class Degrees : Form
    {
        public void Converter (double temp)
        {
            double fahrenheit = (9 / 5) * temp + 32;
            MessageBox.Show(Convert.ToString(fahrenheit) + " degrees is the temperature in fahrenheit");
        }
        public Degrees()
        {
            InitializeComponent();
        }

        private void btnPuch_Click(object sender, EventArgs e)
        {
            Double degrees;

            degrees = Convert.ToDouble(this.txtBox.Text);
            Converter(degrees);
        }
    }
}
