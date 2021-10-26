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
        private string textoTxtObjeto;
        private string txtBtnConfirmar;
        private string formText;
        private DialogResult dialogResult;

        public FrmAltaModificacion(string formText, string textoTxtObjeto, string txtBtnConfirmar)
        {
            this.textoTxtObjeto = textoTxtObjeto;
            this.formText = formText;
            this.txtBtnConfirmar = txtBtnConfirmar;
            dialogResult = new DialogResult();
            InitializeComponent();
        }

        public string Objeto
        {
            get
            {
                return txtObjeto.Text;
            }
        }

        public DialogResult DResult
        {
            get
            {
                return dialogResult;
            }
        }

        private void FrmAltaModificacion_Load(object sender, EventArgs e)
        {
            this.Text = formText;
            txtObjeto.Text = textoTxtObjeto;
            btnConfirmar.Text = txtBtnConfirmar;
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
            if (!String.IsNullOrEmpty(txtObjeto.Text))
            {
                dialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No puede ingresarse un dato vacío", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Cancelar()
        {
            dialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
