using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Contabilitate.Proiect
{
    public partial class Factura : UserControl
    {
        private static Factura _instance;
        public static Factura Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Factura();
                return _instance;

            }
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");


        public Factura()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Facturi] (Seria, Numar, Data, NrCrt, Denumire, UnitateMasura, Cantitate, PretUnitar, ValoareRON, ValoareTVA) values( '" + seria.Text + "'," + numar.Text + ",'" + data.Text + "'," + nrcrt.Text + ",'" + denumire.Text + "','" + um.Text + "'," + cantitate.Text + "," + pretunitar.Text + "," + valoareron.Text + "," + valoaretva.Text + ")", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();

            seria.Text = "";
            numar.Text = "";
            data.Text = "";
            nrcrt.Text = "";
            denumire.Text = "";
            um.Text = "";
            cantitate.Text = "";
            pretunitar.Text = "";
            valoareron.Text = "";
            valoaretva.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();
        }
        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Registrujurnal]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            FactRep fr = new FactRep();
            fr.Show();
        }
    }
}
