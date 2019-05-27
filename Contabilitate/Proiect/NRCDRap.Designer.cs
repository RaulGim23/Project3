namespace Contabilitate.Proiect
{
    partial class NRCDRap
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
            this.nRCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetfinal = new Contabilitate.datasetfinal();
            this.unitateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nRCDTableAdapter = new Contabilitate.datasetfinalTableAdapters.NRCDTableAdapter();
            this.unitateTableAdapter = new Contabilitate.datasetfinalTableAdapters.unitateTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.nRCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nRCDBindingSource
            // 
            this.nRCDBindingSource.DataMember = "NRCD";
            this.nRCDBindingSource.DataSource = this.datasetfinal;
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
            // nRCDTableAdapter
            // 
            this.nRCDTableAdapter.ClearBeforeFill = true;
            // 
            // unitateTableAdapter
            // 
            this.unitateTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.nRCDBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.unitateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Contabilitate.Proiect.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1026, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // NRCDRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "NRCDRap";
            this.Text = "NRCDRap";
            this.Load += new System.EventHandler(this.NRCDRap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nRCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private datasetfinal datasetfinal;
        private System.Windows.Forms.BindingSource nRCDBindingSource;
        private datasetfinalTableAdapters.NRCDTableAdapter nRCDTableAdapter;
        private System.Windows.Forms.BindingSource unitateBindingSource;
        private datasetfinalTableAdapters.unitateTableAdapter unitateTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}