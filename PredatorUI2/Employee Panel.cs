using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql;
using MySqlDriver;


namespace PredatorUI2
{
    public partial class Employee_Panel : Form
    {
        private DatabaseDriver db = new DatabaseDriver("localhost", "root", "root", "his_payroll");
        db.Open();

        public Employee_Panel()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = EmployeeNameTextBox.Text;
            String position = PositionTextBox.Text;
            String accountNum = AccountNumberTextBox.Text;
            String currentBalance = CurrentBalanceTextBox.Text;


        }
    }
}
