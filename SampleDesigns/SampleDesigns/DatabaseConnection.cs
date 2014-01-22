using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace SampleDesigns
{
    class DatabaseConnection
    {
        private MySqlConnection connection;

        private Dictionary<string, string> connectionSettings = new Dictionary<string, string>();

        private string connectionSettingFilePath = @"C:\Users\johndebono10\Desktop\HospiceProject\SampleDesigns\connection.properties";
        private string connectionSettingFileName = "connection.properties";

        private string server;
        private string database;
        private string uID;
        private string password;

        public DatabaseConnection()
        {
            databaseAuthentication();
        }

        private void databaseAuthentication()
        {
            try
            {
                loadConnectionProperties();

                server = connectionSettings["SERVER"];
                database = connectionSettings["DATABASE"];
                uID = connectionSettings["uID"];
                password = connectionSettings["PASSWORD"];

                string connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uID + ";" + "PASSWORD=" + password + ";";
                connection = new MySqlConnection(connectionString);
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show(connectionSettingFileName + " file key names are missing/incorrect!");
            }
        }

        private void loadConnectionProperties()
        {
            try
            {
                foreach (var row in File.ReadAllLines(connectionSettingFilePath))
                {
                    string[] settings = row.Split('=');
                    connectionSettings.Add(settings[0], settings[1]);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(connectionSettingFileName + " file is missing!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool openDatabaseConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to the Server/Database. Contact Administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid Username/Password, Please try again");
                        break;
                    default:
                        MessageBox.Show(e.Message);
                        break;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public bool closeDatabaseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public void Insert(string id, string name, string surname, string password, string username, string email, string contactNo, int userRole)
        {
            if(connection.State == System.Data.ConnectionState.Open)
            {
                string InsertQuery = "INSERT INTO login (Username,Password,IDCard,Name,Surname,Email,ContactNo,RoleID) VALUES ('"+username+"','"+password+"','"+id+"','"+name+"','"+surname+"','"+email+"','"+contactNo+"',"+userRole+")";
                MySqlCommand command = new MySqlCommand(InsertQuery, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
