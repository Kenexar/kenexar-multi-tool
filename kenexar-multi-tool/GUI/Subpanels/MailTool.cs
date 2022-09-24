using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenexar_multi_tool.GUI.Subpanels
{

    public partial class MailTool : Form
    {

        public MailTool()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MailTool_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Text = "admin@kenexar.eu";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            bool usePassChar = TextBoxPassword.UseSystemPasswordChar;

            TextBoxPassword.UseSystemPasswordChar = !usePassChar;
            BtnShowPassword.IconChar = usePassChar ? FontAwesome.Sharp.IconChar.EyeSlash : FontAwesome.Sharp.IconChar.Eye;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
