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

        //String to hold the project name selected
        
        string projectID = "";

        public Employee_Panel()
        {
            InitializeComponent();
           
        }

       

        public string ProjectID
        {
            get
            {
                return projectID;
            }
            set
            {
                projectID = value;
            }
        }
        public void addtoComboBox()
        {
            workerTypeCB.Items.Add("Regular");
            workerTypeCB.Items.Add("Office");
            workerTypeCB.Items.Add("Subcontractual");

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT employee_cat FROM salary_rate";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                categoryCB.Items.Add(reader[0].ToString());
            }
            
        }
        public void loadDataGrid()
        {
            employeesDT.Clear();
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
          
            cmd.CommandText = "SELECT name_last AS 'Last Name' , name_first AS 'First Name', name_mi AS 'Middle Initial', employee_position AS 'Position', employee_type_ID AS 'Employee Type', employee_cat AS 'Employee Category' FROM employee_table WHERE project_ID = @project_ID";
            cmd.Parameters.AddWithValue("@project_ID", projectID);
            MySqlDataReader reader = cmd.ExecuteReader();
           
            employeesDT.Load(reader);

            employeeDataGridView.DataSource = employeesDT;
            
        }


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
            employeeIDquery += "E-";

            //loop to decide how many zeros are needed before inputting the newNum
            for (int k = 0; k < 10 - count; k++)
            {
                employeeIDquery += "0";
            }
            employeeIDquery += newNum.ToString();

            MessageBox.Show("The new project has been assigned with the Employee ID: " + employeeIDquery);
       } else
            {
                employeeIDquery = "E-0000000001";
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            bool errorFound = false;

            if (firstNameTB.Text == "" || lastNameTB.Text == "" || middleInitialTB.Text == "" ||positionTB.Text == "" )
            {
                MessageBox.Show("Please fill out all fields");
                errorFound = true;
            }
                // if first name , last name , middle initial and position text boxes are filled
          if (workerTypeCB.Text == "Regular" || workerTypeCB.Text == "Office")
                {
                    if (workerTypeCB.Text == "Regular")
                    {
                        if (categoryCB.Text == "")
                        {
                            MessageBox.Show("Please fill out worker category field");
                            errorFound = true;
                        }
                    }
                    
                     if (accountNumTB.Text == "" || currentBalTB.Text == "")
                    {
                        MessageBox.Show("Please fill out Account Number and Worker Type fields");
                         errorFound = true;
                       
                    }
               }

            if (errorFound == false)
            {
                // if you selected regular OR office worker type....
                if (workerTypeCB.Text == "Regular" || workerTypeCB.Text == "Office")
                {
                    getNextEmployeeID();

                    MySqlConnection conn = new MySqlConnection(LogIn.login);
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "INSERT INTO employee_table(employee_ID, name_last, name_first, name_mi, employee_position, employee_type_ID, project_ID, employee_cat) VALUES (@employee_ID, @name_last, @name_first, @name_mi, @employee_position, @employee_type_ID, @project_ID, @employee_cat)";

                    //  MessageBox.Show("Before inserting into database: " + employeeIDquery);
                    cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                    cmd.Parameters.AddWithValue("@name_last", lastNameTB.Text);
                    cmd.Parameters.AddWithValue("@name_first", firstNameTB.Text);
                    cmd.Parameters.AddWithValue("@name_mi", middleInitialTB.Text);
                    cmd.Parameters.AddWithValue("@employee_position", positionTB.Text);
                    if (workerTypeCB.Text == "Regular")
                    {
                        cmd.Parameters.AddWithValue("@employee_type_ID", "R");
                        cmd.Parameters.AddWithValue("@employee_cat", categoryCB.Text);

                    }
                    else if (workerTypeCB.Text == "Office")
                    {
                        cmd.Parameters.AddWithValue("@employee_type_ID", "O");
                        cmd.Parameters.AddWithValue("@employee_cat", "Office");
                    }
                    cmd.Parameters.AddWithValue("@project_ID", this.projectID);
                    cmd.ExecuteNonQuery();

                    cmd = conn.CreateCommand();

                    if (workerTypeCB.Text == "Regular")
                    {
                        cmd.CommandText = "INSERT INTO worker_regular(employee_ID, acct_number, cash_advance_balance) VALUES (@employee_ID, @acct_number, @cash_advance_balance)";
                        cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                        cmd.Parameters.AddWithValue("@acct_number", accountNumTB.Text);
                        cmd.Parameters.AddWithValue("@cash_advance_balance", currentBalTB.Text);
                        // cmd.Parameters.AddWithValue("employee_type_ID", "R");
                    }
                    else if (workerTypeCB.Text == "Office")
                    {
                        cmd.CommandText = "INSERT INTO worker_office(employee_ID, acct_number, cash_advance_balance) VALUES (@employee_ID, @acct_number, @cash_advance_balance)";
                        cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                        cmd.Parameters.AddWithValue("@acct_number", accountNumTB.Text);
                        cmd.Parameters.AddWithValue("@cash_advance_balance", currentBalTB.Text);
                        //cmd.Parameters.AddWithValue("employee_type_ID", "O");
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    accountNumTB.Text = "";
                    companyNameTB.Text = "";
                    currentBalTB.Text = "";
                    firstNameTB.Text = "";
                    lastNameTB.Text = "";
                    middleInitialTB.Text = "";
                    positionTB.Text = "";

                }
                
                 else if (workerTypeCB.Text == "Subcontractual")
                {
                    if (companyNameTB.Text == "")
                    {
                        MessageBox.Show("Please fill out Company Name field");
                    }
                    else
                    {
                        getNextEmployeeID();

                        MySqlConnection conn = new MySqlConnection(LogIn.login);
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();

                        cmd.CommandText = "INSERT INTO employee_table(employee_ID, name_last, name_first, name_mi, employee_position, employee_type_ID, project_ID, employee_cat) VALUES (@employee_ID, @name_last, @name_first, @name_mi, @employee_position, @employee_type_ID, @project_ID, @employee_cat)";
                        //  MessageBox.Show("Before inserting into database: " + employeeIDquery);
                        cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                        cmd.Parameters.AddWithValue("@name_last", lastNameTB.Text);
                        cmd.Parameters.AddWithValue("@name_first", firstNameTB.Text);
                        cmd.Parameters.AddWithValue("@name_mi", middleInitialTB.Text);
                        cmd.Parameters.AddWithValue("@employee_position", positionTB.Text);
                       
                        cmd.Parameters.AddWithValue("@employee_type_ID", "S");
                        cmd.Parameters.AddWithValue("@project_ID", this.projectID);
                        cmd.Parameters.AddWithValue("@employee_cat", "Subcon");
                        cmd.ExecuteNonQuery();

                        cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO worker_subcon(employee_ID, company_name) VALUES (@employee_ID, @company_name)";
                        cmd.Parameters.AddWithValue("@employee_ID", employeeIDquery);
                        cmd.Parameters.AddWithValue("@company_name", companyNameTB.Text);
                       // cmd.Parameters.AddWithValue("employee_type_ID", "S");

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        accountNumTB.Text = "";
                        companyNameTB.Text = "";
                        currentBalTB.Text = "";
                        firstNameTB.Text = "";
                        lastNameTB.Text = "";
                        middleInitialTB.Text = "";
                        positionTB.Text = "";

                    }
                } 
               
              
  
             
                //refreshes the datagrid;
                loadDataGrid();
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
          
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();


            cmd.CommandText = "UPDATE employee_table SET name_last = @name_last, name_first = @name_first, name_mi = @name_mi, employee_position = @employee_position, employee_type_ID = @employee_type_ID,  employee_cat = @employee_cat WHERE employee_ID = @employee_ID";
          
                cmd.Parameters.AddWithValue("@name_last", lastNameTB.Text);
                cmd.Parameters.AddWithValue("@name_first", firstNameTB.Text);
                cmd.Parameters.AddWithValue("@name_mi", middleInitialTB.Text);
                cmd.Parameters.AddWithValue("employee_position", positionTB.Text);

                if (workerTypeCB.Text == "Regular")
                {
                    cmd.Parameters.AddWithValue("@employee_type_ID", "R");
                    cmd.Parameters.AddWithValue("@employee_cat", categoryCB.Text);
                }
                else if (workerTypeCB.Text == "Office")
                {
                    cmd.Parameters.AddWithValue("@employee_type_ID", "O");
                    cmd.Parameters.AddWithValue("@employee_cat", "Office");
                }
                else if (workerTypeCB.Text == "Subcontractual")
                {
                    cmd.Parameters.AddWithValue("@employee_type_ID", "S");
                    cmd.Parameters.AddWithValue("@employee_cat", "Subcon");
                }
             // cmd.Parameters.AddWithValue("project_ID", projectID);
                cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee updated in employee_table");
            
            cmd = conn.CreateCommand();
              /**
                if (workerTypeCB.Text == "Regular")
                {
                    cmd.CommandText = "UPDATE worker_regular SET acct_number = @acct_number, cash_advance_balance = @cash_advance_balance WHERE employee_ID = @employee_ID";
                    cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);
                    cmd.Parameters.AddWithValue("@acct_number", accountNumTB.Text);
                    cmd.Parameters.AddWithValue("@cash_advance_balance", currentBalTB.Text);
                    // cmd.Parameters.AddWithValue("employee_type_ID", "R");
                }
                else if (workerTypeCB.Text == "Office")
                {
                    cmd.CommandText = "UPDATE worker_office SET acct_number = @acct_number, cash_advance_balance = @cash_advance_balance WHERE employee_ID = @employee_ID";
                    cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);
                    cmd.Parameters.AddWithValue("@acct_number", accountNumTB.Text);
                    cmd.Parameters.AddWithValue("@cash_advance_balance", currentBalTB.Text);
                    //cmd.Parameters.AddWithValue("employee_type_ID", "O");
                }
                else if (workerTypeCB.Text == "Subcontractual")
                {
                    cmd.CommandText = "UPDATE worker_subcon SET company_name = @company_name WHERE employee_ID = @employee_ID";
                    cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);
                }

                cmd.ExecuteNonQuery();
                conn.Close();*/

                MessageBox.Show("Edit Successful");
                loadDataGrid();
}
        


        private void workerTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workerTypeCB.Text == "Regular" || workerTypeCB.Text == "Office")
            {
                companyNameTB.Visible = false;
                accountNumTB.Visible = true;
                currentBalTB.Visible = true;
                if (workerTypeCB.Text == "Regular")
                {
                    categoryCB.Enabled = true;

                }
                else
                {
                    categoryCB.Enabled = false;
                }

            }
            else
            {
                companyNameTB.Visible = true;
                accountNumTB.Visible = false;
                currentBalTB.Visible = false;

                categoryCB.Enabled = false;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
             DialogResult result = MessageBox.Show(this, "Are you sure you want to delete selected row?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                 MySqlConnection conn = new MySqlConnection(LogIn.login);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                if (workerTypeCB.Text == "Office")
                {
                    cmd.CommandText = "DELETE FROM worker_office WHERE employee_ID = @employee_ID";
                    

                }
                else if (workerTypeCB.Text == "Regular")
                {
                    cmd.CommandText = "DELETE FROM worker_regular WHERE employee_ID = @employee_ID";

                }
                else if (workerTypeCB.Text == "Subcontractual")
                {
                    cmd.CommandText = "DELETE FROM worker_subcon WHERE employee_ID = @employee_ID";
                }
                cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);
                cmd.ExecuteNonQuery();



                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM employee_table WHERE employee_ID = @employee_ID";
                cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);
                cmd.ExecuteNonQuery();
                conn.Close();
                loadDataGrid();
            }
        }

        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = employeeDataGridView.CurrentCell.ColumnIndex;
            int rowIndex = employeeDataGridView.CurrentCell.RowIndex;

            //So that when you click a cell, the entire row is selected
            employeeDataGridView.Rows[rowIndex].Selected = true;

            //When you click a cell, that entity's information will be placed on the textBoxes.
            List<String> stringValues = new List<String>();

            for (int k = 0; k < employeeDataGridView.ColumnCount; k++)
            {
                stringValues.Add(employeeDataGridView.Rows[rowIndex].Cells[k].Value.ToString());
            }

            lastNameTB.Text = stringValues[0];
            firstNameTB.Text = stringValues[1];
            middleInitialTB.Text = stringValues[2];
            positionTB.Text = stringValues[3];

            if (stringValues[4].ToString().Equals("R"))
            {
                workerTypeCB.Text = "Regular";
            }
            else if (stringValues[4].ToString().Equals("O"))
            {
                workerTypeCB.Text = "Office";
            }
            else if (stringValues[4].ToString().Equals("S"))
            {
                workerTypeCB.Text = "Subcontractual";
            }

            categoryCB.Text = stringValues[5].ToString();

            //gets the employee ID of the currently selected row's entity 
            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT employee_ID FROM employee_table WHERE name_last = @name_last AND name_first = @name_first AND name_mi = @name_mi AND employee_position = @employee_position AND employee_cat = @employee_cat";
            cmd.Parameters.AddWithValue(@"name_last", lastNameTB.Text);
            cmd.Parameters.AddWithValue(@"name_first", firstNameTB.Text);
            cmd.Parameters.AddWithValue(@"name_mi", middleInitialTB.Text);
         //   cmd.Parameters.AddWithValue("@project_ID", projectID);
            cmd.Parameters.AddWithValue(@"employee_position", positionTB.Text);
            cmd.Parameters.AddWithValue(@"employee_cat", categoryCB.Text);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                currentSelectedEmployeeID = reader[0].ToString();
            }
            
            reader.Close();
            

            if (workerTypeCB.Text == "Regular" || workerTypeCB.Text == "Office")
            {
                cmd = conn.CreateCommand();

                if (workerTypeCB.Text == "Regular")
                {
                    cmd.CommandText = "SELECT acct_number, cash_advance_balance FROM worker_regular WHERE employee_ID = @employee_ID";
                    cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);
                    MySqlDataReader reader2 = cmd.ExecuteReader();

                    while (reader2.Read())
                    {
                        accountNumTB.Visible = true;
                        currentBalTB.Visible = true;
                        companyNameTB.Visible = false;
                        accountNumTB.Text = reader2[0].ToString();
                        currentBalTB.Text = reader2[1].ToString();

                    }

                    reader2.Close();
                }
                else if (workerTypeCB.Text == "Office")
                {
                    cmd.CommandText = "SELECT acct_number, cash_advance_balance FROM worker_office WHERE employee_ID = @employee_ID";
                    cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);
                    
                    MySqlDataReader reader3 = cmd.ExecuteReader();

                    while (reader3.Read())
                    {
                        accountNumTB.Visible = true;
                        currentBalTB.Visible = true;
                        companyNameTB.Visible = false;
                        accountNumTB.Text = reader3[0].ToString();
                        currentBalTB.Text = reader3[1].ToString();

                    }
                    reader3.Close();
                }
            }
            else if (workerTypeCB.Text == "Subcontractual")
            {
              
                cmd.CommandText = "SELECT company_name FROM worker_subcon WHERE employee_ID = @employee_ID";
                cmd.Parameters.AddWithValue("@employee_ID", currentSelectedEmployeeID);

                MySqlDataReader reader4 = cmd.ExecuteReader();

                while (reader4.Read())
                {
                    companyNameTB.Visible = true;
                    currentBalTB.Visible = false;
                    accountNumTB.Visible = false;

                    companyNameTB.Text = reader4[0].ToString();
                }
            }
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            accountNumTB.Text = "";
            companyNameTB.Text = "";
            currentBalTB.Text = "";
            firstNameTB.Text = "";
            lastNameTB.Text = "";
            middleInitialTB.Text = "";
            positionTB.Text = "";
        }

        private void Employee_Panel_Load(object sender, EventArgs e)
        {
            addtoComboBox();
            loadDataGrid();
        }
    }
}
