using Biblioteca;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDao.Leer();
            dtgvBiblioteca.Refresh();
            dtgvBiblioteca.Update();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Biblioteca.Biblioteca biblioteca = (Biblioteca.Biblioteca) dtgvBiblioteca.CurrentRow.DataBoundItem;
            JuegoDao.Eliminar(biblioteca.CodigoJuego);
            RefrescarBiblioteca();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta frmAlta = new FrmAlta();

            if(frmAlta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Biblioteca.Biblioteca biblioteca = (Biblioteca.Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;
            FrmAlta frmAlta = new FrmAlta(biblioteca.CodigoJuego);


            if (frmAlta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }
        }

    }
}
