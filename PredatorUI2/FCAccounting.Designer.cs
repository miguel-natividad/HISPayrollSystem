namespace PredatorUI2
{
    partial class FCAccounting
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.his_payrollDataSet = new PredatorUI2.his_payrollDataSet();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.DataTable1TableAdapter();
            this.projects_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projects_tableTableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.projects_tableTableAdapter();
            this.entry_salary_reportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entry_salary_reportTableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.entry_salary_reportTableAdapter();
            this.employee_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_tableTableAdapter = new PredatorUI2.his_payrollDataSetTableAdapters.employee_tableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.his_payrollDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projects_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_salary_reportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteZoomOutButton_psd;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(243, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 20);
            this.button2.TabIndex = 48;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteZoomInButton_psd;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(172, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 20);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::PredatorUI2.Properties.Resources.WhitePrintButton_psd;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(101, 618);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 20);
            this.button4.TabIndex = 46;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(868, 48);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 550);
            this.vScrollBar1.TabIndex = 45;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(101, 596);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(767, 17);
            this.hScrollBar1.TabIndex = 44;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.dataTable1BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PredatorUI2.AR.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(101, 48);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(764, 545);
            this.reportViewer1.TabIndex = 49;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // his_payrollDataSet
            // 
            this.his_payrollDataSet.DataSetName = "his_payrollDataSet";
            this.his_payrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.his_payrollDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
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
            // entry_salary_reportBindingSource
            // 
            this.entry_salary_reportBindingSource.DataMember = "entry_salary_report";
            this.entry_salary_reportBindingSource.DataSource = this.his_payrollDataSet;
            // 
            // entry_salary_reportTableAdapter
            // 
            this.entry_salary_reportTableAdapter.ClearBeforeFill = true;
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
            // FCAccounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PredatorUI2.Properties.Resources.FullScreenTemplate1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "FCAccounting";
            this.Text = "FCAccounting";
            this.Load += new System.EventHandler(this.FCAccounting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.his_payrollDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projects_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entry_salary_reportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private his_payrollDataSet his_payrollDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private his_payrollDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource projects_tableBindingSource;
        private System.Windows.Forms.BindingSource entry_salary_reportBindingSource;
        private System.Windows.Forms.BindingSource employee_tableBindingSource;
        private his_payrollDataSetTableAdapters.projects_tableTableAdapter projects_tableTableAdapter;
        private his_payrollDataSetTableAdapters.entry_salary_reportTableAdapter entry_salary_reportTableAdapter;
        private his_payrollDataSetTableAdapters.employee_tableTableAdapter employee_tableTableAdapter;
    }
}