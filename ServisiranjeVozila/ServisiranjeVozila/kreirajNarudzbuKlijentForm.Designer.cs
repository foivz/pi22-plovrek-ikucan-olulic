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
            this.textBoxStanje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRegistracija = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(22, 204);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(106, 23);
            this.buttonDodaj.TabIndex = 46;
            this.buttonDodaj.Text = "Dodaj narudžbu";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Location = new System.Drawing.Point(120, 127);
            this.textBoxNapomena.Multiline = true;
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(157, 71);
            this.textBoxNapomena.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Napomena:";
            // 
            // textBoxStanje
            // 
            this.textBoxStanje.Location = new System.Drawing.Point(120, 101);
            this.textBoxStanje.Name = "textBoxStanje";
            this.textBoxStanje.Size = new System.Drawing.Size(100, 20);
            this.textBoxStanje.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Stanje brojača:";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(120, 76);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxModel.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Model vozila:";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(120, 50);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarka.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Marka vozila:";
            // 
            // textBoxRegistracija
            // 
            this.textBoxRegistracija.Location = new System.Drawing.Point(120, 24);
            this.textBoxRegistracija.Name = "textBoxRegistracija";
            this.textBoxRegistracija.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegistracija.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Registracija vozila:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kreirajNarudzbuKlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxNapomena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxStanje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRegistracija);
            this.Controls.Add(this.label2);
            this.Name = "kreirajNarudzbuKlijentForm";
            this.Text = "Kreiraj narudžbu";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.kreirajNarudzbuKlijentForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStanje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRegistracija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}