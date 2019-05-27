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
    public partial class BalantaRap : Form
    {
        public BalantaRap()
        {
            InitializeComponent();
        }

        private void BalantaRap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetfinal.Balanta' table. You can move, or remove it, as needed.
            this.balantaTableAdapter.Fill(this.datasetfinal.Balanta);
            // TODO: This line of code loads data into the 'datasetfinal.Registrubanca' table. You can move, or remove it, as needed.
            this.registrubancaTableAdapter.Fill(this.datasetfinal.Registrubanca);

            this.reportViewer1.RefreshReport();
        }
    }
}
