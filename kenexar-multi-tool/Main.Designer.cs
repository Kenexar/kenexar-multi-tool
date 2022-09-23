namespace kenexar_multi_tool
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMailTools = new FontAwesome.Sharp.IconButton();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.BtnServer = new FontAwesome.Sharp.IconButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.BtnMailTools);
            this.panel1.Controls.Add(this.LogoBox);
            this.panel1.Controls.Add(this.BtnServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 607);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnMailTools
            // 
            this.BtnMailTools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMailTools.FlatAppearance.BorderSize = 0;
            this.BtnMailTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailTools.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMailTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnMailTools.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.BtnMailTools.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnMailTools.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMailTools.IconSize = 35;
            this.BtnMailTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMailTools.Location = new System.Drawing.Point(0, 116);
            this.BtnMailTools.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMailTools.Name = "BtnMailTools";
            this.BtnMailTools.Size = new System.Drawing.Size(212, 47);
            this.BtnMailTools.TabIndex = 2;
            this.BtnMailTools.Text = "Mail Tools";
            this.BtnMailTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMailTools.UseVisualStyleBackColor = false;
            this.BtnMailTools.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.Location = new System.Drawing.Point(27, 11);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(158, 47);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogoBox.TabIndex = 1;
            this.LogoBox.TabStop = false;
            this.LogoBox.Click += new System.EventHandler(this.LogoBox_Click_1);
            // 
            // BtnServer
            // 
            this.BtnServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnServer.FlatAppearance.BorderSize = 0;
            this.BtnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnServer.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.BtnServer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnServer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnServer.IconSize = 35;
            this.BtnServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnServer.Location = new System.Drawing.Point(0, 63);
            this.BtnServer.Margin = new System.Windows.Forms.Padding(0);
            this.BtnServer.Name = "BtnServer";
            this.BtnServer.Size = new System.Drawing.Size(212, 47);
            this.BtnServer.TabIndex = 0;
            this.BtnServer.Text = "Server";
            this.BtnServer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnServer.UseVisualStyleBackColor = false;
            this.BtnServer.Click += new System.EventHandler(this.BtnServer_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Location = new System.Drawing.Point(215, 13);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(895, 607);
            this.ContentPanel.TabIndex = 1;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.header.Controls.Add(this.BtnExit);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1111, 10);
            this.header.TabIndex = 2;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Red;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.X;
            this.BtnExit.IconColor = System.Drawing.Color.Black;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 10;
            this.BtnExit.Location = new System.Drawing.Point(1062, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(49, 10);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1111, 620);
            this.Controls.Add(this.header);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton BtnServer;
        private PictureBox LogoBox;
        private FontAwesome.Sharp.IconButton BtnMailTools;
        private Panel ContentPanel;
        private Panel header;
        private FontAwesome.Sharp.IconButton BtnExit;
    }
}