using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo4
{
    public partial class Potencia : Form
    {
        public Potencia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double NUMERO = Convert.ToDouble(textBox1.Text);
            double POTENCIA = Convert.ToDouble(textBox2.Text);
            textBox3.Text = string.Format("{0:F2}", Math.Pow(NUMERO, POTENCIA));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
