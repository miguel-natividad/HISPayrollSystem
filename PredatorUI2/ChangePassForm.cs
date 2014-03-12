using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PredatorUI2
{
    public partial class ChangePassForm : Form
    {
        string username = "";
        string password = "";
        public ChangePassForm()
        {
            InitializeComponent();
            
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public string UserName
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            if (passwordTB.Text == password && userNameTB.Text == username)
            {
                Settings_User_Management parent = (Settings_User_Management)this.Owner;
                parent.passBack(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input correct username and password!");
                passwordTB.Clear();
            }
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {
            this.userNameTB.Text = username;
            this.userNameTB.Enabled = false;
        }
    }
}
