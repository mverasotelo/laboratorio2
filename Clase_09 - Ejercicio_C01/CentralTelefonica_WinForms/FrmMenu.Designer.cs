
namespace CentralTelefonica_WinForms
{
    partial class FrmMenu
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
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnFactTotal = new System.Windows.Forms.Button();
            this.btnFactLocal = new System.Windows.Forms.Button();
            this.btnFactProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(12, 33);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(343, 68);
            this.btnLlamar.TabIndex = 0;
            this.btnLlamar.Text = "Generar Llamada";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnFactTotal
            // 
            this.btnFactTotal.Location = new System.Drawing.Point(12, 118);
            this.btnFactTotal.Name = "btnFactTotal";
            this.btnFactTotal.Size = new System.Drawing.Size(343, 68);
            this.btnFactTotal.TabIndex = 1;
            this.btnFactTotal.Text = "Facturación Total";
            this.btnFactTotal.UseVisualStyleBackColor = true;
            this.btnFactTotal.Click += new System.EventHandler(this.btnFactTotal_Click);
            // 
            // btnFactLocal
            // 
            this.btnFactLocal.Location = new System.Drawing.Point(12, 206);
            this.btnFactLocal.Name = "btnFactLocal";
            this.btnFactLocal.Size = new System.Drawing.Size(343, 68);
            this.btnFactLocal.TabIndex = 2;
            this.btnFactLocal.Text = "Facturación Local";
            this.btnFactLocal.UseVisualStyleBackColor = true;
            this.btnFactLocal.Click += new System.EventHandler(this.btnFactLocal_Click);
            // 
            // btnFactProvincial
            // 
            this.btnFactProvincial.Location = new System.Drawing.Point(12, 293);
            this.btnFactProvincial.Name = "btnFactProvincial";
            this.btnFactProvincial.Size = new System.Drawing.Size(343, 68);
            this.btnFactProvincial.TabIndex = 3;
            this.btnFactProvincial.Text = "Facturación Provincial";
            this.btnFactProvincial.UseVisualStyleBackColor = true;
            this.btnFactProvincial.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(343, 68);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 463);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFactProvincial);
            this.Controls.Add(this.btnFactLocal);
            this.Controls.Add(this.btnFactTotal);
            this.Controls.Add(this.btnLlamar);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefónica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnFactTotal;
        private System.Windows.Forms.Button btnFactLocal;
        private System.Windows.Forms.Button btnFactProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

