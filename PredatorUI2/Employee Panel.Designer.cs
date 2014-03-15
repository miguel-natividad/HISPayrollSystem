namespace PredatorUI2
{
    partial class Employee_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Panel));
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.positionTB = new System.Windows.Forms.TextBox();
            this.accountNumTB = new System.Windows.Forms.TextBox();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.middleInitialTB = new System.Windows.Forms.TextBox();
            this.currentBalTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.companyNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.workerTypeCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTB
            // 
            this.firstNameTB.BackColor = System.Drawing.Color.DimGray;
            this.firstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.ForeColor = System.Drawing.Color.White;
            this.firstNameTB.Location = new System.Drawing.Point(399, 137);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(197, 26);
            this.firstNameTB.TabIndex = 22;
            // 
            // lastNameTB
            // 
            this.lastNameTB.BackColor = System.Drawing.Color.DimGray;
            this.lastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTB.ForeColor = System.Drawing.Color.White;
            this.lastNameTB.Location = new System.Drawing.Point(399, 181);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(197, 26);
            this.lastNameTB.TabIndex = 23;
            // 
            // positionTB
            // 
            this.positionTB.BackColor = System.Drawing.Color.DimGray;
            this.positionTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.positionTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionTB.ForeColor = System.Drawing.Color.White;
            this.positionTB.Location = new System.Drawing.Point(399, 229);
            this.positionTB.Name = "positionTB";
            this.positionTB.Size = new System.Drawing.Size(197, 26);
            this.positionTB.TabIndex = 24;
            // 
            // accountNumTB
            // 
            this.accountNumTB.BackColor = System.Drawing.Color.DimGray;
            this.accountNumTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accountNumTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountNumTB.ForeColor = System.Drawing.Color.White;
            this.accountNumTB.Location = new System.Drawing.Point(399, 273);
            this.accountNumTB.Name = "accountNumTB";
            this.accountNumTB.Size = new System.Drawing.Size(197, 26);
            this.accountNumTB.TabIndex = 25;
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteCancelChangesButton_psd;
            this.CancelChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChangesButton.Location = new System.Drawing.Point(800, 377);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(160, 25);
            this.CancelChangesButton.TabIndex = 30;
            this.CancelChangesButton.UseVisualStyleBackColor = true;
            this.CancelChangesButton.Click += new System.EventHandler(this.CancelChangesButton_Click);
            // 
            // save_button
            // 
            this.save_button.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteSaveChangesButton_psd;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Location = new System.Drawing.Point(634, 377);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(160, 25);
            this.save_button.TabIndex = 31;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.employeeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(260, 424);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(702, 132);
            this.employeeDataGridView.TabIndex = 32;
            this.employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellClick);
            // 
            // delBtn
            // 
            this.delBtn.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteDeleteButton_psd;
            this.delBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBtn.Location = new System.Drawing.Point(898, 574);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(65, 20);
            this.delBtn.TabIndex = 35;
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addButton
            // 
            this.addButton.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteAddButton_psd;
            this.addButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(755, 574);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 20);
            this.addButton.TabIndex = 33;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // middleInitialTB
            // 
            this.middleInitialTB.BackColor = System.Drawing.Color.DimGray;
            this.middleInitialTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middleInitialTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleInitialTB.ForeColor = System.Drawing.Color.White;
            this.middleInitialTB.Location = new System.Drawing.Point(744, 137);
            this.middleInitialTB.Name = "middleInitialTB";
            this.middleInitialTB.Size = new System.Drawing.Size(50, 26);
            this.middleInitialTB.TabIndex = 36;
            // 
            // currentBalTB
            // 
            this.currentBalTB.BackColor = System.Drawing.Color.DimGray;
            this.currentBalTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentBalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBalTB.ForeColor = System.Drawing.Color.White;
            this.currentBalTB.Location = new System.Drawing.Point(399, 323);
            this.currentBalTB.Name = "currentBalTB";
            this.currentBalTB.Size = new System.Drawing.Size(197, 26);
            this.currentBalTB.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Current Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Middle Initial";
            // 
            // companyNameTB
            // 
            this.companyNameTB.BackColor = System.Drawing.Color.DimGray;
            this.companyNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNameTB.ForeColor = System.Drawing.Color.White;
            this.companyNameTB.Location = new System.Drawing.Point(399, 376);
            this.companyNameTB.Name = "companyNameTB";
            this.companyNameTB.Size = new System.Drawing.Size(197, 26);
            this.companyNameTB.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Company Name";
            // 
            // workerTypeCB
            // 
            this.workerTypeCB.FormattingEnabled = true;
            this.workerTypeCB.Location = new System.Drawing.Point(752, 194);
            this.workerTypeCB.Name = "workerTypeCB";
            this.workerTypeCB.Size = new System.Drawing.Size(121, 21);
            this.workerTypeCB.TabIndex = 46;
            this.workerTypeCB.SelectedIndexChanged += new System.EventHandler(this.workerTypeCB_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(650, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Worker Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(646, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Category";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // categoryCB
            // 
            this.categoryCB.Enabled = false;
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(752, 239);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(121, 21);
            this.categoryCB.TabIndex = 49;
            // 
            // Employee_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.workerTypeCB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.companyNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentBalTB);
            this.Controls.Add(this.middleInitialTB);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.CancelChangesButton);
            this.Controls.Add(this.accountNumTB);
            this.Controls.Add(this.positionTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Name = "Employee_Panel";
            this.Text = "Employee_Panel";
            this.Load += new System.EventHandler(this.Employee_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox positionTB;
        private System.Windows.Forms.TextBox accountNumTB;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox middleInitialTB;
        private System.Windows.Forms.TextBox currentBalTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companyNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox workerTypeCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox categoryCB;
    }
}