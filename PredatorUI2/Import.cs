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
                        importedDT = GetDataTableExcel(txtFileName.Text, SelectedTable);
                        dataGridView1.DataSource = importedDT;

                        string projectName = dataGridView1.Columns[0].Name.ToString();
                        string startDate = dataGridView1.Rows[0].Cells[1].Value.ToString();
                        string endDate = dataGridView1.Rows[1].Cells[1].Value.ToString();
                      

                        List<string> fullnamesEmployess = new List<string>();

                        MySqlConnection conn = new MySqlConnection(LogIn.login);
                        conn.Open();
                        MySqlCommand cmd = conn.CreateCommand();
                        cmd.CommandText = "SELECT name_last, name_first FROM employee_table";
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string fullname = "";
                            fullname += reader[0].ToString() + ", " + reader[1].ToString();
                            fullnamesEmployess.Add(fullname);
                        }

                        reader.Close();

                        foreach (string s in fullnamesEmployess)
                        {
                            MessageBox.Show(s);
                        }

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}