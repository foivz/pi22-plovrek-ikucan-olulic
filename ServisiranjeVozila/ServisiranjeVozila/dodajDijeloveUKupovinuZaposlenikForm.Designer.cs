namespace ServisiranjeVozila
{
    partial class dodajDijeloveUKupovinuZaposlenikForm
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
            this.dgvDijelovi = new System.Windows.Forms.DataGridView();
            this.textBoxPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.labelPretrazivanjeSifra = new System.Windows.Forms.Label();
            this.labelPretrazivanjeNaziv = new System.Windows.Forms.Label();
            this.textBoxPretrazivanjeNaziv = new System.Windows.Forms.TextBox();
            this.buttonUNarudzbu = new System.Windows.Forms.Button();
            this.dgvDijeloviUKupovini = new System.Windows.Forms.DataGridView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.labelSviDijelovi = new System.Windows.Forms.Label();
            this.labelDijeloviUKupovini = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijeloviUKupovini)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDijelovi
            // 
            this.dgvDijelovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDijelovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijelovi.Location = new System.Drawing.Point(22, 88);
            this.dgvDijelovi.Name = "dgvDijelovi";
            this.dgvDijelovi.Size = new System.Drawing.Size(379, 337);
            this.dgvDijelovi.TabIndex = 1;
            // 
            // textBoxPretrazivanjeSifra
            // 
            this.textBoxPretrazivanjeSifra.Location = new System.Drawing.Point(216, 50);
            this.textBoxPretrazivanjeSifra.Name = "textBoxPretrazivanjeSifra";
            this.textBoxPretrazivanjeSifra.Size = new System.Drawing.Size(185, 20);
            this.textBoxPretrazivanjeSifra.TabIndex = 5;
            this.textBoxPretrazivanjeSifra.TextChanged += new System.EventHandler(this.textBoxPretrazivanjeSifra_TextChanged);
            // 
            // labelPretrazivanjeSifra
            // 
            this.labelPretrazivanjeSifra.AutoSize = true;
            this.labelPretrazivanjeSifra.Location = new System.Drawing.Point(19, 53);
            this.labelPretrazivanjeSifra.Name = "labelPretrazivanjeSifra";
            this.labelPretrazivanjeSifra.Size = new System.Drawing.Size(121, 13);
            this.labelPretrazivanjeSifra.TabIndex = 6;
            this.labelPretrazivanjeSifra.Text = "Pretraživanje prema šifri:";
            // 
            // labelPretrazivanjeNaziv
            // 
            this.labelPretrazivanjeNaziv.AutoSize = true;
            this.labelPretrazivanjeNaziv.Location = new System.Drawing.Point(19, 27);
            this.labelPretrazivanjeNaziv.Name = "labelPretrazivanjeNaziv";
            this.labelPretrazivanjeNaziv.Size = new System.Drawing.Size(137, 13);
            this.labelPretrazivanjeNaziv.TabIndex = 7;
            this.labelPretrazivanjeNaziv.Text = "Pretraživanje prema nazivu:";
            // 
            // textBoxPretrazivanjeNaziv
            // 
            this.textBoxPretrazivanjeNaziv.Location = new System.Drawing.Point(216, 24);
            this.textBoxPretrazivanjeNaziv.Name = "textBoxPretrazivanjeNaziv";
            this.textBoxPretrazivanjeNaziv.Size = new System.Drawing.Size(185, 20);
            this.textBoxPretrazivanjeNaziv.TabIndex = 8;
            this.textBoxPretrazivanjeNaziv.TextChanged += new System.EventHandler(this.textBoxPretrazivanjeNaziv_TextChanged);
            // 
            // buttonUNarudzbu
            // 
            this.buttonUNarudzbu.Location = new System.Drawing.Point(407, 164);
            this.buttonUNarudzbu.Name = "buttonUNarudzbu";
            this.buttonUNarudzbu.Size = new System.Drawing.Size(75, 23);
            this.buttonUNarudzbu.TabIndex = 10;
            this.buttonUNarudzbu.Text = ">>>";
            this.buttonUNarudzbu.UseVisualStyleBackColor = true;
            this.buttonUNarudzbu.Click += new System.EventHandler(this.buttonUNarudzbu_Click);
            // 
            // dgvDijeloviUKupovini
            // 
            this.dgvDijeloviUKupovini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDijeloviUKupovini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijeloviUKupovini.Location = new System.Drawing.Point(488, 88);
            this.dgvDijeloviUKupovini.Name = "dgvDijeloviUKupovini";
            this.dgvDijeloviUKupovini.Size = new System.Drawing.Size(379, 337);
            this.dgvDijeloviUKupovini.TabIndex = 9;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(792, 431);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 11;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // labelSviDijelovi
            // 
            this.labelSviDijelovi.AutoSize = true;
            this.labelSviDijelovi.Location = new System.Drawing.Point(19, 72);
            this.labelSviDijelovi.Name = "labelSviDijelovi";
            this.labelSviDijelovi.Size = new System.Drawing.Size(60, 13);
            this.labelSviDijelovi.TabIndex = 12;
            this.labelSviDijelovi.Text = "Svi dijelovi:";
            // 
            // labelDijeloviUKupovini
            // 
            this.labelDijeloviUKupovini.AutoSize = true;
            this.labelDijeloviUKupovini.Location = new System.Drawing.Point(485, 72);
            this.labelDijeloviUKupovini.Name = "labelDijeloviUKupovini";
            this.labelDijeloviUKupovini.Size = new System.Drawing.Size(96, 13);
            this.labelDijeloviUKupovini.TabIndex = 13;
            this.labelDijeloviUKupovini.Text = "Dijelovi u kupovini:";
            // 
            // dodajDijeloveUKupovinuZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(882, 465);
            this.Controls.Add(this.labelDijeloviUKupovini);
            this.Controls.Add(this.labelSviDijelovi);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.buttonUNarudzbu);
            this.Controls.Add(this.dgvDijeloviUKupovini);
            this.Controls.Add(this.textBoxPretrazivanjeNaziv);
            this.Controls.Add(this.labelPretrazivanjeNaziv);
            this.Controls.Add(this.labelPretrazivanjeSifra);
            this.Controls.Add(this.textBoxPretrazivanjeSifra);
            this.Controls.Add(this.dgvDijelovi);
            this.Name = "dodajDijeloveUKupovinuZaposlenikForm";
            this.Text = "Dodaj dijelove u kupovinu";
            this.Load += new System.EventHandler(this.dodajDijeloveUKupovinuZaposlenikForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.dodajDijeloveUKupovinuZaposlenikForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijeloviUKupovini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDijelovi;
        private System.Windows.Forms.TextBox textBoxPretrazivanjeSifra;
        private System.Windows.Forms.Label labelPretrazivanjeSifra;
        private System.Windows.Forms.Label labelPretrazivanjeNaziv;
        private System.Windows.Forms.TextBox textBoxPretrazivanjeNaziv;
        private System.Windows.Forms.Button buttonUNarudzbu;
        private System.Windows.Forms.DataGridView dgvDijeloviUKupovini;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Label labelSviDijelovi;
        private System.Windows.Forms.Label labelDijeloviUKupovini;
    }
}