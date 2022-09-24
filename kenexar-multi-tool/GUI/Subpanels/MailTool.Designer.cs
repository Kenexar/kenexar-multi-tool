namespace kenexar_multi_tool.GUI.Subpanels
{
    partial class MailTool
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnShowPassword = new FontAwesome.Sharp.IconButton();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.BtnMailGenerator = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnShowPassword);
            this.panel1.Controls.Add(this.TextBoxEmail);
            this.panel1.Controls.Add(this.BtnMailGenerator);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TextBoxPassword);
            this.panel1.Location = new System.Drawing.Point(24, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 144);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "/api/v1/add/mailbox (Write)";
            // 
            // BtnShowPassword
            // 
            this.BtnShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnShowPassword.IconColor = System.Drawing.Color.Black;
            this.BtnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.BtnShowPassword.IconSize = 16;
            this.BtnShowPassword.Location = new System.Drawing.Point(294, 82);
            this.BtnShowPassword.Name = "BtnShowPassword";
            this.BtnShowPassword.Size = new System.Drawing.Size(19, 16);
            this.BtnShowPassword.TabIndex = 4;
            this.BtnShowPassword.UseVisualStyleBackColor = false;
            this.BtnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxEmail.Location = new System.Drawing.Point(16, 60);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.ReadOnly = true;
            this.TextBoxEmail.Size = new System.Drawing.Size(297, 16);
            this.TextBoxEmail.TabIndex = 2;
            this.TextBoxEmail.Text = "example@kenexar.eu";
            // 
            // BtnMailGenerator
            // 
            this.BtnMailGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.BtnMailGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMailGenerator.Location = new System.Drawing.Point(238, 111);
            this.BtnMailGenerator.Margin = new System.Windows.Forms.Padding(10);
            this.BtnMailGenerator.Name = "BtnMailGenerator";
            this.BtnMailGenerator.Size = new System.Drawing.Size(75, 23);
            this.BtnMailGenerator.TabIndex = 1;
            this.BtnMailGenerator.Text = "Generate";
            this.BtnMailGenerator.UseVisualStyleBackColor = false;
            this.BtnMailGenerator.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 21);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Generator";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TextBoxPassword.Location = new System.Drawing.Point(16, 82);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.ReadOnly = true;
            this.TextBoxPassword.Size = new System.Drawing.Size(297, 16);
            this.TextBoxPassword.TabIndex = 5;
            this.TextBoxPassword.Text = "example@kenexar.eu";
            this.TextBoxPassword.UseSystemPasswordChar = true;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // MailTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(895, 607);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailTool";
            this.Text = "Test2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button BtnMailGenerator;
        private TextBox TextBoxEmail;
        private FontAwesome.Sharp.IconButton BtnShowPassword;
        private TextBox TextBoxPassword;
        private Label label2;
    }
}