using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Clase_15_LaListaDelSuper
{
    public partial class FrmListaSuper : Form
    {

        string rutaArchivo;
        List<string> listaSupermercado;

        public FrmListaSuper()
        {
            this.listaSupermercado = new List<string>();
            InitializeComponent();
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            this.rutaArchivo = Path.Combine(ruta, "listaSupermercado.xml");
            CargarListaDesdeArchivo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion formAlta = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            formAlta.ShowDialog();
            if(formAlta.DResult == DialogResult.OK)
            {
                AgregarObjeto(formAlta.Objeto);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItem is null)
            {
            }
            else
            {
                FrmAltaModificacion formModificacion = new FrmAltaModificacion("Modificar objeto", lstObjetos.SelectedItem.ToString(), "Modificar");
                formModificacion.ShowDialog();
                if (formModificacion.DResult == DialogResult.OK)
                {
                    ModificarObjeto(lstObjetos.SelectedIndex, formModificacion.Objeto);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItem is null)
            {
            }
            else
            {
                listaSupermercado.RemoveAt(lstObjetos.SelectedIndex);
                ActualizarLista();
                ActualizarArchivo();
            }
        }

        /// <summary>
        /// Agrega un objeto a la lista
        /// </summary>
        /// <param name="objeto"></param>
        private void AgregarObjeto(string objeto)
        {
            listaSupermercado.Add(objeto);
            ActualizarLista();
            ActualizarArchivo();
        }

        /// <summary>
        /// Modifica el objeto de la lista del indice pasado por parametro
        /// </summary>
        /// <param name="index"></param>
        /// <param name="objeto"></param>
        private void ModificarObjeto(int index, string objeto)
        {
            listaSupermercado[index] = objeto;
            ActualizarLista();
            ActualizarArchivo();
        }

        /// <summary>
        ///  Deserializa el archivo de la lista de super como una lista de string
        /// </summary>
        private void CargarListaDesdeArchivo()
        {
            if (File.Exists(rutaArchivo))
            {
                using (StreamReader streamReader = new StreamReader(rutaArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());

                    listaSupermercado = xmlSerializer.Deserialize(streamReader) as List<string>;
                    ActualizarLista();
                }
            }
        }

        private void ActualizarLista()
        {
            lstObjetos.DataSource = null;
            lstObjetos.DataSource = listaSupermercado;
        }

        private void ActualizarArchivo()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                if(listaSupermercado.Count != 0)
                {
                    xmlSerializer.Serialize(streamWriter, listaSupermercado);
                }
            }
        }

        private void MensajeExcepcion(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error {e}");
            sb.AppendLine(e.Message);
            MessageBox.Show(sb.ToString());
        }
    }
}