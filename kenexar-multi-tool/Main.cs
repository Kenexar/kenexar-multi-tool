using System.Runtime.InteropServices;

namespace kenexar_multi_tool
{
    public partial class Main : Form
    {
        private Form activeForm = new GUI.Subpanels.Server();
        public static string test = "Hey";

        private Form ServerForm = new GUI.Subpanels.Server();
        private Form TestForm = new GUI.Subpanels.Test2();

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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void logobox_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnServer_Click(object sender, EventArgs e)
        {
            OpenChildForm(ServerForm);
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            OpenChildForm(TestForm);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}