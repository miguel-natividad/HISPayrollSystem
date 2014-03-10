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
            ((System.ComponentModel.ISupportInitialize)(this.projectsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // projectsDataGrid
            // 
            this.projectsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.projectsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.projectsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.projectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsDataGrid.Location = new System.Drawing.Point(270, 331);
            this.projectsDataGrid.Name = "projectsDataGrid";
            this.projectsDataGrid.Size = new System.Drawing.Size(702, 132);
            this.projectsDataGrid.TabIndex = 1;
            this.projectsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsDataGrid_CellClick);
            //this.projectsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsDataGrid_CellContentClick);
            // 
            // projectNameTB
            // 
            this.projectNameTB.BackColor = System.Drawing.Color.DimGray;
            this.projectNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameTB.ForeColor = System.Drawing.Color.White;
            this.projectNameTB.Location = new System.Drawing.Point(422, 160);
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
            this.projectLocationTB.Location = new System.Drawing.Point(422, 192);
            this.projectLocationTB.Name = "projectLocationTB";
            this.projectLocationTB.Size = new System.Drawing.Size(173, 26);
            this.projectLocationTB.TabIndex = 22;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(422, 231);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(173, 21);
            this.statusComboBox.TabIndex = 23;
            // 
            // deleteProjectBtn
            // 
            this.deleteProjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteProjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteProjectBtn.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProjectBtn.Location = new System.Drawing.Point(807, 481);
            this.deleteProjectBtn.Name = "deleteProjectBtn";
            this.deleteProjectBtn.Size = new System.Drawing.Size(165, 35);
            this.deleteProjectBtn.TabIndex = 26;
            this.deleteProjectBtn.Text = "DELETE PROJECT";
            this.deleteProjectBtn.UseVisualStyleBackColor = false;
            this.deleteProjectBtn.Click += new System.EventHandler(this.deleteProjectBtn_Click);
            // 
            // editProjectBtn
            // 
            this.editProjectBtn.BackColor = System.Drawing.Color.Transparent;
            this.editProjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editProjectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProjectBtn.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProjectBtn.Location = new System.Drawing.Point(670, 481);
            this.editProjectBtn.Name = "editProjectBtn";
            this.editProjectBtn.Size = new System.Drawing.Size(131, 35);
            this.editProjectBtn.TabIndex = 25;
            this.editProjectBtn.Text = "EDIT PROJECT";
            this.editProjectBtn.UseVisualStyleBackColor = false;
            this.editProjectBtn.Click += new System.EventHandler(this.editProjectBtn_Click);
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelChangesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelChangesButton.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelChangesButton.Location = new System.Drawing.Point(807, 266);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(165, 34);
            this.CancelChangesButton.TabIndex = 29;
            this.CancelChangesButton.Text = "CANCEL CHANGES";
            this.CancelChangesButton.UseVisualStyleBackColor = false;
            this.CancelChangesButton.Click += new System.EventHandler(this.CancelChangesButton_Click);
            // 
            // CreateProjectButton
            // 
            this.CreateProjectButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateProjectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateProjectButton.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProjectButton.Location = new System.Drawing.Point(422, 266);
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
            this.projectsNameLabel.Font = new System.Drawing.Font("TypoSlabserif-Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectsNameLabel.Location = new System.Drawing.Point(266, 164);
            this.projectsNameLabel.Name = "projectsNameLabel";
            this.projectsNameLabel.Size = new System.Drawing.Size(115, 21);
            this.projectsNameLabel.TabIndex = 30;
            this.projectsNameLabel.Text = "Project Name";
            // 
            // projectLocationLabel
            // 
            this.projectLocationLabel.AutoSize = true;
            this.projectLocationLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectLocationLabel.Font = new System.Drawing.Font("TypoSlabserif-Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLocationLabel.Location = new System.Drawing.Point(266, 197);
            this.projectLocationLabel.Name = "projectLocationLabel";
            this.projectLocationLabel.Size = new System.Drawing.Size(136, 21);
            this.projectLocationLabel.TabIndex = 31;
            this.projectLocationLabel.Text = "Project Location";
            // 
            // projectStatusLabel
            // 
            this.projectStatusLabel.AutoSize = true;
            this.projectStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectStatusLabel.Font = new System.Drawing.Font("TypoSlabserif-Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectStatusLabel.Location = new System.Drawing.Point(266, 231);
            this.projectStatusLabel.Name = "projectStatusLabel";
            this.projectStatusLabel.Size = new System.Drawing.Size(117, 21);
            this.projectStatusLabel.TabIndex = 32;
            this.projectStatusLabel.Text = "Project Status";
            // 
            // Projects_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
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
    }
}