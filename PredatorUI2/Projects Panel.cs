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

        DataTable projectsDT = new DataTable();
        public Projects_Panel()
        {
            InitializeComponent();
            statusComboBoxAdd();
            loadDataGrid();
        }

        public void statusComboBoxAdd()
        {
            statusComboBox.Items.Add("Ongoing");
            statusComboBox.Items.Add("Completed");
            statusComboBox.Items.Add("Cancelled");
        }

        public void loadDataGrid()
        {
            projectsDT.Clear();
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT project_name, project_location, project_status FROM project";
            MySqlDataReader reader = cmd.ExecuteReader();
           
            projectsDT.Load(reader);

            projectsDataGrid.DataSource = projectsDT;
            
            
        }

        private void CreateProjectButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT project_id FROM project";
            MySqlDataReader reader = cmd.ExecuteReader();
            List<int> projectIDnum = new List<int>();
         
            while (reader.Read())
            {
                string word = reader[0].ToString();
                string[] values = word.Split('-');
                projectIDnum.Add(int.Parse(values[1]));

            }
            int newNum = 0;
            
            for (int k = 0; k < projectIDnum.Count(); k++)
            {
                if (k == projectIDnum.Count - 1)
                {
                    newNum += projectIDnum[k] + 1;
                }
            }
            MessageBox.Show(newNum.ToString());



            /**cmd.CommandText = "INSERT INTO project(project_name, project_location, project_status) VALUES (@project_name, @project_location, @project_status)";
            cmd.Parameters.AddWithValue("@project_name", projectNameTB.Text);
            cmd.Parameters.AddWithValue("@project_location", projectLocationTB.Text);
            cmd.Parameters.AddWithValue("@project_status", statusComboBox.Text);
            cmd.ExecuteNonQuery();
            conn.Close();*/

            loadDataGrid();
        }
    }
}
