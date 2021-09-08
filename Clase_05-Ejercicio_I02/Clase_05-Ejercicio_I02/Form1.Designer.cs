
namespace Clase_05_Ejercicio_I02
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.gbDetalles = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.cbCSharp = new System.Windows.Forms.CheckBox();
            this.cbCPlusPlus = new System.Windows.Forms.CheckBox();
            this.cbJavaScript = new System.Windows.Forms.CheckBox();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.listboxPais = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.gbDetalles.SuspendLayout();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(14, 99);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 20);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(14, 145);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 20);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(92, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 27);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(92, 92);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(151, 27);
            this.txtDireccion.TabIndex = 5;
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(93, 138);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(150, 27);
            this.numEdad.TabIndex = 6;
            // 
            // gbDetalles
            // 
            this.gbDetalles.Controls.Add(this.numEdad);
            this.gbDetalles.Controls.Add(this.txtDireccion);
            this.gbDetalles.Controls.Add(this.txtNombre);
            this.gbDetalles.Controls.Add(this.lblEdad);
            this.gbDetalles.Controls.Add(this.lblDireccion);
            this.gbDetalles.Controls.Add(this.lblNombre);
            this.gbDetalles.Location = new System.Drawing.Point(23, 37);
            this.gbDetalles.Name = "gbDetalles";
            this.gbDetalles.Size = new System.Drawing.Size(283, 200);
            this.gbDetalles.TabIndex = 7;
            this.gbDetalles.TabStop = false;
            this.gbDetalles.Text = "Detalles del usuario";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(478, 396);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(115, 29);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(32, 45);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(97, 24);
            this.rbMasculino.TabIndex = 10;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(32, 75);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(95, 24);
            this.rbFemenino.TabIndex = 11;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(32, 105);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(101, 24);
            this.rbNoBinario.TabIndex = 12;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBinario);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(383, 37);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(191, 165);
            this.gbGenero.TabIndex = 13;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Género";
            // 
            // cbCSharp
            // 
            this.cbCSharp.AutoSize = true;
            this.cbCSharp.Location = new System.Drawing.Point(32, 30);
            this.cbCSharp.Name = "cbCSharp";
            this.cbCSharp.Size = new System.Drawing.Size(49, 24);
            this.cbCSharp.TabIndex = 14;
            this.cbCSharp.Text = "C#";
            this.cbCSharp.UseVisualStyleBackColor = true;
            // 
            // cbCPlusPlus
            // 
            this.cbCPlusPlus.AutoSize = true;
            this.cbCPlusPlus.Location = new System.Drawing.Point(32, 60);
            this.cbCPlusPlus.Name = "cbCPlusPlus";
            this.cbCPlusPlus.Size = new System.Drawing.Size(60, 24);
            this.cbCPlusPlus.TabIndex = 15;
            this.cbCPlusPlus.Text = "C++";
            this.cbCPlusPlus.UseVisualStyleBackColor = true;
            // 
            // cbJavaScript
            // 
            this.cbJavaScript.AutoSize = true;
            this.cbJavaScript.Location = new System.Drawing.Point(32, 90);
            this.cbJavaScript.Name = "cbJavaScript";
            this.cbJavaScript.Size = new System.Drawing.Size(97, 24);
            this.cbJavaScript.TabIndex = 16;
            this.cbJavaScript.Text = "JavaScript";
            this.cbJavaScript.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.cbJavaScript);
            this.gbCursos.Controls.Add(this.cbCPlusPlus);
            this.gbCursos.Controls.Add(this.cbCSharp);
            this.gbCursos.Location = new System.Drawing.Point(383, 219);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(191, 148);
            this.gbCursos.TabIndex = 17;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(23, 256);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 20);
            this.lblPais.TabIndex = 18;
            this.lblPais.Text = "País";
            // 
            // listboxPais
            // 
            this.listboxPais.FormattingEnabled = true;
            this.listboxPais.ItemHeight = 20;
            this.listboxPais.Location = new System.Drawing.Point(23, 279);
            this.listboxPais.Name = "listboxPais";
            this.listboxPais.Size = new System.Drawing.Size(283, 144);
            this.listboxPais.TabIndex = 19;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.listboxPais);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.gbDetalles);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.gbDetalles.ResumeLayout(false);
            this.gbDetalles.PerformLayout();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.GroupBox gbDetalles;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbNoBinario;
        private System.Windows.Forms.GroupBox gbGenero;
        private System.Windows.Forms.CheckBox cbCSharp;
        private System.Windows.Forms.CheckBox cbCPlusPlus;
        private System.Windows.Forms.CheckBox cbJavaScript;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ListBox listboxPais;
    }
}

