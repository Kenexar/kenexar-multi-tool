using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace kenexar_multi_tool.GUI.Subpanels
{
    public partial class Server : Form
    {
        private EventWaitHandle ewh = new(false, EventResetMode.AutoReset);
        public Server()
        {
            InitializeComponent();
        }


        private void LabelStatus_Click(object sender, EventArgs e)
        {

        }

        private void Server_Load(object sender, EventArgs e)
        {
            HttpClient client = new();

            _ = Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Uri uriResult;
                    bool result = Uri.TryCreate(textBox.Text, UriKind.Absolute, out uriResult)
                        && uriResult.Scheme == Uri.UriSchemeHttp;

                    if (!result)
                    {
                        Action updateLable = () =>
                        {
                            LabelStatus.Text = "Invalid URL";
                            LabelStatus.ForeColor = System.Drawing.Color.FromArgb(179, 45, 60);
                        };
                        LabelStatus.BeginInvoke(updateLable);
                        continue;
                    }

                    HttpResponseMessage response = client.GetAsync(uriResult).Result;
    
                    if (response.IsSuccessStatusCode)
                    {
                        Action updateLable = () =>
                        {
                            LabelStatus.Text = "Online";
                            LabelStatus.ForeColor = System.Drawing.Color.FromArgb(123, 230, 163);
                        };
                        LabelStatus.BeginInvoke(updateLable);

                    }
                    else
                    {
                        Action updateLable = () =>
                        {
                            LabelStatus.Text = "Offline";
                            LabelStatus.ForeColor = System.Drawing.Color.FromArgb(179, 45, 60);
                        };
                        LabelStatus.BeginInvoke(updateLable);
                    }
                  
                    ewh.WaitOne(1000);
                }
            });
        }

        private void Server_Shown(object sender, EventArgs e)
        {
            ewh.Set();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
