using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace DLA
{
    public partial class Form3 : Form
    {
        private readonly string swversion = "1.9"; ////////////////////////Version of this software

        public Form3()
        {

            InitializeComponent();
            this.ShowInTaskbar = false;
            try
            {

                WebClient webClient = new WebClient();
                if (!webClient.DownloadString(@"\\SERVERNAME\District\Admin\Technology\Desktop Services\CL\Software\DLA\Updates\version\version_update.txt").Contains(swversion))
                {
                    btnUpdate.Text = "Update Available";
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnUpdate.Text = "No Update Needed";
                    btnUpdate.Enabled = false;
                }
            }

            catch (Exception)
            {

            }
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            var url = "mailto:christianjlancaster@katyisd.org?subject=Device Location Assistant";
            Process.Start(url);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void Label4_MouseHover(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Blue;
        }

        private void Label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient webClient = new WebClient();
                if (!webClient.DownloadString(@"\\SERVERNAME\District\Admin\Technology\Desktop Services\CL\Software\DLA\Updates\version\version_update.txt").Contains(swversion))//Version of this software
                {
                    using (WebClient Client = new WebClient())
                    {
                        File.Copy(@"\\SERVERNAME\District\Admin\Technology\Desktop Services\CL\Software\DLA\Updates\files\updater.exe", Application.StartupPath + @"\updater.exe");
                        Process.Start(Application.StartupPath + @"\updater.exe");
                        Environment.Exit(0);
                    }


                }
                else
                {
                    MessageBox.Show("No update needed!");
                }
            }

            catch (Exception)
            {

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label6.Text = swversion;
        }

        private void BtnAD_MouseClick(object sender, MouseEventArgs e)
        {
            Form4 m = new Form4();
            m.ShowDialog();
        }
    }
}
