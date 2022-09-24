namespace kenexar_multi_tool.GUI.Subpanels
{
    partial class Settings
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
            this.LabelMailTools = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnShowWriteKey = new FontAwesome.Sharp.IconButton();
            this.TextBoxWriteKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnShowReadKey = new FontAwesome.Sharp.IconButton();
            this.TextBoxReadKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxBaseURL = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnMailSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelMailTools
            // 
            this.LabelMailTools.AutoSize = true;
            this.LabelMailTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.LabelMailTools.Location = new System.Drawing.Point(0, 3);
            this.LabelMailTools.Name = "LabelMailTools";
            this.LabelMailTools.Size = new System.Drawing.Size(105, 15);
            this.LabelMailTools.TabIndex = 2;
            this.LabelMailTools.Text = "Mail Tools Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.BtnMailSave);
            this.panel1.Controls.Add(this.BtnShowWriteKey);
            this.panel1.Controls.Add(this.TextBoxWriteKey);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnShowReadKey);
            this.panel1.Controls.Add(this.TextBoxReadKey);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextBoxBaseURL);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 229);
            this.panel1.TabIndex = 1;
            // 
            // BtnShowWriteKey
            // 
            this.BtnShowWriteKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnShowWriteKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowWriteKey.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnShowWriteKey.IconColor = System.Drawing.Color.Black;
            this.BtnShowWriteKey.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnShowWriteKey.IconSize = 16;
            this.BtnShowWriteKey.Location = new System.Drawing.Point(341, 153);
            this.BtnShowWriteKey.Name = "BtnShowWriteKey";
            this.BtnShowWriteKey.Size = new System.Drawing.Size(19, 16);
            this.BtnShowWriteKey.TabIndex = 9;
            this.BtnShowWriteKey.UseVisualStyleBackColor = false;
            this.BtnShowWriteKey.Click += new System.EventHandler(this.BtnShowWriteKey_Click);
            // 
            // TextBoxWriteKey
            // 
            this.TextBoxWriteKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxWriteKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxWriteKey.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxWriteKey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxWriteKey.Location = new System.Drawing.Point(10, 153);
            this.TextBoxWriteKey.Name = "TextBoxWriteKey";
            this.TextBoxWriteKey.Size = new System.Drawing.Size(350, 16);
            this.TextBoxWriteKey.TabIndex = 10;
            this.TextBoxWriteKey.Text = "example@kenexar.eu";
            this.TextBoxWriteKey.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Write Key";
            // 
            // BtnShowReadKey
            // 
            this.BtnShowReadKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnShowReadKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowReadKey.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnShowReadKey.IconColor = System.Drawing.Color.Black;
            this.BtnShowReadKey.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnShowReadKey.IconSize = 16;
            this.BtnShowReadKey.Location = new System.Drawing.Point(341, 102);
            this.BtnShowReadKey.Name = "BtnShowReadKey";
            this.BtnShowReadKey.Size = new System.Drawing.Size(19, 16);
            this.BtnShowReadKey.TabIndex = 6;
            this.BtnShowReadKey.UseVisualStyleBackColor = false;
            this.BtnShowReadKey.Click += new System.EventHandler(this.BtnShowReadKey_Click);
            // 
            // TextBoxReadKey
            // 
            this.TextBoxReadKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxReadKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxReadKey.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxReadKey.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxReadKey.Location = new System.Drawing.Point(10, 102);
            this.TextBoxReadKey.Name = "TextBoxReadKey";
            this.TextBoxReadKey.Size = new System.Drawing.Size(350, 16);
            this.TextBoxReadKey.TabIndex = 7;
            this.TextBoxReadKey.Text = "example@kenexar.eu";
            this.TextBoxReadKey.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Read Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "API BaseURL";
            // 
            // TextBoxBaseURL
            // 
            this.TextBoxBaseURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxBaseURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxBaseURL.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxBaseURL.Location = new System.Drawing.Point(10, 49);
            this.TextBoxBaseURL.Margin = new System.Windows.Forms.Padding(10);
            this.TextBoxBaseURL.Name = "TextBoxBaseURL";
            this.TextBoxBaseURL.Size = new System.Drawing.Size(350, 16);
            this.TextBoxBaseURL.TabIndex = 1;
            this.TextBoxBaseURL.Text = "example.com";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.LabelMailTools);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 21);
            this.panel2.TabIndex = 0;
            // 
            // BtnMailSave
            // 
            this.BtnMailSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnMailSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailSave.Location = new System.Drawing.Point(285, 196);
            this.BtnMailSave.Margin = new System.Windows.Forms.Padding(10);
            this.BtnMailSave.Name = "BtnMailSave";
            this.BtnMailSave.Size = new System.Drawing.Size(75, 23);
            this.BtnMailSave.TabIndex = 11;
            this.BtnMailSave.Text = "Save";
            this.BtnMailSave.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(895, 607);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label LabelMailTools;
        private Panel panel1;
        private TextBox TextBoxBaseURL;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton BtnShowReadKey;
        private TextBox TextBoxReadKey;
        private FontAwesome.Sharp.IconButton BtnShowWriteKey;
        private TextBox TextBoxWriteKey;
        private Label label3;
        private Button BtnMailSave;
    }
}