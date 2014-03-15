namespace PredatorUI2
{
    partial class Settings_User_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_User_Management));
            this.usermgtDataGrid = new System.Windows.Forms.DataGridView();
            this.changePassBtn = new System.Windows.Forms.Button();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.cancelChangesBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.delUserBtn = new System.Windows.Forms.Button();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.employeesPanelBtn = new System.Windows.Forms.Button();
            this.projectsPanelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usermgtDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usermgtDataGrid
            // 
            this.usermgtDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usermgtDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.usermgtDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.usermgtDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usermgtDataGrid.Location = new System.Drawing.Point(247, 348);
            this.usermgtDataGrid.Name = "usermgtDataGrid";
            this.usermgtDataGrid.Size = new System.Drawing.Size(702, 132);
            this.usermgtDataGrid.TabIndex = 0;
            this.usermgtDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usermgtDataGrid_CellClick);
            // 
            // changePassBtn
            // 
            this.changePassBtn.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteChangePasswordButton_psd;
            this.changePassBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePassBtn.Location = new System.Drawing.Point(423, 308);
            this.changePassBtn.Name = "changePassBtn";
            this.changePassBtn.Size = new System.Drawing.Size(160, 25);
            this.changePassBtn.TabIndex = 1;
            this.changePassBtn.UseVisualStyleBackColor = true;
            this.changePassBtn.Click += new System.EventHandler(this.changePassBtn_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteSaveChangesButton_psd;
            this.saveChangesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangesBtn.Location = new System.Drawing.Point(614, 308);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(160, 25);
            this.saveChangesBtn.TabIndex = 2;
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // cancelChangesBtn
            // 
            this.cancelChangesBtn.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteCancelChangesButton_psd;
            this.cancelChangesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelChangesBtn.Location = new System.Drawing.Point(789, 308);
            this.cancelChangesBtn.Name = "cancelChangesBtn";
            this.cancelChangesBtn.Size = new System.Drawing.Size(160, 25);
            this.cancelChangesBtn.TabIndex = 3;
            this.cancelChangesBtn.UseVisualStyleBackColor = true;
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteAddButton_psd;
            this.addUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Location = new System.Drawing.Point(775, 511);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(65, 20);
            this.addUserBtn.TabIndex = 14;
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // delUserBtn
            // 
            this.delUserBtn.BackgroundImage = global::PredatorUI2.Properties.Resources.WhiteDeleteButton_psd;
            this.delUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delUserBtn.Location = new System.Drawing.Point(884, 511);
            this.delUserBtn.Name = "delUserBtn";
            this.delUserBtn.Size = new System.Drawing.Size(65, 20);
            this.delUserBtn.TabIndex = 16;
            this.delUserBtn.UseVisualStyleBackColor = true;
            this.delUserBtn.Click += new System.EventHandler(this.delUserBtn_Click);
            // 
            // firstNameTB
            // 
            this.firstNameTB.BackColor = System.Drawing.Color.DimGray;
            this.firstNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTB.ForeColor = System.Drawing.Color.White;
            this.firstNameTB.Location = new System.Drawing.Point(353, 177);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(230, 26);
            this.firstNameTB.TabIndex = 20;
            // 
            // lastNameTB
            // 
            this.lastNameTB.BackColor = System.Drawing.Color.DimGray;
            this.lastNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTB.ForeColor = System.Drawing.Color.White;
            this.lastNameTB.Location = new System.Drawing.Point(704, 177);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(230, 26);
            this.lastNameTB.TabIndex = 21;
            // 
            // userNameTB
            // 
            this.userNameTB.BackColor = System.Drawing.Color.DimGray;
            this.userNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTB.ForeColor = System.Drawing.Color.White;
            this.userNameTB.Location = new System.Drawing.Point(353, 211);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(230, 26);
            this.userNameTB.TabIndex = 22;
            // 
            // passwordTB
            // 
            this.passwordTB.BackColor = System.Drawing.Color.DimGray;
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.ForeColor = System.Drawing.Color.White;
            this.passwordTB.Location = new System.Drawing.Point(704, 211);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(230, 26);
            this.passwordTB.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Password";
            // 
            // settingsBtn
            // 
            this.settingsBtn.Location = new System.Drawing.Point(38, 290);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(144, 23);
            this.settingsBtn.TabIndex = 43;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = true;
            // 
            // reportsBtn
            // 
            this.reportsBtn.Location = new System.Drawing.Point(38, 245);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(144, 23);
            this.reportsBtn.TabIndex = 42;
            this.reportsBtn.Text = "Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            // 
            // employeesPanelBtn
            // 
            this.employeesPanelBtn.Location = new System.Drawing.Point(38, 201);
            this.employeesPanelBtn.Name = "employeesPanelBtn";
            this.employeesPanelBtn.Size = new System.Drawing.Size(144, 23);
            this.employeesPanelBtn.TabIndex = 41;
            this.employeesPanelBtn.Text = "Employees Panel";
            this.employeesPanelBtn.UseVisualStyleBackColor = true;
            // 
            // projectsPanelBtn
            // 
            this.projectsPanelBtn.Location = new System.Drawing.Point(38, 163);
            this.projectsPanelBtn.Name = "projectsPanelBtn";
            this.projectsPanelBtn.Size = new System.Drawing.Size(144, 23);
            this.projectsPanelBtn.TabIndex = 40;
            this.projectsPanelBtn.Text = "Projects Panel";
            this.projectsPanelBtn.UseVisualStyleBackColor = true;
            // 
            // Settings_User_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.reportsBtn);
            this.Controls.Add(this.employeesPanelBtn);
            this.Controls.Add(this.projectsPanelBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.delUserBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.cancelChangesBtn);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.changePassBtn);
            this.Controls.Add(this.usermgtDataGrid);
            this.Name = "Settings_User_Management";
            this.Text = "Settings_User_Management";
            ((System.ComponentModel.ISupportInitialize)(this.usermgtDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usermgtDataGrid;
        private System.Windows.Forms.Button changePassBtn;
        private System.Windows.Forms.Button saveChangesBtn;
        private System.Windows.Forms.Button cancelChangesBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button delUserBtn;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button employeesPanelBtn;
        private System.Windows.Forms.Button projectsPanelBtn;
    }
}