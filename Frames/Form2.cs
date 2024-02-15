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
    public partial class GradosRadianes : Form
    {
        public GradosRadianes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double grados = Convert.ToDouble(textBox1.Text);
            textBox2.Text = string.Format("{0:F2}", grados * (Math.PI / 180));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radianes = Convert.ToDouble(textBox2.Text);
            textBox1.Text = string.Format("{0:F2}", radianes * (180 / Math.PI));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
