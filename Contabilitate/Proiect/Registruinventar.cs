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
    public partial class Registruinventar : UserControl
    {
        private static Registruinventar _instance;
        public static Registruinventar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Registruinventar();
                return _instance;

            }
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");

        public Registruinventar()
        {
            InitializeComponent();
        }

        private void Registruinventar_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();
        }

        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [NRCD]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [NRCD] (NrCrt, Denumirebunuri, UM, Cantitatecnfdoc, Cantitrecept, Pretintrare, Valoare) values( " + nrcrt.Text + ",'" + denumire.Text + "'," + UM.Text + "," + cantitate.Text + ", " + cantitrecept.Text + "," + pret.Text + ", "+ valoare.Text+" )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();
            

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void valoare_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            NRCDRap r = new NRCDRap();
            r.Show();
        }
    }
}
