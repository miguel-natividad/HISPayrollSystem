using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PredatorUI2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'his_payrollDataSet.projects_table' table. You can move, or remove it, as needed.
            this.projects_tableTableAdapter.Fill(this.his_payrollDataSet.projects_table);
            // TODO: This line of code loads data into the 'his_payrollDataSet.employee_table' table. You can move, or remove it, as needed.
            this.employee_tableTableAdapter.Fill(this.his_payrollDataSet.employee_table);
            // TODO: This line of code loads data into the 'his_payrollDataSet.entry_timesheet' table. You can move, or remove it, as needed.
            this.entry_timesheetTableAdapter.Fill(this.his_payrollDataSet.entry_timesheet);
            // TODO: This line of code loads data into the 'his_payrollDataSet.entry_salary_report' table. You can move, or remove it, as needed.
            this.entry_salary_reportTableAdapter.Fill(this.his_payrollDataSet.entry_salary_report);
            // TODO: This line of code loads data into the 'his_payrollDataSet.period_table' table. You can move, or remove it, as needed.
            this.period_tableTableAdapter.Fill(this.his_payrollDataSet.period_table);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
