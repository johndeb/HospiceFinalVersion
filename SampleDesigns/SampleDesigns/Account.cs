using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleDesigns
{
    class Account
    {
        private string id;
        private string name;
        private string surname;
        private string password;
        private string username;
        private string eamil;
        private string contactNo;
        private int userRole;

        public Account(string id, string name, string surname, string password, string username, string email, string contactNo, string userRole)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.username = username;
            this.eamil = email;
            this.contactNo = contactNo;
            if (userRole.ToString() == "Admin")
            {
                this.userRole = 1;
            }
            else
            {
                this.userRole = 2;
            }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Eamil
        {
            get { return eamil; }
            set { eamil = value; }
        }
        public string ContactNo
        {
            get { return contactNo; }
            set { contactNo = value; }
        }
        public int UserRole
        {
            get { return userRole; }
            set { userRole = value; }
        }


    }
}
