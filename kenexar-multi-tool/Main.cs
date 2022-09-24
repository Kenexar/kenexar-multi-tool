using System.Runtime.InteropServices;

namespace kenexar_multi_tool
{
    public partial class Main : Form
    {
        private Form activeForm = null;

        private Form ServerForm = new GUI.Subpanels.Server();
        private Form MailForm = new GUI.Subpanels.MailTool();
        private Form SettingsForm = new GUI.Subpanels.Settings();

        private Button activeButton = null;
        private Color baseColor = System.Drawing.Color.FromArgb(20, 20, 20);
        private Color activeColor = System.Drawing.Color.FromArgb(41, 41, 41);

        private void OpenChildForm(Form childFrom)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(childFrom);
            ContentPanel.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        private void SetActiveButton(Button button)
        {
            if (activeButton == null)
                activeButton = button;

            activeButton.BackColor = baseColor;
     
            activeButton = button;
            activeButton.BackColor = activeColor;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BtnServer_Click(object sender, EventArgs e)
        {
            OpenChildForm(ServerForm);
            SetActiveButton(BtnServer);
            LogoBox.Focus();
        }

        private void BtnMailTools_Click(object sender, EventArgs e)
        {
            OpenChildForm(MailForm);
            SetActiveButton(BtnMailTools);
            LogoBox.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            OpenChildForm(ServerForm);
            SetActiveButton(BtnServer);
            LogoBox.Focus();
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(SettingsForm);
            SetActiveButton(BtnSettings);
            LogoBox.Focus();
        }
    }
}