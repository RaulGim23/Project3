using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilitate.Proiect
{
    public partial class NRCDRap : Form
    {
        public NRCDRap()
        {
            InitializeComponent();
        }

        private void NRCDRap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetfinal.unitate' table. You can move, or remove it, as needed.
            this.unitateTableAdapter.Fill(this.datasetfinal.unitate);
            // TODO: This line of code loads data into the 'datasetfinal.NRCD' table. You can move, or remove it, as needed.
            this.nRCDTableAdapter.Fill(this.datasetfinal.NRCD);

            this.reportViewer1.RefreshReport();
        }
    }
}
