namespace ServisiranjeVozila
{
    partial class dodavanjeVozila
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
            this.labelRegistracijaVozila = new System.Windows.Forms.Label();
            this.labelMarkaVozila = new System.Windows.Forms.Label();
            this.labelModelVozila = new System.Windows.Forms.Label();
            this.labelStanjeBrojaca = new System.Windows.Forms.Label();
            this.registracijaTextbox = new System.Windows.Forms.TextBox();
            this.markaTextbox = new System.Windows.Forms.TextBox();
            this.modelTextbox = new System.Windows.Forms.TextBox();
            this.stanjeTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRegistracijaVozila
            // 
            this.labelRegistracijaVozila.AutoSize = true;
            this.labelRegistracijaVozila.Location = new System.Drawing.Point(15, 21);
            this.labelRegistracijaVozila.Name = "labelRegistracijaVozila";
            this.labelRegistracijaVozila.Size = new System.Drawing.Size(95, 13);
            this.labelRegistracijaVozila.TabIndex = 0;
            this.labelRegistracijaVozila.Text = "Registracija vozila:";
            // 
            // labelMarkaVozila
            // 
            this.labelMarkaVozila.AutoSize = true;
            this.labelMarkaVozila.Location = new System.Drawing.Point(15, 54);
            this.labelMarkaVozila.Name = "labelMarkaVozila";
            this.labelMarkaVozila.Size = new System.Drawing.Size(70, 13);
            this.labelMarkaVozila.TabIndex = 1;
            this.labelMarkaVozila.Text = "Marka vozila:";
            // 
            // labelModelVozila
            // 
            this.labelModelVozila.AutoSize = true;
            this.labelModelVozila.Location = new System.Drawing.Point(15, 85);
            this.labelModelVozila.Name = "labelModelVozila";
            this.labelModelVozila.Size = new System.Drawing.Size(69, 13);
            this.labelModelVozila.TabIndex = 2;
            this.labelModelVozila.Text = "Model vozila:";
            // 
            // labelStanjeBrojaca
            // 
            this.labelStanjeBrojaca.AutoSize = true;
            this.labelStanjeBrojaca.Location = new System.Drawing.Point(15, 118);
            this.labelStanjeBrojaca.Name = "labelStanjeBrojaca";
            this.labelStanjeBrojaca.Size = new System.Drawing.Size(78, 13);
            this.labelStanjeBrojaca.TabIndex = 3;
            this.labelStanjeBrojaca.Text = "Stanje brojača:";
            // 
            // registracijaTextbox
            // 
            this.registracijaTextbox.Location = new System.Drawing.Point(127, 18);
            this.registracijaTextbox.Name = "registracijaTextbox";
            this.registracijaTextbox.Size = new System.Drawing.Size(128, 20);
            this.registracijaTextbox.TabIndex = 4;
            // 
            // markaTextbox
            // 
            this.markaTextbox.Location = new System.Drawing.Point(127, 51);
            this.markaTextbox.Name = "markaTextbox";
            this.markaTextbox.Size = new System.Drawing.Size(128, 20);
            this.markaTextbox.TabIndex = 5;
            // 
            // modelTextbox
            // 
            this.modelTextbox.Location = new System.Drawing.Point(127, 82);
            this.modelTextbox.Name = "modelTextbox";
            this.modelTextbox.Size = new System.Drawing.Size(128, 20);
            this.modelTextbox.TabIndex = 6;
            // 
            // stanjeTextbox
            // 
            this.stanjeTextbox.Location = new System.Drawing.Point(127, 115);
            this.stanjeTextbox.Name = "stanjeTextbox";
            this.stanjeTextbox.Size = new System.Drawing.Size(92, 20);
            this.stanjeTextbox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj vozilo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "km";
            // 
            // dodavanjeVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 195);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stanjeTextbox);
            this.Controls.Add(this.modelTextbox);
            this.Controls.Add(this.markaTextbox);
            this.Controls.Add(this.registracijaTextbox);
            this.Controls.Add(this.labelStanjeBrojaca);
            this.Controls.Add(this.labelModelVozila);
            this.Controls.Add(this.labelMarkaVozila);
            this.Controls.Add(this.labelRegistracijaVozila);
            this.Name = "dodavanjeVozila";
            this.Text = "Dodaj vozilo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegistracijaVozila;
        private System.Windows.Forms.Label labelMarkaVozila;
        private System.Windows.Forms.Label labelModelVozila;
        private System.Windows.Forms.Label labelStanjeBrojaca;
        private System.Windows.Forms.TextBox registracijaTextbox;
        private System.Windows.Forms.TextBox markaTextbox;
        private System.Windows.Forms.TextBox modelTextbox;
        private System.Windows.Forms.TextBox stanjeTextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}