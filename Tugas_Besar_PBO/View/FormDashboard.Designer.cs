﻿namespace Tugas_Besar_PBO
{
    partial class FormDashboard
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendaftaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pemilihanProgamStudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahPrestasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.prestasiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.toolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(109, 6);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendaftaranToolStripMenuItem,
            this.pemilihanProgamStudiToolStripMenuItem});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
            this.transaksiToolStripMenuItem.Text = "&Administrasi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // pendaftaranToolStripMenuItem
            // 
            this.pendaftaranToolStripMenuItem.Name = "pendaftaranToolStripMenuItem";
            this.pendaftaranToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pendaftaranToolStripMenuItem.Text = "&Pendaftaran";
            this.pendaftaranToolStripMenuItem.Click += new System.EventHandler(this.pendaftaranToolStripMenuItem_Click);
            // 
            // pemilihanProgamStudiToolStripMenuItem
            // 
            this.pemilihanProgamStudiToolStripMenuItem.Name = "pemilihanProgamStudiToolStripMenuItem";
            this.pemilihanProgamStudiToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pemilihanProgamStudiToolStripMenuItem.Text = "&Progam Studi";
            this.pemilihanProgamStudiToolStripMenuItem.Click += new System.EventHandler(this.pemilihanProgamStudiToolStripMenuItem_Click);
            // 
            // prestasiToolStripMenuItem
            // 
            this.prestasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahPrestasiToolStripMenuItem});
            this.prestasiToolStripMenuItem.Name = "prestasiToolStripMenuItem";
            this.prestasiToolStripMenuItem.Size = new System.Drawing.Size(59, 22);
            this.prestasiToolStripMenuItem.Text = "&Prestasi";
            // 
            // tambahPrestasiToolStripMenuItem
            // 
            this.tambahPrestasiToolStripMenuItem.Name = "tambahPrestasiToolStripMenuItem";
            this.tambahPrestasiToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.tambahPrestasiToolStripMenuItem.Text = "&Tambah Prestasi";
            this.tambahPrestasiToolStripMenuItem.Click += new System.EventHandler(this.tambahPrestasiToolStripMenuItem_Click);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 429);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahPrestasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendaftaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pemilihanProgamStudiToolStripMenuItem;
    }
}

