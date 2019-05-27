namespace Contabilitate.Proiect
{
    partial class UserControl2
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
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.nrcrt = new System.Windows.Forms.TextBox();
            this.recapelem = new System.Windows.Forms.TextBox();
            this.valcontabila = new System.Windows.Forms.TextBox();
            this.valinventar = new System.Windows.Forms.TextBox();
            this.valoarea = new System.Windows.Forms.TextBox();
            this.cauzeledif = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(1210, 185);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(476, 229);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(273, 46);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Registru inventar";
            // 
            // nrcrt
            // 
            this.nrcrt.Location = new System.Drawing.Point(28, 337);
            this.nrcrt.Margin = new System.Windows.Forms.Padding(4);
            this.nrcrt.Name = "nrcrt";
            this.nrcrt.Size = new System.Drawing.Size(281, 22);
            this.nrcrt.TabIndex = 48;
            this.nrcrt.Text = "Nr. Crt.";
            // 
            // recapelem
            // 
            this.recapelem.Location = new System.Drawing.Point(28, 399);
            this.recapelem.Margin = new System.Windows.Forms.Padding(4);
            this.recapelem.Name = "recapelem";
            this.recapelem.Size = new System.Drawing.Size(281, 22);
            this.recapelem.TabIndex = 49;
            this.recapelem.Text = "Recapitularea elementelor inventariate";
            // 
            // valcontabila
            // 
            this.valcontabila.Location = new System.Drawing.Point(484, 337);
            this.valcontabila.Margin = new System.Windows.Forms.Padding(4);
            this.valcontabila.Name = "valcontabila";
            this.valcontabila.Size = new System.Drawing.Size(281, 22);
            this.valcontabila.TabIndex = 50;
            this.valcontabila.Text = "Valoarea contabila";
            // 
            // valinventar
            // 
            this.valinventar.Location = new System.Drawing.Point(484, 399);
            this.valinventar.Margin = new System.Windows.Forms.Padding(4);
            this.valinventar.Name = "valinventar";
            this.valinventar.Size = new System.Drawing.Size(281, 22);
            this.valinventar.TabIndex = 51;
            this.valinventar.Text = "Valoarea de inventar";
            // 
            // valoarea
            // 
            this.valoarea.Location = new System.Drawing.Point(889, 337);
            this.valoarea.Margin = new System.Windows.Forms.Padding(4);
            this.valoarea.Name = "valoarea";
            this.valoarea.Size = new System.Drawing.Size(281, 22);
            this.valoarea.TabIndex = 52;
            this.valoarea.Text = "Valoarea";
            // 
            // cauzeledif
            // 
            this.cauzeledif.Location = new System.Drawing.Point(889, 399);
            this.cauzeledif.Margin = new System.Windows.Forms.Padding(4);
            this.cauzeledif.Name = "cauzeledif";
            this.cauzeledif.Size = new System.Drawing.Size(281, 22);
            this.cauzeledif.TabIndex = 53;
            this.cauzeledif.Text = "Cauzele diferentelor";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(823, 730);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton1.TabIndex = 54;
            this.materialRaisedButton1.Text = "Salvare";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(1026, 730);
            this.materialRaisedButton2.Margin = new System.Windows.Forms.Padding(4);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(144, 47);
            this.materialRaisedButton2.TabIndex = 55;
            this.materialRaisedButton2.Text = "Raport";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.cauzeledif);
            this.Controls.Add(this.valoarea);
            this.Controls.Add(this.valinventar);
            this.Controls.Add(this.valcontabila);
            this.Controls.Add(this.recapelem);
            this.Controls.Add(this.nrcrt);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1214, 804);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox nrcrt;
        private System.Windows.Forms.TextBox recapelem;
        private System.Windows.Forms.TextBox valcontabila;
        private System.Windows.Forms.TextBox valinventar;
        private System.Windows.Forms.TextBox valoarea;
        private System.Windows.Forms.TextBox cauzeledif;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
    }
}
