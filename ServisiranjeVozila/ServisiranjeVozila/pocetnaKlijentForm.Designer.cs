﻿namespace ServisiranjeVozila
{
    partial class PocetnaKlijentForm
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
            this.dgvKorisnikoveNarudzbe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.detaljiNarudzbe = new System.Windows.Forms.Button();
            this.buttonKreirajNarudzbu = new System.Windows.Forms.Button();
            this.buttonPregledVozila = new System.Windows.Forms.Button();
            this.btnPregledOdradenihRadovaNaVozilu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnikoveNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKorisnikoveNarudzbe
            // 
            this.dgvKorisnikoveNarudzbe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnikoveNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnikoveNarudzbe.Location = new System.Drawing.Point(27, 38);
            this.dgvKorisnikoveNarudzbe.Name = "dgvKorisnikoveNarudzbe";
            this.dgvKorisnikoveNarudzbe.Size = new System.Drawing.Size(636, 187);
            this.dgvKorisnikoveNarudzbe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaše narudžbe:";
            // 
            // detaljiNarudzbe
            // 
            this.detaljiNarudzbe.Location = new System.Drawing.Point(546, 231);
            this.detaljiNarudzbe.Name = "detaljiNarudzbe";
            this.detaljiNarudzbe.Size = new System.Drawing.Size(117, 42);
            this.detaljiNarudzbe.TabIndex = 2;
            this.detaljiNarudzbe.Text = "Prikaži detalje za odabranu narudžbu";
            this.detaljiNarudzbe.UseVisualStyleBackColor = true;
            this.detaljiNarudzbe.Click += new System.EventHandler(this.detaljiNarudzbe_Click);
            // 
            // buttonKreirajNarudzbu
            // 
            this.buttonKreirajNarudzbu.Location = new System.Drawing.Point(27, 231);
            this.buttonKreirajNarudzbu.Name = "buttonKreirajNarudzbu";
            this.buttonKreirajNarudzbu.Size = new System.Drawing.Size(117, 42);
            this.buttonKreirajNarudzbu.TabIndex = 3;
            this.buttonKreirajNarudzbu.Text = "Kreiraj novu narudžbu";
            this.buttonKreirajNarudzbu.UseVisualStyleBackColor = true;
            this.buttonKreirajNarudzbu.Click += new System.EventHandler(this.buttonKreirajNarudzbu_Click);
            // 
            // buttonPregledVozila
            // 
            this.buttonPregledVozila.Location = new System.Drawing.Point(150, 231);
            this.buttonPregledVozila.Name = "buttonPregledVozila";
            this.buttonPregledVozila.Size = new System.Drawing.Size(117, 42);
            this.buttonPregledVozila.TabIndex = 4;
            this.buttonPregledVozila.Text = "Pregled vozila";
            this.buttonPregledVozila.UseVisualStyleBackColor = true;
            this.buttonPregledVozila.Click += new System.EventHandler(this.buttonPregledVozila_Click);
            // 
            // btnPregledOdradenihRadovaNaVozilu
            // 
            this.btnPregledOdradenihRadovaNaVozilu.Location = new System.Drawing.Point(274, 232);
            this.btnPregledOdradenihRadovaNaVozilu.Name = "btnPregledOdradenihRadovaNaVozilu";
            this.btnPregledOdradenihRadovaNaVozilu.Size = new System.Drawing.Size(141, 41);
            this.btnPregledOdradenihRadovaNaVozilu.TabIndex = 5;
            this.btnPregledOdradenihRadovaNaVozilu.Text = "Pregled odrađenih radova/servisa na vozilu";
            this.btnPregledOdradenihRadovaNaVozilu.UseVisualStyleBackColor = true;
            this.btnPregledOdradenihRadovaNaVozilu.Click += new System.EventHandler(this.PregledOdradenihRadovaNaVozilu_Click);
            // 
            // PocetnaKlijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(688, 286);
            this.Controls.Add(this.btnPregledOdradenihRadovaNaVozilu);
            this.Controls.Add(this.buttonPregledVozila);
            this.Controls.Add(this.buttonKreirajNarudzbu);
            this.Controls.Add(this.detaljiNarudzbe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKorisnikoveNarudzbe);
            this.Name = "PocetnaKlijentForm";
            this.Text = "Glavni izbornik";
            this.Load += new System.EventHandler(this.PocetnaKlijentForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.PocetnaKlijentForm_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnikoveNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKorisnikoveNarudzbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button detaljiNarudzbe;
        private System.Windows.Forms.Button buttonKreirajNarudzbu;
        private System.Windows.Forms.Button buttonPregledVozila;
        private System.Windows.Forms.Button btnPregledOdradenihRadovaNaVozilu;
    }
}