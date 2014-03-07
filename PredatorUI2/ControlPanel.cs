﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PredatorUI2
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
            DateTime currtime = DateTime.Now;
            timeLabel.Text = currtime.ToString();
        }

        private void projectsBtn_Click(object sender, EventArgs e)
        {
            Projects_Panel projectsPanel = new Projects_Panel();
            projectsPanel.Show();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {
            Employee_Panel employeesPanel = new Employee_Panel();
            employeesPanel.Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Settings_User_Management settings = new Settings_User_Management();
            settings.Show();
        }
    }
}
