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
    public partial class fisacont : UserControl { 
        private static fisacont _instance;
    public static fisacont Instance
    {
        get
        {
            if (_instance == null)
                _instance = new fisacont();
            return _instance;

        }
    }
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");

        public fisacont()
        {
            InitializeComponent();
        }

        private void valoare_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void fisacont_Load(object sender, EventArgs e)
        {

        }

        private void salvare_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [fisecont] (Simbol_cont, Data, Felul_documentului, Numarul_documentului, Explicatii, Simbol_cont_coresp, Debit, Credit, Sold) values('" + simbolcont.Text + "','" + Data.Text + "','" + feluldocumentului.Text + "'," + nrdocument.Text + ",'" + Explicatii.Text + "'," + Simbolcontcoresp.Text + "," + Debit.Text + ", " + Credit.Text + ", " + sold.Text + " )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ViewData();
            simbolcont.Text = "";
            Data.Text = "";

            feluldocumentului.Text = "";
            nrdocument.Text = "";
            Explicatii.Text = "";
            Debit.Text = "";
            Simbolcontcoresp.Text = "";
            Credit.Text = "";
            sold.Text = "";
            
        }

        void ViewData()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [fisecont]", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewData();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            fisecontrep fc = new fisecontrep();
            fc.Show();
        }
    }
} 