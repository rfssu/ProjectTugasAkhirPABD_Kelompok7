
namespace TA_PABD
{
    partial class Form3
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
            this.BLog2 = new System.Windows.Forms.Button();
            this.Pass = new System.Windows.Forms.TextBox();
            this.IdPegawai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BReg2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peminjamanBukuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BLog2
            // 
            this.BLog2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BLog2.Location = new System.Drawing.Point(361, 269);
            this.BLog2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BLog2.Name = "BLog2";
            this.BLog2.Size = new System.Drawing.Size(100, 28);
            this.BLog2.TabIndex = 19;
            this.BLog2.Text = "Login";
            this.BLog2.UseVisualStyleBackColor = false;
            this.BLog2.Click += new System.EventHandler(this.BLog2_Click);
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(261, 203);
            this.Pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(337, 22);
            this.Pass.TabIndex = 18;
            // 
            // IdPegawai
            // 
            this.IdPegawai.Location = new System.Drawing.Point(261, 162);
            this.IdPegawai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdPegawai.Name = "IdPegawai";
            this.IdPegawai.Size = new System.Drawing.Size(337, 22);
            this.IdPegawai.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Id Pegawai";
            // 
            // BReg2
            // 
            this.BReg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BReg2.Location = new System.Drawing.Point(575, 382);
            this.BReg2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BReg2.Name = "BReg2";
            this.BReg2.Size = new System.Drawing.Size(100, 28);
            this.BReg2.TabIndex = 25;
            this.BReg2.Text = "Register";
            this.BReg2.UseVisualStyleBackColor = false;
            this.BReg2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 388);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Belum punya akun?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem1,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(603, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(132, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem1
            // 
            this.profileToolStripMenuItem1.Name = "profileToolStripMenuItem1";
            this.profileToolStripMenuItem1.Size = new System.Drawing.Size(14, 26);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peminjamanBukuToolStripMenuItem1,
            this.logOutToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.menuToolStripMenuItem.Text = "Pilihan Login";
            // 
            // peminjamanBukuToolStripMenuItem1
            // 
            this.peminjamanBukuToolStripMenuItem1.Name = "peminjamanBukuToolStripMenuItem1";
            this.peminjamanBukuToolStripMenuItem1.Size = new System.Drawing.Size(189, 26);
            this.peminjamanBukuToolStripMenuItem1.Text = "Login Member";
            this.peminjamanBukuToolStripMenuItem1.Click += new System.EventHandler(this.peminjamanBukuToolStripMenuItem1_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(189, 26);
            this.logOutToolStripMenuItem1.Text = "Login Pegawai";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(737, 508);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BReg2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BLog2);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.IdPegawai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Login Pegawai";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BLog2;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.TextBox IdPegawai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BReg2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peminjamanBukuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}