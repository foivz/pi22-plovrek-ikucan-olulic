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
            this.dgvPregledOdrađenihRadovaNaVozilu.Location = new System.Drawing.Point(20, 20);
            this.dgvPregledOdrađenihRadovaNaVozilu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPregledOdrađenihRadovaNaVozilu.Name = "dgvPregledOdrađenihRadovaNaVozilu";
            this.dgvPregledOdrađenihRadovaNaVozilu.RowHeadersWidth = 50;
            this.dgvPregledOdrađenihRadovaNaVozilu.Size = new System.Drawing.Size(1162, 498);
            this.dgvPregledOdrađenihRadovaNaVozilu.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(544, 528);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(112, 35);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // pregledOdradenihRadovaNaVozilu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1215, 594);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvPregledOdrađenihRadovaNaVozilu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pregledOdradenihRadovaNaVozilu";
            this.Text = "Pregled odrađenih servisa/radova na vozilu";
            this.Load += new System.EventHandler(this.pregledOdradenihRadovaNaVozilu_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.pregledOdradenihRadovaNaVozilu_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledOdrađenihRadovaNaVozilu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPregledOdrađenihRadovaNaVozilu;
        private System.Windows.Forms.Button btnZatvori;
    }
}