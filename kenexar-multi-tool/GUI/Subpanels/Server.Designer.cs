namespace kenexar_multi_tool.GUI.Subpanels
{
    partial class Server
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
            this.LabelStatus = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.LabelStatus.Location = new System.Drawing.Point(487, 93);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(81, 30);
            this.LabelStatus.TabIndex = 0;
            this.LabelStatus.Text = "Offline";
            this.LabelStatus.Click += new System.EventHandler(this.LabelStatus_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(214, 100);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(267, 23);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "http://dev.kenexar.eu/";
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(895, 607);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.LabelStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Server";
            this.Text = "Test1";
            this.Load += new System.EventHandler(this.Server_Load);
            this.Shown += new System.EventHandler(this.Server_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelStatus;
        private TextBox textBox;
    }
}