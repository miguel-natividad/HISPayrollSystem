namespace PredatorUI2
{
    partial class DBsettings
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
            this.l_server = new System.Windows.Forms.Label();
            this.l_user = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.l_dbname = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_dbname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // l_server
            // 
            this.l_server.AutoSize = true;
            this.l_server.Location = new System.Drawing.Point(29, 44);
            this.l_server.Name = "l_server";
            this.l_server.Size = new System.Drawing.Size(63, 13);
            this.l_server.TabIndex = 0;
            this.l_server.Text = "Host Server";
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Location = new System.Drawing.Point(32, 87);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(55, 13);
            this.l_user.TabIndex = 1;
            this.l_user.Text = "Username";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Location = new System.Drawing.Point(32, 137);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(53, 13);
            this.l_password.TabIndex = 2;
            this.l_password.Text = "Password";
            // 
            // l_dbname
            // 
            this.l_dbname.AutoSize = true;
            this.l_dbname.Location = new System.Drawing.Point(32, 187);
            this.l_dbname.Name = "l_dbname";
            this.l_dbname.Size = new System.Drawing.Size(84, 13);
            this.l_dbname.TabIndex = 3;
            this.l_dbname.Text = "Database Name";
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(176, 44);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(100, 20);
            this.tb_server.TabIndex = 4;
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(176, 79);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 20);
            this.tb_user.TabIndex = 5;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(176, 129);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 6;
            // 
            // tb_dbname
            // 
            this.tb_dbname.Location = new System.Drawing.Point(176, 179);
            this.tb_dbname.Name = "tb_dbname";
            this.tb_dbname.Size = new System.Drawing.Size(100, 20);
            this.tb_dbname.TabIndex = 7;
            // 
            // DBsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 262);
            this.Controls.Add(this.tb_dbname);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.l_dbname);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_user);
            this.Controls.Add(this.l_server);
            this.Name = "DBsettings";
            this.Text = "DBsettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_server;
        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.Label l_dbname;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_dbname;
    }
}