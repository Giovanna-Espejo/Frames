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
    public partial class Impuesto : Form
    {
        public Impuesto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked)
            {
                textBox2.Text = string.Format("{0:F2}", costo);
                int Impu = 0;
                textBox3.Text = string.Format("{0:F2}", Impu);
            }
        else if(radioButton2.Checked){
                double impu = costo * 0.16;
                textBox2.Text = string.Format("{0:F2}", costo + impu);
                textBox3.Text = string.Format("{0:F2}", impu);
    }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
    }

