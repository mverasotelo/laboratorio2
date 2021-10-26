using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Clase_14_SiempreQuiseTenerUnNotepad
{
    public partial class FormNotepad : Form
    {

        private string archivo;

        public FormNotepad()
        {
            InitializeComponent();
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
                Filter = "Text files (*.txt)|*.txt",
                Title = "Abrir archivo de texto"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    archivo = openFileDialog.FileName;
                    using (StreamReader str = new StreamReader(archivo))
                    {
                        rctNotePad.Text = str.ReadToEnd();
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
                Filter = "Text files (*.txt)|*.txt",
                Title = "Guardar como..."
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
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
            if (archivo is not null)
            {
                try
                {
                    using (StreamWriter str = new StreamWriter(archivo))
                    {
                        str.Write(rctNotePad.Text);
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