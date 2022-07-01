namespace ServisiranjeVozila
{
    partial class dodajNapredakZaposlenikForm
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
            this.textBoxRegistracija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxIDNarudzbe = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDodajNapredak = new System.Windows.Forms.Button();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.dgvNapredak = new System.Windows.Forms.DataGridView();
            this.cmbNapredak = new System.Windows.Forms.ComboBox();
            this.labelDodajNapredak = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapredak)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxRegistracija
            // 
            this.textBoxRegistracija.Enabled = false;
            this.textBoxRegistracija.Location = new System.Drawing.Point(127, 48);
            this.textBoxRegistracija.Name = "textBoxRegistracija";
            this.textBoxRegistracija.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistracija.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registracija vozila:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID narudžbe:";
            // 
            // textBoxIDNarudzbe
            // 
            this.textBoxIDNarudzbe.Enabled = false;
            this.textBoxIDNarudzbe.Location = new System.Drawing.Point(127, 22);
            this.textBoxIDNarudzbe.Name = "textBoxIDNarudzbe";
            this.textBoxIDNarudzbe.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDNarudzbe.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Napredak:";
            // 
            // buttonDodajNapredak
            // 
            this.buttonDodajNapredak.Location = new System.Drawing.Point(213, 271);
            this.buttonDodajNapredak.Name = "buttonDodajNapredak";
            this.buttonDodajNapredak.Size = new System.Drawing.Size(97, 23);
            this.buttonDodajNapredak.TabIndex = 24;
            this.buttonDodajNapredak.Text = "Dodaj napredak";
            this.buttonDodajNapredak.UseVisualStyleBackColor = true;
            this.buttonDodajNapredak.Click += new System.EventHandler(this.buttonDodajNapredak_Click);
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(316, 271);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(97, 23);
            this.buttonZatvori.TabIndex = 25;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // dgvNapredak
            // 
            this.dgvNapredak.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNapredak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNapredak.Location = new System.Drawing.Point(127, 74);
            this.dgvNapredak.Name = "dgvNapredak";
            this.dgvNapredak.Size = new System.Drawing.Size(286, 150);
            this.dgvNapredak.TabIndex = 26;
            // 
            // cmbNapredak
            // 
            this.cmbNapredak.FormattingEnabled = true;
            this.cmbNapredak.Location = new System.Drawing.Point(127, 230);
            this.cmbNapredak.Name = "cmbNapredak";
            this.cmbNapredak.Size = new System.Drawing.Size(121, 21);
            this.cmbNapredak.TabIndex = 27;
            // 
            // labelDodajNapredak
            // 
            this.labelDodajNapredak.AutoSize = true;
            this.labelDodajNapredak.Location = new System.Drawing.Point(27, 233);
            this.labelDodajNapredak.Name = "labelDodajNapredak";
            this.labelDodajNapredak.Size = new System.Drawing.Size(86, 13);
            this.labelDodajNapredak.TabIndex = 28;
            this.labelDodajNapredak.Text = "Dodaj napredak:";
            // 
            // dodajNapredakZaposlenikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(437, 311);
            this.Controls.Add(this.labelDodajNapredak);
            this.Controls.Add(this.cmbNapredak);
            this.Controls.Add(this.dgvNapredak);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.buttonDodajNapredak);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIDNarudzbe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRegistracija);
            this.Controls.Add(this.label2);
            this.Name = "dodajNapredakZaposlenikForm";
            this.Text = "Dodaj napredak";
            this.Load += new System.EventHandler(this.dodajNapredakForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.dodajNapredakZaposlenikForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapredak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxRegistracija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxIDNarudzbe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDodajNapredak;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.DataGridView dgvNapredak;
        private System.Windows.Forms.ComboBox cmbNapredak;
        private System.Windows.Forms.Label labelDodajNapredak;
    }
}