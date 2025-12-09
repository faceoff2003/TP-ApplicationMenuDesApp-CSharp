namespace ApplicationMenuDesApp
{
    partial class FrmCalculatrice
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
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblAffichage = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSoustraction = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVal1
            // 
            this.txtVal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtVal1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal1.Location = new System.Drawing.Point(322, 114);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(120, 45);
            this.txtVal1.TabIndex = 1;
            this.txtVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVal2
            // 
            this.txtVal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtVal2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVal2.Location = new System.Drawing.Point(322, 215);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(120, 45);
            this.txtVal2.TabIndex = 2;
            this.txtVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblVal1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal1.Location = new System.Drawing.Point(170, 128);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(132, 31);
            this.lblVal1.TabIndex = 0;
            this.lblVal1.Text = "Nombre 1";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblVal2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVal2.Location = new System.Drawing.Point(170, 229);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(138, 31);
            this.lblVal2.TabIndex = 0;
            this.lblVal2.Text = "Nombre 2";
            // 
            // lblAffichage
            // 
            this.lblAffichage.AutoSize = true;
            this.lblAffichage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAffichage.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichage.Location = new System.Drawing.Point(290, 324);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(0, 31);
            this.lblAffichage.TabIndex = 0;
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddition.Location = new System.Drawing.Point(475, 128);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 57);
            this.btnAddition.TabIndex = 3;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSoustraction
            // 
            this.btnSoustraction.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoustraction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSoustraction.Location = new System.Drawing.Point(556, 128);
            this.btnSoustraction.Name = "btnSoustraction";
            this.btnSoustraction.Size = new System.Drawing.Size(75, 57);
            this.btnSoustraction.TabIndex = 4;
            this.btnSoustraction.Text = "-";
            this.btnSoustraction.UseVisualStyleBackColor = true;
            this.btnSoustraction.Click += new System.EventHandler(this.btnSoustraction_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMultiplication.Location = new System.Drawing.Point(475, 191);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(75, 57);
            this.btnMultiplication.TabIndex = 5;
            this.btnMultiplication.Text = "X";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDivision.Location = new System.Drawing.Point(556, 191);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 57);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(556, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(222, 91);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnC.Location = new System.Drawing.Point(723, 160);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 57);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // FrmCalculatrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(822, 482);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnSoustraction);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblAffichage);
            this.Controls.Add(this.lblVal2);
            this.Controls.Add(this.lblVal1);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.txtVal1);
            this.Name = "FrmCalculatrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSoustraction;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnC;

    }
}