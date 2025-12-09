namespace ApplicationMenuDesApp
{
    partial class FrmConvertisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDirham = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDirham = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEuro
            // 
            this.txtEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtEuro.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuro.Location = new System.Drawing.Point(48, 85);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(323, 45);
            this.txtEuro.TabIndex = 0;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDirham
            // 
            this.txtDirham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtDirham.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirham.Location = new System.Drawing.Point(48, 226);
            this.txtDirham.Name = "txtDirham";
            this.txtDirham.Size = new System.Drawing.Size(323, 45);
            this.txtDirham.TabIndex = 1;
            this.txtDirham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEuro.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(53, 37);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(68, 31);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "Euro";
            // 
            // lblDirham
            // 
            this.lblDirham.AutoSize = true;
            this.lblDirham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblDirham.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirham.Location = new System.Drawing.Point(53, 175);
            this.lblDirham.Name = "lblDirham";
            this.lblDirham.Size = new System.Drawing.Size(73, 31);
            this.lblDirham.TabIndex = 3;
            this.lblDirham.Text = "MAD";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConvertir.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.Red;
            this.btnConvertir.Location = new System.Drawing.Point(455, 158);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(142, 63);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(455, 327);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 63);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmConvertisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblDirham);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtDirham);
            this.Controls.Add(this.txtEuro);
            this.Name = "FrmConvertisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDirham;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDirham;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnExit;
    }
}