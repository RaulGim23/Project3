namespace Contabilitate.Proiect
{
    partial class Registrujurnal
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
            this.simboldebitor = new System.Windows.Forms.TextBox();
            this.explica = new System.Windows.Forms.TextBox();
            this.simbolcreditor = new System.Windows.Forms.TextBox();
            this.datainregistrarii = new System.Windows.Forms.TextBox();
            this.sumacreditoare = new System.Windows.Forms.TextBox();
            this.documentul = new System.Windows.Forms.TextBox();
            this.sumadebitoare = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            this.dataGridView1.Size = new System.Drawing.Size(1229, 185);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nrcrt
            // 
            this.nrcrt.Location = new System.Drawing.Point(33, 366);
            this.nrcrt.Margin = new System.Windows.Forms.Padding(4);
            this.nrcrt.Name = "nrcrt";
            this.nrcrt.Size = new System.Drawing.Size(127, 22);
            this.nrcrt.TabIndex = 48;
            this.nrcrt.Text = "Nr. Crt.";
            // 
            // simboldebitor
            // 
            this.simboldebitor.Location = new System.Drawing.Point(33, 450);
            this.simboldebitor.Margin = new System.Windows.Forms.Padding(4);
            this.simboldebitor.Name = "simboldebitor";
            this.simboldebitor.Size = new System.Drawing.Size(127, 22);
            this.simboldebitor.TabIndex = 49;
            this.simboldebitor.Text = "Simbol debitor";
            // 
            // explica
            // 
            this.explica.Location = new System.Drawing.Point(1055, 366);
            this.explica.Margin = new System.Windows.Forms.Padding(4);
            this.explica.Name = "explica";
            this.explica.Size = new System.Drawing.Size(136, 22);
            this.explica.TabIndex = 50;
            this.explica.Text = "Explicatii";
            // 
            // simbolcreditor
            // 
            this.simbolcreditor.Location = new System.Drawing.Point(332, 450);
            this.simbolcreditor.Margin = new System.Windows.Forms.Padding(4);
            this.simbolcreditor.Name = "simbolcreditor";
            this.simbolcreditor.Size = new System.Drawing.Size(150, 22);
            this.simbolcreditor.TabIndex = 51;
            this.simbolcreditor.Text = "Simbol creditor";
            // 
            // datainregistrarii
            // 
            this.datainregistrarii.Location = new System.Drawing.Point(332, 366);
            this.datainregistrarii.Margin = new System.Windows.Forms.Padding(4);
            this.datainregistrarii.Name = "datainregistrarii";
            this.datainregistrarii.Size = new System.Drawing.Size(150, 22);
            this.datainregistrarii.TabIndex = 52;
            this.datainregistrarii.Text = "Data inregistrarii";
            // 
            // sumacreditoare
            // 
            this.sumacreditoare.Location = new System.Drawing.Point(1055, 450);
            this.sumacreditoare.Margin = new System.Windows.Forms.Padding(4);
            this.sumacreditoare.Name = "sumacreditoare";
            this.sumacreditoare.Size = new System.Drawing.Size(136, 22);
            this.sumacreditoare.TabIndex = 53;
            this.sumacreditoare.Text = "Suma creditoare";
            // 
            // documentul
            // 
            this.documentul.Location = new System.Drawing.Point(702, 366);
            this.documentul.Margin = new System.Windows.Forms.Padding(4);
            this.documentul.Name = "documentul";
            this.documentul.Size = new System.Drawing.Size(154, 22);
            this.documentul.TabIndex = 54;
            this.documentul.Text = "Documentul";
            // 
            // sumadebitoare
            // 
            this.sumadebitoare.Location = new System.Drawing.Point(702, 450);
            this.sumadebitoare.Margin = new System.Windows.Forms.Padding(4);
            this.sumadebitoare.Name = "sumadebitoare";
            this.sumadebitoare.Size = new System.Drawing.Size(154, 22);
            this.sumadebitoare.TabIndex = 55;
            this.sumadebitoare.Text = "Suma debitoare";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(476, 238);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(235, 46);
            this.bunifuCustomLabel1.TabIndex = 56;
            this.bunifuCustomLabel1.Text = "Registru jurnal";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(817, 732);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton1.TabIndex = 57;
            this.materialRaisedButton1.Text = "Salvare";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(1055, 732);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton2.TabIndex = 58;
            this.materialRaisedButton2.Text = "Raport";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // Registrujurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.sumadebitoare);
            this.Controls.Add(this.documentul);
            this.Controls.Add(this.sumacreditoare);
            this.Controls.Add(this.datainregistrarii);
            this.Controls.Add(this.simbolcreditor);
            this.Controls.Add(this.explica);
            this.Controls.Add(this.simboldebitor);
            this.Controls.Add(this.nrcrt);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registrujurnal";
            this.Size = new System.Drawing.Size(1214, 804);
            this.Load += new System.EventHandler(this.Registruinventar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nrcrt;
        private System.Windows.Forms.TextBox simboldebitor;
        private System.Windows.Forms.TextBox explica;
        private System.Windows.Forms.TextBox simbolcreditor;
        private System.Windows.Forms.TextBox datainregistrarii;
        private System.Windows.Forms.TextBox sumacreditoare;
        private System.Windows.Forms.TextBox documentul;
        private System.Windows.Forms.TextBox sumadebitoare;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}
