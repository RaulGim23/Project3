namespace Contabilitate.Proiect
{
    partial class Factura
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
            this.seria = new System.Windows.Forms.TextBox();
            this.um = new System.Windows.Forms.TextBox();
            this.denumire = new System.Windows.Forms.TextBox();
            this.nrcrt = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.numar = new System.Windows.Forms.TextBox();
            this.cantitate = new System.Windows.Forms.TextBox();
            this.pretunitar = new System.Windows.Forms.TextBox();
            this.valoareron = new System.Windows.Forms.TextBox();
            this.valoaretva = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 159);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(564, 221);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(130, 46);
            this.bunifuCustomLabel1.TabIndex = 57;
            this.bunifuCustomLabel1.Text = "Factura";
            // 
            // seria
            // 
            this.seria.Location = new System.Drawing.Point(20, 372);
            this.seria.Margin = new System.Windows.Forms.Padding(4);
            this.seria.Name = "seria";
            this.seria.Size = new System.Drawing.Size(192, 22);
            this.seria.TabIndex = 58;
            this.seria.Text = "Seria";
            // 
            // um
            // 
            this.um.Location = new System.Drawing.Point(546, 505);
            this.um.Margin = new System.Windows.Forms.Padding(4);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(192, 22);
            this.um.TabIndex = 59;
            this.um.Text = "Unitate de masura";
            // 
            // denumire
            // 
            this.denumire.Location = new System.Drawing.Point(546, 438);
            this.denumire.Margin = new System.Windows.Forms.Padding(4);
            this.denumire.Name = "denumire";
            this.denumire.Size = new System.Drawing.Size(192, 22);
            this.denumire.TabIndex = 60;
            this.denumire.Text = "Denumire";
            // 
            // nrcrt
            // 
            this.nrcrt.Location = new System.Drawing.Point(546, 372);
            this.nrcrt.Margin = new System.Windows.Forms.Padding(4);
            this.nrcrt.Name = "nrcrt";
            this.nrcrt.Size = new System.Drawing.Size(192, 22);
            this.nrcrt.TabIndex = 61;
            this.nrcrt.Text = "Nr. Crt. ";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(20, 505);
            this.data.Margin = new System.Windows.Forms.Padding(4);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(192, 22);
            this.data.TabIndex = 62;
            this.data.Text = "Data";
            // 
            // numar
            // 
            this.numar.Location = new System.Drawing.Point(20, 438);
            this.numar.Margin = new System.Windows.Forms.Padding(4);
            this.numar.Name = "numar";
            this.numar.Size = new System.Drawing.Size(192, 22);
            this.numar.TabIndex = 63;
            this.numar.Text = "Numar";
            // 
            // cantitate
            // 
            this.cantitate.Location = new System.Drawing.Point(546, 572);
            this.cantitate.Margin = new System.Windows.Forms.Padding(4);
            this.cantitate.Name = "cantitate";
            this.cantitate.Size = new System.Drawing.Size(192, 22);
            this.cantitate.TabIndex = 64;
            this.cantitate.Text = "Cantitate";
            // 
            // pretunitar
            // 
            this.pretunitar.Location = new System.Drawing.Point(1005, 372);
            this.pretunitar.Margin = new System.Windows.Forms.Padding(4);
            this.pretunitar.Name = "pretunitar";
            this.pretunitar.Size = new System.Drawing.Size(192, 22);
            this.pretunitar.TabIndex = 65;
            this.pretunitar.Text = "Pret Unitar";
            // 
            // valoareron
            // 
            this.valoareron.Location = new System.Drawing.Point(1005, 438);
            this.valoareron.Margin = new System.Windows.Forms.Padding(4);
            this.valoareron.Name = "valoareron";
            this.valoareron.Size = new System.Drawing.Size(192, 22);
            this.valoareron.TabIndex = 66;
            this.valoareron.Text = "Valoare RON";
            // 
            // valoaretva
            // 
            this.valoaretva.Location = new System.Drawing.Point(1005, 505);
            this.valoaretva.Margin = new System.Windows.Forms.Padding(4);
            this.valoaretva.Name = "valoaretva";
            this.valoaretva.Size = new System.Drawing.Size(192, 22);
            this.valoaretva.TabIndex = 67;
            this.valoaretva.Text = "Valoare TVA";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(843, 730);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton1.TabIndex = 68;
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
            this.materialRaisedButton2.TabIndex = 69;
            this.materialRaisedButton2.Text = "Raport";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.valoaretva);
            this.Controls.Add(this.valoareron);
            this.Controls.Add(this.pretunitar);
            this.Controls.Add(this.cantitate);
            this.Controls.Add(this.numar);
            this.Controls.Add(this.data);
            this.Controls.Add(this.nrcrt);
            this.Controls.Add(this.denumire);
            this.Controls.Add(this.um);
            this.Controls.Add(this.seria);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Factura";
            this.Size = new System.Drawing.Size(1214, 804);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox seria;
        private System.Windows.Forms.TextBox um;
        private System.Windows.Forms.TextBox denumire;
        private System.Windows.Forms.TextBox nrcrt;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox numar;
        private System.Windows.Forms.TextBox cantitate;
        private System.Windows.Forms.TextBox pretunitar;
        private System.Windows.Forms.TextBox valoareron;
        private System.Windows.Forms.TextBox valoaretva;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}
