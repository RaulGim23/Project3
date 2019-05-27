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
    public partial class BilantRap : Form
    {
        public BilantRap()
        {
            InitializeComponent();
        }

        private void BilantRap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetfinal.Bilant' table. You can move, or remove it, as needed.
            this.bilantTableAdapter.Fill(this.datasetfinal.Bilant);

            this.reportViewer1.RefreshReport();
        }
    }
}
