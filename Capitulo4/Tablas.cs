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
    public partial class Tablas : Form
    {
        public Tablas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = indice.ToString();
            label3.Text = indice.ToString();
            label4.Text = indice.ToString();
            label5.Text = indice.ToString();
            label6.Text = indice.ToString();
            label7.Text = indice.ToString();
            label8.Text = indice.ToString();
            label9.Text = indice.ToString();
            label10.Text = indice.ToString();
            if (indice == 1)
            {
                label50.Text = "1";
                label49.Text = "2";
                label48.Text = "3";
                label47.Text = "4";
                label46.Text = "5";
                label45.Text = "6";
                label44.Text = "7";
                label43.Text = "8";
                label42.Text = "9";
                label41.Text = "10";
            }
            else if (indice == 2)
            {
                label50.Text = "2";
                label49.Text = "4";
                label48.Text = "6";
                label47.Text = "8";
                label46.Text = "10";
                label45.Text = "12";
                label44.Text = "14";
                label43.Text = "16";
                label42.Text = "18";
                label41.Text = "20";
            }
            else if (indice == 3)
            {
                label50.Text = "3";
                label49.Text = "6";
                label48.Text = "9";
                label47.Text = "12";
                label46.Text = "15";
                label45.Text = "18";
                label44.Text = "21";
                label43.Text = "24";
                label42.Text = "27";
                label41.Text = "30";
            }
            else if (indice == 4)
            {
                label50.Text = "4";
                label49.Text = "8";
                label48.Text = "12";
                label47.Text = "16";
                label46.Text = "20";
                label45.Text = "24";
                label44.Text = "28";
                label43.Text = "32";
                label42.Text = "36";
                label41.Text = "40";
            }
            else if (indice == 5)
            {
                label50.Text = "5";
                label49.Text = "10";
                label48.Text = "15";
                label47.Text = "20";
                label46.Text = "25";
                label45.Text = "30";
                label44.Text = "35";
                label43.Text = "40";
                label42.Text = "45";
                label41.Text = "50";
            }
            else if (indice == 6)
            {
                label50.Text = "6";
                label49.Text = "12";
                label48.Text = "18";
                label47.Text = "24";
                label46.Text = "30";
                label45.Text = "36";
                label44.Text = "42";
                label43.Text = "48";
                label42.Text = "54";
                label41.Text = "60";
            }
            else if (indice == 7)
            {
                label50.Text = "7";
                label49.Text = "14";
                label48.Text = "21";
                label47.Text = "28";
                label46.Text = "35";
                label45.Text = "42";
                label44.Text = "49";
                label43.Text = "56";
                label42.Text = "63";
                label41.Text = "70";
            }
            else if (indice == 8)
            {
                label50.Text = "8";
                label49.Text = "16";
                label48.Text = "24";
                label47.Text = "32";
                label46.Text = "40";
                label45.Text = "48";
                label44.Text = "56";
                label43.Text = "64";
                label42.Text = "72";
                label41.Text = "80";
            }
            else if (indice == 9)
            {
                label50.Text = "9";
                label49.Text = "18";
                label48.Text = "27";
                label47.Text = "36";
                label46.Text = "45";
                label45.Text = "54";
                label44.Text = "63";
                label43.Text = "72";
                label42.Text = "81";
                label41.Text = "90";
            }
            else if (indice == 10)
            {
                label50.Text = "10";
                label49.Text = "20";
                label48.Text = "30";
                label47.Text = "40";
                label46.Text = "50";
                label45.Text = "60";
                label44.Text = "70";
                label43.Text = "80";
                label42.Text = "90";
                label41.Text = "100";
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Tablas_Load(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }
    }
}
