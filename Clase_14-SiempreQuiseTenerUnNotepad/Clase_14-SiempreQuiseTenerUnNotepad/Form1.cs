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

namespace Clase_14_SiempreQuiseTenerUnNotepad
{
    public partial class FormNotepad : Form
    {

        private string ruta;

        public FormNotepad()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
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
                    ruta = openFileDialog.FileName;
                    using (StreamReader str = new StreamReader(ruta))
                    {
                        rctNotePad.Text = str.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}");
                }
            }
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
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}");
                }
            }
        }

        private void guardarArchivo()
        {
            if (ruta is not null)
            {
                try
                {
                    using (StreamWriter str = new StreamWriter(ruta))
                    {
                        str.Write(rctNotePad.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}");
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
    }
}