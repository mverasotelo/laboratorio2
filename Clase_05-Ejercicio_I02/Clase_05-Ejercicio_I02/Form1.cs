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

namespace Clase_05_Ejercicio_I02
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            listboxPais.Items.Add("Argentina");
            listboxPais.Items.Add("Chile");
            listboxPais.Items.Add("Uruguay");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int edad = (int) numEdad.Value;
            string pais = (string) listboxPais.SelectedItem;
            string genero ="";
            string[] cursos = {"",""};
            
            Ingresante ingresante = new Ingresante(cursos,direccion,edad,genero,nombre,pais);

            MessageBox.Show(ingresante.Mostrar(),"",MessageBoxButtons.OK);
        }
    }
}
