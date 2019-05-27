using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contabilitate.Proiect
{
    public partial class Report3 : Form
    {   private static Report3 _instance;
        public static Report3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Report3();
                return _instance;

            }
        }
        public Report3()
        {
            InitializeComponent();
            
            
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Factura.Instance))
            {
                panel1.Controls.Add(Factura.Instance);
                Factura.Instance.BringToFront();
            }
            else Factura.Instance.BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(fisacont.Instance))
            {
                panel1.Controls.Add(fisacont.Instance);
                fisacont.Instance.BringToFront();
            } else fisacont.Instance.BringToFront();

        }

        private void factura1_Load(object sender, EventArgs e)
        {

        }

        private void NRCD_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Registruinventar.Instance))
            {
                panel1.Controls.Add(Registruinventar.Instance);
                Registruinventar.Instance.BringToFront();
            }
            else Registruinventar.Instance.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl2.Instance))
            {
                panel1.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.BringToFront();
            }
            else UserControl2.Instance.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Registrujurnal.Instance))
            {
                panel1.Controls.Add(Registrujurnal.Instance);
                Registrujurnal.Instance.BringToFront();
            }
            else Registrujurnal.Instance.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Registrucasa.Instance))
            {
                panel1.Controls.Add(Registrucasa.Instance);
                Registrucasa.Instance.BringToFront();
            }
            else Registrucasa.Instance.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Registrubanca.Instance))
            {
                panel1.Controls.Add(Registrubanca.Instance);
                Registrubanca.Instance.BringToFront();
            }
            else Registrubanca.Instance.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (!panel1.Controls.Contains(Balanta.Instance))
            {
                panel1.Controls.Add(Balanta.Instance);
                Balanta.Instance.BringToFront();
            }
            else Balanta.Instance.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Management.Instance))
            {
                panel1.Controls.Add(Management.Instance);
                Management.Instance.BringToFront();
            }
            else Management.Instance.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://C:\\Users\\raul\\Desktop\\CHMfiles\\manual.chm");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
        }
    }
}
