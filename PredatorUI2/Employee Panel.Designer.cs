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
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.AccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.CurrentBalanceTextBox = new System.Windows.Forms.TextBox();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.BackColor = System.Drawing.Color.DimGray;
            this.EmployeeNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameTextBox.ForeColor = System.Drawing.Color.White;
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(414, 181);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(223, 26);
            this.EmployeeNameTextBox.TabIndex = 22;
            this.EmployeeNameTextBox.TextChanged += new System.EventHandler(this.EmployeeNameTextBox_TextChanged);
            // 
            // AccountNumberTextBox
            // 
            this.AccountNumberTextBox.BackColor = System.Drawing.Color.DimGray;
            this.AccountNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberTextBox.ForeColor = System.Drawing.Color.White;
            this.AccountNumberTextBox.Location = new System.Drawing.Point(429, 213);
            this.AccountNumberTextBox.Name = "AccountNumberTextBox";
            this.AccountNumberTextBox.Size = new System.Drawing.Size(208, 26);
            this.AccountNumberTextBox.TabIndex = 23;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.BackColor = System.Drawing.Color.DimGray;
            this.PositionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionTextBox.ForeColor = System.Drawing.Color.White;
            this.PositionTextBox.Location = new System.Drawing.Point(766, 181);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(197, 26);
            this.PositionTextBox.TabIndex = 24;
            this.PositionTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CurrentBalanceTextBox
            // 
            this.CurrentBalanceTextBox.BackColor = System.Drawing.Color.DimGray;
            this.CurrentBalanceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentBalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceTextBox.ForeColor = System.Drawing.Color.White;
            this.CurrentBalanceTextBox.Location = new System.Drawing.Point(845, 213);
            this.CurrentBalanceTextBox.Name = "CurrentBalanceTextBox";
            this.CurrentBalanceTextBox.Size = new System.Drawing.Size(118, 26);
            this.CurrentBalanceTextBox.TabIndex = 25;
            this.CurrentBalanceTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteCancelChangesButton_psd;
            this.CancelChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChangesButton.Location = new System.Drawing.Point(803, 255);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(160, 25);
            this.CancelChangesButton.TabIndex = 30;
            this.CancelChangesButton.UseVisualStyleBackColor = true;
            // 
            // save_button
            // 
            this.save_button.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteSaveChangesButton_psd;
            this.save_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_button.Location = new System.Drawing.Point(637, 255);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(160, 25);
            this.save_button.TabIndex = 31;
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeName,
            this.Position,
            this.CurrentBalance,
            this.AccountNumber});
            this.dataGridView1.Location = new System.Drawing.Point(270, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(702, 132);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 210;
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.Width = 150;
            // 
            // CurrentBalance
            // 
            this.CurrentBalance.HeaderText = "Current Balance";
            this.CurrentBalance.Name = "CurrentBalance";
            this.CurrentBalance.Width = 150;
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "Account Number";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Width = 150;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteDeleteButton_psd;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(908, 481);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 20);
            this.button4.TabIndex = 35;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteEditButton_psd;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(836, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 20);
            this.button3.TabIndex = 34;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteAddButton_psd;
            this.ChangeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Location = new System.Drawing.Point(765, 481);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(65, 20);
            this.ChangeButton.TabIndex = 33;
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // Employee_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PredatorUI2.Properties.Resources.Employee_psd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.CancelChangesButton);
            this.Controls.Add(this.CurrentBalanceTextBox);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.AccountNumberTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Name = "Employee_Panel";
            this.Text = "Employee_Panel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox AccountNumberTextBox;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.TextBox CurrentBalanceTextBox;
        private System.Windows.Forms.Button CancelChangesButton;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ChangeButton;
    }
}