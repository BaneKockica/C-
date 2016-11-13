namespace KorisnickiInterfejs
{
    partial class GlavnaKonobar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaKonobar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strorniranjeRačunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novRačunToolStripMenuItem,
            this.strorniranjeRačunaToolStripMenuItem,
            this.meniToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novRačunToolStripMenuItem
            // 
            this.novRačunToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.novRačunToolStripMenuItem.Name = "novRačunToolStripMenuItem";
            this.novRačunToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.novRačunToolStripMenuItem.Text = "Nov račun";
            this.novRačunToolStripMenuItem.Click += new System.EventHandler(this.novRačunToolStripMenuItem_Click);
            // 
            // strorniranjeRačunaToolStripMenuItem
            // 
            this.strorniranjeRačunaToolStripMenuItem.Name = "strorniranjeRačunaToolStripMenuItem";
            this.strorniranjeRačunaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.strorniranjeRačunaToolStripMenuItem.Text = "Strorniranje računa";
            this.strorniranjeRačunaToolStripMenuItem.Click += new System.EventHandler(this.strorniranjeRačunaToolStripMenuItem_Click);
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.meniToolStripMenuItem.Text = "Meni";
            this.meniToolStripMenuItem.Click += new System.EventHandler(this.meniToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GlavnaKonobar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(304, 179);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaKonobar";
            this.Text = "Pocetna!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GlavnaKonobar_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strorniranjeRačunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
    }
}

