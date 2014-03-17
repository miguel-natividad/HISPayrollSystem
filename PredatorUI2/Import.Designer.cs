namespace PredatorUI2
{
    partial class Import
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Import));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.manageTSLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.importBioBtn = new System.Windows.Forms.Button();
            this.currentTimeSheet = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.curSalarySummaryBtn = new System.Windows.Forms.Button();
            this.manageEmployeesBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(325, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 229);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(408, 164);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(379, 20);
            this.txtFileName.TabIndex = 28;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(331, 164);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(63, 13);
            this.lblFilename.TabIndex = 27;
            this.lblFilename.Text = "File Name";
            // 
            // manageTSLabel
            // 
            this.manageTSLabel.AutoSize = true;
            this.manageTSLabel.Location = new System.Drawing.Point(32, 126);
            this.manageTSLabel.Name = "manageTSLabel";
            this.manageTSLabel.Size = new System.Drawing.Size(108, 13);
            this.manageTSLabel.TabIndex = 29;
            this.manageTSLabel.Text = "Manage Time Sheets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Calculate Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Employees";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 485);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Reports";
            // 
            // importBioBtn
            // 
            this.importBioBtn.Location = new System.Drawing.Point(65, 159);
            this.importBioBtn.Name = "importBioBtn";
            this.importBioBtn.Size = new System.Drawing.Size(123, 23);
            this.importBioBtn.TabIndex = 33;
            this.importBioBtn.Text = "Import Biometrics";
            this.importBioBtn.UseVisualStyleBackColor = true;
            // 
            // currentTimeSheet
            // 
            this.currentTimeSheet.Location = new System.Drawing.Point(65, 201);
            this.currentTimeSheet.Name = "currentTimeSheet";
            this.currentTimeSheet.Size = new System.Drawing.Size(123, 23);
            this.currentTimeSheet.TabIndex = 34;
            this.currentTimeSheet.Text = "Current Time Sheet";
            this.currentTimeSheet.UseVisualStyleBackColor = true;
            this.currentTimeSheet.Click += new System.EventHandler(this.currentTimeSheet_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(65, 315);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(148, 23);
            this.calculateBtn.TabIndex = 35;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            // 
            // curSalarySummaryBtn
            // 
            this.curSalarySummaryBtn.Location = new System.Drawing.Point(65, 361);
            this.curSalarySummaryBtn.Name = "curSalarySummaryBtn";
            this.curSalarySummaryBtn.Size = new System.Drawing.Size(148, 23);
            this.curSalarySummaryBtn.TabIndex = 36;
            this.curSalarySummaryBtn.Text = "Current Salary Summary";
            this.curSalarySummaryBtn.UseVisualStyleBackColor = true;
            // 
            // manageEmployeesBtn
            // 
            this.manageEmployeesBtn.Location = new System.Drawing.Point(65, 437);
            this.manageEmployeesBtn.Name = "manageEmployeesBtn";
            this.manageEmployeesBtn.Size = new System.Drawing.Size(148, 23);
            this.manageEmployeesBtn.TabIndex = 37;
            this.manageEmployeesBtn.Text = "Manage Employees";
            this.manageEmployeesBtn.UseVisualStyleBackColor = true;
            this.manageEmployeesBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(325, 454);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(140, 23);
            this.saveChangesBtn.TabIndex = 38;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.manageEmployeesBtn);
            this.Controls.Add(this.curSalarySummaryBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.currentTimeSheet);
            this.Controls.Add(this.importBioBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manageTSLabel);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Import";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label manageTSLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button importBioBtn;
        private System.Windows.Forms.Button currentTimeSheet;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button curSalarySummaryBtn;
        private System.Windows.Forms.Button manageEmployeesBtn;
        private System.Windows.Forms.Button saveChangesBtn;
    }
}

