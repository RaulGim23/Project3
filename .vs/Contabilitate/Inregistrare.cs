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
using System.Security.Cryptography;

namespace Contabilitate
{
    public partial class Inregistrare : Form
    {
        OleDbConnection conn = new OleDbConnection(ConfigurationManager.AppSettings["Con"]);
        public Inregistrare()
        {
            InitializeComponent();
        }

        
    

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {   
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [utilizatori] (nume, parola) values('" + user.Text + "','" + pass.Text + "'         )", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Login L = new Login();
            L.Show();
            this.Hide();

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
           
        }

       // public string GetMD5(string text)
       // {
       //     MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider;
       //     md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
       //     byte[] result=md5.Hash;
       //     StringBuilder str = new StringBuilder();
      //      for (int i=1; i<result.Length; i++)
      //      {
      //          str.Append(result[i].ToString("x2"));

       //     }
       //     return str.ToString();
       // }
    }
}
