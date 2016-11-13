namespace KorisnickiInterfejs
{
    partial class NovRacun
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.txtDatumIzdavanja = new System.Windows.Forms.TextBox();
            this.txtUkupnaVrednost = new System.Windows.Forms.TextBox();
            this.btnKreirajRacun = new System.Windows.Forms.Button();
            this.btnSacuvajRacun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtKolina = new System.Windows.Forms.TextBox();
            this.cbProizvodi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj računa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum izdavanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ukupan iznos računa:";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(21, 34);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.ReadOnly = true;
            this.txtBrojRacuna.Size = new System.Drawing.Size(144, 20);
            this.txtBrojRacuna.TabIndex = 3;
            this.txtBrojRacuna.TextChanged += new System.EventHandler(this.txtBrojRacuna_TextChanged);
            // 
            // txtDatumIzdavanja
            // 
            this.txtDatumIzdavanja.Location = new System.Drawing.Point(246, 34);
            this.txtDatumIzdavanja.Name = "txtDatumIzdavanja";
            this.txtDatumIzdavanja.ReadOnly = true;
            this.txtDatumIzdavanja.Size = new System.Drawing.Size(156, 20);
            this.txtDatumIzdavanja.TabIndex = 4;
            // 
            // txtUkupnaVrednost
            // 
            this.txtUkupnaVrednost.Location = new System.Drawing.Point(21, 91);
            this.txtUkupnaVrednost.Name = "txtUkupnaVrednost";
            this.txtUkupnaVrednost.ReadOnly = true;
            this.txtUkupnaVrednost.Size = new System.Drawing.Size(144, 20);
            this.txtUkupnaVrednost.TabIndex = 5;
            // 
            // btnKreirajRacun
            // 
            this.btnKreirajRacun.Location = new System.Drawing.Point(246, 75);
            this.btnKreirajRacun.Name = "btnKreirajRacun";
            this.btnKreirajRacun.Size = new System.Drawing.Size(156, 36);
            this.btnKreirajRacun.TabIndex = 7;
            this.btnKreirajRacun.Text = "Kreiraj nov račun";
            this.btnKreirajRacun.UseVisualStyleBackColor = true;
            this.btnKreirajRacun.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSacuvajRacun
            // 
            this.btnSacuvajRacun.Location = new System.Drawing.Point(21, 449);
            this.btnSacuvajRacun.Name = "btnSacuvajRacun";
            this.btnSacuvajRacun.Size = new System.Drawing.Size(381, 41);
            this.btnSacuvajRacun.TabIndex = 10;
            this.btnSacuvajRacun.Text = "Štampaj račun";
            this.btnSacuvajRacun.UseVisualStyleBackColor = true;
            this.btnSacuvajRacun.Visible = false;
            this.btnSacuvajRacun.Click += new System.EventHandler(this.btnSacuvajRacun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtKolina);
            this.groupBox1.Controls.Add(this.cbProizvodi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnObrisiStavku);
            this.groupBox1.Controls.Add(this.btnDodajStavku);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 326);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos stavke računa";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(209, 243);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(156, 33);
            this.btnObrisiStavku.TabIndex = 15;
            this.btnObrisiStavku.Text = "Obriši stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(21, 243);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(158, 33);
            this.btnDodajStavku.TabIndex = 14;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 149);
            this.dataGridView1.TabIndex = 13;
            // 
            // txtKolina
            // 
            this.txtKolina.Location = new System.Drawing.Point(207, 197);
            this.txtKolina.Name = "txtKolina";
            this.txtKolina.Size = new System.Drawing.Size(126, 20);
            this.txtKolina.TabIndex = 20;
            // 
            // cbProizvodi
            // 
            this.cbProizvodi.FormattingEnabled = true;
            this.cbProizvodi.Location = new System.Drawing.Point(21, 196);
            this.cbProizvodi.Name = "cbProizvodi";
            this.cbProizvodi.Size = new System.Drawing.Size(155, 21);
            this.cbProizvodi.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Količina:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Proizvod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "din.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "kom.";
            // 
            // NovRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 494);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvajRacun);
            this.Controls.Add(this.btnKreirajRacun);
            this.Controls.Add(this.txtUkupnaVrednost);
            this.Controls.Add(this.txtDatumIzdavanja);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovRacun";
            this.Text = "Nov racun";
            this.Load += new System.EventHandler(this.NovRacun_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.TextBox txtDatumIzdavanja;
        private System.Windows.Forms.TextBox txtUkupnaVrednost;
        private System.Windows.Forms.Button btnKreirajRacun;
        private System.Windows.Forms.Button btnSacuvajRacun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtKolina;
        private System.Windows.Forms.ComboBox cbProizvodi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}