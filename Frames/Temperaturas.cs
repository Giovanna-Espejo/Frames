using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frames
{
    public partial class Temperaturas : Form
    {
        public Temperaturas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cels = Convert.ToDouble(textBox1.Text);
            textBox2.Text = string.Format("{0:F2}", (cels * 9 / 5) + 32);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Fahren = Convert.ToDouble(textBox2.Text);
            textBox1.Text = string.Format("{0:F2}", (Fahren - 32) * 5 / 9);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
