using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_05___Ejercicios_I01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            string[] materias = {"Programacion II", "Estadística", "Inglés II", "Metodología", "Laboratorio II", "Arquitectura y SO"};
            cmbMateria.DataSource = materias;
            cmbMateria.SelectedIndex = 0;
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            if (!String.IsNullOrWhiteSpace(nombre) && !String.IsNullOrWhiteSpace(apellido))
            {
                string mensaje = $"Soy {nombre} {apellido} y mi materia favorita es {cmbMateria.Text}";
                frmSaludo frmSaludo = new frmSaludo("¡Hola, Windows Forms!", mensaje);
                frmSaludo.ShowDialog();
            }
            else 
            {
                string msgBoxText = "Se deben completar los siguientes campos:";

                if(String.IsNullOrWhiteSpace(nombre))
                {
                    msgBoxText += "\nNombre";
                }
                if(String.IsNullOrWhiteSpace(apellido))
                {
                    msgBoxText += "\nApellido";
                }

                MessageBox.Show(msgBoxText, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}   
