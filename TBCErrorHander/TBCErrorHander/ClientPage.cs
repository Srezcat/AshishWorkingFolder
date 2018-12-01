﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBCErrorHander
{
    public partial class ClientPage : Form
    {
        public UserSessionModel session { get; set; }
        public ClientPage()
        {
            InitializeComponent();
        }

        public ClientPage(UserSessionModel usm)
        {
            InitializeComponent();
            session = usm;
        }

        //Goes back to register page
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        //Goes to AddIssue Page
        private void addIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientAddIssue aci = new ClientAddIssue(session);
            aci.MdiParent = this;
            aci.Show();
        }

        //Goes to View Issue Page
        private void viewIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientViewIssue cvi = new ClientViewIssue(session);
            cvi.MdiParent = this;
            cvi.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
