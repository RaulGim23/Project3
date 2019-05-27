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
namespace Contabilitate.Proiect
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\raul\source\repos\Contabilitate\Contabilitate\bazadatecontabilitate.accdb");
        
        
           
             

    public Form1()
        {
            InitializeComponent();
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {   
            OleDbDataAdapter da = new OleDbDataAdapter("insert into [Management] (Contract, Data, Preluare, Inregistrare, Obtinere, Depunere, Facturare, Incasare, Dator) values( " + contract.Text + ", '" + date.Text + "',"+checkboxevent1 +"," + checkboxevent2 + "," + checkboxevent3 + "," + checkboxevent4 + "," + checkboxevent5 + " ," + checkboxevent6 + "," + checkboxevent7 + ")", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            contract.Text = "";
            
        }

        int checkboxevent1;
        int checkboxevent2;
        int checkboxevent3;
        int checkboxevent4;
        int checkboxevent5;
        int checkboxevent6;
        int checkboxevent7;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkBox1.Checked)
                checkboxevent1 = -1;
            else
                checkboxevent1 = 0;



        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkboxevent2 = -1;
            else
                checkboxevent2 = 0;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                checkboxevent3 = -1;
            else
                checkboxevent3 = 0;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkboxevent4 = -1;
            else
                checkboxevent4 = 0;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkboxevent5= -1;
            else
                checkboxevent5 = 0;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkboxevent6 = -1;
            else
                checkboxevent6 = 0;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkboxevent7 = -1;
            else
                checkboxevent7 = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 C = new Form2();
            C.Show();
        }
    }
}
