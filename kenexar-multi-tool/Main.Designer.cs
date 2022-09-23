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
            this.btnTest2 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnServer = new FontAwesome.Sharp.IconButton();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.btnTest2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 607);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTest2
            // 
            this.btnTest2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest2.FlatAppearance.BorderSize = 0;
            this.btnTest2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTest2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnTest2.IconChar = FontAwesome.Sharp.IconChar.Satellite;
            this.btnTest2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnTest2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTest2.IconSize = 35;
            this.btnTest2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest2.Location = new System.Drawing.Point(0, 116);
            this.btnTest2.Margin = new System.Windows.Forms.Padding(0);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(212, 47);
            this.btnTest2.TabIndex = 2;
            this.btnTest2.Text = "Test 2";
            this.btnTest2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTest2.UseVisualStyleBackColor = false;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BtnServer
            // 
            this.BtnServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnServer.FlatAppearance.BorderSize = 0;
            this.BtnServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnServer.IconChar = FontAwesome.Sharp.IconChar.Satellite;
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
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1111, 10);
            this.header.TabIndex = 2;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.header_MouseDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton BtnServer;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnTest2;
        private Panel ContentPanel;
        private Panel header;
    }
}