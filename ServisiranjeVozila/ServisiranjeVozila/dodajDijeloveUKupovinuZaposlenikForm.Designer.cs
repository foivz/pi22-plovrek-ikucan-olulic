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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPretrazivanjeNaziv = new System.Windows.Forms.TextBox();
            this.buttonUNarudzbu = new System.Windows.Forms.Button();
            this.dgvDijeloviUNarudzbi = new System.Windows.Forms.DataGridView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijeloviUNarudzbi)).BeginInit();
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
            this.textBoxPretrazivanjeSifra.Location = new System.Drawing.Point(216, 59);
            this.textBoxPretrazivanjeSifra.Name = "textBoxPretrazivanjeSifra";
            this.textBoxPretrazivanjeSifra.Size = new System.Drawing.Size(185, 20);
            this.textBoxPretrazivanjeSifra.TabIndex = 5;
            this.textBoxPretrazivanjeSifra.TextChanged += new System.EventHandler(this.textBoxPretrazivanjeSifra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pretraživanje prema šifri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pretraživanje prema nazivu:";
            // 
            // textBoxPretrazivanjeNaziv
            // 
            this.textBoxPretrazivanjeNaziv.Location = new System.Drawing.Point(216, 33);
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
            // dgvDijeloviUNarudzbi
            // 
            this.dgvDijeloviUNarudzbi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDijeloviUNarudzbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijeloviUNarudzbi.Location = new System.Drawing.Point(488, 88);
            this.dgvDijeloviUNarudzbi.Name = "dgvDijeloviUNarudzbi";
            this.dgvDijeloviUNarudzbi.Size = new System.Drawing.Size(379, 337);
            this.dgvDijeloviUNarudzbi.TabIndex = 9;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(792, 436);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 11;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // dodajDijeloveUKupovinuZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 471);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.buttonUNarudzbu);
            this.Controls.Add(this.dgvDijeloviUNarudzbi);
            this.Controls.Add(this.textBoxPretrazivanjeNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPretrazivanjeSifra);
            this.Controls.Add(this.dgvDijelovi);
            this.Name = "dodajDijeloveUKupovinuZaposlenikForm";
            this.Text = "Dodaj dijelove u kupovinu";
            this.Load += new System.EventHandler(this.dodajDijeloveUKupovinuZaposlenikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijeloviUNarudzbi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDijelovi;
        private System.Windows.Forms.TextBox textBoxPretrazivanjeSifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPretrazivanjeNaziv;
        private System.Windows.Forms.Button buttonUNarudzbu;
        private System.Windows.Forms.DataGridView dgvDijeloviUNarudzbi;
        private System.Windows.Forms.Button buttonZatvori;
    }
}