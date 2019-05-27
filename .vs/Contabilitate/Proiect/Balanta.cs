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
    public partial class Balanta : UserControl
    {
        private static Balanta _instance;
        public static Balanta Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Balanta();
                return _instance;

            }
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");

        public Balanta()
        {
            InitializeComponent();
        }

        private void Balanta_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Balanta] (Cont, Denumireacontului, Sumedebitoare, Sumecreditoare, Rulajedebitoare, Rulajecreditoare, Sumetotaledebit, Sumetotalecredit, Solduridebitoare, Solduricreditoare) values( " + cont.Text + ",'" + denumire.Text + "'," + sumedebit.Text + "," + sumecredit.Text + "," + rulajedebit.Text + ", " + rulajecreditoare.Text + ", " +Sy+ ", " + sumetotalecredit + ", " +solduridebit+ ", " +solduricreditoare+" )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();
            
        }

        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Balanta]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }


        private void Sy_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();
        }

        private void rulajecreditoare_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            BalantaRap I = new BalantaRap();
            I.Show();
        }
    }
}
