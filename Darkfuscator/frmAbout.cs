using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Darkfuscator
{
    public partial class frmAbout : Form
    {
        public string strUser = "";
        public frmAbout()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel1.Text);
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
        }

        private void glassButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
