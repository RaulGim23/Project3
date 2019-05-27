namespace Contabilitate.Proiect
{
    partial class FactRep
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.facturiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturi = new Contabilitate.Facturi();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadatecontabilitateDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadatecontabilitateDataSet8 = new Contabilitate.bazadatecontabilitateDataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturiTableAdapter = new Contabilitate.FacturiTableAdapters.FacturiTableAdapter();
            this.clientiTableAdapter = new Contabilitate.bazadatecontabilitateDataSet8TableAdapters.ClientiTableAdapter();
            this.datasetfinal = new Contabilitate.datasetfinal();
            this.facturiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.facturiTableAdapter1 = new Contabilitate.datasetfinalTableAdapters.FacturiTableAdapter();
            this.clientiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter1 = new Contabilitate.datasetfinalTableAdapters.ClientiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadatecontabilitateDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadatecontabilitateDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // facturiBindingSource1
            // 
            this.facturiBindingSource1.DataMember = "Facturi";
            this.facturiBindingSource1.DataSource = this.facturiBindingSource;
            // 
            // facturiBindingSource
            // 
            this.facturiBindingSource.DataSource = this.facturi;
            this.facturiBindingSource.Position = 0;
            this.facturiBindingSource.CurrentChanged += new System.EventHandler(this.facturiBindingSource_CurrentChanged_1);
            // 
            // facturi
            // 
            this.facturi.DataSetName = "Facturi";
            this.facturi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.bazadatecontabilitateDataSet8BindingSource;
            // 
            // bazadatecontabilitateDataSet8BindingSource
            // 
            this.bazadatecontabilitateDataSet8BindingSource.DataSource = this.bazadatecontabilitateDataSet8;
            this.bazadatecontabilitateDataSet8BindingSource.Position = 0;
            // 
            // bazadatecontabilitateDataSet8
            // 
            this.bazadatecontabilitateDataSet8.DataSetName = "bazadatecontabilitateDataSet8";
            this.bazadatecontabilitateDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.facturiBindingSource2;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.clientiBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Contabilitate.Proiect.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1084, 508);
            this.reportViewer1.TabIndex = 0;
            // 
            // facturiTableAdapter
            // 
            this.facturiTableAdapter.ClearBeforeFill = true;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // datasetfinal
            // 
            this.datasetfinal.DataSetName = "datasetfinal";
            this.datasetfinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturiBindingSource2
            // 
            this.facturiBindingSource2.DataMember = "Facturi";
            this.facturiBindingSource2.DataSource = this.datasetfinal;
            // 
            // facturiTableAdapter1
            // 
            this.facturiTableAdapter1.ClearBeforeFill = true;
            // 
            // clientiBindingSource1
            // 
            this.clientiBindingSource1.DataMember = "Clienti";
            this.clientiBindingSource1.DataSource = this.datasetfinal;
            // 
            // clientiTableAdapter1
            // 
            this.clientiTableAdapter1.ClearBeforeFill = true;
            // 
            // FactRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 508);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FactRep";
            this.Text = "FactRep";
            this.Load += new System.EventHandler(this.FactRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadatecontabilitateDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadatecontabilitateDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource facturiBindingSource;
        private Facturi facturi;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource facturiBindingSource1;
        private FacturiTableAdapters.FacturiTableAdapter facturiTableAdapter;
        private System.Windows.Forms.BindingSource bazadatecontabilitateDataSet8BindingSource;
        private bazadatecontabilitateDataSet8 bazadatecontabilitateDataSet8;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private bazadatecontabilitateDataSet8TableAdapters.ClientiTableAdapter clientiTableAdapter;
        private datasetfinal datasetfinal;
        private System.Windows.Forms.BindingSource facturiBindingSource2;
        private datasetfinalTableAdapters.FacturiTableAdapter facturiTableAdapter1;
        private System.Windows.Forms.BindingSource clientiBindingSource1;
        private datasetfinalTableAdapters.ClientiTableAdapter clientiTableAdapter1;
    }
}