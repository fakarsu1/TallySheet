namespace TSheet.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.puantajGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puantajGirişiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanPuantajCetveliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lokasyonEkleSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puantajGirişiToolStripMenuItem,
            this.çalışanToolStripMenuItem,
            this.lokasyonEkleSilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // puantajGirişiToolStripMenuItem
            // 
            this.puantajGirişiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puantajGirişiToolStripMenuItem1,
            this.çalışanPuantajCetveliToolStripMenuItem});
            this.puantajGirişiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("puantajGirişiToolStripMenuItem.Image")));
            this.puantajGirişiToolStripMenuItem.Name = "puantajGirişiToolStripMenuItem";
            this.puantajGirişiToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.puantajGirişiToolStripMenuItem.Text = "Puantaj";
            // 
            // puantajGirişiToolStripMenuItem1
            // 
            this.puantajGirişiToolStripMenuItem1.Name = "puantajGirişiToolStripMenuItem1";
            this.puantajGirişiToolStripMenuItem1.Size = new System.Drawing.Size(194, 22);
            this.puantajGirişiToolStripMenuItem1.Text = "Puantaj Girişi";
            this.puantajGirişiToolStripMenuItem1.Click += new System.EventHandler(this.puantajGirişiToolStripMenuItem1_Click);
            // 
            // çalışanPuantajCetveliToolStripMenuItem
            // 
            this.çalışanPuantajCetveliToolStripMenuItem.Name = "çalışanPuantajCetveliToolStripMenuItem";
            this.çalışanPuantajCetveliToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.çalışanPuantajCetveliToolStripMenuItem.Text = "Çalışan Puantaj Cetveli";
            this.çalışanPuantajCetveliToolStripMenuItem.Click += new System.EventHandler(this.çalışanPuantajCetveliToolStripMenuItem_Click);
            // 
            // çalışanToolStripMenuItem
            // 
            this.çalışanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.görevToolStripMenuItem});
            this.çalışanToolStripMenuItem.Name = "çalışanToolStripMenuItem";
            this.çalışanToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.çalışanToolStripMenuItem.Text = "Çalışan";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem2,
            this.güncelleSilToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.ekleToolStripMenuItem.Text = "Çalışan";
            // 
            // ekleToolStripMenuItem2
            // 
            this.ekleToolStripMenuItem2.Name = "ekleToolStripMenuItem2";
            this.ekleToolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.ekleToolStripMenuItem2.Text = "Ekle";
            this.ekleToolStripMenuItem2.Click += new System.EventHandler(this.ekleToolStripMenuItem2_Click);
            // 
            // güncelleSilToolStripMenuItem
            // 
            this.güncelleSilToolStripMenuItem.Name = "güncelleSilToolStripMenuItem";
            this.güncelleSilToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.güncelleSilToolStripMenuItem.Text = "Güncelle/Sil";
            this.güncelleSilToolStripMenuItem.Click += new System.EventHandler(this.güncelleSilToolStripMenuItem_Click);
            // 
            // görevToolStripMenuItem
            // 
            this.görevToolStripMenuItem.Name = "görevToolStripMenuItem";
            this.görevToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.görevToolStripMenuItem.Text = "Görev";
            this.görevToolStripMenuItem.Click += new System.EventHandler(this.görevToolStripMenuItem_Click);
            // 
            // lokasyonEkleSilToolStripMenuItem
            // 
            this.lokasyonEkleSilToolStripMenuItem.Name = "lokasyonEkleSilToolStripMenuItem";
            this.lokasyonEkleSilToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.lokasyonEkleSilToolStripMenuItem.Text = "Lokasyon";
            this.lokasyonEkleSilToolStripMenuItem.Click += new System.EventHandler(this.lokasyonEkleSilToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TSheet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem puantajGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puantajGirişiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çalışanPuantajCetveliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem güncelleSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lokasyonEkleSilToolStripMenuItem;
    }
}