namespace ServisiranjeVozila
{
    partial class detaljiNarudzbeKlijentForm
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
            this.labelKorime = new System.Windows.Forms.Label();
            this.textBoxKorime = new System.Windows.Forms.TextBox();
            this.textBoxRegistracija = new System.Windows.Forms.TextBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.labelNapomena = new System.Windows.Forms.Label();
            this.textBoxDatum = new System.Windows.Forms.TextBox();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelPotvrdeno = new System.Windows.Forms.Label();
            this.labelOtkazano = new System.Windows.Forms.Label();
            this.labelZavrseno = new System.Windows.Forms.Label();
            this.radioButtonPotvrdeno = new System.Windows.Forms.RadioButton();
            this.radioButtonOtkazano = new System.Windows.Forms.RadioButton();
            this.radioButtonZavrseno = new System.Windows.Forms.RadioButton();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.groupBoxDijelovi = new System.Windows.Forms.GroupBox();
            this.dgvDijelovi = new System.Windows.Forms.DataGridView();
            this.groupBoxPodaci = new System.Windows.Forms.GroupBox();
            this.groupBoxNapredak = new System.Windows.Forms.GroupBox();
            this.dgvNapredak = new System.Windows.Forms.DataGridView();
            this.groupBoxDijelovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).BeginInit();
            this.groupBoxPodaci.SuspendLayout();
            this.groupBoxNapredak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapredak)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKorime
            // 
            this.labelKorime.AutoSize = true;
            this.labelKorime.Location = new System.Drawing.Point(40, 39);
            this.labelKorime.Name = "labelKorime";
            this.labelKorime.Size = new System.Drawing.Size(78, 13);
            this.labelKorime.TabIndex = 0;
            this.labelKorime.Text = "Korisničko ime:";
            // 
            // textBoxKorime
            // 
            this.textBoxKorime.Enabled = false;
            this.textBoxKorime.Location = new System.Drawing.Point(140, 36);
            this.textBoxKorime.Name = "textBoxKorime";
            this.textBoxKorime.Size = new System.Drawing.Size(100, 20);
            this.textBoxKorime.TabIndex = 1;
            // 
            // textBoxRegistracija
            // 
            this.textBoxRegistracija.Enabled = false;
            this.textBoxRegistracija.Location = new System.Drawing.Point(140, 62);
            this.textBoxRegistracija.Name = "textBoxRegistracija";
            this.textBoxRegistracija.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistracija.TabIndex = 3;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Location = new System.Drawing.Point(39, 65);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(95, 13);
            this.labelReg.TabIndex = 2;
            this.labelReg.Text = "Registracija vozila:";
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Enabled = false;
            this.textBoxNapomena.Location = new System.Drawing.Point(128, 74);
            this.textBoxNapomena.Multiline = true;
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(157, 71);
            this.textBoxNapomena.TabIndex = 11;
            // 
            // labelNapomena
            // 
            this.labelNapomena.AutoSize = true;
            this.labelNapomena.Location = new System.Drawing.Point(27, 74);
            this.labelNapomena.Name = "labelNapomena";
            this.labelNapomena.Size = new System.Drawing.Size(62, 13);
            this.labelNapomena.TabIndex = 10;
            this.labelNapomena.Text = "Napomena:";
            // 
            // textBoxDatum
            // 
            this.textBoxDatum.Enabled = false;
            this.textBoxDatum.Location = new System.Drawing.Point(128, 151);
            this.textBoxDatum.Name = "textBoxDatum";
            this.textBoxDatum.Size = new System.Drawing.Size(100, 20);
            this.textBoxDatum.TabIndex = 13;
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(27, 154);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(88, 13);
            this.labelDatum.TabIndex = 12;
            this.labelDatum.Text = "Datum narudžbe:";
            // 
            // labelPotvrdeno
            // 
            this.labelPotvrdeno.AutoSize = true;
            this.labelPotvrdeno.Location = new System.Drawing.Point(27, 180);
            this.labelPotvrdeno.Name = "labelPotvrdeno";
            this.labelPotvrdeno.Size = new System.Drawing.Size(60, 13);
            this.labelPotvrdeno.TabIndex = 14;
            this.labelPotvrdeno.Text = "Potvrđeno:";
            // 
            // labelOtkazano
            // 
            this.labelOtkazano.AutoSize = true;
            this.labelOtkazano.Location = new System.Drawing.Point(27, 206);
            this.labelOtkazano.Name = "labelOtkazano";
            this.labelOtkazano.Size = new System.Drawing.Size(56, 13);
            this.labelOtkazano.TabIndex = 16;
            this.labelOtkazano.Text = "Otkazano:";
            // 
            // labelZavrseno
            // 
            this.labelZavrseno.AutoSize = true;
            this.labelZavrseno.Location = new System.Drawing.Point(27, 232);
            this.labelZavrseno.Name = "labelZavrseno";
            this.labelZavrseno.Size = new System.Drawing.Size(55, 13);
            this.labelZavrseno.TabIndex = 18;
            this.labelZavrseno.Text = "Završeno:";
            // 
            // radioButtonPotvrdeno
            // 
            this.radioButtonPotvrdeno.AutoSize = true;
            this.radioButtonPotvrdeno.Enabled = false;
            this.radioButtonPotvrdeno.Location = new System.Drawing.Point(128, 180);
            this.radioButtonPotvrdeno.Name = "radioButtonPotvrdeno";
            this.radioButtonPotvrdeno.Size = new System.Drawing.Size(14, 13);
            this.radioButtonPotvrdeno.TabIndex = 19;
            this.radioButtonPotvrdeno.TabStop = true;
            this.radioButtonPotvrdeno.UseVisualStyleBackColor = true;
            // 
            // radioButtonOtkazano
            // 
            this.radioButtonOtkazano.AutoSize = true;
            this.radioButtonOtkazano.Enabled = false;
            this.radioButtonOtkazano.Location = new System.Drawing.Point(128, 206);
            this.radioButtonOtkazano.Name = "radioButtonOtkazano";
            this.radioButtonOtkazano.Size = new System.Drawing.Size(14, 13);
            this.radioButtonOtkazano.TabIndex = 20;
            this.radioButtonOtkazano.TabStop = true;
            this.radioButtonOtkazano.UseVisualStyleBackColor = true;
            // 
            // radioButtonZavrseno
            // 
            this.radioButtonZavrseno.AutoSize = true;
            this.radioButtonZavrseno.Enabled = false;
            this.radioButtonZavrseno.Location = new System.Drawing.Point(128, 232);
            this.radioButtonZavrseno.Name = "radioButtonZavrseno";
            this.radioButtonZavrseno.Size = new System.Drawing.Size(14, 13);
            this.radioButtonZavrseno.TabIndex = 21;
            this.radioButtonZavrseno.TabStop = true;
            this.radioButtonZavrseno.UseVisualStyleBackColor = true;
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Enabled = false;
            this.buttonOtkazi.Location = new System.Drawing.Point(81, 262);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(106, 23);
            this.buttonOtkazi.TabIndex = 22;
            this.buttonOtkazi.Text = "Otkaži narudžbu";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(1044, 397);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(82, 23);
            this.buttonZatvori.TabIndex = 23;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // groupBoxDijelovi
            // 
            this.groupBoxDijelovi.Controls.Add(this.dgvDijelovi);
            this.groupBoxDijelovi.Location = new System.Drawing.Point(321, 14);
            this.groupBoxDijelovi.Name = "groupBoxDijelovi";
            this.groupBoxDijelovi.Size = new System.Drawing.Size(395, 383);
            this.groupBoxDijelovi.TabIndex = 24;
            this.groupBoxDijelovi.TabStop = false;
            this.groupBoxDijelovi.Text = "Popis dijelova";
            // 
            // dgvDijelovi
            // 
            this.dgvDijelovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDijelovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijelovi.Location = new System.Drawing.Point(6, 19);
            this.dgvDijelovi.Name = "dgvDijelovi";
            this.dgvDijelovi.Size = new System.Drawing.Size(383, 358);
            this.dgvDijelovi.TabIndex = 0;
            // 
            // groupBoxPodaci
            // 
            this.groupBoxPodaci.Controls.Add(this.textBoxNapomena);
            this.groupBoxPodaci.Controls.Add(this.labelNapomena);
            this.groupBoxPodaci.Controls.Add(this.buttonOtkazi);
            this.groupBoxPodaci.Controls.Add(this.labelDatum);
            this.groupBoxPodaci.Controls.Add(this.radioButtonZavrseno);
            this.groupBoxPodaci.Controls.Add(this.textBoxDatum);
            this.groupBoxPodaci.Controls.Add(this.radioButtonOtkazano);
            this.groupBoxPodaci.Controls.Add(this.labelPotvrdeno);
            this.groupBoxPodaci.Controls.Add(this.radioButtonPotvrdeno);
            this.groupBoxPodaci.Controls.Add(this.labelOtkazano);
            this.groupBoxPodaci.Controls.Add(this.labelZavrseno);
            this.groupBoxPodaci.Location = new System.Drawing.Point(12, 14);
            this.groupBoxPodaci.Name = "groupBoxPodaci";
            this.groupBoxPodaci.Size = new System.Drawing.Size(294, 383);
            this.groupBoxPodaci.TabIndex = 25;
            this.groupBoxPodaci.TabStop = false;
            this.groupBoxPodaci.Text = "Podaci o narudžbi";
            // 
            // groupBoxNapredak
            // 
            this.groupBoxNapredak.Controls.Add(this.dgvNapredak);
            this.groupBoxNapredak.Location = new System.Drawing.Point(731, 14);
            this.groupBoxNapredak.Name = "groupBoxNapredak";
            this.groupBoxNapredak.Size = new System.Drawing.Size(395, 383);
            this.groupBoxNapredak.TabIndex = 25;
            this.groupBoxNapredak.TabStop = false;
            this.groupBoxNapredak.Text = "Napredak";
            // 
            // dgvNapredak
            // 
            this.dgvNapredak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNapredak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNapredak.Location = new System.Drawing.Point(6, 19);
            this.dgvNapredak.Name = "dgvNapredak";
            this.dgvNapredak.Size = new System.Drawing.Size(383, 358);
            this.dgvNapredak.TabIndex = 1;
            // 
            // detaljiNarudzbeKlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1138, 428);
            this.Controls.Add(this.groupBoxDijelovi);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.textBoxRegistracija);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.textBoxKorime);
            this.Controls.Add(this.labelKorime);
            this.Controls.Add(this.groupBoxPodaci);
            this.Controls.Add(this.groupBoxNapredak);
            this.Name = "detaljiNarudzbeKlijentForm";
            this.Text = "Detalji narudžbe";
            this.Load += new System.EventHandler(this.detaljiNarudzbeForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.detaljiNarudzbeKlijentForm_HelpRequested);
            this.groupBoxDijelovi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijelovi)).EndInit();
            this.groupBoxPodaci.ResumeLayout(false);
            this.groupBoxPodaci.PerformLayout();
            this.groupBoxNapredak.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapredak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKorime;
        private System.Windows.Forms.TextBox textBoxKorime;
        private System.Windows.Forms.TextBox textBoxRegistracija;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.Label labelNapomena;
        private System.Windows.Forms.TextBox textBoxDatum;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelPotvrdeno;
        private System.Windows.Forms.Label labelOtkazano;
        private System.Windows.Forms.Label labelZavrseno;
        private System.Windows.Forms.RadioButton radioButtonPotvrdeno;
        private System.Windows.Forms.RadioButton radioButtonOtkazano;
        private System.Windows.Forms.RadioButton radioButtonZavrseno;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.GroupBox groupBoxDijelovi;
        private System.Windows.Forms.DataGridView dgvDijelovi;
        private System.Windows.Forms.GroupBox groupBoxPodaci;
        private System.Windows.Forms.GroupBox groupBoxNapredak;
        private System.Windows.Forms.DataGridView dgvNapredak;
    }
}