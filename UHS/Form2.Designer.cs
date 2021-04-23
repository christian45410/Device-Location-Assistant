namespace DLA
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCAdmin = new System.Windows.Forms.TextBox();
            this.tbCElem = new System.Windows.Forms.TextBox();
            this.tbCSenior = new System.Windows.Forms.TextBox();
            this.tbCJunior = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUAdmin = new System.Windows.Forms.TextBox();
            this.tbUElem = new System.Windows.Forms.TextBox();
            this.tbUSenior = new System.Windows.Forms.TextBox();
            this.tbUJunior = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.panel2.Controls.Add(this.btnDefault);
            this.panel2.Controls.Add(this.btn);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 469);
            this.panel2.TabIndex = 3;
            // 
            // btnDefault
            // 
            this.btnDefault.ForeColor = System.Drawing.Color.Black;
            this.btnDefault.Location = new System.Drawing.Point(12, 432);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(75, 23);
            this.btnDefault.TabIndex = 12;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.BtnDefault_Click);
            // 
            // btn
            // 
            this.btn.ForeColor = System.Drawing.Color.Black;
            this.btn.Location = new System.Drawing.Point(184, 432);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "Cancel";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Cancel);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(265, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbCAdmin);
            this.groupBox2.Controls.Add(this.tbCElem);
            this.groupBox2.Controls.Add(this.tbCSenior);
            this.groupBox2.Controls.Add(this.tbCJunior);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 204);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "High School";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Junior High";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Elementary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Admin";
            // 
            // tbCAdmin
            // 
            this.tbCAdmin.Location = new System.Drawing.Point(22, 42);
            this.tbCAdmin.Name = "tbCAdmin";
            this.tbCAdmin.Size = new System.Drawing.Size(291, 20);
            this.tbCAdmin.TabIndex = 8;
            // 
            // tbCElem
            // 
            this.tbCElem.Location = new System.Drawing.Point(22, 81);
            this.tbCElem.Name = "tbCElem";
            this.tbCElem.Size = new System.Drawing.Size(291, 20);
            this.tbCElem.TabIndex = 9;
            // 
            // tbCSenior
            // 
            this.tbCSenior.Location = new System.Drawing.Point(22, 159);
            this.tbCSenior.Name = "tbCSenior";
            this.tbCSenior.Size = new System.Drawing.Size(291, 20);
            this.tbCSenior.TabIndex = 11;
            // 
            // tbCJunior
            // 
            this.tbCJunior.Location = new System.Drawing.Point(22, 120);
            this.tbCJunior.Name = "tbCJunior";
            this.tbCJunior.Size = new System.Drawing.Size(291, 20);
            this.tbCJunior.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbUAdmin);
            this.groupBox1.Controls.Add(this.tbUElem);
            this.groupBox1.Controls.Add(this.tbUSenior);
            this.groupBox1.Controls.Add(this.tbUJunior);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 204);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "High School";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Junior High";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elementary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin";
            // 
            // tbUAdmin
            // 
            this.tbUAdmin.Location = new System.Drawing.Point(22, 45);
            this.tbUAdmin.Name = "tbUAdmin";
            this.tbUAdmin.Size = new System.Drawing.Size(291, 20);
            this.tbUAdmin.TabIndex = 0;
            // 
            // tbUElem
            // 
            this.tbUElem.Location = new System.Drawing.Point(22, 84);
            this.tbUElem.Name = "tbUElem";
            this.tbUElem.Size = new System.Drawing.Size(291, 20);
            this.tbUElem.TabIndex = 1;
            // 
            // tbUSenior
            // 
            this.tbUSenior.Location = new System.Drawing.Point(22, 162);
            this.tbUSenior.Name = "tbUSenior";
            this.tbUSenior.Size = new System.Drawing.Size(291, 20);
            this.tbUSenior.TabIndex = 3;
            // 
            // tbUJunior
            // 
            this.tbUJunior.Location = new System.Drawing.Point(22, 123);
            this.tbUJunior.Name = "tbUJunior";
            this.tbUJunior.Size = new System.Drawing.Size(291, 20);
            this.tbUJunior.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 469);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Location Assistant - Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCAdmin;
        private System.Windows.Forms.TextBox tbCElem;
        private System.Windows.Forms.TextBox tbCSenior;
        private System.Windows.Forms.TextBox tbCJunior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUAdmin;
        private System.Windows.Forms.TextBox tbUElem;
        private System.Windows.Forms.TextBox tbUSenior;
        private System.Windows.Forms.TextBox tbUJunior;
        private System.Windows.Forms.Button btnDefault;
    }
}