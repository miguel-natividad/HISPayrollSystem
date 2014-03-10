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

        public Settings_User_Management()
        {
            InitializeComponent();
            loadDataGrid();
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

        private void usermgtDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            userNameTB.Text = stringValues[0];
           // passwordTB.Text = stringValues[1];
            firstNameTB.Text = stringValues[1];
            lastNameTB.Text = stringValues[2];

            initialUserName = userNameTB.Text;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            string currentPass = "";

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT password FROM user_accounts_table";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                currentPass = reader[0].ToString();
            }


        }
    }
}
