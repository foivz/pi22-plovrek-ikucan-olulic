namespace ServisiranjeVozila
{
    partial class kreirajNarudzbuKlijentForm
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbVozila = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(22, 161);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(106, 23);
            this.buttonDodaj.TabIndex = 46;
            this.buttonDodaj.Text = "Dodaj narudžbu";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Location = new System.Drawing.Point(120, 65);
            this.textBoxNapomena.Multiline = true;
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(157, 71);
            this.textBoxNapomena.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Napomena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Vozilo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbVozila
            // 
            this.cmbVozila.FormattingEnabled = true;
            this.cmbVozila.Location = new System.Drawing.Point(120, 24);
            this.cmbVozila.Name = "cmbVozila";
            this.cmbVozila.Size = new System.Drawing.Size(157, 21);
            this.cmbVozila.TabIndex = 48;
            // 
            // kreirajNarudzbuKlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(301, 202);
            this.Controls.Add(this.cmbVozila);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxNapomena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "kreirajNarudzbuKlijentForm";
            this.Text = "Kreiraj narudžbu";
            this.Load += new System.EventHandler(this.kreirajNarudzbuKlijentForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.kreirajNarudzbuKlijentForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbVozila;
    }
}