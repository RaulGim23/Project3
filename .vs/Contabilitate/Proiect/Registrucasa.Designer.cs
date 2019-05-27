namespace Contabilitate.Proiect
{
    partial class Registrucasa
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrcrt = new System.Windows.Forms.TextBox();
            this.nract = new System.Windows.Forms.TextBox();
            this.explicatia = new System.Windows.Forms.TextBox();
            this.nranexa = new System.Windows.Forms.TextBox();
            this.incasari = new System.Windows.Forms.TextBox();
            this.simbolcont = new System.Windows.Forms.TextBox();
            this.cont = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.plati = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 185);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nrcrt
            // 
            this.nrcrt.Location = new System.Drawing.Point(4, 345);
            this.nrcrt.Margin = new System.Windows.Forms.Padding(4);
            this.nrcrt.Name = "nrcrt";
            this.nrcrt.Size = new System.Drawing.Size(281, 22);
            this.nrcrt.TabIndex = 48;
            this.nrcrt.Text = "Nr. Crt.";
            // 
            // nract
            // 
            this.nract.Location = new System.Drawing.Point(4, 423);
            this.nract.Margin = new System.Windows.Forms.Padding(4);
            this.nract.Name = "nract";
            this.nract.Size = new System.Drawing.Size(281, 22);
            this.nract.TabIndex = 49;
            this.nract.Text = "Nr. act. casa";
            // 
            // explicatia
            // 
            this.explicatia.Location = new System.Drawing.Point(458, 345);
            this.explicatia.Margin = new System.Windows.Forms.Padding(4);
            this.explicatia.Name = "explicatia";
            this.explicatia.Size = new System.Drawing.Size(281, 22);
            this.explicatia.TabIndex = 50;
            this.explicatia.Text = "Explicatia";
            // 
            // nranexa
            // 
            this.nranexa.Location = new System.Drawing.Point(4, 503);
            this.nranexa.Margin = new System.Windows.Forms.Padding(4);
            this.nranexa.Name = "nranexa";
            this.nranexa.Size = new System.Drawing.Size(281, 22);
            this.nranexa.TabIndex = 51;
            this.nranexa.Text = "Nr. anexa";
            // 
            // incasari
            // 
            this.incasari.Location = new System.Drawing.Point(458, 423);
            this.incasari.Margin = new System.Windows.Forms.Padding(4);
            this.incasari.Name = "incasari";
            this.incasari.Size = new System.Drawing.Size(281, 22);
            this.incasari.TabIndex = 52;
            this.incasari.Text = "Incasari";
            // 
            // simbolcont
            // 
            this.simbolcont.Location = new System.Drawing.Point(929, 423);
            this.simbolcont.Margin = new System.Windows.Forms.Padding(4);
            this.simbolcont.Name = "simbolcont";
            this.simbolcont.Size = new System.Drawing.Size(281, 22);
            this.simbolcont.TabIndex = 54;
            this.simbolcont.Text = "Simbol cont corespondent";
            // 
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(929, 345);
            this.cont.Margin = new System.Windows.Forms.Padding(4);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(281, 22);
            this.cont.TabIndex = 56;
            this.cont.Text = "Contul";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(450, 238);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(263, 46);
            this.bunifuCustomLabel2.TabIndex = 58;
            this.bunifuCustomLabel2.Text = "Registru de casa";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(824, 730);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton1.TabIndex = 59;
            this.materialRaisedButton1.Text = "Salvare";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(1053, 730);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton2.TabIndex = 60;
            this.materialRaisedButton2.Text = "Raport";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // plati
            // 
            this.plati.Location = new System.Drawing.Point(458, 503);
            this.plati.Margin = new System.Windows.Forms.Padding(4);
            this.plati.Name = "plati";
            this.plati.Size = new System.Drawing.Size(281, 22);
            this.plati.TabIndex = 61;
            this.plati.Text = "Plati";
            // 
            // Registrucasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plati);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.simbolcont);
            this.Controls.Add(this.incasari);
            this.Controls.Add(this.nranexa);
            this.Controls.Add(this.explicatia);
            this.Controls.Add(this.nract);
            this.Controls.Add(this.nrcrt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Registrucasa";
            this.Size = new System.Drawing.Size(1214, 804);
            this.Load += new System.EventHandler(this.Registrucasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nrcrt;
        private System.Windows.Forms.TextBox nract;
        private System.Windows.Forms.TextBox explicatia;
        private System.Windows.Forms.TextBox nranexa;
        private System.Windows.Forms.TextBox incasari;
        private System.Windows.Forms.TextBox simbolcont;
        private System.Windows.Forms.TextBox cont;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.TextBox plati;
    }
}
