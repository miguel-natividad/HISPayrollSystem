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

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordTB.Text == password)
            {
                Settings_User_Management parent = (Settings_User_Management)this.Owner;
                parent.passBack(true);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please input correct password!");
                passwordTB.Clear();
            }
        }
    }
}
