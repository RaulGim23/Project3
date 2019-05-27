namespace Contabilitate.Proiect
{
    partial class Management
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
            this.contract = new System.Windows.Forms.TextBox();
            this.preluare = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.inregistrare = new System.Windows.Forms.TextBox();
            this.obtinere = new System.Windows.Forms.TextBox();
            this.depunere = new System.Windows.Forms.TextBox();
            this.facturare = new System.Windows.Forms.TextBox();
            this.datori = new System.Windows.Forms.TextBox();
            this.incasare = new System.Windows.Forms.TextBox();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // contract
            // 
            this.contract.Location = new System.Drawing.Point(86, 239);
            this.contract.Name = "contract";
            this.contract.Size = new System.Drawing.Size(100, 20);
            this.contract.TabIndex = 2;
            // 
            // preluare
            // 
            this.preluare.Location = new System.Drawing.Point(429, 239);
            this.preluare.Name = "preluare";
            this.preluare.Size = new System.Drawing.Size(100, 20);
            this.preluare.TabIndex = 3;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(255, 239);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(100, 20);
            this.data.TabIndex = 4;
            // 
            // inregistrare
            // 
            this.inregistrare.Location = new System.Drawing.Point(605, 239);
            this.inregistrare.Name = "inregistrare";
            this.inregistrare.Size = new System.Drawing.Size(100, 20);
            this.inregistrare.TabIndex = 5;
            // 
            // obtinere
            // 
            this.obtinere.Location = new System.Drawing.Point(771, 239);
            this.obtinere.Name = "obtinere";
            this.obtinere.Size = new System.Drawing.Size(100, 20);
            this.obtinere.TabIndex = 6;
            // 
            // depunere
            // 
            this.depunere.Location = new System.Drawing.Point(946, 239);
            this.depunere.Name = "depunere";
            this.depunere.Size = new System.Drawing.Size(100, 20);
            this.depunere.TabIndex = 7;
            // 
            // facturare
            // 
            this.facturare.Location = new System.Drawing.Point(255, 333);
            this.facturare.Name = "facturare";
            this.facturare.Size = new System.Drawing.Size(100, 20);
            this.facturare.TabIndex = 8;
            // 
            // datori
            // 
            this.datori.Location = new System.Drawing.Point(605, 342);
            this.datori.Name = "datori";
            this.datori.Size = new System.Drawing.Size(100, 20);
            this.datori.TabIndex = 9;
            // 
            // incasare
            // 
            this.incasare.Location = new System.Drawing.Point(429, 342);
            this.incasare.Name = "incasare";
            this.incasare.Size = new System.Drawing.Size(100, 20);
            this.incasare.TabIndex = 10;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(938, 568);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(108, 38);
            this.materialRaisedButton1.TabIndex = 63;
            this.materialRaisedButton1.Text = "Salvare";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.incasare);
            this.Controls.Add(this.datori);
            this.Controls.Add(this.facturare);
            this.Controls.Add(this.depunere);
            this.Controls.Add(this.obtinere);
            this.Controls.Add(this.inregistrare);
            this.Controls.Add(this.data);
            this.Controls.Add(this.preluare);
            this.Controls.Add(this.contract);
            this.Name = "Management";
            this.Size = new System.Drawing.Size(1214, 804);
            this.Load += new System.EventHandler(this.Management_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox contract;
        private System.Windows.Forms.TextBox preluare;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox inregistrare;
        private System.Windows.Forms.TextBox obtinere;
        private System.Windows.Forms.TextBox depunere;
        private System.Windows.Forms.TextBox facturare;
        private System.Windows.Forms.TextBox datori;
        private System.Windows.Forms.TextBox incasare;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}
