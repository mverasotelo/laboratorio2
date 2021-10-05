
namespace Clase_10___Ejercicio_I02
{
    partial class FrmCalculador
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
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblKilometros = new System.Windows.Forms.Label();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rctCalculador = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLitros.Location = new System.Drawing.Point(78, 159);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(51, 23);
            this.lblLitros.TabIndex = 0;
            this.lblLitros.Text = "Litros";
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKilometros.Location = new System.Drawing.Point(78, 72);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(91, 23);
            this.lblKilometros.TabIndex = 1;
            this.lblKilometros.Text = "Kilometros";
            // 
            // txtLitros
            // 
            this.txtLitros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLitros.Location = new System.Drawing.Point(78, 182);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(199, 34);
            this.txtLitros.TabIndex = 2;
            // 
            // txtKilometros
            // 
            this.txtKilometros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKilometros.Location = new System.Drawing.Point(78, 95);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(199, 34);
            this.txtKilometros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(78, 272);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(199, 37);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rctCalculador
            // 
            this.rctCalculador.Location = new System.Drawing.Point(360, 41);
            this.rctCalculador.Name = "rctCalculador";
            this.rctCalculador.ReadOnly = true;
            this.rctCalculador.Size = new System.Drawing.Size(414, 371);
            this.rctCalculador.TabIndex = 5;
            this.rctCalculador.Text = "";
            // 
            // FrmCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rctCalculador);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.lblKilometros);
            this.Controls.Add(this.lblLitros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rctCalculador;
    }
}

