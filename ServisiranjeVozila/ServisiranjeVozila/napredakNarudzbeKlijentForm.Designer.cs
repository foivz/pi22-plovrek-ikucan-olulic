namespace ServisiranjeVozila
{
    partial class napredakNarudzbeKlijentForm
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
            this.textBoxNapredak = new System.Windows.Forms.TextBox();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNapredak
            // 
            this.textBoxNapredak.Enabled = false;
            this.textBoxNapredak.Location = new System.Drawing.Point(26, 21);
            this.textBoxNapredak.Multiline = true;
            this.textBoxNapredak.Name = "textBoxNapredak";
            this.textBoxNapredak.Size = new System.Drawing.Size(478, 320);
            this.textBoxNapredak.TabIndex = 0;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.Location = new System.Drawing.Point(429, 347);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(75, 23);
            this.buttonZatvori.TabIndex = 1;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // napredakNarudzbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 381);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.textBoxNapredak);
            this.Name = "napredakNarudzbeForm";
            this.Text = "Napredak";
            this.Load += new System.EventHandler(this.napredakNarudzbeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNapredak;
        private System.Windows.Forms.Button buttonZatvori;
    }
}