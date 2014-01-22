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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void aDMINToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            New_Account n = new New_Account();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuTabs menu = new MenuTabs("Users");
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuTabs menu = new MenuTabs("Members");
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuTabs menu = new MenuTabs("Emails");
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuTabs menu = new MenuTabs("Reports");
            menu.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true ;
            }
        }
    }
}
