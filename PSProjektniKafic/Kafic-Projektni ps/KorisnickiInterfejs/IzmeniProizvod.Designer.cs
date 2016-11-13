namespace KorisnickiInterfejs
{
    partial class IzmeniProizvod
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
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtPriprema = new System.Windows.Forms.TextBox();
            this.txtSastojci = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(136, 188);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(194, 23);
            this.btnIzmeni.TabIndex = 28;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(136, 138);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(332, 20);
            this.txtCena.TabIndex = 27;
            // 
            // txtPriprema
            // 
            this.txtPriprema.Location = new System.Drawing.Point(136, 100);
            this.txtPriprema.Name = "txtPriprema";
            this.txtPriprema.Size = new System.Drawing.Size(332, 20);
            this.txtPriprema.TabIndex = 26;
            // 
            // txtSastojci
            // 
            this.txtSastojci.Location = new System.Drawing.Point(136, 65);
            this.txtSastojci.Name = "txtSastojci";
            this.txtSastojci.Size = new System.Drawing.Size(332, 20);
            this.txtSastojci.TabIndex = 25;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(136, 30);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(332, 20);
            this.txtNaziv.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cena:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Način pripreme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sastojci:";
            // 
            // IzmeniProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 235);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtPriprema);
            this.Controls.Add(this.txtSastojci);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "IzmeniProizvod";
            this.Text = "Izmeni proizvod";
            this.Load += new System.EventHandler(this.IzmeniProizvod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeni;
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