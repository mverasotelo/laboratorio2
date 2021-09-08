using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06_Ejercicio_I03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> contadorPalabras = ObtenerContadorPalabras();
            MostrarPodio(contadorPalabras);

        }

        private void MostrarPodio(Dictionary<string, int> contadorPalabras)
        {
            StringBuilder mensaje = new StringBuilder();

            if (contadorPalabras.Count > 0)
            {
                mensaje.AppendLine("Palabras con más ocurrencias");
                foreach (KeyValuePair<string, int> item in contadorPalabras.OrderByDescending(r => r.Value).Take(3))
                {
                    mensaje.AppendLine($"{item.Key} ({item.Value})");
                }
            }
            else
            {
                mensaje.AppendLine("No se han ingresado palabras");
            }

            MessageBox.Show(mensaje.ToString());
        }

        private Dictionary<string,int> ObtenerContadorPalabras()
        {
            Dictionary<string, int> palabras = new Dictionary<string, int>();

            foreach (string palabra in (richTextBoxPalabras.Text).Split(' ', StringSplitOptions.RemoveEmptyEntries))
            {
                if (palabras.ContainsKey(palabra))
                {
                    palabras[palabra]++;
                }
                else
                {
                    palabras.Add(palabra, 1);
                }
            }
            return palabras;
        }
    }
}
