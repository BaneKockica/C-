namespace KorisnickiInterfejs
{
    partial class GlavnaAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unosProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaIPretragaProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konobarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosNovogKonobaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaIBrisanjeKonobaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.konobarToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(260, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosProizvodaToolStripMenuItem,
            this.izmenaIPretragaProizvodaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Proizvod";
            // 
            // unosProizvodaToolStripMenuItem
            // 
            this.unosProizvodaToolStripMenuItem.Name = "unosProizvodaToolStripMenuItem";
            this.unosProizvodaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.unosProizvodaToolStripMenuItem.Text = "Unos proizvoda";
            this.unosProizvodaToolStripMenuItem.Click += new System.EventHandler(this.unosProizvodaToolStripMenuItem_Click);
            // 
            // izmenaIPretragaProizvodaToolStripMenuItem
            // 
            this.izmenaIPretragaProizvodaToolStripMenuItem.Name = "izmenaIPretragaProizvodaToolStripMenuItem";
            this.izmenaIPretragaProizvodaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.izmenaIPretragaProizvodaToolStripMenuItem.Text = "Izmena i pretraga proizvoda";
            this.izmenaIPretragaProizvodaToolStripMenuItem.Click += new System.EventHandler(this.izmenaIPretragaProizvodaToolStripMenuItem_Click);
            // 
            // konobarToolStripMenuItem
            // 
            this.konobarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosNovogKonobaraToolStripMenuItem,
            this.izmenaIBrisanjeKonobaraToolStripMenuItem});
            this.konobarToolStripMenuItem.Name = "konobarToolStripMenuItem";
            this.konobarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.konobarToolStripMenuItem.Text = "Konobar";
            // 
            // unosNovogKonobaraToolStripMenuItem
            // 
            this.unosNovogKonobaraToolStripMenuItem.Name = "unosNovogKonobaraToolStripMenuItem";
            this.unosNovogKonobaraToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.unosNovogKonobaraToolStripMenuItem.Text = "Unos novog konobara";
            this.unosNovogKonobaraToolStripMenuItem.Click += new System.EventHandler(this.unosNovogKonobaraToolStripMenuItem_Click);
            // 
            // izmenaIBrisanjeKonobaraToolStripMenuItem
            // 
            this.izmenaIBrisanjeKonobaraToolStripMenuItem.Name = "izmenaIBrisanjeKonobaraToolStripMenuItem";
            this.izmenaIBrisanjeKonobaraToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.izmenaIBrisanjeKonobaraToolStripMenuItem.Text = "Izmena i brisanje konobara";
            this.izmenaIBrisanjeKonobaraToolStripMenuItem.Click += new System.EventHandler(this.izmenaIBrisanjeKonobaraToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // GlavnaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 196);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaAdmin";
            this.Text = "Pocetna!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlavnaAdmin_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unosProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaIPretragaProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konobarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosNovogKonobaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaIBrisanjeKonobaraToolStripMenuItem;
    }
}