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
    public partial class UserControl2 : UserControl
    {
        private static UserControl2 _instance;
        public static UserControl2 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl2();
                return _instance;

            }
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");

        public UserControl2()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Registruinventar] (NrCrt, Recapitulare, Valoarecontabila, Valoaredeinventar, Valoarea, Cauzelediferentelor) values( " + nrcrt.Text + ",'" + recapelem.Text + "'," + valcontabila.Text + "," + valinventar.Text + ", " + valoarea.Text + ", '" + cauzeledif.Text + "' )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();
        }

        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [Registruinventar]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Reginventar I = new Reginventar();
            I.Show();
        }
    }
}
