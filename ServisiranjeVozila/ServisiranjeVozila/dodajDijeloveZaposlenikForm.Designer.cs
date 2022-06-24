namespace ServisiranjeVozila
{
    partial class dodajDijeloveZaposlenikForm
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
            this.dgvSviDijelovi = new System.Windows.Forms.DataGridView();
            this.dgvDijeloviUNarudzbi = new System.Windows.Forms.DataGridView();
            this.buttonUNarudzbu = new System.Windows.Forms.Button();
            this.textBoxPretrazivanje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviDijelovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijeloviUNarudzbi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviDijelovi
            // 
            this.dgvSviDijelovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSviDijelovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviDijelovi.Location = new System.Drawing.Point(27, 47);
            this.dgvSviDijelovi.Name = "dgvSviDijelovi";
            this.dgvSviDijelovi.Size = new System.Drawing.Size(325, 337);
            this.dgvSviDijelovi.TabIndex = 0;
            // 
            // dgvDijeloviUNarudzbi
            // 
            this.dgvDijeloviUNarudzbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDijeloviUNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijeloviUNarudzbi.Location = new System.Drawing.Point(439, 47);
            this.dgvDijeloviUNarudzbi.Name = "dgvDijeloviUNarudzbi";
            this.dgvDijeloviUNarudzbi.Size = new System.Drawing.Size(325, 337);
            this.dgvDijeloviUNarudzbi.TabIndex = 1;
            // 
            // buttonUNarudzbu
            // 
            this.buttonUNarudzbu.Location = new System.Drawing.Point(358, 123);
            this.buttonUNarudzbu.Name = "buttonUNarudzbu";
            this.buttonUNarudzbu.Size = new System.Drawing.Size(75, 23);
            this.buttonUNarudzbu.TabIndex = 2;
            this.buttonUNarudzbu.Text = ">>>";
            this.buttonUNarudzbu.UseVisualStyleBackColor = true;
            this.buttonUNarudzbu.Click += new System.EventHandler(this.buttonUNarudzbu_Click);
            // 
            // textBoxPretrazivanje
            // 
            this.textBoxPretrazivanje.Location = new System.Drawing.Point(167, 21);
            this.textBoxPretrazivanje.Name = "textBoxPretrazivanje";
            this.textBoxPretrazivanje.Size = new System.Drawing.Size(185, 20);
            this.textBoxPretrazivanje.TabIndex = 4;
            this.textBoxPretrazivanje.TextChanged += new System.EventHandler(this.textBoxPretrazivanje_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraživanje prema nazivu:";
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(689, 391);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 6;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // dodajDijeloveZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 426);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Controls.Add(this.buttonUNarudzbu);
            this.Controls.Add(this.dgvDijeloviUNarudzbi);
            this.Controls.Add(this.dgvSviDijelovi);
            this.Name = "dodajDijeloveZaposlenikForm";
            this.Text = "Dodaj dijelove";
            this.Load += new System.EventHandler(this.dodajDijeloveZaposlenikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviDijelovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijeloviUNarudzbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviDijelovi;
        private System.Windows.Forms.DataGridView dgvDijeloviUNarudzbi;
        private System.Windows.Forms.Button buttonUNarudzbu;
        private System.Windows.Forms.TextBox textBoxPretrazivanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZatvori;
    }
}