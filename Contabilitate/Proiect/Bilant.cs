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
    public partial class Bilant : UserControl
    {
        private static Bilant _instance;
        public static Bilant Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Bilant();
                return _instance;

            }
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");
        
        public Bilant()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox9_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Bilant_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Bilant] (NrCrt, Denumireaindicatorilor, Codrand, Soldinceputulanului, Soldlasfperioadei) values( " + nrcrt.Text + ", '" + denindic.Text + "'," + codrand.Text + "," + sold.Text + "," + soldsf.Text + " )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();

            nrcrt.Text = "";
            denindic.Text = "";
            codrand.Text = "";
            sold.Text = "";
            soldsf.Text = "";

        }
        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Bilant]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            BilantRap I = new BilantRap();
            I.Show();
        }
    }
}
