namespace ServisiranjeVozila
{
    partial class pregledVozilaKlijentForm
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
            this.dgvVozila = new System.Windows.Forms.DataGridView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.buttonDodajVozilo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVozila
            // 
            this.dgvVozila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVozila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVozila.Location = new System.Drawing.Point(12, 12);
            this.dgvVozila.Name = "dgvVozila";
            this.dgvVozila.Size = new System.Drawing.Size(467, 198);
            this.dgvVozila.TabIndex = 0;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(404, 216);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 1;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // buttonDodajVozilo
            // 
            this.buttonDodajVozilo.Location = new System.Drawing.Point(12, 216);
            this.buttonDodajVozilo.Name = "buttonDodajVozilo";
            this.buttonDodajVozilo.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajVozilo.TabIndex = 2;
            this.buttonDodajVozilo.Text = "Dodaj vozilo";
            this.buttonDodajVozilo.UseVisualStyleBackColor = true;
            // 
            // pregledVozilaKlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 248);
            this.Controls.Add(this.buttonDodajVozilo);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.dgvVozila);
            this.Name = "pregledVozilaKlijentForm";
            this.Text = "Vozila";
            this.Load += new System.EventHandler(this.VozilaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVozila)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVozila;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Button buttonDodajVozilo;
    }
}