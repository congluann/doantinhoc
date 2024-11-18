namespace doantinhocreal
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
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hẹnGiờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đồngHồToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đếmGiờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem,
            this.hẹnGiờToolStripMenuItem,
            this.đồngHồToolStripMenuItem,
            this.đếmGiờToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.bToolStripMenuItem.Text = "Đồng Hồ";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // hẹnGiờToolStripMenuItem
            // 
            this.hẹnGiờToolStripMenuItem.Name = "hẹnGiờToolStripMenuItem";
            this.hẹnGiờToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.hẹnGiờToolStripMenuItem.Text = "Hẹn Giờ";
            this.hẹnGiờToolStripMenuItem.Click += new System.EventHandler(this.hẹnGiờToolStripMenuItem_Click);
            // 
            // đồngHồToolStripMenuItem
            // 
            this.đồngHồToolStripMenuItem.Name = "đồngHồToolStripMenuItem";
            this.đồngHồToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.đồngHồToolStripMenuItem.Text = "Báo Thức";
            this.đồngHồToolStripMenuItem.Click += new System.EventHandler(this.đồngHồToolStripMenuItem_Click);
            // 
            // đếmGiờToolStripMenuItem
            // 
            this.đếmGiờToolStripMenuItem.Name = "đếmGiờToolStripMenuItem";
            this.đếmGiờToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.đếmGiờToolStripMenuItem.Text = "Bấm Giờ";
            this.đếmGiờToolStripMenuItem.Click += new System.EventHandler(this.đếmGiờToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 474);
            this.panel1.TabIndex = 1;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hẹnGiờToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem đồngHồToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đếmGiờToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

