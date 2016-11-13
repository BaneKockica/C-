namespace KorisnickiInterfejs
{
    partial class Meni
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
            this.dgvPrikazProizvoda = new System.Windows.Forms.DataGridView();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazProizvoda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikazProizvoda
            // 
            this.dgvPrikazProizvoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazProizvoda.Location = new System.Drawing.Point(14, 79);
            this.dgvPrikazProizvoda.Name = "dgvPrikazProizvoda";
            this.dgvPrikazProizvoda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikazProizvoda.Size = new System.Drawing.Size(498, 263);
            this.dgvPrikazProizvoda.TabIndex = 14;
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(14, 35);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(279, 20);
            this.txtKriterijum.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unesite kriterijum pretrage( Naziv proizvoda):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pretrazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Meni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvPrikazProizvoda);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.label1);
            this.Name = "Meni";
            this.Text = "Meni";
            this.Load += new System.EventHandler(this.Meni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazProizvoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikazProizvoda;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}