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
    public partial class Registrubanca : UserControl
    {
        private static Registrubanca _instance;
        public static Registrubanca Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Registrubanca();
                return _instance;

            }
        }

        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");

        public Registrubanca()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrubanca_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Registrubanca] (NrCrt, Data, Nrdocument, Explicatii, Incasari, Plati, Sold, Contcorespondent, Soldziuaprecedenta, Totalcont) values( " + nrcrt.Text + ",'" + data.Text + "'," + nrdocument.Text + ",'" + explicatii.Text + "'," + Incasari.Text + "," + plati.Text + "," + sold.Text + "," + contcoresp.Text + "," + soldziuaprec.Text + ", " + totalcont.Text + " )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();
            nrcrt.Text = "";
            nrdocument.Text = "";

            explicatii.Text = "";
            Incasari.Text = "";
            plati.Text = "";
            sold.Text = "";
            contcoresp.Text = "";
            soldziuaprec.Text = "";
            totalcont.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();

        }
        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Registrubanca]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Regbanca I = new Regbanca();
            I.Show();
        }
    }
}
