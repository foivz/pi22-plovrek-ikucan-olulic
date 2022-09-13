namespace ServisiranjeVozila
{
    partial class posaljiEmailForm
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
            this.korisnikTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.brojSatiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.posaljiButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // korisnikTextBox
            // 
            this.korisnikTextBox.Location = new System.Drawing.Point(104, 75);
            this.korisnikTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.korisnikTextBox.Name = "korisnikTextBox";
            this.korisnikTextBox.Size = new System.Drawing.Size(493, 26);
            this.korisnikTextBox.TabIndex = 0;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(104, 134);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(216, 26);
            this.emailTextBox.TabIndex = 1;
            // 
            // brojSatiTextBox
            // 
            this.brojSatiTextBox.Location = new System.Drawing.Point(104, 191);
            this.brojSatiTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.brojSatiTextBox.Name = "brojSatiTextBox";
            this.brojSatiTextBox.Size = new System.Drawing.Size(78, 26);
            this.brojSatiTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Korisnik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj sati:";
            // 
            // posaljiButton
            // 
            this.posaljiButton.Location = new System.Drawing.Point(70, 272);
            this.posaljiButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.posaljiButton.Name = "posaljiButton";
            this.posaljiButton.Size = new System.Drawing.Size(112, 35);
            this.posaljiButton.TabIndex = 7;
            this.posaljiButton.Text = "Pošalji";
            this.posaljiButton.UseVisualStyleBackColor = true;
            this.posaljiButton.Click += new System.EventHandler(this.posaljiButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(208, 272);
            this.odustaniButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(112, 35);
            this.odustaniButton.TabIndex = 8;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // posaljiEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 392);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.posaljiButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brojSatiTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.korisnikTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "posaljiEmailForm";
            this.Text = "posaljiEmail";
            this.Load += new System.EventHandler(this.posaljiEmailForm_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.posaljiEmailForm_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox korisnikTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox brojSatiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button posaljiButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}