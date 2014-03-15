using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
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

        private static int Minimum_Length = 5;
        private static int Upper_Case_length = 1;
        private static int Lower_Case_length = 1;
      //  private static int NonAlpha_length = 1;
        private static int Numeric_length = 1;

        public Settings_User_Management()
        {
            InitializeComponent();
            loadDataGrid();
        }

        public static bool IsValid(string Password)
        {
            if (Password.Length < Minimum_Length)
                return false;
            if (UpperCaseCount(Password) < Upper_Case_length)
                return false;
            if (LowerCaseCount(Password) < Lower_Case_length)
                return false;
            if (NumericCount(Password) < 1)
                return false;
            if (Password.Contains(" "))
                return false;
            if (Password.Equals("guest") || Password.Equals("Guest") || Password.Equals("GUEST") || Password.Equals("password") || Password.Equals("Password") || Password.Equals("PASSWORD"))
                return false;

            //if (NonAlphaCount(Password) < NonAlpha_length)
            //    return false;
            return true;
        }

        //if user has expressed intent to change password 
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
            if (reader.HasRows == true)
            {
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

                usermgtIDnum.Sort();
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
                //  string[] numberInWords = newNum.ToString().Split();
                int count = newNum.ToString().Length;

                //begins the query by adding the prefix, 'PRJ-'
                usermgtIDquery += "USER-";

                //loop to decide how many zeros are needed before inputting the newNum
                for (int k = 0; k < 5 - count; k++)
                {
                    usermgtIDquery += "0";
                }
                usermgtIDquery += newNum.ToString();

                MessageBox.Show("The new project has been assigned with the USER ID: " + usermgtIDquery);
            }
            else
            {
                usermgtIDquery = "USER-0000000001";
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            //checks first if first name, last name, username, and password text fields have been filled out 
            if (firstNameTB.Text == "" || lastNameTB.Text == "" || userNameTB.Text == "" || passwordTB.Text== "")
            {
                MessageBox.Show("Please fill out all the fields.");
            }
                // if fields have been filled out 
            else
            {
                //checks if entered password is valid
                if (IsValid(passwordTB.Text) == false)
                {
                    string requirements = "";
                    requirements += "Please satisfy the following conditions: \n";
                    requirements += "At Least 5 Characters \n";
                    requirements += "No spaces \n";
                    requirements += "Contains at least 1 capital letter \n";
                    requirements += "Contains at least 1 number \n";
                    requirements += "Cannot be 'guest' or 'password' \n";
                    MessageBox.Show(requirements);
                }
                    // if password passes requirements, then insert into usser_accounts_table
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

                    firstNameTB.Clear();
                    lastNameTB.Clear();
                    passwordTB.Clear();
                    userNameTB.Clear();
                }
            }
        }

      
        public void passBack(bool b)
        {
            this.PasswordEntered = b;

            passwordTB.Text = currentPass;
           // passwordTB.PasswordChar = (char)0;
        }

        private static int UpperCaseCount(string Password)
        {
            return Regex.Matches(Password, "[A-Z]").Count;
        }

        private static int LowerCaseCount(string Password)
        {
            return Regex.Matches(Password, "[a-z]").Count;
        }
        private static int NumericCount(string Password)
        {
            return Regex.Matches(Password, "[0-9]").Count;
        }
        private static int NonAlphaCount(string Password)
        {
            return Regex.Matches(Password, @"[^0-9a-zA-Z\._]").Count;
        }
        private void changePassBtn_Click(object sender, EventArgs e)
        {
          

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT username, password FROM user_accounts_table WHERE username = @username";
            cmd.Parameters.AddWithValue("@username", initialUserName);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                initialUserName = reader[0].ToString();
                currentPass = reader[1].ToString();
            }


            using (ChangePassForm cpf = new ChangePassForm())
            {
                // passing this in ShowDialog will set the .Owner 
                // property of the child form
                
                cpf.UserName = initialUserName;
                cpf.Password = currentPass;
               
                cpf.ShowDialog(this);
            }



            
        }

        public void getCurrentUserID()
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
                   
                        

                        //initializes strings to hold the new values
                        String newUserName = userNameTB.Text;
                        String newFirstName = firstNameTB.Text;
                        String newLastName = lastNameTB.Text;

                        MySqlConnection conn = new MySqlConnection(LogIn.login);
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();


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

                        initialUserName = newUserName;

                        firstNameTB.Clear();
                        lastNameTB.Clear();
                        passwordTB.Clear();
                        userNameTB.Clear();
                    
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
                    if (IsValid(passwordTB.Text) == false)
                    {
                        string requirements = "";
                        requirements += "Please satisfy the following conditions: \n";
                        requirements += "At Least 5 Characters \n";
                        requirements += "No spaces \n";
                        requirements += "Contains at least 1 capital letter \n";
                        requirements += "Contains at least 1 number \n";
                        requirements += "Cannot be 'guest' or 'password' \n";
                        MessageBox.Show(requirements);

                    }
                    else
                    {

                        getCurrentUserID();

                        //initializes strings to hold the new values
                        String newUserName = userNameTB.Text;
                        String newFirstName = firstNameTB.Text;
                        String newLastName = lastNameTB.Text;
                        String newPass = passwordTB.Text;

                        
                        //Will update databaes with new values
                        MySqlConnection conn = new MySqlConnection(LogIn.login);
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();


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
                        initialUserName = newUserName;

                        firstNameTB.Clear();
                        lastNameTB.Clear();
                        passwordTB.Clear();
                        userNameTB.Clear();
                    }
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
            passwordTB.Text = "";
            lastNameTB.Text = stringValues[1];
            userNameTB.Text = stringValues[2];

            initialUserName = userNameTB.Text;
            getCurrentUserID();
        }

        private void delUserBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to delete selected row?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                getCurrentUserID();

                MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM user_accounts_table WHERE user_ID =@user_ID";
                cmd.Parameters.AddWithValue("@user_ID", currentSelectedUserMgt);
                cmd.ExecuteNonQuery();
                conn.Close();
                loadDataGrid();
                MessageBox.Show("Delete Successful");

                firstNameTB.Clear();
                lastNameTB.Clear();
                passwordTB.Clear();
                userNameTB.Clear();
            }
        }
    }
}
