using System;
using System.Windows.Forms;
using Centralita;

namespace CentralTelefonica_WinForms
{
    public partial class FrmMenu : Form
    {
        Centralita.Centralita c = new Centralita.Centralita("Fede Center");

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(c);
            frmLlamador.ShowDialog();
        }

        private void btnFactTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar= new FrmMostrar(c);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Todas;
            frmMostrar.ShowDialog();
        }

        private void btnFactLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(c);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Local;
            frmMostrar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(c);
            frmMostrar.TipoLlamada = Llamada.TipoLlamada.Provincial;
            frmMostrar.ShowDialog();
        }
    }
}
