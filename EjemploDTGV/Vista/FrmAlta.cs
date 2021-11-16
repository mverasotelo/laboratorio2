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

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;

        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            this.codigoJuego = codigoJuego;
            cmbUsuarios.Hide();
            lblUsuarios.Text = String.Empty;
            PintarForm();
        }

        private void PintarForm()
        {
            Juego juego = JuegoDao.LeerPorId(codigoJuego);
            txtGenero.Text = juego.Genero;
            txtNombre.Text = juego.Nombre;
            nupPrecio.Value = (decimal)juego.Precio;
        }

        public FrmAlta()
        {
            InitializeComponent();
        }


        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = UsuarioDao.Leer();
            nupPrecio.Maximum = 10000;

        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            if(btnGuardar.Text == "Modificar")
            {
                Juego juego = new Juego(codigoJuego, ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario, txtGenero.Text, txtNombre.Text, (double)nupPrecio.Value);
                JuegoDao.Modificar(juego);
                DialogResult = DialogResult.OK;

            }
            else
            {
                Juego juego = new Juego(((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario, txtGenero.Text, txtNombre.Text, (double)nupPrecio.Value);
                JuegoDao.Guardar(juego);
                DialogResult = DialogResult.OK;
            }
        }

    }
}
