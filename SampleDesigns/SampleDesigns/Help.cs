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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UsernameLbl.Hide();
            txtUserName.Hide();
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            emailLabel.Show();
            txtLbl.Show();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            emailLabel.Show();
            txtLbl.Show();
            UsernameLbl.Show();
            txtUserName.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A temporary password will be sent via Email.");
        }


    }
}
