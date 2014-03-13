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
    public partial class ViewEmployees : Form
    {
        //Initializes a Data Table which will hold the data from projects_table from the HIS MySQL database
        DataTable viewEmployeesDT = new DataTable();
        

        public ViewEmployees()
        {
            InitializeComponent();
            loadDataGrid();
        }

        public void loadDataGrid()
        {
            viewEmployeesDT.Clear();
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string dataGridQuery = "SELECT name_last AS 'Last Name' , name_first AS 'First Name', name_mi AS 'Middle Initial', employee_position AS 'Position', employee_type_ID AS 'Employee Type' FROM employee_table";
            cmd.CommandText = dataGridQuery;
            MySqlDataReader reader = cmd.ExecuteReader();

            viewEmployeesDT.Load(reader);

            viewEmployeesDG.DataSource = viewEmployeesDT;
            
        }
    }
}
