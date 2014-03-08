using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


 namespace PredatorUI2
{
    public partial class LogIn : Form
    {
        public static string login = "server=localhost;database=his_payroll_db;uid=root;password=verisiminitude0908;";
       

        public LogIn()
        {
            InitializeComponent();
            
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
           
            MySqlConnection conn = new MySqlConnection(login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT username, password FROM user_table";
            MySqlDataReader reader = cmd.ExecuteReader();
         
            while (reader.Read())
            {
                if (UserNameTextBox.Text == reader[0].ToString() && PasswordTextBox.Text == reader[1].ToString())
                {
                    MessageBox.Show("Login Successful");
                    ControlPanel cp = new ControlPanel();
                    cp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed. Please input correct username and/or password");
                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MySqlConnection conn = new MySqlConnection(login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT username, password FROM user_table";
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (UserNameTextBox.Text == reader[0].ToString() && PasswordTextBox.Text == reader[1].ToString())
                    {
                        MessageBox.Show("Login Successful");
                        ControlPanel cp = new ControlPanel();
                        cp.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed. Please input correct username and/or password");
                        UserNameTextBox.Clear();
                        PasswordTextBox.Clear();
                    }
                }
            }

        }

        

     
    }
}
