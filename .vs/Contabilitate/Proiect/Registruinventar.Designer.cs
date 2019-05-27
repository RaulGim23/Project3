namespace Contabilitate.Proiect
{
    partial class Registruinventar
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.nrcrt = new System.Windows.Forms.TextBox();
            this.cantitate = new System.Windows.Forms.TextBox();
            this.denumire = new System.Windows.Forms.TextBox();
            this.cantitrecept = new System.Windows.Forms.TextBox();
            this.UM = new System.Windows.Forms.TextBox();
            this.valoare = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pret = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1210, 185);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(811, 716);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton1.TabIndex = 44;
            this.materialRaisedButton1.Text = "Salvare";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(1017, 716);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton2.TabIndex = 45;
            this.materialRaisedButton2.Text = "Raport";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // nrcrt
            // 
            this.nrcrt.Location = new System.Drawing.Point(37, 358);
            this.nrcrt.Margin = new System.Windows.Forms.Padding(4);
            this.nrcrt.Name = "nrcrt";
            this.nrcrt.Size = new System.Drawing.Size(281, 22);
            this.nrcrt.TabIndex = 47;
            this.nrcrt.Text = "Nr. Crt.";
            // 
            // cantitate
            // 
            this.cantitate.Location = new System.Drawing.Point(439, 443);
            this.cantitate.Margin = new System.Windows.Forms.Padding(4);
            this.cantitate.Name = "cantitate";
            this.cantitate.Size = new System.Drawing.Size(277, 22);
            this.cantitate.TabIndex = 48;
            this.cantitate.Text = "Cantitate conform documente";
            // 
            // denumire
            // 
            this.denumire.Location = new System.Drawing.Point(37, 443);
            this.denumire.Margin = new System.Windows.Forms.Padding(4);
            this.denumire.Name = "denumire";
            this.denumire.Size = new System.Drawing.Size(277, 22);
            this.denumire.TabIndex = 49;
            this.denumire.Text = "Denumire bunuri";
            // 
            // cantitrecept
            // 
            this.cantitrecept.Location = new System.Drawing.Point(439, 524);
            this.cantitrecept.Margin = new System.Windows.Forms.Padding(4);
            this.cantitrecept.Name = "cantitrecept";
            this.cantitrecept.Size = new System.Drawing.Size(277, 22);
            this.cantitrecept.TabIndex = 50;
            this.cantitrecept.Text = "Cantitate receptionata";
            // 
            // UM
            // 
            this.UM.Location = new System.Drawing.Point(439, 358);
            this.UM.Margin = new System.Windows.Forms.Padding(4);
            this.UM.Name = "UM";
            this.UM.Size = new System.Drawing.Size(277, 22);
            this.UM.TabIndex = 51;
            this.UM.Text = "Unitate de masura";
            this.UM.TextChanged += new System.EventHandler(this.valoare_TextChanged);
            // 
            // valoare
            // 
            this.valoare.Location = new System.Drawing.Point(861, 443);
            this.valoare.Margin = new System.Windows.Forms.Padding(4);
            this.valoare.Name = "valoare";
            this.valoare.Size = new System.Drawing.Size(300, 22);
            this.valoare.TabIndex = 52;
            this.valoare.Text = "Valoare";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(336, 244);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(557, 46);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Nota receptie si constatari diferente";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // pret
            // 
            this.pret.Location = new System.Drawing.Point(861, 358);
            this.pret.Margin = new System.Windows.Forms.Padding(4);
            this.pret.Name = "pret";
            this.pret.Size = new System.Drawing.Size(300, 22);
            this.pret.TabIndex = 53;
            this.pret.Text = "Pret intrare";
            // 
            // Registruinventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pret);
            this.Controls.Add(this.valoare);
            this.Controls.Add(this.UM);
            this.Controls.Add(this.cantitrecept);
            this.Controls.Add(this.denumire);
            this.Controls.Add(this.cantitate);
            this.Controls.Add(this.nrcrt);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registruinventar";
            this.Size = new System.Drawing.Size(1214, 804);
            this.Load += new System.EventHandler(this.Registruinventar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.TextBox nrcrt;
        private System.Windows.Forms.TextBox cantitate;
        private System.Windows.Forms.TextBox denumire;
        private System.Windows.Forms.TextBox cantitrecept;
        private System.Windows.Forms.TextBox UM;
        private System.Windows.Forms.TextBox valoare;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox pret;
    }
}
