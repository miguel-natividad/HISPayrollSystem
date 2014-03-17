namespace PredatorUI2
{
    partial class Projects_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects_Panel));
            this.projectsDataGrid = new System.Windows.Forms.DataGridView();
            this.projectNameTB = new System.Windows.Forms.TextBox();
            this.projectLocationTB = new System.Windows.Forms.TextBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.deleteProjectBtn = new System.Windows.Forms.Button();
            this.editProjectBtn = new System.Windows.Forms.Button();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.CreateProjectButton = new System.Windows.Forms.Button();
            this.projectsNameLabel = new System.Windows.Forms.Label();
            this.projectLocationLabel = new System.Windows.Forms.Label();
            this.projectStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lodgingAllowTB = new System.Windows.Forms.TextBox();
            this.manageSalaryBtn = new System.Windows.Forms.Button();
            this.projectsPanelBtn = new System.Windows.Forms.Button();
            this.employeesPanelBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // projectsDataGrid
            // 
            this.projectsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projectsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.projectsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.projectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGrid.Location = new System.Drawing.Point(270, 374);
            this.projectsDataGrid.Name = "projectsDataGrid";
            this.projectsDataGrid.Size = new System.Drawing.Size(702, 132);
            this.projectsDataGrid.TabIndex = 1;
            this.projectsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsDataGrid_CellClick);
            // 
            // projectNameTB
            // 
            this.projectNameTB.BackColor = System.Drawing.Color.DimGray;
            this.projectNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameTB.ForeColor = System.Drawing.Color.White;
            this.projectNameTB.Location = new System.Drawing.Point(474, 152);
            this.projectNameTB.Name = "projectNameTB";
            this.projectNameTB.Size = new System.Drawing.Size(173, 26);
            this.projectNameTB.TabIndex = 21;
            // 
            // projectLocationTB
            // 
            this.projectLocationTB.BackColor = System.Drawing.Color.DimGray;
            this.projectLocationTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectLocationTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLocationTB.ForeColor = System.Drawing.Color.White;
            this.projectLocationTB.Location = new System.Drawing.Point(474, 184);
            this.projectLocationTB.Name = "projectLocationTB";
            this.projectLocationTB.Size = new System.Drawing.Size(173, 26);
            this.projectLocationTB.TabIndex = 22;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(474, 223);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(173, 21);
            this.statusComboBox.TabIndex = 23;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // deleteProjectBtn
            // 
            this.deleteProjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteProjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProjectBtn.Font = new System.Drawing.Font("TypoSlabserif-Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProjectBtn.Location = new System.Drawing.Point(452, 512);
            this.deleteProjectBtn.Name = "deleteProjectBtn";
            this.deleteProjectBtn.Size = new System.Drawing.Size(165, 35);
            this.deleteProjectBtn.TabIndex = 26;
            this.deleteProjectBtn.Text = "DELETE PROJECT";
            this.deleteProjectBtn.UseVisualStyleBackColor = false;
            this.deleteProjectBtn.Visible = false;
            this.deleteProjectBtn.Click += new System.EventHandler(this.deleteProjectBtn_Click);
            // 
            // editProjectBtn
            // 
            this.editProjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.editProjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProjectBtn.Font = new System.Drawing.Font("TypoSlabserif-Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProjectBtn.Location = new System.Drawing.Point(623, 313);
            this.editProjectBtn.Name = "editProjectBtn";
            this.editProjectBtn.Size = new System.Drawing.Size(178, 35);
            this.editProjectBtn.TabIndex = 25;
            this.editProjectBtn.Text = "SAVE CHANGES";
            this.editProjectBtn.UseVisualStyleBackColor = false;
            this.editProjectBtn.Click += new System.EventHandler(this.editProjectBtn_Click);
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChangesButton.Font = new System.Drawing.Font("TypoSlabserif-Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelChangesButton.Location = new System.Drawing.Point(807, 313);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(165, 34);
            this.CancelChangesButton.TabIndex = 29;
            this.CancelChangesButton.Text = "CLEAR FIELDS";
            this.CancelChangesButton.UseVisualStyleBackColor = false;
            this.CancelChangesButton.Click += new System.EventHandler(this.CancelChangesButton_Click);
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjectButton.Font = new System.Drawing.Font("TypoSlabserif-Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProjectButton.Location = new System.Drawing.Point(444, 314);
            this.CreateProjectButton.Name = "CreateProjectButton";
            this.CreateProjectButton.Size = new System.Drawing.Size(173, 34);
            this.CreateProjectButton.TabIndex = 27;
            this.CreateProjectButton.Text = "CREATE PROJECT";
            this.CreateProjectButton.UseVisualStyleBackColor = false;
            this.CreateProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // projectsNameLabel
            // 
            this.projectsNameLabel.AutoSize = true;
            this.projectsNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectsNameLabel.Font = new System.Drawing.Font("TypoSlabserif-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsNameLabel.Location = new System.Drawing.Point(266, 156);
            this.projectsNameLabel.Name = "projectsNameLabel";
            this.projectsNameLabel.Size = new System.Drawing.Size(115, 21);
            this.projectsNameLabel.TabIndex = 30;
            this.projectsNameLabel.Text = "Project Name";
            // 
            // projectLocationLabel
            // 
            this.projectLocationLabel.AutoSize = true;
            this.projectLocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectLocationLabel.Font = new System.Drawing.Font("TypoSlabserif-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLocationLabel.Location = new System.Drawing.Point(266, 189);
            this.projectLocationLabel.Name = "projectLocationLabel";
            this.projectLocationLabel.Size = new System.Drawing.Size(136, 21);
            this.projectLocationLabel.TabIndex = 31;
            this.projectLocationLabel.Text = "Project Location";
            // 
            // projectStatusLabel
            // 
            this.projectStatusLabel.AutoSize = true;
            this.projectStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectStatusLabel.Font = new System.Drawing.Font("TypoSlabserif-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectStatusLabel.Location = new System.Drawing.Point(266, 223);
            this.projectStatusLabel.Name = "projectStatusLabel";
            this.projectStatusLabel.Size = new System.Drawing.Size(117, 21);
            this.projectStatusLabel.TabIndex = 32;
            this.projectStatusLabel.Text = "Project Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TypoSlabserif-Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lodging Allowance";
            // 
            // lodgingAllowTB
            // 
            this.lodgingAllowTB.BackColor = System.Drawing.Color.DimGray;
            this.lodgingAllowTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lodgingAllowTB.Font = new System.Drawing.Font("TypoSlabserif-Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingAllowTB.ForeColor = System.Drawing.Color.White;
            this.lodgingAllowTB.Location = new System.Drawing.Point(474, 258);
            this.lodgingAllowTB.Name = "lodgingAllowTB";
            this.lodgingAllowTB.Size = new System.Drawing.Size(173, 27);
            this.lodgingAllowTB.TabIndex = 34;
            this.lodgingAllowTB.Text = "0.00";
            this.lodgingAllowTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // manageSalaryBtn
            // 
            this.manageSalaryBtn.BackColor = System.Drawing.Color.Transparent;
            this.manageSalaryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageSalaryBtn.Enabled = false;
            this.manageSalaryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageSalaryBtn.Font = new System.Drawing.Font("TypoSlabserif-Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageSalaryBtn.Location = new System.Drawing.Point(807, 512);
            this.manageSalaryBtn.Name = "manageSalaryBtn";
            this.manageSalaryBtn.Size = new System.Drawing.Size(173, 35);
            this.manageSalaryBtn.TabIndex = 35;
            this.manageSalaryBtn.Text = "MANAGE SALARY";
            this.manageSalaryBtn.UseVisualStyleBackColor = false;
            this.manageSalaryBtn.Click += new System.EventHandler(this.manageSalaryBtn_Click);
            // 
            // projectsPanelBtn
            // 
            this.projectsPanelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.projectsPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projectsPanelBtn.Font = new System.Drawing.Font("TypoSlabserif-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsPanelBtn.Location = new System.Drawing.Point(22, 137);
            this.projectsPanelBtn.Name = "projectsPanelBtn";
            this.projectsPanelBtn.Size = new System.Drawing.Size(200, 40);
            this.projectsPanelBtn.TabIndex = 36;
            this.projectsPanelBtn.Text = "Projects Panel";
            this.projectsPanelBtn.UseVisualStyleBackColor = true;
            this.projectsPanelBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeesPanelBtn
            // 
            this.employeesPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeesPanelBtn.Font = new System.Drawing.Font("TypoSlabserif-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesPanelBtn.Location = new System.Drawing.Point(22, 183);
            this.employeesPanelBtn.Name = "employeesPanelBtn";
            this.employeesPanelBtn.Size = new System.Drawing.Size(200, 40);
            this.employeesPanelBtn.TabIndex = 37;
            this.employeesPanelBtn.Text = "Employees Panel";
            this.employeesPanelBtn.UseVisualStyleBackColor = true;
            this.employeesPanelBtn.Click += new System.EventHandler(this.employeesPanelBtn_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("TypoSlabserif-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(22, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 40);
            this.button2.TabIndex = 41;
            this.button2.Text = "Reports";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("TypoSlabserif-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(22, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 42;
            this.button3.Text = "Salary Rate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("TypoSlabserif-Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 43;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Projects_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.employeesPanelBtn);
            this.Controls.Add(this.projectsPanelBtn);
            this.Controls.Add(this.manageSalaryBtn);
            this.Controls.Add(this.lodgingAllowTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectStatusLabel);
            this.Controls.Add(this.projectLocationLabel);
            this.Controls.Add(this.projectsNameLabel);
            this.Controls.Add(this.CancelChangesButton);
            this.Controls.Add(this.CreateProjectButton);
            this.Controls.Add(this.deleteProjectBtn);
            this.Controls.Add(this.editProjectBtn);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.projectLocationTB);
            this.Controls.Add(this.projectNameTB);
            this.Controls.Add(this.projectsDataGrid);
            this.Name = "Projects_Panel";
            this.Text = "Projects_Panel";
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projectsDataGrid;
        private System.Windows.Forms.TextBox projectNameTB;
        private System.Windows.Forms.TextBox projectLocationTB;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button deleteProjectBtn;
        private System.Windows.Forms.Button editProjectBtn;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.Button CreateProjectButton;
        private System.Windows.Forms.Label projectsNameLabel;
        private System.Windows.Forms.Label projectLocationLabel;
        private System.Windows.Forms.Label projectStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lodgingAllowTB;
        private System.Windows.Forms.Button manageSalaryBtn;
        private System.Windows.Forms.Button projectsPanelBtn;
        private System.Windows.Forms.Button employeesPanelBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}