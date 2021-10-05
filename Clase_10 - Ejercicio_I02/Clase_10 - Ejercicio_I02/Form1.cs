using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Clase_10___Ejercicio_I02
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKilometros.Text == "" || txtLitros.Text == "")
                {
                    throw new ParametrosVaciosExcepcion("Alguno de los parámetros está vacio");
                }

                rctCalculador.Text =$"km/hs: {Calculador.Calcular(int.Parse(txtKilometros.Text), int.Parse(txtLitros.Text))}";

            }
            catch (ParametrosVaciosExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("El formato de entrada no es el correcto");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
