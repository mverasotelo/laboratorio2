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

namespace Ejercicio_I01___Avisame_Si_Cambias
{
    public partial class FrmAvisador : Form
    {
        private Persona persona;

        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void FrmAvisador_Load(object sender, EventArgs e)
        {
        }

        private void NotificarCambio(string texto)
        {
            MessageBox.Show(texto);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (persona is null)
            {
                persona = new Persona();
                persona.EventoString += NotificarCambio;
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                btnCrear.Text = "Actualizar";
            }
            else
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                lblNombreCompleto.Text = persona.Mostrar();
            }
        }
    }
}
