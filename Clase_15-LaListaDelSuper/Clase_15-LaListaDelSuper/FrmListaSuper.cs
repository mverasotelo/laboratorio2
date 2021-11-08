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
            if (File.Exists(rutaArchivo))
            {
                CargarListaDesdeArchivo();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion formAlta = new FrmAltaModificacion("Agregar objeto", "", "Agregar");
            formAlta.ShowDialog();
            if(formAlta.DialogResult == DialogResult.OK)
            {
                AgregarObjeto(formAlta.Objeto);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItem is null)
            {
                MessageBox.Show("Debe seleccionar un objeto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmAltaModificacion formModificacion = new FrmAltaModificacion("Modificar objeto", lstObjetos.SelectedItem.ToString(), "Modificar");
                formModificacion.ShowDialog();
                if (formModificacion.DialogResult == DialogResult.OK)
                {
                    ModificarObjeto(lstObjetos.SelectedIndex, formModificacion.Objeto);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstObjetos.SelectedItem is null)
            {
                MessageBox.Show("Debe seleccionar un objeto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                listaSupermercado.RemoveAt(lstObjetos.SelectedIndex);
                ActualizarLista();
                GuardarDatosEnArchivo();
            }
        }

        /// <summary>
        /// Agrega un objeto a la lista
        /// </summary>
        /// <param name="objeto"></param>
        private void AgregarObjeto(string objeto)
        {
            if (!listaSupermercado.Contains(objeto))
            {
                listaSupermercado.Add(objeto);
                ActualizarLista();
                GuardarDatosEnArchivo();
            }
            else
            {
                MessageBox.Show("El objeto ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            GuardarDatosEnArchivo();
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

        private void GuardarDatosEnArchivo()
        {
            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(listaSupermercado.GetType());
                xmlSerializer.Serialize(streamWriter, listaSupermercado);
            }
        }

        //private void MensajeExcepcion(Exception e)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.AppendLine($"Error {e}");
        //    sb.AppendLine(e.Message);
        //    MessageBox.Show(sb.ToString());
        //}
    }
}