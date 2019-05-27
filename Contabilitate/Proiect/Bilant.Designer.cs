namespace Contabilitate.Proiect
{
    partial class Bilant
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
            this.codrand = new System.Windows.Forms.TextBox();
            this.denindic = new System.Windows.Forms.TextBox();
            this.sold = new System.Windows.Forms.TextBox();
            this.soldsf = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1206, 185);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(600, 246);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 46);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "Bilant";
            // 
            // nrcrt
            // 
            this.nrcrt.Location = new System.Drawing.Point(36, 350);
            this.nrcrt.Margin = new System.Windows.Forms.Padding(4);
            this.nrcrt.Name = "nrcrt";
            this.nrcrt.Size = new System.Drawing.Size(281, 22);
            this.nrcrt.TabIndex = 53;
            this.nrcrt.Text = "NrCrt";
            // 
            // codrand
            // 
            this.codrand.Location = new System.Drawing.Point(508, 350);
            this.codrand.Margin = new System.Windows.Forms.Padding(4);
            this.codrand.Name = "codrand";
            this.codrand.Size = new System.Drawing.Size(281, 22);
            this.codrand.TabIndex = 54;
            this.codrand.Text = "Cod rand.";
            // 
            // denindic
            // 
            this.denindic.Location = new System.Drawing.Point(36, 407);
            this.denindic.Margin = new System.Windows.Forms.Padding(4);
            this.denindic.Name = "denindic";
            this.denindic.Size = new System.Drawing.Size(281, 22);
            this.denindic.TabIndex = 55;
            this.denindic.Text = "Denumirea indicatorilor";
            // 
            // sold
            // 
            this.sold.Location = new System.Drawing.Point(508, 407);
            this.sold.Margin = new System.Windows.Forms.Padding(4);
            this.sold.Name = "sold";
            this.sold.Size = new System.Drawing.Size(281, 22);
            this.sold.TabIndex = 56;
            this.sold.Text = "Sold la inceputul anului";
            // 
            // soldsf
            // 
            this.soldsf.Location = new System.Drawing.Point(901, 350);
            this.soldsf.Margin = new System.Windows.Forms.Padding(4);
            this.soldsf.Name = "soldsf";
            this.soldsf.Size = new System.Drawing.Size(281, 22);
            this.soldsf.TabIndex = 57;
            this.soldsf.Text = "Sold la sfarsitul anului";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(837, 647);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton1.TabIndex = 62;
            this.materialRaisedButton1.Text = "Salvare";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(1049, 647);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton2.TabIndex = 63;
            this.materialRaisedButton2.Text = "Raport";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Bilant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.soldsf);
            this.Controls.Add(this.sold);
            this.Controls.Add(this.denindic);
            this.Controls.Add(this.codrand);
            this.Controls.Add(this.nrcrt);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bilant";
            this.Size = new System.Drawing.Size(1214, 804);
            this.Load += new System.EventHandler(this.Bilant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox nrcrt;
        private System.Windows.Forms.TextBox codrand;
        private System.Windows.Forms.TextBox denindic;
        private System.Windows.Forms.TextBox sold;
        private System.Windows.Forms.TextBox soldsf;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}
