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
    public partial class Dias : Form
    {
        public Dias()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num= (int)Convert.ToInt64(textBox1.Text);
            switch (num)
            {
                case 1:
                    MessageBox.Show("El día es Lunes");
                    break;
                case 2:
                    MessageBox.Show("El día es Martes");
                    break;
                case 3:
                    MessageBox.Show("El día es Miercoles");
                    break;
                case 4:
                    MessageBox.Show("El día es Jueves");
                    break;
                case 5:
                    MessageBox.Show("El día es Viernes");
                    break;
                case 6:
                    MessageBox.Show("El día es Sabado");
                    break;
                case 7:
                    MessageBox.Show("El día es Domingo");
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
