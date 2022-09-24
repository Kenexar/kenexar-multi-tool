using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenexar_multi_tool.GUI.Subpanels
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void BtnShowReadKey_Click(object sender, EventArgs e)
        {
            bool usePassChar = TextBoxReadKey.UseSystemPasswordChar;

            TextBoxReadKey.UseSystemPasswordChar = !usePassChar;
            BtnShowReadKey.IconChar = usePassChar ? FontAwesome.Sharp.IconChar.EyeSlash : FontAwesome.Sharp.IconChar.Eye;
        }

        private void BtnShowWriteKey_Click(object sender, EventArgs e)
        {
            bool usePassChar = TextBoxWriteKey.UseSystemPasswordChar;

            TextBoxWriteKey.UseSystemPasswordChar = !usePassChar;
            BtnShowWriteKey.IconChar = usePassChar ? FontAwesome.Sharp.IconChar.EyeSlash : FontAwesome.Sharp.IconChar.Eye;
        }
    }
}
