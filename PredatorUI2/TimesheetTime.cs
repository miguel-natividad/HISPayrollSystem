using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Import;

namespace PredatorUI2
{
    public partial class TimesheetTime : Form
    {
        public TimesheetTime()
        {
            InitializeComponent();
        }

        private void TimesheetTime_Load(object sender, EventArgs e)
        {
            Import.Form1 a = new Form1();
            a.ShowDialog();
        }
    }
}
