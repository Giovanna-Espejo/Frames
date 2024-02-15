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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form areas = new Poligono_Area();
            areas.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form GyR = new GradosRadianes();
            GyR.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form temp = new Temperaturas();
            temp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form cambio = new TipoCambio();
            cambio.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form pares = new ParImpar();
            pares.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form impuesto = new Impuesto();
            impuesto.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form dia = new Dias();
            dia.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form PERI = new Perimetro();
            PERI.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
