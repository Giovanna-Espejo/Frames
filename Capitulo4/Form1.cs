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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Tablas();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form pote = new Potencia();
            pote.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form primos = new Primos();
            primos.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form edad = new Edades();
            edad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form cal = new Caldera();
            cal.Show();
        }
    }
}
