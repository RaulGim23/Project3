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
    public partial class fisecontrep : Form
    {
        public fisecontrep()
        {
            InitializeComponent();
        }

        private void fisecontrep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetfinal.fisecont' table. You can move, or remove it, as needed.
            this.fisecontTableAdapter1.Fill(this.datasetfinal.fisecont);
            // TODO: This line of code loads data into the 'bazadatecontabilitateDataSet8.fisecont' table. You can move, or remove it, as needed.
            this.fisecontTableAdapter.Fill(this.bazadatecontabilitateDataSet8.fisecont);

            this.reportViewer1.RefreshReport();
        }
    }
}
