namespace Contabilitate.Proiect
{
    partial class Balanta
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
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cont = new System.Windows.Forms.TextBox();
            this.denumire = new System.Windows.Forms.TextBox();
            this.sumedebit = new System.Windows.Forms.TextBox();
            this.sumecredit = new System.Windows.Forms.TextBox();
            this.solduridebit = new System.Windows.Forms.TextBox();
            this.sumetotalecredit = new System.Windows.Forms.TextBox();
            this.rulajedebit = new System.Windows.Forms.TextBox();
            this.rulajecreditoare = new System.Windows.Forms.TextBox();
            this.Sy = new System.Windows.Forms.TextBox();
            this.solduricreditoare = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(565, 292);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(129, 46);
            this.bunifuCustomLabel1.TabIndex = 22;
            this.bunifuCustomLabel1.Text = "Balanta";
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
            this.dataGridView1.Size = new System.Drawing.Size(1212, 185);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cont
            // 
            this.cont.Location = new System.Drawing.Point(25, 361);
            this.cont.Margin = new System.Windows.Forms.Padding(4);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(281, 22);
            this.cont.TabIndex = 51;
            this.cont.Text = "Cont";
            // 
            // denumire
            // 
            this.denumire.Location = new System.Drawing.Point(25, 430);
            this.denumire.Margin = new System.Windows.Forms.Padding(4);
            this.denumire.Name = "denumire";
            this.denumire.Size = new System.Drawing.Size(281, 22);
            this.denumire.TabIndex = 52;
            this.denumire.Text = "Denumirea contului";
            // 
            // sumedebit
            // 
            this.sumedebit.Location = new System.Drawing.Point(25, 505);
            this.sumedebit.Margin = new System.Windows.Forms.Padding(4);
            this.sumedebit.Name = "sumedebit";
            this.sumedebit.Size = new System.Drawing.Size(281, 22);
            this.sumedebit.TabIndex = 53;
            this.sumedebit.Text = "Sume debitoare";
            // 
            // sumecredit
            // 
            this.sumecredit.Location = new System.Drawing.Point(482, 361);
            this.sumecredit.Margin = new System.Windows.Forms.Padding(4);
            this.sumecredit.Name = "sumecredit";
            this.sumecredit.Size = new System.Drawing.Size(281, 22);
            this.sumecredit.TabIndex = 54;
            this.sumecredit.Text = "Sume creditoare";
            // 
            // solduridebit
            // 
            this.solduridebit.Location = new System.Drawing.Point(929, 430);
            this.solduridebit.Margin = new System.Windows.Forms.Padding(4);
            this.solduridebit.Name = "solduridebit";
            this.solduridebit.Size = new System.Drawing.Size(281, 22);
            this.solduridebit.TabIndex = 55;
            this.solduridebit.Text = "Solduri debitoare";
            // 
            // sumetotalecredit
            // 
            this.sumetotalecredit.Location = new System.Drawing.Point(929, 361);
            this.sumetotalecredit.Margin = new System.Windows.Forms.Padding(4);
            this.sumetotalecredit.Name = "sumetotalecredit";
            this.sumetotalecredit.Size = new System.Drawing.Size(281, 22);
            this.sumetotalecredit.TabIndex = 56;
            this.sumetotalecredit.Text = "Sume totale credit";
            // 
            // rulajedebit
            // 
            this.rulajedebit.Location = new System.Drawing.Point(482, 430);
            this.rulajedebit.Margin = new System.Windows.Forms.Padding(4);
            this.rulajedebit.Name = "rulajedebit";
            this.rulajedebit.Size = new System.Drawing.Size(281, 22);
            this.rulajedebit.TabIndex = 57;
            this.rulajedebit.Text = "Rulaje debitoare";
            // 
            // rulajecreditoare
            // 
            this.rulajecreditoare.Location = new System.Drawing.Point(482, 505);
            this.rulajecreditoare.Margin = new System.Windows.Forms.Padding(4);
            this.rulajecreditoare.Name = "rulajecreditoare";
            this.rulajecreditoare.Size = new System.Drawing.Size(281, 22);
            this.rulajecreditoare.TabIndex = 58;
            this.rulajecreditoare.Text = "Rulaje creditoare";
            this.rulajecreditoare.TextChanged += new System.EventHandler(this.rulajecreditoare_TextChanged);
            // 
            // Sy
            // 
            this.Sy.Location = new System.Drawing.Point(482, 579);
            this.Sy.Margin = new System.Windows.Forms.Padding(4);
            this.Sy.Name = "Sy";
            this.Sy.Size = new System.Drawing.Size(281, 22);
            this.Sy.TabIndex = 59;
            this.Sy.Text = "Sume totale debit";
            this.Sy.TextChanged += new System.EventHandler(this.Sy_TextChanged);
            // 
            // solduricreditoare
            // 
            this.solduricreditoare.Location = new System.Drawing.Point(929, 505);
            this.solduricreditoare.Margin = new System.Windows.Forms.Padding(4);
            this.solduricreditoare.Name = "solduricreditoare";
            this.solduricreditoare.Size = new System.Drawing.Size(281, 22);
            this.solduricreditoare.TabIndex = 60;
            this.solduricreditoare.Text = "Solduri creditoare";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(832, 718);
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
            this.materialRaisedButton2.Location = new System.Drawing.Point(1066, 718);
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
            // Balanta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.solduricreditoare);
            this.Controls.Add(this.Sy);
            this.Controls.Add(this.rulajecreditoare);
            this.Controls.Add(this.rulajedebit);
            this.Controls.Add(this.sumetotalecredit);
            this.Controls.Add(this.solduridebit);
            this.Controls.Add(this.sumecredit);
            this.Controls.Add(this.sumedebit);
            this.Controls.Add(this.denumire);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Balanta";
            this.Size = new System.Drawing.Size(1216, 804);
            this.Load += new System.EventHandler(this.Balanta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cont;
        private System.Windows.Forms.TextBox denumire;
        private System.Windows.Forms.TextBox sumedebit;
        private System.Windows.Forms.TextBox sumecredit;
        private System.Windows.Forms.TextBox solduridebit;
        private System.Windows.Forms.TextBox sumetotalecredit;
        private System.Windows.Forms.TextBox rulajedebit;
        private System.Windows.Forms.TextBox rulajecreditoare;
        private System.Windows.Forms.TextBox Sy;
        private System.Windows.Forms.TextBox solduricreditoare;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}
