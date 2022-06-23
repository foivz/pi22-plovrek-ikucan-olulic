namespace ServisiranjeVozila
{
    partial class PocetnaKlijentForm
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
            this.dgvKorisnikoveNarudzbe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.detaljiNarudzbe = new System.Windows.Forms.Button();
            this.buttonNapredak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnikoveNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnikoveNarudzbe
            // 
            this.dgvKorisnikoveNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnikoveNarudzbe.Location = new System.Drawing.Point(27, 38);
            this.dgvKorisnikoveNarudzbe.Name = "dgvKorisnikoveNarudzbe";
            this.dgvKorisnikoveNarudzbe.Size = new System.Drawing.Size(636, 187);
            this.dgvKorisnikoveNarudzbe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaše narudžbe:";
            // 
            // detaljiNarudzbe
            // 
            this.detaljiNarudzbe.Location = new System.Drawing.Point(546, 231);
            this.detaljiNarudzbe.Name = "detaljiNarudzbe";
            this.detaljiNarudzbe.Size = new System.Drawing.Size(117, 42);
            this.detaljiNarudzbe.TabIndex = 2;
            this.detaljiNarudzbe.Text = "Prikaži detalje za odabranu narudžbu";
            this.detaljiNarudzbe.UseVisualStyleBackColor = true;
            this.detaljiNarudzbe.Click += new System.EventHandler(this.detaljiNarudzbe_Click);
            // 
            // buttonNapredak
            // 
            this.buttonNapredak.Location = new System.Drawing.Point(423, 231);
            this.buttonNapredak.Name = "buttonNapredak";
            this.buttonNapredak.Size = new System.Drawing.Size(117, 42);
            this.buttonNapredak.TabIndex = 3;
            this.buttonNapredak.Text = "Prikaži napredak za odabranu narudžbu";
            this.buttonNapredak.UseVisualStyleBackColor = true;
            this.buttonNapredak.Click += new System.EventHandler(this.buttonNapredak_Click);
            // 
            // PocetnaKlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 321);
            this.Controls.Add(this.buttonNapredak);
            this.Controls.Add(this.detaljiNarudzbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKorisnikoveNarudzbe);
            this.Name = "PocetnaKlijentForm";
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.PocetnaKlijentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnikoveNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnikoveNarudzbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button detaljiNarudzbe;
        private System.Windows.Forms.Button buttonNapredak;
    }
}