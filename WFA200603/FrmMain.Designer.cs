namespace WFA200603
{
    partial class FrmMain
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
            this.txtMeret = new System.Windows.Forms.TextBox();
            this.btnEllenorzes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHossz = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlusz = new System.Windows.Forms.Button();
            this.btnMinusz = new System.Windows.Forms.Button();
            this.txtKezdoallapot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMeret
            // 
            this.txtMeret.Enabled = false;
            this.txtMeret.Location = new System.Drawing.Point(217, 17);
            this.txtMeret.Name = "txtMeret";
            this.txtMeret.Size = new System.Drawing.Size(28, 22);
            this.txtMeret.TabIndex = 0;
            this.txtMeret.Text = "4";
            this.txtMeret.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEllenorzes
            // 
            this.btnEllenorzes.Location = new System.Drawing.Point(389, 122);
            this.btnEllenorzes.Name = "btnEllenorzes";
            this.btnEllenorzes.Size = new System.Drawing.Size(121, 23);
            this.btnEllenorzes.TabIndex = 1;
            this.btnEllenorzes.Text = "Ellenőrzés";
            this.btnEllenorzes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Új feladvány mérete:";
            // 
            // lblHossz
            // 
            this.lblHossz.AutoSize = true;
            this.lblHossz.Location = new System.Drawing.Point(12, 128);
            this.lblHossz.Name = "lblHossz";
            this.lblHossz.Size = new System.Drawing.Size(79, 17);
            this.lblHossz.TabIndex = 2;
            this.lblHossz.Text = "Hossz: ###";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kezdőállapot:";
            // 
            // btnPlusz
            // 
            this.btnPlusz.Location = new System.Drawing.Point(251, 17);
            this.btnPlusz.Name = "btnPlusz";
            this.btnPlusz.Size = new System.Drawing.Size(27, 23);
            this.btnPlusz.TabIndex = 1;
            this.btnPlusz.Text = "+";
            this.btnPlusz.UseVisualStyleBackColor = true;
            // 
            // btnMinusz
            // 
            this.btnMinusz.Location = new System.Drawing.Point(184, 17);
            this.btnMinusz.Name = "btnMinusz";
            this.btnMinusz.Size = new System.Drawing.Size(27, 23);
            this.btnMinusz.TabIndex = 1;
            this.btnMinusz.Text = "-";
            this.btnMinusz.UseVisualStyleBackColor = true;
            // 
            // txtKezdoallapot
            // 
            this.txtKezdoallapot.Location = new System.Drawing.Point(12, 80);
            this.txtKezdoallapot.Name = "txtKezdoallapot";
            this.txtKezdoallapot.Size = new System.Drawing.Size(498, 22);
            this.txtKezdoallapot.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 163);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHossz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinusz);
            this.Controls.Add(this.btnPlusz);
            this.Controls.Add(this.btnEllenorzes);
            this.Controls.Add(this.txtKezdoallapot);
            this.Controls.Add(this.txtMeret);
            this.Name = "FrmMain";
            this.Text = "Sudoku-ellenőrző";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMeret;
        private System.Windows.Forms.Button btnEllenorzes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHossz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlusz;
        private System.Windows.Forms.Button btnMinusz;
        private System.Windows.Forms.TextBox txtKezdoallapot;
    }
}

