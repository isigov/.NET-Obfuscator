namespace Darkfuscator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.chkObfuscateTypes = new System.Windows.Forms.CheckBox();
            this.chkObfuscateMethods = new System.Windows.Forms.CheckBox();
            this.chkObfuscateProperties = new System.Windows.Forms.CheckBox();
            this.chkObfuscateFields = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new Glass.GlassButton();
            this.button2 = new Glass.GlassButton();
            this.button1 = new Glass.GlassButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkObfuscateTypes
            // 
            this.chkObfuscateTypes.AutoSize = true;
            this.chkObfuscateTypes.BackColor = System.Drawing.Color.Transparent;
            this.chkObfuscateTypes.Checked = true;
            this.chkObfuscateTypes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateTypes.ForeColor = System.Drawing.Color.Black;
            this.chkObfuscateTypes.Location = new System.Drawing.Point(58, 18);
            this.chkObfuscateTypes.Name = "chkObfuscateTypes";
            this.chkObfuscateTypes.Size = new System.Drawing.Size(104, 17);
            this.chkObfuscateTypes.TabIndex = 1;
            this.chkObfuscateTypes.Text = "Obfuscate types ";
            this.chkObfuscateTypes.UseVisualStyleBackColor = false;
            // 
            // chkObfuscateMethods
            // 
            this.chkObfuscateMethods.AutoSize = true;
            this.chkObfuscateMethods.BackColor = System.Drawing.Color.Transparent;
            this.chkObfuscateMethods.Checked = true;
            this.chkObfuscateMethods.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateMethods.ForeColor = System.Drawing.Color.Black;
            this.chkObfuscateMethods.Location = new System.Drawing.Point(490, 41);
            this.chkObfuscateMethods.Name = "chkObfuscateMethods";
            this.chkObfuscateMethods.Size = new System.Drawing.Size(118, 17);
            this.chkObfuscateMethods.TabIndex = 2;
            this.chkObfuscateMethods.Text = "Obfuscate methods";
            this.chkObfuscateMethods.UseVisualStyleBackColor = false;
            // 
            // chkObfuscateProperties
            // 
            this.chkObfuscateProperties.AutoSize = true;
            this.chkObfuscateProperties.BackColor = System.Drawing.Color.Transparent;
            this.chkObfuscateProperties.Checked = true;
            this.chkObfuscateProperties.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateProperties.ForeColor = System.Drawing.Color.Black;
            this.chkObfuscateProperties.Location = new System.Drawing.Point(201, 41);
            this.chkObfuscateProperties.Name = "chkObfuscateProperties";
            this.chkObfuscateProperties.Size = new System.Drawing.Size(125, 17);
            this.chkObfuscateProperties.TabIndex = 4;
            this.chkObfuscateProperties.Text = "Obfuscate properties";
            this.chkObfuscateProperties.UseVisualStyleBackColor = false;
            // 
            // chkObfuscateFields
            // 
            this.chkObfuscateFields.AutoSize = true;
            this.chkObfuscateFields.BackColor = System.Drawing.Color.Transparent;
            this.chkObfuscateFields.Checked = true;
            this.chkObfuscateFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkObfuscateFields.ForeColor = System.Drawing.Color.Black;
            this.chkObfuscateFields.Location = new System.Drawing.Point(358, 18);
            this.chkObfuscateFields.Name = "chkObfuscateFields";
            this.chkObfuscateFields.Size = new System.Drawing.Size(102, 17);
            this.chkObfuscateFields.TabIndex = 8;
            this.chkObfuscateFields.Text = "Obfuscate fields";
            this.chkObfuscateFields.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(580, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Path to .NET assembly";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(126, 397);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(432, 24);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(490, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "String encryption";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Enabled = false;
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Location = new System.Drawing.Point(201, 18);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(123, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Obfuscate resources";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(58, 41);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(132, 17);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "Obfuscate parameters";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 343);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImage = global::Darkfuscator.Properties.Resources.Windows_Vista_HQ_Wallpaper_03;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.chkObfuscateTypes);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.chkObfuscateMethods);
            this.tabPage1.Controls.Add(this.chkObfuscateProperties);
            this.tabPage1.Controls.Add(this.chkObfuscateFields);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Obfuscation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(280, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Types to obfuscate:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(79, 116);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(526, 164);
            this.checkedListBox1.TabIndex = 22;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.ForeColor = System.Drawing.Color.Black;
            this.checkBox5.Location = new System.Drawing.Point(358, 41);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(85, 17);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "Control Flow";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.BackgroundImage = global::Darkfuscator.Properties.Resources.Windows_Vista_HQ_Wallpaper_03;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 317);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assembly Info";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(132, 65);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(419, 181);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "Product Name:\r\nCompany Name:\r\nVersion:\r\nCopyright:\r\nDescription:";
            // 
            // button3
            // 
            this.button3.Image = global::Darkfuscator.Properties.Resources.question_19x19;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(574, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = "About";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.GlowColor = System.Drawing.Color.White;
            this.button2.Image = global::Darkfuscator.Properties.Resources.SuccessIconReduced;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(7, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Obfuscate";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Darkfuscator.Properties.Resources.ccc_icon_search_19x19;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(589, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "  Open File";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Darkfuscator.Properties.Resources.Windows_Vista_HQ_Wallpaper_03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 433);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Darkfuscator v1.03";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkObfuscateTypes;
        private System.Windows.Forms.CheckBox chkObfuscateMethods;
        private System.Windows.Forms.CheckBox chkObfuscateProperties;
        private System.Windows.Forms.CheckBox chkObfuscateFields;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Glass.GlassButton button1;
        private Glass.GlassButton button2;
        private Glass.GlassButton button3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
    }
}

