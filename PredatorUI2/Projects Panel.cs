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
    public partial class Projects_Panel : Form
    {
        //Initializes a Data Table which will hold the data from projects_table from the HIS MySQL database
        DataTable projectsDT = new DataTable();
        String projectIDquery = "";
        public Projects_Panel()
        {
            InitializeComponent();
            statusComboBoxAdd();
            loadDataGrid();
        }

        //Adds Items to the Project Status Combo Box
        public void statusComboBoxAdd()
        {
            statusComboBox.Items.Add("Ongoing");
            statusComboBox.Items.Add("Completed");
            statusComboBox.Items.Add("Cancelled");
        }

        //Loads Data Into The Data Grid View
        //Essentially, binding the Data Table to the Data Grid View
        public void loadDataGrid()
        {
            projectsDT.Clear();
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT project_name, project_location, project_status FROM projects_table";
            MySqlDataReader reader = cmd.ExecuteReader();
           
            projectsDT.Load(reader);

            projectsDataGrid.DataSource = projectsDT;
            
            
        }
        //increments the Project_ID to follow the format: PRJ-000000000X
        public void getNextProjectID()
        {
            //Resets the String projectIDquery;
            projectIDquery = "";

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            //Gets all the project_ids currently in the database
            cmd.CommandText = "SELECT project_id FROM projects_table";
            MySqlDataReader reader = cmd.ExecuteReader();

            //Creates a list of integers which will hold the project IDs currently in the database 
            List<int> projectIDnum = new List<int>();

            while (reader.Read())
            {
                //Assigns to string 'word' the project_ID value
                string word = reader[0].ToString();

                //splits a project_id. From PRJ-000000000X into PRJ and 0000000000X
                string[] values = word.Split('-');

                //Adds only the numerical part to the list , 'projectIDnum'
                projectIDnum.Add(int.Parse(values[1]));

            }
            reader.Close();

            int newNum = 0;

            for (int k = 0; k < projectIDnum.Count(); k++)
            {
                //checks if K has reached the LAST number in projectIDnum list
                if (k == projectIDnum.Count - 1)
                {
                    //so the new number is equal to the LAST number incremented by 1.
                    newNum += projectIDnum[k] + 1;
                }
            }

            //splits the new number into its individual characters, so that we can count how many zeroes we need.
            string[] numberInWords = newNum.ToString().Split();

           
            //begins the query by adding the prefix, 'PRJ-'
            projectIDquery += "PRJ-";

            //loop to decide how many zeros are needed before inputting the newNum
            for (int k = 0; k < 10 - numberInWords.Count(); k++)
            {
                projectIDquery += "0";
            }
            projectIDquery += newNum.ToString();

            MessageBox.Show("The new project has been assigned with the project ID: " + projectIDquery);

        }

        
        //Creates a new project
        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            getNextProjectID();

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO projects_table(project_ID, project_name, project_location, project_status) VALUES (@project_ID, @project_name, @project_location, @project_status)";
            cmd.Parameters.AddWithValue("@project_ID", projectIDquery);
            cmd.Parameters.AddWithValue("@project_name", projectNameTB.Text);
            cmd.Parameters.AddWithValue("@project_location", projectLocationTB.Text);
            cmd.Parameters.AddWithValue("@project_status", statusComboBox.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            loadDataGrid();
        }
    }
}
