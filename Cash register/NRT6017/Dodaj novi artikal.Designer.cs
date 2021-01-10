namespace NRT6017
{
    partial class Dodaj_novi_artikal
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.tbxNaziv = new System.Windows.Forms.TextBox();
            this.tbxCena = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.tbxPopust = new System.Windows.Forms.TextBox();
            this.lblPopust = new System.Windows.Forms.Label();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(51, 7);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(67, 25);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // tbxNaziv
            // 
            this.tbxNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxNaziv.Location = new System.Drawing.Point(124, 4);
            this.tbxNaziv.Name = "tbxNaziv";
            this.tbxNaziv.Size = new System.Drawing.Size(228, 30);
            this.tbxNaziv.TabIndex = 1;
            // 
            // tbxCena
            // 
            this.tbxCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxCena.Location = new System.Drawing.Point(124, 42);
            this.tbxCena.Name = "tbxCena";
            this.tbxCena.Size = new System.Drawing.Size(228, 30);
            this.tbxCena.TabIndex = 3;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCena.Location = new System.Drawing.Point(51, 45);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(66, 25);
            this.lblCena.TabIndex = 2;
            this.lblCena.Text = "Cena:";
            // 
            // tbxPopust
            // 
            this.tbxPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxPopust.Location = new System.Drawing.Point(124, 78);
            this.tbxPopust.Name = "tbxPopust";
            this.tbxPopust.Size = new System.Drawing.Size(228, 30);
            this.tbxPopust.TabIndex = 5;
            // 
            // lblPopust
            // 
            this.lblPopust.AutoSize = true;
            this.lblPopust.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPopust.Location = new System.Drawing.Point(38, 81);
            this.lblPopust.Name = "lblPopust";
            this.lblPopust.Size = new System.Drawing.Size(79, 25);
            this.lblPopust.TabIndex = 4;
            this.lblPopust.Text = "Popust:";
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKategorija.Location = new System.Drawing.Point(12, 117);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(106, 25);
            this.lblKategorija.TabIndex = 6;
            this.lblKategorija.Text = "Kategorija:";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(124, 150);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(228, 41);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj artikal";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbKategorija
            // 
            this.cbKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(124, 114);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(228, 33);
            this.cbKategorija.TabIndex = 9;
            // 
            // Dodaj_novi_artikal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 207);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.tbxPopust);
            this.Controls.Add(this.lblPopust);
            this.Controls.Add(this.tbxCena);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.tbxNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "Dodaj_novi_artikal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj_novi_artikal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dodaj_novi_artikal_FormClosing);
            this.Load += new System.EventHandler(this.Dodaj_novi_artikal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox tbxNaziv;
        private System.Windows.Forms.TextBox tbxCena;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.TextBox tbxPopust;
        private System.Windows.Forms.Label lblPopust;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbKategorija;
    }
}