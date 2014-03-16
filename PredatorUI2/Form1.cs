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
        //creates a static string that contains login credentials for mySQL that can be accessed in any class
        public static string login = "server=localhost;database=his_payroll;uid=root;password=c7h1e6n9g3;";
       

        public LogIn()
        {
            InitializeComponent();
            
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
           //This part will get the User Name and Password data from the MYSQL database
            MySqlConnection conn = new MySqlConnection(login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT username, password FROM user_accounts_table WHERE username = @username";
            cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
            MySqlDataReader reader = cmd.ExecuteReader();
         
            //This part checks if what the user has inputted MATCHES what is inputted in the HIS MySQL database
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
                    //User has inputted wrong credentials. He has to start over. Text Boxes are cleared. 
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

        //This just does exactly the same thing as the Login Button, but ...uses the "Enter" key 
        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MySqlConnection conn = new MySqlConnection(login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT username, password FROM user_accounts_table WHERE username = @username";
                cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Import newImp = new Import();
            newImp.Show();
        }

        

     
    }
}
