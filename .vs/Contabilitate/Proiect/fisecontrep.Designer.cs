namespace Contabilitate.Proiect
{
    partial class fisecontrep
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
            this.fisecontBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadatecontabilitateDataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazadatecontabilitateDataSet8 = new Contabilitate.bazadatecontabilitateDataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fisecontTableAdapter = new Contabilitate.bazadatecontabilitateDataSet8TableAdapters.fisecontTableAdapter();
            this.datasetfinal = new Contabilitate.datasetfinal();
            this.fisecontBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fisecontTableAdapter1 = new Contabilitate.datasetfinalTableAdapters.fisecontTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fisecontBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadatecontabilitateDataSet8BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadatecontabilitateDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisecontBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // fisecontBindingSource
            // 
            this.fisecontBindingSource.DataMember = "fisecont";
            this.fisecontBindingSource.DataSource = this.bazadatecontabilitateDataSet8BindingSource;
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
            reportDataSource1.Value = this.fisecontBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Contabilitate.Proiect.fisecont.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // fisecontTableAdapter
            // 
            this.fisecontTableAdapter.ClearBeforeFill = true;
            // 
            // datasetfinal
            // 
            this.datasetfinal.DataSetName = "datasetfinal";
            this.datasetfinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fisecontBindingSource1
            // 
            this.fisecontBindingSource1.DataMember = "fisecont";
            this.fisecontBindingSource1.DataSource = this.datasetfinal;
            // 
            // fisecontTableAdapter1
            // 
            this.fisecontTableAdapter1.ClearBeforeFill = true;
            // 
            // fisecontrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "fisecontrep";
            this.Text = "fisecontrep";
            this.Load += new System.EventHandler(this.fisecontrep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fisecontBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadatecontabilitateDataSet8BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazadatecontabilitateDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fisecontBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private bazadatecontabilitateDataSet8 bazadatecontabilitateDataSet8;
        private System.Windows.Forms.BindingSource bazadatecontabilitateDataSet8BindingSource;
        private System.Windows.Forms.BindingSource fisecontBindingSource;
        private bazadatecontabilitateDataSet8TableAdapters.fisecontTableAdapter fisecontTableAdapter;
        private datasetfinal datasetfinal;
        private System.Windows.Forms.BindingSource fisecontBindingSource1;
        private datasetfinalTableAdapters.fisecontTableAdapter fisecontTableAdapter1;
    }
}