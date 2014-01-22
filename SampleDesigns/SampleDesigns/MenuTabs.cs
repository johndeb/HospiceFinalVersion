using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SampleDesigns
{
    public partial class MenuTabs : Form
    {
        string buttonSelected;
        public MenuTabs()
        {
            InitializeComponent();
        }

        public MenuTabs(string selectedButton)
        {
            buttonSelected = selectedButton; 
            InitializeComponent();
            switch (buttonSelected){
                case "Users":
                    tabAccounts.SelectTab(0);
                    break;
                case "Members":
                    tabAccounts.SelectTab(1);
                    break;
                case "Emails":
                    tabAccounts.SelectTab(2);
                    break;
                case "Reports":
                    tabAccounts.SelectTab(4);
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MenuTabs_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Account n = new New_Account();
            n.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void MenuTabs_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabAccounts.SelectTab(2);
        }
    }
}
