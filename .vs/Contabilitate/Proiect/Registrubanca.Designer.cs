namespace Contabilitate.Proiect
{
    partial class Registrubanca
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nrcrt = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.explicatii = new System.Windows.Forms.TextBox();
            this.nrdocument = new System.Windows.Forms.TextBox();
            this.Incasari = new System.Windows.Forms.TextBox();
            this.totalcont = new System.Windows.Forms.TextBox();
            this.plati = new System.Windows.Forms.TextBox();
            this.soldziuaprec = new System.Windows.Forms.TextBox();
            this.contcoresp = new System.Windows.Forms.TextBox();
            this.sold = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.dataGridView1.Size = new System.Drawing.Size(1206, 185);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(448, 216);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(288, 46);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Registru de banca";
            // 
            // nrcrt
            // 
            this.nrcrt.Location = new System.Drawing.Point(31, 334);
            this.nrcrt.Margin = new System.Windows.Forms.Padding(4);
            this.nrcrt.Name = "nrcrt";
            this.nrcrt.Size = new System.Drawing.Size(281, 22);
            this.nrcrt.TabIndex = 51;
            this.nrcrt.Text = "Nr. Crt.";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(31, 410);
            this.data.Margin = new System.Windows.Forms.Padding(4);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(281, 22);
            this.data.TabIndex = 52;
            this.data.Text = "Data";
            // 
            // explicatii
            // 
            this.explicatii.Location = new System.Drawing.Point(455, 334);
            this.explicatii.Margin = new System.Windows.Forms.Padding(4);
            this.explicatii.Name = "explicatii";
            this.explicatii.Size = new System.Drawing.Size(281, 22);
            this.explicatii.TabIndex = 53;
            this.explicatii.Text = "Explicatii";
            // 
            // nrdocument
            // 
            this.nrdocument.Location = new System.Drawing.Point(31, 495);
            this.nrdocument.Margin = new System.Windows.Forms.Padding(4);
            this.nrdocument.Name = "nrdocument";
            this.nrdocument.Size = new System.Drawing.Size(281, 22);
            this.nrdocument.TabIndex = 54;
            this.nrdocument.Text = "Numar document";
            // 
            // Incasari
            // 
            this.Incasari.Location = new System.Drawing.Point(455, 410);
            this.Incasari.Margin = new System.Windows.Forms.Padding(4);
            this.Incasari.Name = "Incasari";
            this.Incasari.Size = new System.Drawing.Size(281, 22);
            this.Incasari.TabIndex = 55;
            this.Incasari.Text = "Incasari";
            // 
            // totalcont
            // 
            this.totalcont.Location = new System.Drawing.Point(859, 495);
            this.totalcont.Margin = new System.Windows.Forms.Padding(4);
            this.totalcont.Name = "totalcont";
            this.totalcont.Size = new System.Drawing.Size(281, 22);
            this.totalcont.TabIndex = 56;
            this.totalcont.Text = "Total cont";
            this.totalcont.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // plati
            // 
            this.plati.Location = new System.Drawing.Point(455, 495);
            this.plati.Margin = new System.Windows.Forms.Padding(4);
            this.plati.Name = "plati";
            this.plati.Size = new System.Drawing.Size(281, 22);
            this.plati.TabIndex = 57;
            this.plati.Text = "Plati";
            // 
            // soldziuaprec
            // 
            this.soldziuaprec.Location = new System.Drawing.Point(859, 410);
            this.soldziuaprec.Margin = new System.Windows.Forms.Padding(4);
            this.soldziuaprec.Name = "soldziuaprec";
            this.soldziuaprec.Size = new System.Drawing.Size(281, 22);
            this.soldziuaprec.TabIndex = 58;
            this.soldziuaprec.Text = "Sold ziua precedenta";
            // 
            // contcoresp
            // 
            this.contcoresp.Location = new System.Drawing.Point(859, 334);
            this.contcoresp.Margin = new System.Windows.Forms.Padding(4);
            this.contcoresp.Name = "contcoresp";
            this.contcoresp.Size = new System.Drawing.Size(281, 22);
            this.contcoresp.TabIndex = 59;
            this.contcoresp.Text = "Cont corespondent";
            // 
            // sold
            // 
            this.sold.Location = new System.Drawing.Point(455, 573);
            this.sold.Margin = new System.Windows.Forms.Padding(4);
            this.sold.Name = "sold";
            this.sold.Size = new System.Drawing.Size(281, 22);
            this.sold.TabIndex = 60;
            this.sold.Text = "Sold";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(794, 657);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton1.TabIndex = 61;
            this.materialRaisedButton1.Text = "Salvare";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(992, 657);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton2.TabIndex = 62;
            this.materialRaisedButton2.Text = "Raport";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Registrubanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.sold);
            this.Controls.Add(this.contcoresp);
            this.Controls.Add(this.soldziuaprec);
            this.Controls.Add(this.plati);
            this.Controls.Add(this.totalcont);
            this.Controls.Add(this.Incasari);
            this.Controls.Add(this.nrdocument);
            this.Controls.Add(this.explicatii);
            this.Controls.Add(this.data);
            this.Controls.Add(this.nrcrt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrubanca";
            this.Size = new System.Drawing.Size(1214, 804);
            this.Load += new System.EventHandler(this.Registrubanca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox nrcrt;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox explicatii;
        private System.Windows.Forms.TextBox nrdocument;
        private System.Windows.Forms.TextBox Incasari;
        private System.Windows.Forms.TextBox totalcont;
        private System.Windows.Forms.TextBox plati;
        private System.Windows.Forms.TextBox soldziuaprec;
        private System.Windows.Forms.TextBox contcoresp;
        private System.Windows.Forms.TextBox sold;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}
