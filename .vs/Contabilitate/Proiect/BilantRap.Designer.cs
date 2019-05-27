namespace Contabilitate.Proiect
{
    partial class BilantRap
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datasetfinal = new Contabilitate.datasetfinal();
            this.datasetfinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilantTableAdapter = new Contabilitate.datasetfinalTableAdapters.BilantTableAdapter();
            this.unitateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bilantBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.unitateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Contabilitate.Proiect.Report7.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // datasetfinal
            // 
            this.datasetfinal.DataSetName = "datasetfinal";
            this.datasetfinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datasetfinalBindingSource
            // 
            this.datasetfinalBindingSource.DataSource = this.datasetfinal;
            this.datasetfinalBindingSource.Position = 0;
            // 
            // bilantBindingSource
            // 
            this.bilantBindingSource.DataMember = "Bilant";
            this.bilantBindingSource.DataSource = this.datasetfinalBindingSource;
            // 
            // bilantTableAdapter
            // 
            this.bilantTableAdapter.ClearBeforeFill = true;
            // 
            // unitateBindingSource
            // 
            this.unitateBindingSource.DataMember = "unitate";
            this.unitateBindingSource.DataSource = this.datasetfinal;
            // 
            // BilantRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BilantRap";
            this.Text = "BilantRap";
            this.Load += new System.EventHandler(this.BilantRap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private datasetfinal datasetfinal;
        private System.Windows.Forms.BindingSource datasetfinalBindingSource;
        private System.Windows.Forms.BindingSource bilantBindingSource;
        private datasetfinalTableAdapters.BilantTableAdapter bilantTableAdapter;
        private System.Windows.Forms.BindingSource unitateBindingSource;
    }
}