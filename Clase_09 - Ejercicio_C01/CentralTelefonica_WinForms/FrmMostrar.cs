using System;
using System.Text;
using System.Windows.Forms;
using Centralita;

namespace CentralTelefonica_WinForms
{
    public partial class FrmMostrar : Form
    {
        private Centralita.Centralita centralita;
        private Llamada.TipoLlamada tipoLlamada;

        /// <summary>
        /// Solo escritura
        /// </summary>
        public Llamada.TipoLlamada TipoLlamada
        {
            set
            {
                tipoLlamada = value;
            }
        }

        public FrmMostrar(Centralita.Centralita centralita)
        {
            this.centralita = centralita;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            rctFacturacion.Text = GenerarFacturacion(tipoLlamada);
        }

        private string GenerarFacturacion(Llamada.TipoLlamada tipoLlamada)
        {
            StringBuilder sb = new StringBuilder();
            switch (tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    sb.AppendLine($"Facturacion por llamadas locales: ${centralita.GananciasPorLocal:N2}");
                    break;
                case Llamada.TipoLlamada.Provincial:
                    sb.AppendLine($"Facturacion por llamadas provinciales: ${centralita.GananciasPorProvincial:N2}");
                    break;
                case Llamada.TipoLlamada.Todas:
                    sb.AppendLine($"Facturacion total: ${centralita.GananciasPorTodas:N2}");
                    break;
            }
            return sb.ToString();
        }

    }
}
