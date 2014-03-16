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
        //String to hold the query that will get the projectID of the currently selected row's entity
        String projectIDquery = "";

        //String to hold the projectID after running projectIDquery
        String currentSelectedProjectID = "";

        //String to hold the project name BEFORE ANY EDITS ARE MADE
        String initialProjectName = "";


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
            statusComboBox.Items.Add("Closed");
            
        }

        //Loads Data Into The Data Grid View
        //Essentially, binding the Data Table to the Data Grid View
        public void loadDataGrid()
        {
            projectsDT.Clear();
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string dataGridQuery = "SELECT project_name AS 'Project Name' , project_location AS 'Project Location', project_status AS 'Project Status', project_lodging AS 'Project Lodging' FROM projects_table";
            cmd.CommandText = dataGridQuery;
            MySqlDataReader reader = cmd.ExecuteReader();
           
            projectsDT.Load(reader);

            projectsDataGrid.DataSource = projectsDT;
            
            
        }

        public void getCurrentProjectID()
        {
            //gets the project ID of the currently selected row's entity 
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT project_ID FROM projects_table WHERE project_name = @project_name";
            cmd.Parameters.AddWithValue(@"project_name", initialProjectName);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                currentSelectedProjectID = reader[0].ToString();
            }
            reader.Close();
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

            if (reader.HasRows == true)
            {

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

                int count = newNum.ToString().Length;

                //begins the query by adding the prefix, 'PRJ-'
                projectIDquery += "PRJ-";

                //loop to decide how many zeros are needed before inputting the newNum
                for (int k = 0; k < 10 - count; k++)
                {
                    projectIDquery += "0";
                }
                projectIDquery += newNum.ToString();

                MessageBox.Show("The new project has been assigned with the project ID: " + projectIDquery);

            }
            else
            {
                projectIDquery = "PRJ-0000000001";
            }
        }

        
        //Creates a new project
        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            if (projectNameTB.Text == ""|| projectLocationTB.Text == ""  || statusComboBox.Text == "")
            {
                MessageBox.Show("Please fill out all the fields.");
            }
            else
            {
                getNextProjectID();

                MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO projects_table(project_ID, project_name, project_location, project_status, project_lodging) VALUES (@project_ID, @project_name, @project_location, @project_status, @project_lodging)";
                cmd.Parameters.AddWithValue("@project_ID", projectIDquery);
                cmd.Parameters.AddWithValue("@project_name", projectNameTB.Text);
                cmd.Parameters.AddWithValue("@project_location", projectLocationTB.Text);
                cmd.Parameters.AddWithValue("@project_status", statusComboBox.Text);
                cmd.Parameters.AddWithValue("@project_lodging", lodgingAllowTB.Text);

                cmd.ExecuteNonQuery();
                conn.Close();

                //refreshes the datagrid;
                loadDataGrid();
            }
        }

    

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            projectNameTB.Clear();
            projectLocationTB.Clear();
            statusComboBox.Text = "";
        }

        private void editProjectBtn_Click(object sender, EventArgs e)
        {
            if (projectNameTB.Text == "" || projectLocationTB.Text == "" || statusComboBox.Text == "")
            {
                MessageBox.Show("Please fill out all the fields.");
            }
            else
            {
                //gets the project ID of the currently selected row's entity 
                getCurrentProjectID();

                //initializes strings to hold the new values
                String newProjName = projectNameTB.Text;
                String newProjLocation = projectLocationTB.Text;
                String newStatus = statusComboBox.Text;
                String newLodging = lodgingAllowTB.Text;

                //Will update databaes with new values
                MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                

                cmd.CommandText = "UPDATE projects_table SET project_name =@project_name, project_location=@project_location, project_status=@project_status, project_lodging=@project_lodging WHERE project_ID=@project_ID";

                cmd.Parameters.AddWithValue("@project_name", newProjName);
                cmd.Parameters.AddWithValue("@project_location", newProjLocation);
                cmd.Parameters.AddWithValue("@project_status", newStatus);
                cmd.Parameters.AddWithValue("@project_ID", currentSelectedProjectID);
                cmd.Parameters.AddWithValue("@project_lodging", newLodging);
                cmd.ExecuteNonQuery();
                conn.Close();

                //refreshes the datagrid;
                loadDataGrid();
                MessageBox.Show("Edit Successful");
            }
        }
        private void deleteProjectBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to delete selected row?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                //gets the project ID of the currently selected row's entity 
                MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT project_ID FROM projects_table WHERE project_name = @project_name";
                cmd.Parameters.AddWithValue(@"project_name", initialProjectName);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    currentSelectedProjectID = reader[0].ToString();
                }
                reader.Close();


               
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM projects_table WHERE project_ID =@project_ID";
                cmd.Parameters.AddWithValue("@project_ID", currentSelectedProjectID);
                cmd.ExecuteNonQuery();
                conn.Close();
                loadDataGrid();
                MessageBox.Show("Delete Successful");

                projectNameTB.Clear();
                projectLocationTB.Clear();
                statusComboBox.Text = "";
            }
        }

        private void projectsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = projectsDataGrid.CurrentCell.ColumnIndex;
            int rowIndex = projectsDataGrid.CurrentCell.RowIndex;

            //So that when you click a cell, the entire row is selected
            projectsDataGrid.Rows[rowIndex].Selected = true;

            //When you click a cell, that entity's information will be placed on the textBoxes.
            List<String> stringValues = new List<String>();

            for (int k = 0; k < projectsDataGrid.ColumnCount; k++)
            {
                stringValues.Add(projectsDataGrid.Rows[rowIndex].Cells[k].Value.ToString());
            }

            projectNameTB.Text = stringValues[0];
            projectLocationTB.Text = stringValues[1];
            statusComboBox.Text = stringValues[2];
            lodgingAllowTB.Text = stringValues[3];

            initialProjectName = projectNameTB.Text;
            manageSalaryBtn.Enabled = true;

            getCurrentProjectID();


            /**
            //gets the project ID of the currently selected row's entity 
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT project_ID FROM projects_table WHERE project_name = @project_name";
            cmd.Parameters.AddWithValue(@"project_name", initialProjectName);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                currentSelectedProjectID = reader[0].ToString();
            }
            reader.Close();

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT project_lodging FROM projects_table WHERE project_ID = @project_ID";
            cmd.Parameters.AddWithValue("@project_ID", currentSelectedProjectID);
            MySqlDataReader reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                lodgingAllowTB.Text = reader2[0].ToString();
            }
            reader2.Close();*/
        }

        private void manageSalaryBtn_Click(object sender, EventArgs e)
        {
           
                Import imp = new Import();
           
               
                imp.ProjectID = currentSelectedProjectID;
                imp.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projects_Panel projectsPanel = new Projects_Panel();
            projectsPanel.Show();
        }

        private void employeesPanelBtn_Click(object sender, EventArgs e)
        {
            ViewEmployees vemp = new ViewEmployees();
            vemp.Show();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings_User_Management settingsUser = new Settings_User_Management();
            settingsUser.Show();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Salary_Rates_Panel srp = new Salary_Rates_Panel();
            srp.Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {

        }

      
    }
}
