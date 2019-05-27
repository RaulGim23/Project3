namespace Contabilitate
{
    partial class Regbanca
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
            this.RegistrubancaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegistrubancaTableAdapter = new Contabilitate.datasetfinalTableAdapters.RegistrubancaTableAdapter();
            this.unitateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitateTableAdapter = new Contabilitate.datasetfinalTableAdapters.unitateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrubancaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RegistrubancaBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.unitateBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Contabilitate.Proiect.Report5.rdlc";
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
            // RegistrubancaBindingSource
            // 
            this.RegistrubancaBindingSource.DataMember = "Registrubanca";
            this.RegistrubancaBindingSource.DataSource = this.datasetfinal;
            // 
            // RegistrubancaTableAdapter
            // 
            this.RegistrubancaTableAdapter.ClearBeforeFill = true;
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
            // Regbanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Regbanca";
            this.Text = "Regbanca";
            this.Load += new System.EventHandler(this.Regbanca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrubancaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RegistrubancaBindingSource;
        private datasetfinal datasetfinal;
        private System.Windows.Forms.BindingSource unitateBindingSource;
        private datasetfinalTableAdapters.RegistrubancaTableAdapter RegistrubancaTableAdapter;
        private datasetfinalTableAdapters.unitateTableAdapter unitateTableAdapter;
    }
}