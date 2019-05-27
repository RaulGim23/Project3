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
    public partial class FactRep : Form
    {
        public FactRep()
        {
            InitializeComponent();
        }

        private void FactRep_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetfinal.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter1.Fill(this.datasetfinal.Clienti);
            // TODO: This line of code loads data into the 'datasetfinal.Facturi' table. You can move, or remove it, as needed.
            this.facturiTableAdapter1.Fill(this.datasetfinal.Facturi);
            // TODO: This line of code loads data into the 'bazadatecontabilitateDataSet8.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.bazadatecontabilitateDataSet8.Clienti);
            // TODO: This line of code loads data into the 'facturi._Facturi' table. You can move, or remove it, as needed.
            this.facturiTableAdapter.Fill(this.facturi._Facturi);


            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void FacturiBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void facturiBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
