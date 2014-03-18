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
            
            // TODO: This line of code loads data into the 'his_payrollDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.his_payrollDataSet.DataTable1);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
