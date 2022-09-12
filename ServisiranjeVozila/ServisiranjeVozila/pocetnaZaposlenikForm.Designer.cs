namespace ServisiranjeVozila
{
    partial class pocetnaZaposlenikForm
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
            this.labelSveNarudzbe = new System.Windows.Forms.Label();
            this.dgvSveNarudzbe = new System.Windows.Forms.DataGridView();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.buttonNapredak = new System.Windows.Forms.Button();
            this.buttonZavrsi = new System.Windows.Forms.Button();
            this.buttonDijelovi = new System.Windows.Forms.Button();
            this.dgvKupovinaDijelova = new System.Windows.Forms.DataGridView();
            this.labelKupovine = new System.Windows.Forms.Label();
            this.buttonDijeloviKupovina = new System.Windows.Forms.Button();
            this.buttonKreirajKupovinu = new System.Windows.Forms.Button();
            this.buttonKupovinaZavrsena = new System.Windows.Forms.Button();
            this.posaljiObavijestKorisnikuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupovinaDijelova)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSveNarudzbe
            // 
            this.labelSveNarudzbe.AutoSize = true;
            this.labelSveNarudzbe.Location = new System.Drawing.Point(9, 23);
            this.labelSveNarudzbe.Name = "labelSveNarudzbe";
            this.labelSveNarudzbe.Size = new System.Drawing.Size(76, 13);
            this.labelSveNarudzbe.TabIndex = 3;
            this.labelSveNarudzbe.Text = "Sve narudžbe:";
            // 
            // dgvSveNarudzbe
            // 
            this.dgvSveNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveNarudzbe.Location = new System.Drawing.Point(12, 39);
            this.dgvSveNarudzbe.Name = "dgvSveNarudzbe";
            this.dgvSveNarudzbe.Size = new System.Drawing.Size(636, 187);
            this.dgvSveNarudzbe.TabIndex = 2;
            this.dgvSveNarudzbe.SelectionChanged += new System.EventHandler(this.dgvSveNarudzbe_SelectionChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Sve narudžbe",
            "U tijeku",
            "Nepotvrđene narudžbe",
            "Potvrđene narudžbe",
            "Otkazane narudžbe",
            "Završene narudžbe"});
            this.cmbFilter.Location = new System.Drawing.Point(446, 12);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbFilter.TabIndex = 4;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(573, 10);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 5;
            this.buttonFilter.Text = "Filtriraj";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonPotvrdi
            // 
            this.buttonPotvrdi.Location = new System.Drawing.Point(12, 232);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(103, 37);
            this.buttonPotvrdi.TabIndex = 6;
            this.buttonPotvrdi.Text = "Potvrdi narudžbu";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // buttonNapredak
            // 
            this.buttonNapredak.Location = new System.Drawing.Point(121, 232);
            this.buttonNapredak.Name = "buttonNapredak";
            this.buttonNapredak.Size = new System.Drawing.Size(103, 37);
            this.buttonNapredak.TabIndex = 7;
            this.buttonNapredak.Text = "Dodaj podatke o napretku";
            this.buttonNapredak.UseVisualStyleBackColor = true;
            this.buttonNapredak.Click += new System.EventHandler(this.buttonNapredak_Click);
            // 
            // buttonZavrsi
            // 
            this.buttonZavrsi.Location = new System.Drawing.Point(545, 232);
            this.buttonZavrsi.Name = "buttonZavrsi";
            this.buttonZavrsi.Size = new System.Drawing.Size(103, 37);
            this.buttonZavrsi.TabIndex = 8;
            this.buttonZavrsi.Text = "Postavi narudžbu kao završenu";
            this.buttonZavrsi.UseVisualStyleBackColor = true;
            this.buttonZavrsi.Click += new System.EventHandler(this.buttonZavrsi_Click);
            // 
            // buttonDijelovi
            // 
            this.buttonDijelovi.Location = new System.Drawing.Point(230, 232);
            this.buttonDijelovi.Name = "buttonDijelovi";
            this.buttonDijelovi.Size = new System.Drawing.Size(103, 37);
            this.buttonDijelovi.TabIndex = 9;
            this.buttonDijelovi.Text = "Dodaj dijelove narudžbi";
            this.buttonDijelovi.UseVisualStyleBackColor = true;
            this.buttonDijelovi.Click += new System.EventHandler(this.buttonDijelovi_Click);
            // 
            // dgvKupovinaDijelova
            // 
            this.dgvKupovinaDijelova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKupovinaDijelova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKupovinaDijelova.Location = new System.Drawing.Point(12, 313);
            this.dgvKupovinaDijelova.Name = "dgvKupovinaDijelova";
            this.dgvKupovinaDijelova.Size = new System.Drawing.Size(636, 187);
            this.dgvKupovinaDijelova.TabIndex = 10;
            this.dgvKupovinaDijelova.SelectionChanged += new System.EventHandler(this.dgvKupovinaDijelova_SelectionChanged);
            // 
            // labelKupovine
            // 
            this.labelKupovine.AutoSize = true;
            this.labelKupovine.Location = new System.Drawing.Point(9, 297);
            this.labelKupovine.Name = "labelKupovine";
            this.labelKupovine.Size = new System.Drawing.Size(94, 13);
            this.labelKupovine.TabIndex = 11;
            this.labelKupovine.Text = "Kupovine dijelova:";
            // 
            // buttonDijeloviKupovina
            // 
            this.buttonDijeloviKupovina.Location = new System.Drawing.Point(121, 506);
            this.buttonDijeloviKupovina.Name = "buttonDijeloviKupovina";
            this.buttonDijeloviKupovina.Size = new System.Drawing.Size(103, 37);
            this.buttonDijeloviKupovina.TabIndex = 12;
            this.buttonDijeloviKupovina.Text = "Dodaj dijelove u kupovinu";
            this.buttonDijeloviKupovina.UseVisualStyleBackColor = true;
            this.buttonDijeloviKupovina.Click += new System.EventHandler(this.buttonDijeloviKupovina_Click);
            // 
            // buttonKreirajKupovinu
            // 
            this.buttonKreirajKupovinu.Location = new System.Drawing.Point(12, 506);
            this.buttonKreirajKupovinu.Name = "buttonKreirajKupovinu";
            this.buttonKreirajKupovinu.Size = new System.Drawing.Size(103, 37);
            this.buttonKreirajKupovinu.TabIndex = 13;
            this.buttonKreirajKupovinu.Text = "Kreiraj novu kupovinu";
            this.buttonKreirajKupovinu.UseVisualStyleBackColor = true;
            this.buttonKreirajKupovinu.Click += new System.EventHandler(this.buttonKreirajKupovinu_Click);
            // 
            // buttonKupovinaZavrsena
            // 
            this.buttonKupovinaZavrsena.Location = new System.Drawing.Point(545, 506);
            this.buttonKupovinaZavrsena.Name = "buttonKupovinaZavrsena";
            this.buttonKupovinaZavrsena.Size = new System.Drawing.Size(103, 37);
            this.buttonKupovinaZavrsena.TabIndex = 14;
            this.buttonKupovinaZavrsena.Text = "Postavi kupovinu kao završenu";
            this.buttonKupovinaZavrsena.UseVisualStyleBackColor = true;
            this.buttonKupovinaZavrsena.Click += new System.EventHandler(this.buttonKupovinaZavrsena_Click);
            // 
            // posaljiObavijestKorisnikuButton
            // 
            this.posaljiObavijestKorisnikuButton.Location = new System.Drawing.Point(340, 233);
            this.posaljiObavijestKorisnikuButton.Name = "posaljiObavijestKorisnikuButton";
            this.posaljiObavijestKorisnikuButton.Size = new System.Drawing.Size(92, 36);
            this.posaljiObavijestKorisnikuButton.TabIndex = 15;
            this.posaljiObavijestKorisnikuButton.Text = "Pošalji obavijest korisniku";
            this.posaljiObavijestKorisnikuButton.UseVisualStyleBackColor = true;
            this.posaljiObavijestKorisnikuButton.Click += new System.EventHandler(this.posaljiObavijestKorisnikuButton_Click);
            // 
            // pocetnaZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(662, 566);
            this.Controls.Add(this.posaljiObavijestKorisnikuButton);
            this.Controls.Add(this.buttonKupovinaZavrsena);
            this.Controls.Add(this.buttonKreirajKupovinu);
            this.Controls.Add(this.buttonDijeloviKupovina);
            this.Controls.Add(this.labelKupovine);
            this.Controls.Add(this.dgvKupovinaDijelova);
            this.Controls.Add(this.buttonDijelovi);
            this.Controls.Add(this.buttonZavrsi);
            this.Controls.Add(this.buttonNapredak);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.labelSveNarudzbe);
            this.Controls.Add(this.dgvSveNarudzbe);
            this.Name = "pocetnaZaposlenikForm";
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.pocetnaZaposlenikForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.pocetnaZaposlenikForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKupovinaDijelova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSveNarudzbe;
        private System.Windows.Forms.DataGridView dgvSveNarudzbe;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Button buttonNapredak;
        private System.Windows.Forms.Button buttonZavrsi;
        private System.Windows.Forms.Button buttonDijelovi;
        private System.Windows.Forms.DataGridView dgvKupovinaDijelova;
        private System.Windows.Forms.Label labelKupovine;
        private System.Windows.Forms.Button buttonDijeloviKupovina;
        private System.Windows.Forms.Button buttonKreirajKupovinu;
        private System.Windows.Forms.Button buttonKupovinaZavrsena;
        private System.Windows.Forms.Button posaljiObavijestKorisnikuButton;
    }
}