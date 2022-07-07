namespace ServisiranjeVozila
{
    partial class pregledOdradenihRadovaNaVozilu
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
            this.dgvPregledOdrađenihRadovaNaVozilu = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledOdrađenihRadovaNaVozilu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPregledOdrađenihRadovaNaVozilu
            // 
            this.dgvPregledOdrađenihRadovaNaVozilu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledOdrađenihRadovaNaVozilu.Location = new System.Drawing.Point(13, 13);
            this.dgvPregledOdrađenihRadovaNaVozilu.Name = "dgvPregledOdrađenihRadovaNaVozilu";
            this.dgvPregledOdrađenihRadovaNaVozilu.Size = new System.Drawing.Size(775, 324);
            this.dgvPregledOdrađenihRadovaNaVozilu.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(363, 343);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // pregledOdradenihRadovaNaVozilu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(810, 386);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvPregledOdrađenihRadovaNaVozilu);
            this.Name = "pregledOdradenihRadovaNaVozilu";
            this.Text = "Pregled odrađenih servisa/radova na vozilu";
            this.Load += new System.EventHandler(this.pregledOdradenihRadovaNaVozilu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledOdrađenihRadovaNaVozilu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledOdrađenihRadovaNaVozilu;
        private System.Windows.Forms.Button btnZatvori;
    }
}