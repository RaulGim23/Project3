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
    public partial class Registrucasa : UserControl
    {
        private static Registrucasa _instance;
        public static Registrucasa Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Registrucasa();
                return _instance;

            }
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");


        public Registrucasa()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Registrucasa] (NrCrt, Nractcasa, Nranexa, Explicatia, Incasari, Plati, Simbolcont, Simbolcontcorespondent) values( " + nrcrt.Text + "," + nract.Text + ","+nranexa.Text+",'" + explicatia.Text + "'," + incasari.Text + "," + plati.Text + "," + cont.Text + "," +simbolcont.Text+" )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();
            nrcrt.Text = "";
            nract.Text = "";

            explicatia.Text = "";
            incasari.Text = "";
            plati.Text = "";
            cont.Text = "";
            simbolcont.Text = "";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();
        }
        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Registrucasa]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Registrucasa_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Regcasa I = new Regcasa();
            I.Show();
        }
    }
}
