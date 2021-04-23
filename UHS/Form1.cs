using DLA;
using System;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace UHS
{
    public partial class Form1 : Form
    {
        Thread th;
        private StringReader myReader;
        private readonly string swversion = "1.8"; ////////////////////////Version of this software


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMunis_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://munis.katyisd.org:55000/default.aspx");

        }

        private void btnKams_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tipwebkatyisd.com/TipWebIT/Home.aspx");
        }

        private void BtnPing_Click(object sender, EventArgs e)
        {
            tbPing.Text = string.Empty;
            string a = tbSearch.Text;
            string b = cmbCampus.Text;

            if (String.IsNullOrEmpty(cmbCampus.Text) || cmbCampus.Text == "Campus" || cmbCampus.Text == "campus")
            {
                ///using (Form3 f3 = new Form3())
                ///{
                ///    f3.ShowDialog(this);
                ///}
                return;
            }

            else if (cmbCampus.Text == "ESC" || cmbCampus.Text == "esc" || cmbCampus.Text == "admin" || cmbCampus.Text == "Admin" || cmbCampus.Text == "ADMIN")
                tbHost.Text = ($"{a}.katyisd.org");

            else
                tbHost.Text = ($"{a}.{b}.katyisd.org");

            th = new Thread(Thread1);
            th.Start();
        }

        public void Thread1() ////////////////////////////////////// Ping domain computer by hostname and campus abbr.
        {
            try
            {
                string command = "/c ping -4 -a " + tbHost.Text;
                ProcessStartInfo procStartInfo = new ProcessStartInfo("CMD", command);
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.OutputDataReceived += new DataReceivedEventHandler(proc_OutPutDataReceived);
                proc.Start();
                proc.BeginOutputReadLine();
                proc.WaitForExit();
            }

            catch (Exception)
            {

            }
        }

        void proc_OutPutDataReceived(object sender, DataReceivedEventArgs e)  ////////////////////////////////////// Sends cmd output to pingBox
        {
            if (e.Data != null)
            {
                string newLine = e.Data.Trim() + Environment.NewLine;
                MethodInvoker append = () => tbPing.Text += newLine;
                tbPing.BeginInvoke(append);
            }
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            tbResult.Items.Clear();
            try
            {
                using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
                {
                    using (UserPrincipal user = UserPrincipal.FindByIdentity(context, tbSearch.Text))
                    {
                        if (user != null)
                        {
                            lbID.Text = "ID:   " + user.EmployeeId;
                            lbNameF.Text = "Full Name:   " + user.Surname + ", " + user.GivenName + " " + user.MiddleName;
                            lbEmail.Text = "Email:   " + user.EmailAddress;
                            lbPhone.Text = "Phone:   " + user.VoiceTelephoneNumber;
                            lbLogon.Text = "Last Logon:   " + user.LastLogon;
                            lbPassSet.Text = "Last Password Set:   " + user.LastPasswordSet;
                        }
                    }
                }

                XDocument doc = XDocument.Load("config_dla.xml");
                string adminu = doc.Root.Element("Users").Element("uAdmin").Value;
                string elemu = doc.Root.Element("Users").Element("uElementary").Value;
                string junioru = doc.Root.Element("Users").Element("uJuniorHigh").Value;
                string senioru = doc.Root.Element("Users").Element("uSeniorHigh").Value;
                string adminc = doc.Root.Element("Computers").Element("cAdmin").Value;
                string elemc = doc.Root.Element("Computers").Element("cElementary").Value;
                string juniorc = doc.Root.Element("Computers").Element("cJuniorHigh").Value;
                string seniorc = doc.Root.Element("Computers").Element("cSeniorHigh").Value;

                if (File.Exists(adminu + tbSearch.Text + ".log"))
                {
                    var lines = File.ReadAllLines(adminu + tbSearch.Text + ".log").Reverse();

                    foreach (string line in lines)
                    {
                        tbResult.Items.Add(line);
                    }
                    lbLastcomp.Text = "Last Computer Logon:   " + File.ReadLines(adminu + tbSearch.Text + ".log").Last();
                }

                else if (File.Exists(elemu + tbSearch.Text + ".log"))
                {
                    var lines = File.ReadAllLines(elemu + tbSearch.Text + ".log").Reverse();

                    foreach (string line in lines)
                    {
                        tbResult.Items.Add(line);
                    }
                    lbLastcomp.Text = "Last Computer Logon:   " + File.ReadLines(elemu + tbSearch.Text + ".log").Last();
                }

                else if (File.Exists(junioru + tbSearch.Text + ".log"))
                {
                    var lines = File.ReadAllLines(junioru + tbSearch.Text + ".log").Reverse();

                    foreach (string line in lines)
                    {
                        tbResult.Items.Add(line);
                    }
                    lbLastcomp.Text = "Last Computer Logon:   " + File.ReadLines(junioru + tbSearch.Text + ".log").Last();
                }

                else if (File.Exists(senioru + tbSearch.Text + ".log"))
                {
                    var lines = File.ReadAllLines(senioru + tbSearch.Text + ".log").Reverse();

                    foreach (string line in lines)
                    {
                        tbResult.Items.Add(line);
                    }
                    lbLastcomp.Text = "Last Computer Logon:   " + File.ReadLines(senioru + tbSearch.Text + ".log").Last();
                }

                else if (File.Exists(adminc + tbSearch.Text + ".log"))
                {
                    var lines = File.ReadAllLines(adminc + tbSearch.Text + ".log").Reverse();

                    foreach (string line in lines)
                    {
                        tbResult.Items.Add(line);
                    }
                }

                else if (File.Exists(elemc + tbSearch.Text + ".log"))
                {
                    var lines = File.ReadAllLines(elemc + tbSearch.Text + ".log").Reverse();

                    foreach (string line in lines)
                    {
                        tbResult.Items.Add(line);
                    }
                }

                else if (File.Exists(juniorc + tbSearch.Text + ".log"))
                {
                    var lines = File.ReadAllLines(juniorc + tbSearch.Text + ".log").Reverse();

                    foreach (string line in lines)
                    {
                        tbResult.Items.Add(line);
                    }
                }

                else if (File.Exists(seniorc + tbSearch.Text + ".log"))
                {
                    var lines = File.ReadAllLines(seniorc + tbSearch.Text + ".log").Reverse();

                    foreach (string line in lines)
                    {
                        tbResult.Items.Add(line);
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void CmbCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCampus.SelectedIndex == 2)
            {
                cmbCampus.SelectedIndex = 0;
                return;
            }

            else if (cmbCampus.SelectedIndex == 44)
            {
                cmbCampus.SelectedIndex = 0;
                return;
            }

            else if (cmbCampus.SelectedIndex == 61)
            {
                cmbCampus.SelectedIndex = 0;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCampus.Items.Add("");
            string[] items = {
            "ESC",
            "──────",
            "BCE",
            "BES",
            "BHE",
            "CBE",
            "CE",
            "DWE",
            "FE",
            "FES",
            "FPSE",
            "GE",
            "HE",
            "JEE",
            "JHE",
            "JRE",
            "JWE",
            "KDE",
            "KE",
            "MCE",
            "MGE",
            "MJE",
            "MPE",
            "MRE",
            "NCE",
            "OKE",
            "OLE",
            "PE",
            "PME",
            "RAE",
            "RES",
            "RJWE",
            "RKE",
            "RRE",
            "SEC",
            "SE",
            "SES",
            "SSE",
            "TWE",
            "USE",
            "WCE",
            "WE",
            "WME",
            "──────",
            "AJH",
            "BDJH",
            "BJH",
            "CJH",
            "CRJH",
            "KJH",
            "MCJH",
            "MDJH",
            "MMJH",
            "MPJH",
            "MRJH",
            "SJH",
            "SLJH",
            "TJH",
            "WCJH",
            "WMJH",
            "──────",
            "CRHS",
            "KHS",
            "MCHS",
            "MCTC",
            "MRHS",
            "OAC",
            "OTHS",
            "OHS",
            "RHS",
            "SLHS",
            "THS"};
            cmbCampus.Items.AddRange(items);

            if (!File.Exists("config_dla.xml"))
            {
                using (XmlWriter xmlW = XmlWriter.Create("config_dla.xml"))
                {
                    xmlW.WriteStartElement("Path");

                    xmlW.WriteStartElement("Users");
                    xmlW.WriteElementString("uAdmin", @"\\ktfs01\logincapture$\Admin\Users\");
                    xmlW.WriteElementString("uElementary", @"\\ktfs01\logincapture$\Elementary\Users\");
                    xmlW.WriteElementString("uJuniorHigh", @"\\ktfs01\logincapture$\JuniorHigh\Users\");
                    xmlW.WriteElementString("uSeniorHigh", @"\\ktfs01\logincapture$\SeniorHigh\Users\");
                    xmlW.WriteEndElement();

                    xmlW.WriteStartElement("Computers");
                    xmlW.WriteElementString("cAdmin", @"\\ktfs01\logincapture$\Admin\Computers\");
                    xmlW.WriteElementString("cElementary", @"\\ktfs01\logincapture$\Elementary\Computers\");
                    xmlW.WriteElementString("cJuniorHigh", @"\\ktfs01\logincapture$\JuniorHigh\Computers\");
                    xmlW.WriteElementString("cSeniorHigh", @"\\ktfs01\logincapture$\SeniorHigh\Computers\");
                    xmlW.WriteEndElement();

                    xmlW.WriteEndElement();
                }
            }
            if (File.Exists("updater.exe"))
            {
                File.Delete("updater.exe");
            }

            try
            {
                WebClient webClient = new WebClient();
                if (!webClient.DownloadString(@"\\ktfs01\District\Admin\Technology\Desktop Services\CL\Software\ULA\Updates\version\version_update.txt").Contains(swversion))//Version of this software
                {
                    using (WebClient Client = new WebClient())
                    {
                        lbUpdate.Visible = true;
                    }
                }
                else
                {
                    lbUpdate.Visible = false;
                }
            }

            catch (Exception)
            {

            }




        }

        private void CmbCampus_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(tbSearch.Text)) tbSearch.Text = "Search";
            if (cmbCampus.Text == "")
            {
                cmbCampus.Text = "Campus";
                cmbCampus.ForeColor = Color.Silver;
            }
        }

        private void CmbCampus_Enter(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(tbSearch.Text)) tbSearch.Text = "Search";
            if (cmbCampus.Text == "Campus")
            {
                cmbCampus.Text = "";
                cmbCampus.ForeColor = Color.Black;
            }
        }

        private void TbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                tbSearch.Text = "Search";
                tbSearch.ForeColor = Color.Silver;
            }
        }

        private void TbSearch_Enter(object sender, EventArgs e)
        {
            if (tbSearch.Text == "Search")
            {
                tbSearch.Text = "";
                tbSearch.ForeColor = Color.Black;
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        protected void PrintDocument1_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPosition = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            Font printFont = this.tbResult.Font;
            SolidBrush myBrush = new SolidBrush(Color.Black);

            linesPerPage =
               ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage && ((line = myReader.ReadLine()) != null))
            {
                yPosition = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont,
                                       myBrush, leftMargin,
                                       yPosition, new StringFormat());
                count++;
            }

            if (line != null)
                ev.HasMorePages = false; // Set to 'true' to print multiple pages
            else
                ev.HasMorePages = false;
            myBrush.Dispose();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.AllowSomePages = false; // Set to 'true' to print multiple pages
            printDialog1.ShowHelp = true;
            string strText = "";
            foreach (object x in tbResult.Items)
            {
                strText = strText + x.ToString() + "\n";
            }

            myReader = new StringReader(strText);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {

                this.printDocument1.Print();
            }
        }

        private void TbResult_DoubleClick(object sender, EventArgs e)
        {
            System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();
            foreach (object item in tbResult.SelectedItems)
                copy_buffer.AppendLine(item.ToString());
            if (copy_buffer.Length > 0)
                Clipboard.SetText(copy_buffer.ToString());
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            Form3 m = new Form3();
            m.ShowDialog();
            this.Visible = true;
        }

        private void BtnAbout_MouseHover(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.Blue;
        }

        private void BtnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.Black;
        }
    }
}

