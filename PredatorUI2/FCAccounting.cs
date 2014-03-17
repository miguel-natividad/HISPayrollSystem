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
    public partial class FCAccounting : Form
    {
        public FCAccounting()
        {
            InitializeComponent();
        }

        private void FCAccounting_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
