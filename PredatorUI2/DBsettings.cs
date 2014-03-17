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
    public partial class DBsettings : Form
    {
        public static String dbname;
        public static String dbuser;
        public static String dbpass;
        public static String dbserver;

        public DBsettings()
        {
            InitializeComponent();
            dbname = tb_dbname.Text;
            dbuser = tb_user.Text;
            dbpass = tb_pass.Text;
            dbserver = tb_server.Text;
        }


        private void DBsettings_Load(object sender, EventArgs e)
        {

        }

        public void b_ok_Click(object sender, EventArgs e)
        {
            dbname = tb_dbname.Text;
            dbuser = tb_user.Text;
            dbpass = tb_pass.Text;
            dbserver = tb_server.Text;

            this.Close();
        }

        /*
        public String DBname
        {
            get
            {
                return dbname;
            }
            set
            {
                dbname = value;
            }
        }
        public String DBuser
        {
            get
            {
                return dbuser;
            }
            set
            {
                dbuser = value;
            }
        }
        public String DBpass
        {
            get
            {
                return dbpass;
            }
            set
            {
                dbpass = value;
            }
        }
        public String DBserver
        {
            get
            {
                return dbserver;
            }
            set
            {
                dbserver = value;
            }
        }
          */
    }
}
