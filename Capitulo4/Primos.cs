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
    public partial class Primos : Form
    {
        public Primos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> primos = ObtenerNumerosPrimos(1, 1000);
            textBox1.Text = string.Join(", ", primos);
        }
        private List<int> ObtenerNumerosPrimos(int inicio, int fin)
        {
            List<int> primos = new List<int>();

            for (int numero = inicio; numero <= fin; numero++)
            {
                if (EsPrimo(numero))
                {
                    primos.Add(numero);
                }
            }

            return primos;
        }
        private bool EsPrimo(int numero)
        {
            if (numero < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        private void Primos_Load(object sender, EventArgs e)
        {

        }
    }
}
