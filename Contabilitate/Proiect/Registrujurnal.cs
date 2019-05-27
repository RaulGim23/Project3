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
    public partial class Registrujurnal : UserControl
    {
        private static Registrujurnal _instance;
        public static Registrujurnal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Registrujurnal();
                return _instance;

            }
        }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");

        public Registrujurnal()
        {
            InitializeComponent();
        }

        private void Registruinventar_Load(object sender, EventArgs e)
        {

        }

        private void salvare_Click(object sender, EventArgs e)
        {

        }

        private void suma_crd_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void suma_db_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void raport1_Click(object sender, EventArgs e)
        {

        }

        private void explic_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void simbol_credit_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void simbol_debit_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void documentul_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void NrCrtext_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Datainreg_OnValueChanged(object sender, EventArgs e)
        {

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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Registrujurnal] (NrCrt, Datainreg, Documentul, Explicatii, Simboldebitor, Simbolcreditor, Sumadebitoare, Sumacreditoare) values( " + nrcrt.Text + ",'" + datainregistrarii.Text + "','" + documentul.Text + "','" + explica.Text + "'," + simboldebitor.Text + "," + simbolcreditor.Text + "," + sumadebitoare.Text + "," + sumacreditoare.Text + ")", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();

            nrcrt.Text = "";
            datainregistrarii.Text = "";

            documentul.Text = "";
            explica.Text = "";
            simboldebitor.Text = "";
            simbolcreditor.Text = "";
            sumadebitoare.Text = "";
            sumacreditoare.Text = "";
        }

        private void nrcd1_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Regjurnal I = new Regjurnal();
            I.Show();
        }
    }
}
