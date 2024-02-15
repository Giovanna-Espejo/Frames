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
    public partial class ParImpar : Form
    {
        public ParImpar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num= (int)Convert.ToInt64(textBox1.Text);

            if (Par(num))
            {
                MessageBox.Show($"Es par el numero: {num}");
            }
            else
            {
                MessageBox.Show($"Es impar el numero: {num}");
            }
        }
        static bool Par(int num)
        {
            return num % 2 == 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
