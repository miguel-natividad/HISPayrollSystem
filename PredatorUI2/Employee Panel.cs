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
    public partial class Employee_Panel : Form
    {
        //Initializes a Data Table which will hold the data from employee_table from the HIS MySQL database
        DataTable employeesDT = new DataTable();

        //String to hold the query that will get the projectID of the currently selected row's entity
        String employeeIDquery = "";

        //String to hold the employee_ID after running projectIDquery
        String currentSelectedEmployeeID = "";

        //String to hold the employee BEFORE ANY EDITS ARE MADE
        String initialEmployeeName = "";

        public Employee_Panel()
        {
            InitializeComponent();
            addtoComboBox();
            loadDataGrid();
        }

        public void addtoComboBox()
        {
            workerTypeCB.Items.Add("Regular");
            workerTypeCB.Items.Add("Office");
            workerTypeCB.Items.Add("Subcontractual");
        }
        public void loadDataGrid()
        {
            employeesDT.Clear();
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string dataGridQuery = "SELECT name_last AS 'Last Name' , name_first AS 'First Name', name_mi AS 'Middle Initial', employee_position AS 'Position', employee_type_ID AS 'Employee Type' FROM employee_table";
            cmd.CommandText = dataGridQuery;
            MySqlDataReader reader = cmd.ExecuteReader();
           
            employeesDT.Load(reader);

            employeeDataGridView.DataSource = employeesDT;
            
        }


       /** public void getNextEmployeeID()
        {
            //Resets the String projectIDquery;
            employeeIDquery = "";

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            //Gets all the project_ids currently in the database
            cmd.CommandText = "SELECT employee_ID FROM employee_table";
            MySqlDataReader reader = cmd.ExecuteReader();

            //Creates a list of integers which will hold the project IDs currently in the database 
            List<int> employeeIDnum = new List<int>();

            if (reader.HasRows == true)
            {
                
                while (reader.Read())
                {
                    //Assigns to string 'word' the project_ID value
                    string word = reader[0].ToString();

                    //splits a project_id. From PRJ-000000000X into PRJ and 0000000000X
                    string[] values = word.Split('-');

                    //Adds only the numerical part to the list , 'projectIDnum'
                    employeeIDnum.Add(int.Parse(values[1]));

                }
                reader.Close();

                int newNum = 0;

                for (int k = 0; k < employeeIDnum.Count(); k++)
                {
                    //checks if K has reached the LAST number in projectIDnum list
                    if (k == employeeIDnum.Count() - 1)
                    {
                        //so the new number is equal to the LAST number incremented by 1.
                        newNum += employeeIDnum[k] + 1;
                    }
                }

                //splits the new number into its individual characters, so that we can count how many zeroes we need.
               // string[] numberInWords = newNum.ToString().Split();
                int count = newNum.ToString().Length;


                //begins the query by adding the prefix, 'PRJ-'
                employeeIDquery += "EMP-";

                //loop to decide how many zeros are needed before inputting the newNum
                for (int k = 0; k < 10 - count; k++)
                {
                    employeeIDquery += "0";
                }
                employeeIDquery += newNum.ToString();

                foreach (int i in employeeIDnum)
                {
                    MessageBox.Show(i.ToString());
                }

                MessageBox.Show("The new project has been assigned with the Employee ID: " + employeeIDquery);

            }
            else
            {
                employeeIDquery = "EMP-0000000001";

                //MessageBox.Show("reached" + employeeIDquery);
            }
           
        } 
   */

        public void getNextEmployeeID()
        {
            //Resets the String projectIDquery;
            employeeIDquery = "";

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            //Gets all the project_ids currently in the database
            cmd.CommandText = "SELECT employee_ID FROM employee_table";
            MySqlDataReader reader = cmd.ExecuteReader();

            //Creates a list of integers which will hold the project IDs currently in the database 
            List<int> employeeIDnum = new List<int>();
           if (reader.HasRows == true)
            {
                   while (reader.Read())
                {
                //Assigns to string 'word' the project_ID value
                string word = reader[0].ToString();

                //splits a project_id. From PRJ-000000000X into PRJ and 0000000000X
                string[] values = word.Split('-');

                //Adds only the numerical part to the list , 'projectIDnum'
                employeeIDnum.Add(int.Parse(values[1]));
               

                 }
                   employeeIDnum.Sort();
            reader.Close();
            employeeIDnum.Sort();

            int newNum = 0;

                   for (int k = 0; k < employeeIDnum.Count(); k++)
                 {
                //checks if K has reached the LAST number in projectIDnum list
                      if (k == employeeIDnum.Count - 1)
                          {
                     //so the new number is equal to the LAST number incremented by 1.
                             newNum += employeeIDnum[k] + 1;
                         }
                    }

            //splits the new number into its individual characters, so that we can count how many zeroes we need.
            //  string[] numberInWords = newNum.ToString().Split();
            int count = newNum.ToString().Length;

            //begins the query by adding the prefix, 'PRJ-'
            employeeIDquery += "EMP-";

            //loop to decide how many zeros are needed before inputting the newNum
            for (int k = 0; k < 10 - count; k++)
            {
                employeeIDquery += "0";
            }
            employeeIDquery += newNum.ToString();

            MessageBox.Show("The new project has been assigned with the EMP ID: " + employeeIDquery);
       } else
            {
                employeeIDquery = "EMP-0000000001";
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNameTB.Text == "" || lastNameTB.Text == "" || middleInitialTB.Text == "" || accountNumTB.Text == "" || companyNameTB.Text == "" || currentBalTB.Text == "" || positionTB.Text == "")
            {
                MessageBox.Show("Please fill out all fields");
            }
            else
            {
                getNextEmployeeID();
                
                MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO employee_table(employee_ID, name_last, name_first, name_mi, employee_position, employee_type_ID) VALUES (@employee_ID, @name_last, @name_first, @name_mi, @employee_position, @employee_type_ID)";
              //  MessageBox.Show("Before inserting into database: " + employeeIDquery);
                cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                cmd.Parameters.AddWithValue("@name_last", lastNameTB.Text);
                cmd.Parameters.AddWithValue("@name_first", firstNameTB.Text);
                cmd.Parameters.AddWithValue("@name_mi", middleInitialTB.Text);
                cmd.Parameters.AddWithValue("@employee_position", positionTB.Text);

                if (workerTypeCB.Text == "Regular")
                {
                    cmd.Parameters.AddWithValue("@employee_type_ID", "R");

                }
                else if (workerTypeCB.Text == "Office")
                {
                    cmd.Parameters.AddWithValue("@employee_type_ID", "O");
                }
                else if (workerTypeCB.Text == "Subcontractual")
                {
                    cmd.Parameters.AddWithValue("@employee_type_ID", "S");
                }

                cmd.ExecuteNonQuery();

                cmd = conn.CreateCommand();
           
                if (workerTypeCB.Text == "Regular")
                {
                    cmd.CommandText = "INSERT INTO worker_regular(employee_ID, acct_number, cash_advance_balance, employee_type_ID) VALUES (@employee_ID, @acct_number, @cash_advance_balance, @employee_type_ID)";
                    cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                    cmd.Parameters.AddWithValue("@acct_number", accountNumTB.Text);
                    cmd.Parameters.AddWithValue("@cash_advance_balance", currentBalTB.Text);
                    cmd.Parameters.AddWithValue("employee_type_ID", "R");
                }
                else if (workerTypeCB.Text == "Office")
                {
                    cmd.CommandText = "INSERT INTO worker_office(employee_ID, acct_number, cash_advance_balance, employee_type_ID) VALUES (@employee_ID, @acct_number, @cash_advance_balance, @employee_type_ID)";
                    cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                    cmd.Parameters.AddWithValue("@acct_number", accountNumTB.Text);
                    cmd.Parameters.AddWithValue("@cash_advance_balance", currentBalTB.Text);
                    cmd.Parameters.AddWithValue("employee_type_ID", "O");
                }
                else if (workerTypeCB.Text == "Subcontractual")
                {
                    cmd.CommandText = "INSERT INTO worker_subcon(employee_ID, company_name, employee_type_ID) VALUES (@employee_ID, @company_name, @employee_type_ID)";
                    cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                    cmd.Parameters.AddWithValue("@company_name", companyNameTB.Text);
                    cmd.Parameters.AddWithValue("employee_type_ID", "S");
                }

                cmd.ExecuteNonQuery();

                conn.Close();




                //refreshes the datagrid;
                loadDataGrid();
            }
        }
    }
}
