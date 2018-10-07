namespace melek_nihal_aydın
{
    partial class Form1
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.islemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griyontemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamadegerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalcıkarımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.islemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // islemlerToolStripMenuItem
            // 
            this.islemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.griyontemleriToolStripMenuItem});
            this.islemlerToolStripMenuItem.Name = "islemlerToolStripMenuItem";
            this.islemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.islemlerToolStripMenuItem.Text = "islemler";
            // 
            // griyontemleriToolStripMenuItem
            // 
            this.griyontemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ortalamadegerToolStripMenuItem,
            this.bT709ToolStripMenuItem,
            this.lumaToolStripMenuItem,
            this.açıklıkToolStripMenuItem,
            this.kanalcıkarımToolStripMenuItem});
            this.griyontemleriToolStripMenuItem.Name = "griyontemleriToolStripMenuItem";
            this.griyontemleriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.griyontemleriToolStripMenuItem.Text = "griyontemleri";
            // 
            // ortalamadegerToolStripMenuItem
            // 
            this.ortalamadegerToolStripMenuItem.Name = "ortalamadegerToolStripMenuItem";
            this.ortalamadegerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ortalamadegerToolStripMenuItem.Text = "ortalamadeger";
            this.ortalamadegerToolStripMenuItem.Click += new System.EventHandler(this.ortalamadegerToolStripMenuItem_Click);
            // 
            // bT709ToolStripMenuItem
            // 
            this.bT709ToolStripMenuItem.Name = "bT709ToolStripMenuItem";
            this.bT709ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bT709ToolStripMenuItem.Text = "bt709";
            this.bT709ToolStripMenuItem.Click += new System.EventHandler(this.bT709ToolStripMenuItem_Click);
            // 
            // lumaToolStripMenuItem
            // 
            this.lumaToolStripMenuItem.Name = "lumaToolStripMenuItem";
            this.lumaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lumaToolStripMenuItem.Text = "luma";
            this.lumaToolStripMenuItem.Click += new System.EventHandler(this.lumaToolStripMenuItem_Click);
            // 
            // açıklıkToolStripMenuItem
            // 
            this.açıklıkToolStripMenuItem.Name = "açıklıkToolStripMenuItem";
            this.açıklıkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.açıklıkToolStripMenuItem.Text = "açıklık";
            this.açıklıkToolStripMenuItem.Click += new System.EventHandler(this.açıklıkToolStripMenuItem_Click);
            // 
            // kanalcıkarımToolStripMenuItem
            // 
            this.kanalcıkarımToolStripMenuItem.Name = "kanalcıkarımToolStripMenuItem";
            this.kanalcıkarımToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kanalcıkarımToolStripMenuItem.Text = "kanalcıkarım";
            this.kanalcıkarımToolStripMenuItem.Click += new System.EventHandler(this.kanalcıkarımToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem islemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griyontemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamadegerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalcıkarımToolStripMenuItem;
    }
}

