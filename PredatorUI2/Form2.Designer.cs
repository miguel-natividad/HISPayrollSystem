namespace PredatorUI2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.his_payrollDataSet = new PredatorUI2.his_payrollDataSet();
            this.projects_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projects_tableTableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.projects_tableTableAdapter();
            this.employee_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_tableTableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.employee_tableTableAdapter();
            this.entry_timesheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entry_timesheetTableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.entry_timesheetTableAdapter();
            this.entry_salary_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entry_salary_reportTableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.entry_salary_reportTableAdapter();
            this.period_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.period_tableTableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.period_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.his_payrollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projects_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_timesheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_salary_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Projects";
            reportDataSource1.Value = this.projects_tableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PredatorUI2.CBR.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(905, 517);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // his_payrollDataSet
            // 
            this.his_payrollDataSet.DataSetName = "his_payrollDataSet";
            this.his_payrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projects_tableBindingSource
            // 
            this.projects_tableBindingSource.DataMember = "projects_table";
            this.projects_tableBindingSource.DataSource = this.his_payrollDataSet;
            // 
            // projects_tableTableAdapter
            // 
            this.projects_tableTableAdapter.ClearBeforeFill = true;
            // 
            // employee_tableBindingSource
            // 
            this.employee_tableBindingSource.DataMember = "employee_table";
            this.employee_tableBindingSource.DataSource = this.his_payrollDataSet;
            // 
            // employee_tableTableAdapter
            // 
            this.employee_tableTableAdapter.ClearBeforeFill = true;
            // 
            // entry_timesheetBindingSource
            // 
            this.entry_timesheetBindingSource.DataMember = "entry_timesheet";
            this.entry_timesheetBindingSource.DataSource = this.his_payrollDataSet;
            // 
            // entry_timesheetTableAdapter
            // 
            this.entry_timesheetTableAdapter.ClearBeforeFill = true;
            // 
            // entry_salary_reportBindingSource
            // 
            this.entry_salary_reportBindingSource.DataMember = "entry_salary_report";
            this.entry_salary_reportBindingSource.DataSource = this.his_payrollDataSet;
            // 
            // entry_salary_reportTableAdapter
            // 
            this.entry_salary_reportTableAdapter.ClearBeforeFill = true;
            // 
            // period_tableBindingSource
            // 
            this.period_tableBindingSource.DataMember = "period_table";
            this.period_tableBindingSource.DataSource = this.his_payrollDataSet;
            // 
            // period_tableTableAdapter
            // 
            this.period_tableTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 541);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.his_payrollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projects_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_timesheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_salary_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period_tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource projects_tableBindingSource;
        private his_payrollDataSet his_payrollDataSet;
        private System.Windows.Forms.BindingSource employee_tableBindingSource;
        private System.Windows.Forms.BindingSource entry_timesheetBindingSource;
        private System.Windows.Forms.BindingSource entry_salary_reportBindingSource;
        private System.Windows.Forms.BindingSource period_tableBindingSource;
        private his_payrollDataSetTableAdapters.projects_tableTableAdapter projects_tableTableAdapter;
        private his_payrollDataSetTableAdapters.employee_tableTableAdapter employee_tableTableAdapter;
        private his_payrollDataSetTableAdapters.entry_timesheetTableAdapter entry_timesheetTableAdapter;
        private his_payrollDataSetTableAdapters.entry_salary_reportTableAdapter entry_salary_reportTableAdapter;
        private his_payrollDataSetTableAdapters.period_tableTableAdapter period_tableTableAdapter;
    }
}