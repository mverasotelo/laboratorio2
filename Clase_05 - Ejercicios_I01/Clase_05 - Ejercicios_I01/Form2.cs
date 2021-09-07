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
    public partial class frmSaludo : Form
    {


        public frmSaludo(String titulo, String mensaje)
        {
            InitializeComponent();
            lblTitulo.Text = titulo;
            lblMensaje.Text = mensaje;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
