namespace Contabilitate.Proiect
{
    partial class BalantaRap
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.registrubancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetfinal = new Contabilitate.datasetfinal();
            this.unitateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.registrubancaTableAdapter = new Contabilitate.datasetfinalTableAdapters.RegistrubancaTableAdapter();
            this.balantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balantaTableAdapter = new Contabilitate.datasetfinalTableAdapters.BalantaTableAdapter();
            this.balantaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.registrubancaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // registrubancaBindingSource
            // 
            this.registrubancaBindingSource.DataMember = "Registrubanca";
            this.registrubancaBindingSource.DataSource = this.datasetfinal;
            // 
            // datasetfinal
            // 
            this.datasetfinal.DataSetName = "datasetfinal";
            this.datasetfinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitateBindingSource
            // 
            this.unitateBindingSource.DataMember = "unitate";
            this.unitateBindingSource.DataSource = this.datasetfinal;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.balantaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Contabilitate.Proiect.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(867, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // registrubancaTableAdapter
            // 
            this.registrubancaTableAdapter.ClearBeforeFill = true;
            // 
            // balantaBindingSource
            // 
            this.balantaBindingSource.DataMember = "Balanta";
            this.balantaBindingSource.DataSource = this.datasetfinal;
            // 
            // balantaTableAdapter
            // 
            this.balantaTableAdapter.ClearBeforeFill = true;
            // 
            // balantaBindingSource1
            // 
            this.balantaBindingSource1.DataMember = "Balanta";
            this.balantaBindingSource1.DataSource = this.datasetfinal;
            // 
            // BalantaRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BalantaRap";
            this.Text = "BalantaRap";
            this.Load += new System.EventHandler(this.BalantaRap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrubancaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private datasetfinal datasetfinal;
        private System.Windows.Forms.BindingSource registrubancaBindingSource;
        private datasetfinalTableAdapters.RegistrubancaTableAdapter registrubancaTableAdapter;
        private System.Windows.Forms.BindingSource balantaBindingSource;
        private datasetfinalTableAdapters.BalantaTableAdapter balantaTableAdapter;
        private System.Windows.Forms.BindingSource unitateBindingSource;
        private System.Windows.Forms.BindingSource balantaBindingSource1;
    }
}