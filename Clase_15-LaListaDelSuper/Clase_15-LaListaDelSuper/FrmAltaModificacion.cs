using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Clase_15_LaListaDelSuper
{
    public partial class FrmAltaModificacion : Form
    {
        public FrmAltaModificacion(string formText, string textoTxtObjeto, string txtBtnConfirmar)
        {
            InitializeComponent();
            this.Text = formText;
            txtObjeto.Text = textoTxtObjeto;
            btnConfirmar.Text = txtBtnConfirmar;
        }

        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Confirmar();
            }
            else if(e.KeyChar == (char)27)
            {
                Cancelar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Confirmar()
        {
            if (!string.IsNullOrWhiteSpace(txtObjeto.Text))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No puede ingresarse un dato vacío", "Validación",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cancelar()
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
