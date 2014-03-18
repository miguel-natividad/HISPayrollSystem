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

        public static string login;
       

        public LogIn()
        {
            InitializeComponent();
            
        }

        public String DBset()
        {
            string server = DBsettings.dbserver;
            string username = DBsettings.dbuser;
            string pwd = DBsettings.dbpass;
            string db = DBsettings.dbname;

            login = "server=" + server +";database=" + db + ";uid=" + username + ";password=" + pwd + ";";

            return login;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            //This part will get the User Name and Password data from the MYSQL database
            MySqlConnection conn = new MySqlConnection(DBset());
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT username, password FROM user_accounts_table WHERE username = @username";
            cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            //This part checks if what the user has inputted MATCHES what is inputted in the HIS MySQL database
            if (reader.HasRows == true)
            {
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
            else
            {
                MessageBox.Show("No Such User Found");
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
                //This part will get the User Name and Password data from the MYSQL database
                MySqlConnection conn = new MySqlConnection(DBset());
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT username, password FROM user_accounts_table WHERE username = @username";
                cmd.Parameters.AddWithValue("@username", UserNameTextBox.Text);
                MySqlDataReader reader = cmd.ExecuteReader();

                //This part checks if what the user has inputted MATCHES what is inputted in the HIS MySQL database
                if (reader.HasRows == true)
                {
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
                else
                {
                    MessageBox.Show("No Such User Found");
                    UserNameTextBox.Clear();
                    PasswordTextBox.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {

            FCAccounting a = new FCAccounting();
            a.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /** DBsettings db = new DBsettings();
            db.ShowDialog();*/

            using (DBsettings dbSettings = new DBsettings())
            {
                dbSettings.ShowDialog(this);
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void projectsBtn_Click(object sender, EventArgs e)
        {
            DBsettings db = new DBsettings();
            db.ShowDialog();
        }

        

     
    }
}
