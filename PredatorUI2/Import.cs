using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Documents;
using System.Windows.Controls;
using ADOX;

namespace PredatorUI2
{
    public partial class Import : Form
    {

        string projectID = "";
        string periodIDquery = "";
        string timesheetEntryIDquery = "";

        public DataTable importedDT = new DataTable();
        public Import()
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
        public static string SelectedTable = string.Empty;

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select file";
            fdlg.InitialDirectory = @"c:\";
            fdlg.FileName = txtFileName.Text;
            fdlg.Filter = "Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = fdlg.FileName;
                ImportFile();
                Application.DoEvents();
            }
        }
        public void getNextTimeSheetEntryID()
        {
            //Resets the String projectIDquery;
            timesheetEntryIDquery = "";

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            //Gets all the project_ids currently in the database
            cmd.CommandText = "SELECT TSE_ID FROM entry_timesheet";
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
                timesheetEntryIDquery += "TSE-";

                //loop to decide how many zeros are needed before inputting the newNum
                for (int k = 0; k < 10 - count; k++)
                {
                    timesheetEntryIDquery += "0";
                }
                timesheetEntryIDquery += newNum.ToString();

                MessageBox.Show("The new project has been assigned with the Time Sheet Entry ID: " + timesheetEntryIDquery);

            }
            else
            {
                timesheetEntryIDquery = "TSE-0000000001";
            }
        }
        public void getNextPeriodID()
        {
            //Resets the String projectIDquery;
            periodIDquery = "";

            MySqlConnection conn = new MySqlConnection(LogIn.login);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();

            //Gets all the project_ids currently in the database
            cmd.CommandText = "SELECT period_ID FROM period_table";
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
                periodIDquery += "P-";

                //loop to decide how many zeros are needed before inputting the newNum
                for (int k = 0; k < 10 - count; k++)
                {
                    periodIDquery += "0";
                }
                periodIDquery += newNum.ToString();

                MessageBox.Show("The new project has been assigned with the period ID: " + periodIDquery);

            }
            else
            {
                periodIDquery = "P-0000000001";
            }
        }


        private void ImportFile()
        {
            if (txtFileName.Text.Trim() != string.Empty)
            {
                try
                {
                    string[] strTables = GetTableExcel(txtFileName.Text);

                    frmSelectTables objSelectTable = new frmSelectTables(strTables);
                    objSelectTable.ShowDialog(this);
                    objSelectTable.Dispose();
                    if ((SelectedTable != string.Empty) && (SelectedTable != null))
                    {
                        //the actual importing
                        //binds datagridView1 to the data table
                        importedDT = GetDataTableExcel(txtFileName.Text, SelectedTable);
                        dataGridView1.DataSource = importedDT;

                        //gets the Project Name and the start and end dates of the imported biometric file
                        string projectName = dataGridView1.Columns[0].Name.ToString();
                        //MessageBox.Show(projectName);
                        string startDate = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        string endDate = dataGridView1.Rows[1].Cells[1].Value.ToString();

                        //converts the date in the imported biometric file to a mysql accepted format
                        string[] startDateBroken = startDate.Split('/');
                        string correctlyFormattedStart = "";
                        correctlyFormattedStart += startDateBroken[2] + "-" + startDateBroken[0] + "-" + startDateBroken[1];


                        string[] endDateBroken = endDate.Split('/');
                        string correctlyFormattedEnd = "";
                        correctlyFormattedEnd += endDateBroken[2] + "-" + endDateBroken[0] + "-" + endDateBroken[1];




                        //gets the next period ID 
                        getNextPeriodID();

                        //insert into period_table PERIOD ID, START_DATE, END_DATE based on imported biometric file
                        MySqlConnection conn = new MySqlConnection(LogIn.login);
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "INSERT INTO period_table(period_ID, start_date, end_date) VALUES (@period_id, @start_date, @end_date)";
                        cmd.Parameters.AddWithValue("@period_id", periodIDquery);
                        cmd.Parameters.AddWithValue("@start_date", correctlyFormattedStart);
                        cmd.Parameters.AddWithValue("@end_date", correctlyFormattedEnd);
                        cmd.ExecuteNonQuery();


                        //to compute for weeknum, month and year USING MYSQL 


                        cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT DATE_FORMAT(start_date, '%v') AS 'NUM', DATE_FORMAT(end_date, '%M') AS 'MONTH', DATE_FORMAT(end_date, '%Y')AS 'YEAR' FROM period_table WHERE period_id = @period_id";
                        cmd.Parameters.AddWithValue("@period_id", periodIDquery);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        string weeknum = "";
                        string month = "";
                        string year = "";

                        while (reader.Read())
                        {
                            weeknum = reader[0].ToString();
                            month = reader[1].ToString();
                            year = reader[2].ToString();
                        }
                      //  MessageBox.Show(weeknum);
                       // MessageBox.Show(month);
                       // MessageBox.Show(year);

                        reader.Close();
                        /**DataTable query = new DataTable();
                        query.Load(reader);
                        dataGridView1.DataSource = query;
                        reader.Close();

                        weeknum = dataGridView1.Rows[0].Cells[0].Value.ToString();
                        month = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        year = dataGridView1.Rows[0].Cells[2].Value.ToString();*/

                        //updating  period_table the computed values of WEEKNUM, MONTH, YEAR
                        cmd = conn.CreateCommand();
                        cmd.CommandText = "UPDATE period_table SET week_num = @week_num, month = @month, year = @year WHERE period_ID = @period_ID";
                        cmd.Parameters.AddWithValue("@week_num", weeknum);
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                        cmd.Parameters.AddWithValue("@period_id", periodIDquery);
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("Updated");


                        //gets a list of employees
                        List<string> fullnamesEmployess = new List<string>();

                        cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT name_last, name_first, employee_ID FROM employee_table WHERE employee_table.project_ID =(SELECT project_ID FROM projects_table WHERE project_name =@project_name)";
                        cmd.Parameters.AddWithValue("@project_name", projectName);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string fullname = "";
                            fullname += reader[0].ToString() + ", " + reader[1].ToString() + ", " + reader[2].ToString();
                            fullnamesEmployess.Add(fullname);
                        }

                       

                        reader.Close();

                        //checks if member is found in the imported biometric file
                        bool memberFound = false;

                     

                        for (int k = 0; k < dataGridView1.Rows.Count - 1; k++)
                        {
                            foreach (string s in fullnamesEmployess)
                            {
                                string[] value = s.Split(',');
                                string onlythefullname = "";
                                string employee_ID = value[2];
                                onlythefullname += value[0] + "," + value[1];
                                
                          
                                if (dataGridView1.Rows[k].Cells[0].Value.ToString().Equals(onlythefullname.ToUpper(), StringComparison.OrdinalIgnoreCase))
                                {
                                    //MessageBox.Show("Employee found: " + dataGridView1.Rows[k].Cells[0].Value.ToString());
                                    memberFound = true;

                                   
                                    
                                    //insert the different days of this found - employee's attendance into entry_timesheet
                                    for (int sk = 1; sk <= 6; sk++)
                                    {
                                            cmd = conn.CreateCommand();
                                            cmd.CommandText = "INSERT INTO entry_timesheet(TSE_ID, date, morning_in, morning_out, afternoon_in, afternoon_out, ot_in, ot_out, period_ID, project_ID, employee_ID) VALUES (@TSE_ID, @date, @morning_in, @morning_out, @afternoon_in, @afternoon_out, @ot_in, @ot_out, @period_ID, @project_ID, @employee_ID)";
                                            //gets the next ID for Time Sheet Entry table
                                            getNextTimeSheetEntryID();
                                            cmd.Parameters.AddWithValue("@TSE_ID", timesheetEntryIDquery);

                                            string dateEntryWithoutDay = dataGridView1.Rows[k + sk].Cells[0].Value.ToString();
                                            string[] justDate = dateEntryWithoutDay.Split(' ');
                                            string[] individualDateElements = justDate[0].Split('/');
                                            string finaldateEntry = "";
                                            finaldateEntry += individualDateElements[2] + "-" + individualDateElements[0] + "-" + individualDateElements[1];
                                            //MessageBox.Show(finaldateEntry);
                                            cmd.Parameters.AddWithValue("@date", finaldateEntry);
                                            cmd.Parameters.AddWithValue("@morning_in", dataGridView1.Rows[k + sk].Cells[1].Value.ToString());
                                            cmd.Parameters.AddWithValue("@morning_out", dataGridView1.Rows[k + sk].Cells[2].Value.ToString());
                                            cmd.Parameters.AddWithValue("@afternoon_in", dataGridView1.Rows[k + sk].Cells[3].Value.ToString());
                                            cmd.Parameters.AddWithValue("@afternoon_out", dataGridView1.Rows[k + sk].Cells[4].Value.ToString());
                                            cmd.Parameters.AddWithValue("@ot_in", dataGridView1.Rows[k + sk].Cells[5].Value.ToString());
                                            cmd.Parameters.AddWithValue("@ot_out", dataGridView1.Rows[k + sk].Cells[6].Value.ToString());
                                            cmd.Parameters.AddWithValue("@period_ID", periodIDquery);
                                            cmd.Parameters.AddWithValue("@project_ID", projectID);
                                            //  MessageBox.Show(projectID);
                                            cmd.Parameters.AddWithValue("@employee_ID", employee_ID);
                                            // MessageBox.Show(employee_ID);

                                            cmd.ExecuteNonQuery();

                                        //retrieves afternoon_out so that we can convert it into military time, which is more mysql acceptable
                                            MySqlConnection conn2 = new MySqlConnection(LogIn.login);
                                            conn2.Open();
                                            MySqlCommand cmd2 = conn2.CreateCommand();
                                            cmd2.CommandText = "SELECT ADDTIME(afternoon_out, '12:00:00') FROM entry_timesheet WHERE afternoon_out < '12:00:00' AND TSE_ID = @TSE_ID";
                                            cmd2.Parameters.AddWithValue("@TSE_ID", timesheetEntryIDquery);
                                            MySqlDataReader reader2 = cmd2.ExecuteReader();
                                           // MessageBox.Show(timesheetEntryIDquery);
                                            string correctAfternoonOutTime = "";
                                            while (reader2.Read())
                                            {
                                                correctAfternoonOutTime = reader2[0].ToString();
                                            }


                                        //updates afternoon_out with the new value (military time)
                                            cmd = conn.CreateCommand();
                                            cmd.CommandText = "UPDATE entry_timesheet SET afternoon_out = @afternoon_out WHERE entry_timesheet.TSE_ID = @TSE_ID";
                                            cmd.Parameters.AddWithValue("@afternoon_out", correctAfternoonOutTime);   
                                        cmd.Parameters.AddWithValue("@TSE_ID", timesheetEntryIDquery);
                                            cmd.ExecuteNonQuery();


                                        //computes for totalHOurs worked
                                            cmd = conn.CreateCommand();
                                            cmd.CommandText = "SELECT TIME_FORMAT(TIMEDIFF(morning_out, morning_in), '%k') + TIME_FORMAT(TIMEDIFF(afternoon_out, afternoon_in), '%k') FROM entry_timesheet  WHERE TSE_ID = @TSE_ID";
                                             cmd.Parameters.AddWithValue("@TSE_ID", timesheetEntryIDquery);
                                        reader = cmd.ExecuteReader();
                                        string totalHoursWorked = "";
                                        while (reader.Read())
                                        {
                                            totalHoursWorked = reader[0].ToString();
                                        }
                                        //MessageBox.Show(totalHoursWorked);
                                        reader.Close();

                                        //updates the totalHours worked column with the computed Value 
                                            cmd = conn.CreateCommand();
                                            cmd.CommandText = "UPDATE entry_timesheet SET total_hours = @totalHours WHERE TSE_ID = @TSE_ID";
                                            cmd.Parameters.AddWithValue("@totalHours", totalHoursWorked);
                                        cmd.Parameters.AddWithValue("@TSE_ID", timesheetEntryIDquery);
                                        cmd.ExecuteNonQuery();
                                      

                                    }
                                }
                            }
                        }

                        if (memberFound == false)
                        {
                            MessageBox.Show("No such member found");
                        }

                        /** foreach (string s in fullnamesEmployess)
                         {
                             MessageBox.Show(s);
                         }*/
                        MessageBox.Show("import complete");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        public static DataTable GetDataTableExcel(string strFileName, string Table)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";");
            conn.Open();
            string strQuery = "SELECT * FROM [" + Table + "]";
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
            System.Data.DataSet ds = new System.Data.DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static string[] GetTableExcel(string strFileName)
        {
            string[] strTables = new string[100];
            Catalog oCatlog = new Catalog();
            ADOX.Table oTable = new ADOX.Table();
            ADODB.Connection oConn = new ADODB.Connection();
            oConn.Open("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";", "", "", 0);
            oCatlog.ActiveConnection = oConn;
            if (oCatlog.Tables.Count > 0)
            {
                int item = 0;
                foreach (ADOX.Table tab in oCatlog.Tables)
                {
                    if (tab.Type == "TABLE")
                    {
                        strTables[item] = tab.Name;
                        item++;
                    }
                }
            }
            return strTables;
        }

        //manage employees button
        private void button2_Click(object sender, EventArgs e)
        {

            Employee_Panel emppanel = new Employee_Panel();
            emppanel.ProjectID = this.ProjectID;

            emppanel.Show();
        }

        
    }
}