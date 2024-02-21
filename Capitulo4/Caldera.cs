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
    public partial class Caldera : Form
    {
        private const int TemperaturaMaxima = 180;
        private const int TemperaturaMinima = 32;
        private int temperaturaActual;
        private bool temperaturaAceptable = false;
        private Random random = new Random();
        private int resta;
        public Caldera()
        {
            InitializeComponent();
            resta = random.Next(1, 11);
            temperaturaActual = random.Next(TemperaturaMinima, TemperaturaMaxima + 1);
            ActualizarTemperatura();
        }

        private void ActualizarTemperatura()
        {
            textBox1.Text = temperaturaActual.ToString() + "°C";
        }

        private void VerificarTemperatura()
        {
            if (temperaturaAceptable)
            {
                MessageBox.Show("La temperatura actual es aceptable.", "Temperatura Aceptable");
            }
            else
            {
                temperaturaActual -= resta;
                if (temperaturaActual <= TemperaturaMinima || temperaturaActual < 28)
                {
                    temperaturaActual = TemperaturaMinima;
                    MessageBox.Show("Esta es la temperatura mínima aceptable.", "Temperatura Mínima Aceptable");
                    temperaturaAceptable = true;
                }
                ActualizarTemperatura();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temperaturaAceptable = true;
            VerificarTemperatura();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            temperaturaAceptable = false;
            VerificarTemperatura();
        }
    }
}