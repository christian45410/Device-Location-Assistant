namespace UHS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPing = new System.Windows.Forms.ToolStripButton();
            this.cmbCampus = new System.Windows.Forms.ToolStripComboBox();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnMunis = new System.Windows.Forms.ToolStripButton();
            this.btnKams = new System.Windows.Forms.ToolStripButton();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbResult = new System.Windows.Forms.ListBox();
            this.lbLastcomp = new System.Windows.Forms.Label();
            this.lbPassSet = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbLogon = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNameF = new System.Windows.Forms.Label();
            this.tbPing = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAbout = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPing,
            this.cmbCampus,
            this.tbSearch,
            this.btnSettings,
            this.btnPrint,
            this.btnMunis,
            this.btnKams});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPing
            // 
            this.btnPing.ForeColor = System.Drawing.Color.Black;
            this.btnPing.Image = ((System.Drawing.Image)(resources.GetObject("btnPing.Image")));
            this.btnPing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPing.Name = "btnPing";
            this.btnPing.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPing.Size = new System.Drawing.Size(138, 22);
            this.btnPing.Text = "Ping Computer";
            this.btnPing.ToolTipText = "Enter a computers name in the search box, select \r\nthe campus from the drop down " +
    "box and click this \r\nbutton to attempt to ping the computer on the domain.";
            this.btnPing.Click += new System.EventHandler(this.BtnPing_Click);
            // 
            // cmbCampus
            // 
            this.cmbCampus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCampus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCampus.BackColor = System.Drawing.SystemColors.Info;
            this.cmbCampus.ForeColor = System.Drawing.Color.Silver;
            this.cmbCampus.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(121, 25);
            this.cmbCampus.Text = "Campus";
            this.cmbCampus.SelectedIndexChanged += new System.EventHandler(this.CmbCampus_SelectedIndexChanged);
            this.cmbCampus.Enter += new System.EventHandler(this.CmbCampus_Enter);
            this.cmbCampus.Leave += new System.EventHandler(this.CmbCampus_Leave);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.Info;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.ForeColor = System.Drawing.Color.Silver;
            this.tbSearch.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(121, 25);
            this.tbSearch.Text = "Search";
            this.tbSearch.ToolTipText = "Lookup a users or computers information";
            this.tbSearch.Enter += new System.EventHandler(this.TbSearch_Enter);
            this.tbSearch.Leave += new System.EventHandler(this.TbSearch_Leave);
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(23, 22);
            this.btnSettings.Text = "&New";
            this.btnSettings.ToolTipText = "Change the location where the software\r\nwill find the login capture data.";
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(23, 22);
            this.btnPrint.Text = "&Print";
            this.btnPrint.ToolTipText = "Print the information in the left column.\r\nThis only prints the first page to sav" +
    "e paper.";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnMunis
            // 
            this.btnMunis.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMunis.ForeColor = System.Drawing.Color.Black;
            this.btnMunis.Image = ((System.Drawing.Image)(resources.GetObject("btnMunis.Image")));
            this.btnMunis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMunis.Name = "btnMunis";
            this.btnMunis.Size = new System.Drawing.Size(60, 22);
            this.btnMunis.Text = "Munis";
            this.btnMunis.ToolTipText = "Open Munis in the default web browser.";
            this.btnMunis.Click += new System.EventHandler(this.BtnMunis_Click);
            // 
            // btnKams
            // 
            this.btnKams.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKams.ForeColor = System.Drawing.Color.Black;
            this.btnKams.Image = global::DLA.Properties.Resources.kams;
            this.btnKams.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKams.Margin = new System.Windows.Forms.Padding(92, 1, 0, 2);
            this.btnKams.Name = "btnKams";
            this.btnKams.Size = new System.Drawing.Size(59, 22);
            this.btnKams.Text = "KAMS";
            this.btnKams.Click += new System.EventHandler(this.btnKams_Click);
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(110, 67);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(29, 20);
            this.tbHost.TabIndex = 11;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Gainsboro;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbLastcomp);
            this.splitContainer1.Panel2.Controls.Add(this.lbPassSet);
            this.splitContainer1.Panel2.Controls.Add(this.lbID);
            this.splitContainer1.Panel2.Controls.Add(this.lbPhone);
            this.splitContainer1.Panel2.Controls.Add(this.lbLogon);
            this.splitContainer1.Panel2.Controls.Add(this.lbEmail);
            this.splitContainer1.Panel2.Controls.Add(this.lbNameF);
            this.splitContainer1.Panel2.Controls.Add(this.tbPing);
            this.splitContainer1.Size = new System.Drawing.Size(633, 410);
            this.splitContainer1.SplitterDistance = 243;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbResult
            // 
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.Location = new System.Drawing.Point(0, 0);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(243, 410);
            this.tbResult.TabIndex = 6;
            // 
            // lbLastcomp
            // 
            this.lbLastcomp.AutoSize = true;
            this.lbLastcomp.ForeColor = System.Drawing.Color.Black;
            this.lbLastcomp.Location = new System.Drawing.Point(9, 96);
            this.lbLastcomp.Name = "lbLastcomp";
            this.lbLastcomp.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lbLastcomp.Size = new System.Drawing.Size(25, 17);
            this.lbLastcomp.TabIndex = 32;
            this.lbLastcomp.Text = "      ";
            // 
            // lbPassSet
            // 
            this.lbPassSet.AutoSize = true;
            this.lbPassSet.ForeColor = System.Drawing.Color.Black;
            this.lbPassSet.Location = new System.Drawing.Point(9, 113);
            this.lbPassSet.Name = "lbPassSet";
            this.lbPassSet.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lbPassSet.Size = new System.Drawing.Size(25, 17);
            this.lbPassSet.TabIndex = 31;
            this.lbPassSet.Text = "      ";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.ForeColor = System.Drawing.Color.Black;
            this.lbID.Location = new System.Drawing.Point(9, 11);
            this.lbID.Name = "lbID";
            this.lbID.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lbID.Size = new System.Drawing.Size(25, 17);
            this.lbID.TabIndex = 24;
            this.lbID.Text = "      ";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.ForeColor = System.Drawing.Color.Black;
            this.lbPhone.Location = new System.Drawing.Point(9, 62);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lbPhone.Size = new System.Drawing.Size(25, 17);
            this.lbPhone.TabIndex = 23;
            this.lbPhone.Text = "      ";
            // 
            // lbLogon
            // 
            this.lbLogon.AutoSize = true;
            this.lbLogon.ForeColor = System.Drawing.Color.Black;
            this.lbLogon.Location = new System.Drawing.Point(9, 79);
            this.lbLogon.Name = "lbLogon";
            this.lbLogon.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lbLogon.Size = new System.Drawing.Size(25, 17);
            this.lbLogon.TabIndex = 22;
            this.lbLogon.Text = "      ";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.Black;
            this.lbEmail.Location = new System.Drawing.Point(9, 45);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lbEmail.Size = new System.Drawing.Size(25, 17);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "      ";
            // 
            // lbNameF
            // 
            this.lbNameF.AutoSize = true;
            this.lbNameF.ForeColor = System.Drawing.Color.Black;
            this.lbNameF.Location = new System.Drawing.Point(9, 28);
            this.lbNameF.Name = "lbNameF";
            this.lbNameF.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.lbNameF.Size = new System.Drawing.Size(25, 17);
            this.lbNameF.TabIndex = 20;
            this.lbNameF.Text = "      ";
            // 
            // tbPing
            // 
            this.tbPing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPing.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPing.ForeColor = System.Drawing.Color.Black;
            this.tbPing.Location = new System.Drawing.Point(2, 143);
            this.tbPing.Multiline = true;
            this.tbPing.Name = "tbPing";
            this.tbPing.Size = new System.Drawing.Size(382, 172);
            this.tbPing.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbout.AutoSize = true;
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.Location = new System.Drawing.Point(3, 439);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(35, 13);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            this.btnAbout.MouseLeave += new System.EventHandler(this.BtnAbout_MouseLeave);
            this.btnAbout.MouseHover += new System.EventHandler(this.BtnAbout_MouseHover);
            // 
            // lbUpdate
            // 
            this.lbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbUpdate.ForeColor = System.Drawing.Color.Black;
            this.lbUpdate.Location = new System.Drawing.Point(44, 439);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(123, 13);
            this.lbUpdate.TabIndex = 14;
            this.lbUpdate.Text = "<--------- Update available";
            this.lbUpdate.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(633, 455);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbHost);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(599, 399);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Location Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPing;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.ToolStripComboBox cmbCampus;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripButton btnMunis;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox tbResult;
        private System.Windows.Forms.TextBox tbPing;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label btnAbout;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbPassSet;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbLogon;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNameF;
        private System.Windows.Forms.Label lbLastcomp;
        private System.Windows.Forms.ToolStripButton btnKams;
    }
}

