namespace KorisnickiInterfejs
{
    partial class UnosNovogProizvoda
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnKreirajProizvod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtPriprema = new System.Windows.Forms.TextBox();
            this.txtSastojci = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra proizvoda:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(126, 26);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.ReadOnly = true;
            this.txtSifra.Size = new System.Drawing.Size(332, 20);
            this.txtSifra.TabIndex = 4;
            // 
            // btnKreirajProizvod
            // 
            this.btnKreirajProizvod.Location = new System.Drawing.Point(126, 65);
            this.btnKreirajProizvod.Name = "btnKreirajProizvod";
            this.btnKreirajProizvod.Size = new System.Drawing.Size(194, 23);
            this.btnKreirajProizvod.TabIndex = 9;
            this.btnKreirajProizvod.Text = "Kreiraj nov proizvod";
            this.btnKreirajProizvod.UseVisualStyleBackColor = true;
            this.btnKreirajProizvod.Click += new System.EventHandler(this.btnKreirajProizvod_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.txtCena);
            this.groupBox1.Controls.Add(this.txtPriprema);
            this.groupBox1.Controls.Add(this.txtSastojci);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 243);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos podataka o proizvodu";
            this.groupBox1.Visible = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(114, 201);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(194, 23);
            this.btnSacuvaj.TabIndex = 19;
            this.btnSacuvaj.Text = "Sačuvaj ";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(114, 151);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(332, 20);
            this.txtCena.TabIndex = 18;
            // 
            // txtPriprema
            // 
            this.txtPriprema.Location = new System.Drawing.Point(114, 113);
            this.txtPriprema.Name = "txtPriprema";
            this.txtPriprema.Size = new System.Drawing.Size(332, 20);
            this.txtPriprema.TabIndex = 17;
            // 
            // txtSastojci
            // 
            this.txtSastojci.Location = new System.Drawing.Point(114, 78);
            this.txtSastojci.Name = "txtSastojci";
            this.txtSastojci.Size = new System.Drawing.Size(332, 20);
            this.txtSastojci.TabIndex = 16;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(114, 43);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(332, 20);
            this.txtNaziv.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Način pripreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sastojci:";
            // 
            // UnosNovogProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKreirajProizvod);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label1);
            this.Name = "UnosNovogProizvoda";
            this.Text = "Unos novog proizvoda";
            this.Load += new System.EventHandler(this.UnosNovogProizvoda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Button btnKreirajProizvod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtPriprema;
        private System.Windows.Forms.TextBox txtSastojci;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}