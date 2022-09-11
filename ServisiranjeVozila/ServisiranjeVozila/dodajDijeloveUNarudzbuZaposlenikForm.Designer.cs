namespace ServisiranjeVozila
{
    partial class dodajDijeloveUNarudzbuZaposlenikForm
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
            this.labelPretrazivanjeNaziv = new System.Windows.Forms.Label();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.labelPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.textBoxPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.labelSviDijelovi = new System.Windows.Forms.Label();
            this.labelDijeloviUNarudzbi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviDijelovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijeloviUNarudzbi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviDijelovi
            // 
            this.dgvSviDijelovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSviDijelovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviDijelovi.Location = new System.Drawing.Point(21, 88);
            this.dgvSviDijelovi.Name = "dgvSviDijelovi";
            this.dgvSviDijelovi.Size = new System.Drawing.Size(379, 337);
            this.dgvSviDijelovi.TabIndex = 0;
            // 
            // dgvDijeloviUNarudzbi
            // 
            this.dgvDijeloviUNarudzbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDijeloviUNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijeloviUNarudzbi.Location = new System.Drawing.Point(487, 89);
            this.dgvDijeloviUNarudzbi.Name = "dgvDijeloviUNarudzbi";
            this.dgvDijeloviUNarudzbi.Size = new System.Drawing.Size(379, 337);
            this.dgvDijeloviUNarudzbi.TabIndex = 1;
            // 
            // buttonUNarudzbu
            // 
            this.buttonUNarudzbu.Location = new System.Drawing.Point(406, 165);
            this.buttonUNarudzbu.Name = "buttonUNarudzbu";
            this.buttonUNarudzbu.Size = new System.Drawing.Size(75, 23);
            this.buttonUNarudzbu.TabIndex = 2;
            this.buttonUNarudzbu.Text = ">>>";
            this.buttonUNarudzbu.UseVisualStyleBackColor = true;
            this.buttonUNarudzbu.Click += new System.EventHandler(this.buttonUNarudzbu_Click);
            // 
            // textBoxPretrazivanje
            // 
            this.textBoxPretrazivanje.Location = new System.Drawing.Point(215, 25);
            this.textBoxPretrazivanje.Name = "textBoxPretrazivanje";
            this.textBoxPretrazivanje.Size = new System.Drawing.Size(185, 20);
            this.textBoxPretrazivanje.TabIndex = 4;
            this.textBoxPretrazivanje.TextChanged += new System.EventHandler(this.textBoxPretrazivanje_TextChanged);
            // 
            // labelPretrazivanjeNaziv
            // 
            this.labelPretrazivanjeNaziv.AutoSize = true;
            this.labelPretrazivanjeNaziv.Location = new System.Drawing.Point(18, 28);
            this.labelPretrazivanjeNaziv.Name = "labelPretrazivanjeNaziv";
            this.labelPretrazivanjeNaziv.Size = new System.Drawing.Size(137, 13);
            this.labelPretrazivanjeNaziv.TabIndex = 5;
            this.labelPretrazivanjeNaziv.Text = "Pretraživanje prema nazivu:";
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(791, 432);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 6;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // labelPretrazivanjeSifra
            // 
            this.labelPretrazivanjeSifra.AutoSize = true;
            this.labelPretrazivanjeSifra.Location = new System.Drawing.Point(18, 54);
            this.labelPretrazivanjeSifra.Name = "labelPretrazivanjeSifra";
            this.labelPretrazivanjeSifra.Size = new System.Drawing.Size(121, 13);
            this.labelPretrazivanjeSifra.TabIndex = 8;
            this.labelPretrazivanjeSifra.Text = "Pretraživanje prema šifri:";
            // 
            // textBoxPretrazivanjeSifra
            // 
            this.textBoxPretrazivanjeSifra.Location = new System.Drawing.Point(215, 51);
            this.textBoxPretrazivanjeSifra.Name = "textBoxPretrazivanjeSifra";
            this.textBoxPretrazivanjeSifra.Size = new System.Drawing.Size(185, 20);
            this.textBoxPretrazivanjeSifra.TabIndex = 7;
            this.textBoxPretrazivanjeSifra.TextChanged += new System.EventHandler(this.textBoxPretrazivanjeSifra_TextChanged);
            // 
            // labelSviDijelovi
            // 
            this.labelSviDijelovi.AutoSize = true;
            this.labelSviDijelovi.Location = new System.Drawing.Point(18, 72);
            this.labelSviDijelovi.Name = "labelSviDijelovi";
            this.labelSviDijelovi.Size = new System.Drawing.Size(60, 13);
            this.labelSviDijelovi.TabIndex = 13;
            this.labelSviDijelovi.Text = "Svi dijelovi:";
            // 
            // labelDijeloviUNarudzbi
            // 
            this.labelDijeloviUNarudzbi.AutoSize = true;
            this.labelDijeloviUNarudzbi.Location = new System.Drawing.Point(484, 73);
            this.labelDijeloviUNarudzbi.Name = "labelDijeloviUNarudzbi";
            this.labelDijeloviUNarudzbi.Size = new System.Drawing.Size(136, 13);
            this.labelDijeloviUNarudzbi.TabIndex = 14;
            this.labelDijeloviUNarudzbi.Text = "Dijelovi utrošeni u narudžbi:";
            // 
            // dodajDijeloveUNarudzbuZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(884, 468);
            this.Controls.Add(this.labelDijeloviUNarudzbi);
            this.Controls.Add(this.labelSviDijelovi);
            this.Controls.Add(this.labelPretrazivanjeSifra);
            this.Controls.Add(this.textBoxPretrazivanjeSifra);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.labelPretrazivanjeNaziv);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Controls.Add(this.buttonUNarudzbu);
            this.Controls.Add(this.dgvDijeloviUNarudzbi);
            this.Controls.Add(this.dgvSviDijelovi);
            this.Name = "dodajDijeloveUNarudzbuZaposlenikForm";
            this.Text = "Dodaj dijelove u narudžbu";
            this.Load += new System.EventHandler(this.dodajDijeloveZaposlenikForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.dodajDijeloveZaposlenikForm_HelpRequested);
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
        private System.Windows.Forms.Label labelPretrazivanjeNaziv;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Label labelPretrazivanjeSifra;
        private System.Windows.Forms.TextBox textBoxPretrazivanjeSifra;
        private System.Windows.Forms.Label labelSviDijelovi;
        private System.Windows.Forms.Label labelDijeloviUNarudzbi;
    }
}