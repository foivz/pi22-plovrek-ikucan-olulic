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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPretrazivanjeSifra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretraživanje prema nazivu:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pretraživanje prema šifri:";
            // 
            // textBoxPretrazivanjeSifra
            // 
            this.textBoxPretrazivanjeSifra.Location = new System.Drawing.Point(215, 51);
            this.textBoxPretrazivanjeSifra.Name = "textBoxPretrazivanjeSifra";
            this.textBoxPretrazivanjeSifra.Size = new System.Drawing.Size(185, 20);
            this.textBoxPretrazivanjeSifra.TabIndex = 7;
            this.textBoxPretrazivanjeSifra.TextChanged += new System.EventHandler(this.textBoxPretrazivanjeSifra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Svi dijelovi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dijelovi utrošeni u narudžbi:";
            // 
            // dodajDijeloveZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPretrazivanjeSifra);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPretrazivanje);
            this.Controls.Add(this.buttonUNarudzbu);
            this.Controls.Add(this.dgvDijeloviUNarudzbi);
            this.Controls.Add(this.dgvSviDijelovi);
            this.Name = "dodajDijeloveZaposlenikForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPretrazivanjeSifra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}