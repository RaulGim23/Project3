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
    public partial class Management : UserControl
    {
        private static Management _instance;
        public static Management Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Management();
                return _instance;

            }
        }
        public Management()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Management] (Contract, Data) values( " + contract.Text + ", " + data.Text + "," + preluare.Text + "," + inregistrare.Text + "," + obtinere.Text + "," + depunere.Text + "," + facturare.Text + " ," + incasare.Text + "," + datori.Text + ")", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void Management_Load(object sender, EventArgs e)
        {

        }
    }
}
