using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PredatorUI2
{
    public partial class Settings_User_Management : Form
    {
        //Initializes a Data Table which will hold the data from projects_table from the HIS MySQL database
        DataTable usermgtDT = new DataTable();
        //String to hold the query that will get the projectID of the currently selected row's entity
        String usermgtIDquery = "";

        //String to hold the projectID after running projectIDquery
        String currentSelectedUserMgt = "";

        //String to hold the project name BEFORE ANY EDITS ARE MADE
        String initialUserName = "";

        bool passwordEntered = false;

        string currentPass = "";
        public Settings_User_Management()
        {
            InitializeComponent();
            loadDataGrid();
        }

        public bool PasswordEntered
        {
            get
            {
                return passwordEntered;
            }
            set
            {
                passwordEntered = true;
            }
        }
        public void loadDataGrid()
        {
            usermgtDT.Clear();

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT first_name, last_name, username FROM user_accounts_table";
            MySqlDataReader reader = cmd.ExecuteReader();

            usermgtDT.Load(reader);

            usermgtDataGrid.DataSource = usermgtDT;
        }

        public void getNextUserMgtID()
        {
            //Resets the String projectIDquery;
            usermgtIDquery = "";

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            //Gets all the project_ids currently in the database
            cmd.CommandText = "SELECT user_ID FROM user_accounts_table";
            MySqlDataReader reader = cmd.ExecuteReader();

            //Creates a list of integers which will hold the project IDs currently in the database 
            List<int> usermgtIDnum = new List<int>();

            while (reader.Read())
            {
                //Assigns to string 'word' the project_ID value
                string word = reader[0].ToString();

                //splits a project_id. From PRJ-000000000X into PRJ and 0000000000X
                string[] values = word.Split('-');

                //Adds only the numerical part to the list , 'projectIDnum'
                usermgtIDnum.Add(int.Parse(values[1]));

            }
            reader.Close();

            int newNum = 0;

            for (int k = 0; k < usermgtIDnum.Count(); k++)
            {
                //checks if K has reached the LAST number in projectIDnum list
                if (k == usermgtIDnum.Count - 1)
                {
                    //so the new number is equal to the LAST number incremented by 1.
                    newNum += usermgtIDnum[k] + 1;
                }
            }

            //splits the new number into its individual characters, so that we can count how many zeroes we need.
            string[] numberInWords = newNum.ToString().Split();


            //begins the query by adding the prefix, 'PRJ-'
            usermgtIDquery += "PRJ-";

            //loop to decide how many zeros are needed before inputting the newNum
            for (int k = 0; k < 10 - numberInWords.Count(); k++)
            {
                usermgtIDquery += "0";
            }
            usermgtIDquery += newNum.ToString();

            MessageBox.Show("The new project has been assigned with the user ID: " + usermgtIDquery);
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTB.Text == "" || lastNameTB.Text == "" || userNameTB.Text == "" || passwordTB.Text== "")
            {
                MessageBox.Show("Please fill out all the fields.");
            }
            else
            {
                getNextUserMgtID();

                MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO user_accounts_table(user_ID, username, password, first_name, last_name) VALUES (@user_ID, @username, @password, @first_name, @last_name)";
                cmd.Parameters.AddWithValue("@user_ID", usermgtIDquery);
                cmd.Parameters.AddWithValue("@username", userNameTB.Text);
                cmd.Parameters.AddWithValue("@password", passwordTB.Text);
                cmd.Parameters.AddWithValue("@first_name", firstNameTB.Text);
                cmd.Parameters.AddWithValue("@last_name", lastNameTB.Text);
                cmd.ExecuteNonQuery();
                conn.Close();

                //refreshes the datagrid;
                loadDataGrid();
            }
        }

      
        public void passBack(bool b)
        {
            this.PasswordEntered = b;
            passwordTB.Text = currentPass;
            passwordTB.PasswordChar = (char)0;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
          

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT password FROM user_accounts_table";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentPass = reader[0].ToString();
            }

          
            using (ChangePassForm cpf = new ChangePassForm())
            {
                // passing this in ShowDialog will set the .Owner 
                // property of the child form
               
                cpf.Password = currentPass;
                cpf.ShowDialog(this);
            }



            
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            if (passwordEntered == false)
            {
                if (firstNameTB.Text == "" || lastNameTB.Text == "" || userNameTB.Text == "")
                {
                    MessageBox.Show("Please fill out all the fields.");
                }
                else
                {
                    //gets the user ID of the currently selected row's entity 
                    MySqlConnection conn = new MySqlConnection(LogIn.login);
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT user_ID FROM user_accounts_table WHERE username = @username";
                    cmd.Parameters.AddWithValue(@"username", initialUserName);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        currentSelectedUserMgt = reader[0].ToString();
                    }
                    reader.Close();

                    //initializes strings to hold the new values
                    String newUserName = userNameTB.Text;
                    String newFirstName = firstNameTB.Text;
                    String newLastName = lastNameTB.Text;

                    //Will update databaes with new values
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "UPDATE user_accounts_table SET username=@username, first_name=@first_name, last_name=@last_name WHERE user_ID=@user_ID";
                    cmd.Parameters.AddWithValue("@user_ID", currentSelectedUserMgt); 
                    cmd.Parameters.AddWithValue("@username", newUserName);
                    cmd.Parameters.AddWithValue("@first_name", newFirstName);
                    cmd.Parameters.AddWithValue("@last_name", newLastName);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                   
                    //refreshes the datagrid;
                    loadDataGrid();
                    MessageBox.Show("Edit Successful");
                }
            }
            else
            {
                if (firstNameTB.Text == "" || lastNameTB.Text == "" || userNameTB.Text == "" || passwordTB.Text == "")
                {
                    MessageBox.Show("Please fill out all the fields.");
                }
                else
                {
                    //gets the user ID of the currently selected row's entity 
                    MySqlConnection conn = new MySqlConnection(LogIn.login);
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "SELECT user_ID FROM user_accounts_table WHERE username = @user_name";
                    cmd.Parameters.AddWithValue(@"user_name", initialUserName);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        currentSelectedUserMgt = reader[0].ToString();
                    }
                    reader.Close();

                    //initializes strings to hold the new values
                    String newUserName = userNameTB.Text;
                    String newFirstName = firstNameTB.Text;
                    String newLastName = lastNameTB.Text;
                    String newPass = passwordTB.Text;

                    //Will update databaes with new values
                    cmd = conn.CreateCommand();

                    cmd.CommandText = "UPDATE user_accounts_table SET username=@user_name, first_name=@first_name, last_name=@last_name, password=@password WHERE user_ID=@user_ID";
                    cmd.Parameters.AddWithValue("@user_ID", currentSelectedUserMgt); 
                    cmd.Parameters.AddWithValue("@user_name", newUserName);
                    cmd.Parameters.AddWithValue("@first_name", newFirstName);
                    cmd.Parameters.AddWithValue("@last_name", newLastName);
                    cmd.Parameters.AddWithValue("@password", newPass);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    //refreshes the datagrid;
                    loadDataGrid();
                    MessageBox.Show("Edit Successful");
                }
            }
        }

        private void usermgtDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = usermgtDataGrid.CurrentCell.ColumnIndex;
            int rowIndex = usermgtDataGrid.CurrentCell.RowIndex;

            //So that when you click a cell, the entire row is selected
            usermgtDataGrid.Rows[rowIndex].Selected = true;

            //When you click a cell, that entity's information will be placed on the textBoxes.
            List<String> stringValues = new List<String>();

            for (int k = 0; k < usermgtDataGrid.ColumnCount; k++)
            {
                stringValues.Add(usermgtDataGrid.Rows[rowIndex].Cells[k].Value.ToString());
            }

            firstNameTB.Text = stringValues[0];
            // passwordTB.Text = stringValues[1];
            lastNameTB.Text = stringValues[1];
            userNameTB.Text = stringValues[2];

            initialUserName = userNameTB.Text;
        }
    }
}
