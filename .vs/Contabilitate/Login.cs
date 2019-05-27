using Contabilitate.Proiect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Configuration;

namespace Contabilitate
{
    public partial class Login : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);

       

        public Login()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Inregistrare I = new Inregistrare();
            I.Show();
            this.Hide();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            OleDbDataAdapter da = new OleDbDataAdapter("Select * from [utilizatori] where [nume] ='" + txtuser.Text + "' and [parola]='" + txtpass.Text + "' ", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Report3 R = new Report3();
                R.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(this, "Wrong User Name and Password !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
