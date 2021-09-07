using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_09
{
    public partial class FrmClase05 : Form
    {
        public FrmClase05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea crear un formulario?", "Crear un formulario", MessageBoxButtons.YesNoCancel);    

            if(result == DialogResult.Yes)
            {
                FrmClase05 frm = new FrmClase05();
                frm.Show();
                Thread.Sleep(2000);
                frm.Hide();
                Thread.Sleep(2000);
                frm.Show();

            }
        }

        private void FrmClase05_Load(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            Controls.Add(tb);
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            DialogResult exit = MessageBox.Show("Desea cerrar el formulario?", "Salir", MessageBoxButtons.YesNoCancel);
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
