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
    public partial class New_Account : Form
    {
        public New_Account()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Account user = new Account(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox9.Text, textBox7.Text, textBox8.Text, comboBox1.Text);
            DatabaseConnection insertUser = new DatabaseConnection();
            bool open = insertUser.openDatabaseConnection();
            if (open)
            {
                insertUser.Insert(user.Id, user.Name, user.Surname, user.Password, user.Username, user.Eamil, user.ContactNo, user.UserRole);
                insertUser.closeDatabaseConnection();
                MessageBox.Show("Account Created");
                this.Close();
            }
            else
            {
                MessageBox.Show("Contact Administrator");
            }

        }

       
    }
}
