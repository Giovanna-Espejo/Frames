using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Frames
{
    public partial class TipoCambio : Form
    {
        public TipoCambio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double dolarEuro = Convert.ToDouble(textBox4.Text);
            double Dolar = Convert.ToDouble(textBox1.Text);
            textBox2.Text = string.Format("{0:F2}", Dolar * dolarEuro);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double euroDolar = Convert.ToDouble(textBox3.Text);
            double Euro = Convert.ToDouble(textBox2.Text);
            textBox2.Text = string.Format("{0:F2}", Euro * euroDolar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
