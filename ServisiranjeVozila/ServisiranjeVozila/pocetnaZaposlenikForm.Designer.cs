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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSveNarudzbe = new System.Windows.Forms.DataGridView();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonPotvrdi = new System.Windows.Forms.Button();
            this.buttonNapredak = new System.Windows.Forms.Button();
            this.buttonZavrsi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sve narudžbe:";
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
            this.buttonPotvrdi.Location = new System.Drawing.Point(545, 232);
            this.buttonPotvrdi.Name = "buttonPotvrdi";
            this.buttonPotvrdi.Size = new System.Drawing.Size(103, 37);
            this.buttonPotvrdi.TabIndex = 6;
            this.buttonPotvrdi.Text = "Potvrdi narudžbu";
            this.buttonPotvrdi.UseVisualStyleBackColor = true;
            this.buttonPotvrdi.Click += new System.EventHandler(this.buttonPotvrdi_Click);
            // 
            // buttonNapredak
            // 
            this.buttonNapredak.Location = new System.Drawing.Point(436, 232);
            this.buttonNapredak.Name = "buttonNapredak";
            this.buttonNapredak.Size = new System.Drawing.Size(103, 37);
            this.buttonNapredak.TabIndex = 7;
            this.buttonNapredak.Text = "Dodaj podatke o napretku";
            this.buttonNapredak.UseVisualStyleBackColor = true;
            this.buttonNapredak.Click += new System.EventHandler(this.buttonNapredak_Click);
            // 
            // buttonZavrsi
            // 
            this.buttonZavrsi.Location = new System.Drawing.Point(327, 232);
            this.buttonZavrsi.Name = "buttonZavrsi";
            this.buttonZavrsi.Size = new System.Drawing.Size(103, 37);
            this.buttonZavrsi.TabIndex = 8;
            this.buttonZavrsi.Text = "Postavi narudžbu kao završenu";
            this.buttonZavrsi.UseVisualStyleBackColor = true;
            this.buttonZavrsi.Click += new System.EventHandler(this.buttonZavrsi_Click);
            // 
            // pocetnaZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 290);
            this.Controls.Add(this.buttonZavrsi);
            this.Controls.Add(this.buttonNapredak);
            this.Controls.Add(this.buttonPotvrdi);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSveNarudzbe);
            this.Name = "pocetnaZaposlenikForm";
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.pocetnaZaposlenikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSveNarudzbe;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonPotvrdi;
        private System.Windows.Forms.Button buttonNapredak;
        private System.Windows.Forms.Button buttonZavrsi;
    }
}