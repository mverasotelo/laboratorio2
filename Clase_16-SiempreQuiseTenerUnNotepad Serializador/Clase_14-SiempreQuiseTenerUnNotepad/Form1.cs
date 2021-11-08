using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using IO;

namespace Clase_14_SiempreQuiseTenerUnNotepad
{
    public partial class FormNotepad : Form
    {
        string rutaDocumento;
        private PuntoJson<string> ptoJson;
        private PuntoTxt ptoTxt;
        private PuntoXml<string> ptoXml;

        public FormNotepad()
        {
            InitializeComponent();
            ptoJson = new PuntoJson<string>();
            ptoXml = new PuntoXml<string>();
            ptoTxt = new PuntoTxt();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArchivo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarArchivo();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarComo();
        }

        private void rctNotePad_TextChanged(object sender, EventArgs e)
        {
            lblToolStrip.Text = $"{ContarCaracteres()} caracteres";
        }

        private void abrirArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Archivos de texto (.txt)|*.txt|Archivos XML (.xml)|*.xml|Archivos JSON (.json)|*.json",
                Title = "Abrir archivo de texto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string rutaDocumento = openFileDialog.FileName;

                    switch (Path.GetExtension(rutaDocumento))
                    {
                        case ".xml":
                            rctNotePad.Text = ptoXml.Leer(rutaDocumento);
                            break;
                        case ".json":
                            rctNotePad.Text = ptoJson.Leer(rutaDocumento);
                            break;
                        case ".txt":
                            rctNotePad.Text = ptoTxt.Leer(rutaDocumento);
                            break;
                    }
                }
                catch (Exception ex)
                {   
                    MostrarMensajeError(ex);
                }
            }
        }

        private void guardarComo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Archivos de texto (.txt)|*.txt|Archivos XML (.xml)|*.xml|Archivos JSON (.json)|*.json",
                Title = "Guardar como..."
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (Path.GetExtension(rutaDocumento))
                    {
                        case ".xml":
                            ptoXml.GuardarComo(rutaDocumento, rctNotePad.Text);
                            break;
                        case ".json":
                            ptoJson.GuardarComo(rutaDocumento, rctNotePad.Text);
                            break;
                        case ".txt":
                            ptoTxt.GuardarComo(rutaDocumento, rctNotePad.Text);
                            break;
                    }
                    if (saveFileDialog.FileName != "")
                    {
                        using (StreamWriter str = new StreamWriter(saveFileDialog.FileName))
                        {
                            str.Write(rctNotePad.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError(ex);
                }
            }
        }

        private void guardarArchivo()
        {
            if (rutaDocumento is not null)
            {
                try
                {
                    switch (Path.GetExtension(rutaDocumento))
                    {
                        case ".xml":
                            ptoXml.Guardar(rutaDocumento, rctNotePad.Text);
                            break;
                        case ".json":
                            ptoJson.Guardar(rutaDocumento, rctNotePad.Text);
                            break;
                        case ".txt":
                            ptoTxt.Guardar(rutaDocumento, rctNotePad.Text);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensajeError(ex);
                }
            }
            else
            {
                guardarComo();
            }
        }

        private int ContarCaracteres()
        {
            int caracteres = rctNotePad.Text.Count();
            return caracteres;
        }

        private void MostrarMensajeError(Exception e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error {e}");
            sb.AppendLine(e.Message);
            MessageBox.Show(sb.ToString());
        }
    }
}