using System;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Windows.Forms;

namespace DLA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start(); // start timer (you can do it on form load, if you need)
            startTime = DateTime.Now; // and remember start time
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure you want to permanently delete this computer from active directory?", "Warning!", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult1 = System.Windows.Forms.MessageBox.Show("Are you sure? This action cannot be undone!", "Warning!", MessageBoxButtons.YesNo);

                if (dialogResult1 == DialogResult.Yes)
                {
                    try
                    {
                        PrincipalContext ctx = new PrincipalContext(ContextType.Domain);
                        ComputerPrincipal computer = ComputerPrincipal.FindByIdentity(ctx, tbSearch.Text);
                        if (computer != null)
                        {
                            computer.Delete();
                        }
                        else
                        {
                            return;
                        }
                    }

                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (PrincipalContext ctx = new PrincipalContext(ContextType.Domain))
                {
                    ComputerPrincipal computer = ComputerPrincipal.FindByIdentity(ctx, tbSearch.Text);

                    if (computer != null)
                    {
                        tbSearch.ForeColor = Color.Green;
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        tbSearch.ForeColor = Color.Red;
                        btnDelete.Enabled = false;
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private int secondsToWait = 30;
        private DateTime startTime;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
            int remainingSeconds = secondsToWait - elapsedSeconds;

            if (remainingSeconds <= 0)
            {
                timer1.Stop();
                this.Close();
            }

            lbTimer.Text =
                String.Format("This tool will close in: {0} seconds", remainingSeconds);
        }
    }
}
