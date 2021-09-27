using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita;

namespace CentralTelefonica_WinForms
{
    public partial class FrmLlamador : Form
    {
        private Centralita.Centralita centralita;

        public FrmLlamador(Centralita.Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        public Centralita.Centralita Centralita{
            get
            {
                return centralita;
            }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            //COMBOBOX FRANJAS
            //Carga
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franjas));

            cmbFranja.Enabled = false;
        }

        private void TecladoClick(object sender, EventArgs e)
        {
            txtNroDestino.Text += ((Button)sender).Text;

            if(txtNroDestino.Text[0] == '#')
            {
                cmbFranja.Enabled = true;
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if(txtNroDestino.Text == "" || txtNroOrigen.Text == "")
            {
                MessageBox.Show("Debe ingresar un número de orígen y un número de destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Provincial.Franjas franjas;
                Enum.TryParse<Provincial.Franjas>(cmbFranja.SelectedValue.ToString(), out franjas);

                float duracion = GenerarNumeroRandom(1, 51);

                if (txtNroDestino.Text[0] == '#')
                {
                    Provincial auxiliar = new Provincial(txtNroOrigen.Text, franjas, duracion, txtNroDestino.Text);
                    centralita.Llamadas.Add(auxiliar);
                }
                else
                {
                    float costo = (GenerarNumeroRandom(5, 57) / 10);
                    Local auxiliar = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);
                    centralita.Llamadas.Add(auxiliar);
                }
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";
            cmbFranja.Enabled = false;
        }

        private float GenerarNumeroRandom(int min, int max)
        {
            Random r = new Random();
            return r.Next(min, max);
        }
    }
}
