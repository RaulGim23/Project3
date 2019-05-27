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
    public partial class Reginventar : Form
    {
        public Reginventar()
        {
            InitializeComponent();
        }

        private void Reginventar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetfinal.unitate' table. You can move, or remove it, as needed.
            this.unitateTableAdapter.Fill(this.datasetfinal.unitate);
            // TODO: This line of code loads data into the 'datasetfinal.Registruinventar' table. You can move, or remove it, as needed.
            this.registruinventarTableAdapter.Fill(this.datasetfinal.Registruinventar);

            this.reportViewer1.RefreshReport();
        }
    }
}
