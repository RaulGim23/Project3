using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilitate
{
    public partial class Regbanca : Form
    {
        public Regbanca()
        {
            InitializeComponent();
        }

        private void Regbanca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'datasetfinal.Registrubanca' table. You can move, or remove it, as needed.
            this.RegistrubancaTableAdapter.Fill(this.datasetfinal.Registrubanca);
            // TODO: This line of code loads data into the 'datasetfinal.unitate' table. You can move, or remove it, as needed.
            this.unitateTableAdapter.Fill(this.datasetfinal.unitate);

            this.reportViewer1.RefreshReport();
        }
    }
}
