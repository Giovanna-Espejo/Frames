using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Capitulo4
{
    public partial class Edades : Form
    {
        private int[] edades;
        public Edades()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Obtener el número de personas
            int numeroPersonas;
            if (!int.TryParse(textBox1.Text, out numeroPersonas) || numeroPersonas <= 0)
            {
                MessageBox.Show("Por favor, ingrese un número válido de personas.", "Error");
                return;
            }

            // Inicializar el array de edades
            edades = new int[numeroPersonas];

            // Leer las edades ingresadas por el usuario y almacenarlas en el array
            for (int i = 0; i < numeroPersonas; i++)
            {
                string edadString = PedirEdad($"Ingrese la edad de la persona {i + 1}:");
                if (!int.TryParse(edadString, out int edad) || edad < 0)
                {
                    MessageBox.Show("Por favor, ingrese una edad válida.", "Error");
                    return;
                }
                edades[i] = edad;

            }

            // Calcular la mayor y menor edad
            int mayorEdad = CalcularMayorEdad();
            int menorEdad = CalcularMenorEdad();
            int promedio = CalcularPromedio();

            // Mostrar los resultados
            label2.Text = $"La edad mayor es: {mayorEdad} años\nLa edad menor es: {menorEdad} años\nEl promedio de edades es: {promedio} años";
        }

        private string PedirEdad(string mensaje)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = mensaje,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = "Edad:" };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 150 };
            Button confirmation = new Button() { Text = "Ok", Left = 50, Width = 100, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "0";
        }

        private int CalcularMayorEdad()
        {
            int mayorEdad = int.MinValue;
            foreach (int edad in edades)
            {
                if (edad > mayorEdad)
                {
                    mayorEdad = edad;
                }
            }
            return mayorEdad;
        }

        private int CalcularMenorEdad()
        {
            int menorEdad = int.MaxValue;
            foreach (int edad in edades)
            {
                if (edad < menorEdad)
                {
                    menorEdad = edad;
                }
            }
            return menorEdad;
        }
        private int CalcularPromedio()
        {
            int promedio = 0;
            foreach (int edad in edades)
            {
                promedio += edad;
            }
            return promedio / edades.Length;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
