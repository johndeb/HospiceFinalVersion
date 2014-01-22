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
    public partial class LogIn : Form
    {

        bool pAccount;
        public LogIn()
        {
            InitializeComponent();
        }

        public LogIn(bool pAccount)
        {
            InitializeComponent();
            this.pAccount = pAccount;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            New_Account l = new New_Account();
            l.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection hospiceDatabase = new DatabaseConnection();
            //this.Hide();
            //Form1 m = new Form1();
            //m.Show();
        }
    }
}
