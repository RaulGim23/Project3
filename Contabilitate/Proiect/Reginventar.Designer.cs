namespace Contabilitate.Proiect
{
    partial class Reginventar
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
            this.registruinventarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registruinventarTableAdapter = new Contabilitate.datasetfinalTableAdapters.RegistruinventarTableAdapter();
            this.unitateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitateTableAdapter = new Contabilitate.datasetfinalTableAdapters.unitateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registruinventarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.registruinventarBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.unitateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Contabilitate.Proiect.Registruinventar.rdlc";
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
            // registruinventarBindingSource
            // 
            this.registruinventarBindingSource.DataMember = "Registruinventar";
            this.registruinventarBindingSource.DataSource = this.datasetfinal;
            // 
            // registruinventarTableAdapter
            // 
            this.registruinventarTableAdapter.ClearBeforeFill = true;
            // 
            // unitateBindingSource
            // 
            this.unitateBindingSource.DataMember = "unitate";
            this.unitateBindingSource.DataSource = this.datasetfinal;
            // 
            // unitateTableAdapter
            // 
            this.unitateTableAdapter.ClearBeforeFill = true;
            // 
            // Reginventar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reginventar";
            this.Text = "Reginventar";
            this.Load += new System.EventHandler(this.Reginventar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registruinventarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private datasetfinal datasetfinal;
        private System.Windows.Forms.BindingSource registruinventarBindingSource;
        private datasetfinalTableAdapters.RegistruinventarTableAdapter registruinventarTableAdapter;
        private System.Windows.Forms.BindingSource unitateBindingSource;
        private datasetfinalTableAdapters.unitateTableAdapter unitateTableAdapter;
    }
}