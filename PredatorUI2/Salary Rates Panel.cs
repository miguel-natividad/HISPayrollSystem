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
    public partial class Salary_Rates_Panel : Form
    {
        //Initializes a Data Table which will hold the data from projects_table from the HIS MySQL database
        DataTable salaryDT = new DataTable();
        //String to hold the query that will get the projectID of the currently selected row's entity
        String employeecat = "";

        //String to hold the projectID after running projectIDquery
        String salary = "";

        public Salary_Rates_Panel()
        {
            InitializeComponent();
            statusComboBoxAdd();
            loadDataGrid();
        }

        private void UserNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void statusComboBoxAdd()
        {
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT employee_cat FROM salary_rate";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0].ToString());
            }
        }

        public void loadDataGrid()
        {
            salaryDT.Clear();
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string dataGridQuery = "SELECT employee_cat AS 'Employee Category' , salary AS 'Salary' FROM salary_rate";
            cmd.CommandText = dataGridQuery;
            MySqlDataReader reader = cmd.ExecuteReader();

            salaryDT.Load(reader);

            salaryDataGrid.DataSource = salaryDT;
        }

        private void salaryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill out all the fields.");
            }
            else
            {
              
                //initializes strings to hold the new values
                String newEmployeeCat = comboBox2.Text;
                String newSalary = textBox1.Text;
              
                //Will update databaes with new values
                MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();


                cmd.CommandText = "UPDATE salary_rate SET salary=@salary where employee_Cat=@employee_cat";

                cmd.Parameters.AddWithValue("@employee_cat", newEmployeeCat);
                cmd.Parameters.AddWithValue("@salary", newSalary);
                cmd.ExecuteNonQuery();
                conn.Close();

                //refreshes the datagrid;
                loadDataGrid();
                MessageBox.Show("Edit Successful");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill out all the fields.");
            }
            else
            {

                //initializes strings to hold the new values
                String newEmployeeCat = textBox2.Text;
                String newSalary = textBox1.Text;

                //Will update databaes with new values
                MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();


                cmd.CommandText = "INSERT INTO salary_rate (employee_cat, salary) VALUES (@employee_cat, @salary)";
                cmd.Parameters.AddWithValue("@employee_cat", newEmployeeCat);
                cmd.Parameters.AddWithValue("@salary", newSalary);
                cmd.ExecuteNonQuery();
                conn.Close();

                //refreshes the datagrid;
                loadDataGrid();
                MessageBox.Show("Add Successful");
            }

        }
    }
}
