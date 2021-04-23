using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DLA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Btn_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (XmlWriter xmlW = XmlWriter.Create("config_dla.xml"))
            {
                xmlW.WriteStartElement("Path");
                xmlW.WriteStartElement("Users");
                xmlW.WriteElementString("uAdmin", tbUAdmin.Text);
                xmlW.WriteElementString("uElementary", tbUElem.Text);
                xmlW.WriteElementString("uJuniorHigh", tbUJunior.Text);
                xmlW.WriteElementString("uSeniorHigh", tbUSenior.Text);
                xmlW.WriteEndElement();
                xmlW.WriteStartElement("Computers");
                xmlW.WriteElementString("cAdmin", tbCAdmin.Text);
                xmlW.WriteElementString("cElementary", tbCElem.Text);
                xmlW.WriteElementString("cJuniorHigh", tbCJunior.Text);
                xmlW.WriteElementString("cSeniorHigh", tbCSenior.Text);
                xmlW.WriteEndElement();
                xmlW.WriteEndElement();
            }
            this.Close();
        }

        private void BtnDefault_Click(object sender, EventArgs e)
        {
            tbUAdmin.Text = (@"\\ktfs01\logincapture$\Admin\Users\");
            tbUElem.Text = (@"\\ktfs01\logincapture$\Elementary\Users\");
            tbUJunior.Text = (@"\\ktfs01\logincapture$\JuniorHigh\Users\");
            tbUSenior.Text = (@"\\ktfs01\logincapture$\SeniorHigh\Users\");
            tbCAdmin.Text = (@"\\ktfs01\logincapture$\Admin\Computers\");
            tbCElem.Text = (@"\\ktfs01\logincapture$\Elementary\Computers\");
            tbCJunior.Text = (@"\\ktfs01\logincapture$\JuniorHigh\Computers\");
            tbCSenior.Text = (@"\\ktfs01\logincapture$\SeniorHigh\Computers\");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (System.IO.File.Exists("config_dla.xml"))
            {
                XDocument doc = XDocument.Load("config_dla.xml");

                var adminu = doc.Root.Elements("Users").Select(x => x.Element("uAdmin"));
                var elemu = doc.Root.Elements("Users").Select(x => x.Element("uElementary"));
                var junioru = doc.Root.Elements("Users").Select(x => x.Element("uJuniorHigh"));
                var senioru = doc.Root.Elements("Users").Select(x => x.Element("uSeniorHigh"));
                var adminc = doc.Root.Elements("Computers").Select(x => x.Element("cAdmin"));
                var elemc = doc.Root.Elements("Computers").Select(x => x.Element("cElementary"));
                var juniorc = doc.Root.Elements("Computers").Select(x => x.Element("cJuniorHigh"));
                var seniorc = doc.Root.Elements("Computers").Select(x => x.Element("cSeniorHigh"));

                foreach (var AdminU in adminu)
                {
                    tbUAdmin.Text = AdminU.Value;
                }

                foreach (var ElemU in elemu)
                {
                    tbUElem.Text = ElemU.Value;
                }

                foreach (var JuniorU in junioru)
                {
                    tbUJunior.Text = JuniorU.Value;
                }

                foreach (var SeniorU in senioru)
                {
                    tbUSenior.Text = SeniorU.Value;
                }

                foreach (var AdminC in adminc)
                {
                    tbCAdmin.Text = AdminC.Value;
                }

                foreach (var ElemC in elemc)
                {
                    tbCElem.Text = ElemC.Value;
                }

                foreach (var JuniorC in juniorc)
                {
                    tbCJunior.Text = JuniorC.Value;
                }

                foreach (var SeniorC in seniorc)
                {
                    tbCSenior.Text = SeniorC.Value;
                }
            }
        }
    }
}
