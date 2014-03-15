namespace PredatorUI2
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.LogInButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UsernameLabelImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameLabelImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogInButton.BackgroundImage")));
            this.LogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Location = new System.Drawing.Point(498, 432);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(100, 30);
            this.LogInButton.TabIndex = 0;
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(654, 432);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 30);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UsernameLabelImage
            // 
            this.UsernameLabelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsernameLabelImage.Image = ((System.Drawing.Image)(resources.GetObject("UsernameLabelImage.Image")));
            this.UsernameLabelImage.Location = new System.Drawing.Point(447, 268);
            this.UsernameLabelImage.Name = "UsernameLabelImage";
            this.UsernameLabelImage.Size = new System.Drawing.Size(120, 30);
            this.UsernameLabelImage.TabIndex = 2;
            this.UsernameLabelImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(447, 334);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 30);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.Color.DimGray;
            this.UserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.ForeColor = System.Drawing.Color.White;
            this.UserNameTextBox.Location = new System.Drawing.Point(573, 271);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(230, 30);
            this.UserNameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.DimGray;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.Location = new System.Drawing.Point(573, 334);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(230, 30);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameLabelImage);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogInButton);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.UsernameLabelImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox UsernameLabelImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button button1;

    }
}

