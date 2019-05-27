namespace Contabilitate.Proiect
{
    partial class Regcasa
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
            this.registrucasaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetfinal = new Contabilitate.datasetfinal();
            this.unitateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unitateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetfinalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.registrucasaTableAdapter = new Contabilitate.datasetfinalTableAdapters.RegistrucasaTableAdapter();
            this.unitateTableAdapter = new Contabilitate.datasetfinalTableAdapters.unitateTableAdapter();
            this.unitateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.registrucasaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // registrucasaBindingSource
            // 
            this.registrucasaBindingSource.DataMember = "Registrucasa";
            this.registrucasaBindingSource.DataSource = this.datasetfinal;
            // 
            // datasetfinal
            // 
            this.datasetfinal.DataSetName = "datasetfinal";
            this.datasetfinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitateBindingSource1
            // 
            this.unitateBindingSource1.DataMember = "unitate";
            this.unitateBindingSource1.DataSource = this.datasetfinal;
            // 
            // unitateBindingSource
            // 
            this.unitateBindingSource.DataMember = "unitate";
            this.unitateBindingSource.DataSource = this.datasetfinalBindingSource;
            // 
            // datasetfinalBindingSource
            // 
            this.datasetfinalBindingSource.DataSource = this.datasetfinal;
            this.datasetfinalBindingSource.Position = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.registrucasaBindingSource;
            reportDataSource2.Name = "DataSet3";
            reportDataSource2.Value = this.unitateBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Contabilitate.Proiect.Registrucasa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // registrucasaTableAdapter
            // 
            this.registrucasaTableAdapter.ClearBeforeFill = true;
            // 
            // unitateTableAdapter
            // 
            this.unitateTableAdapter.ClearBeforeFill = true;
            // 
            // unitateBindingSource2
            // 
            this.unitateBindingSource2.DataMember = "unitate";
            this.unitateBindingSource2.DataSource = this.datasetfinal;
            // 
            // Regcasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Regcasa";
            this.Text = "Regcasa";
            this.Load += new System.EventHandler(this.Regcasa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrucasaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetfinalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitateBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private datasetfinal datasetfinal;
        private System.Windows.Forms.BindingSource registrucasaBindingSource;
        private datasetfinalTableAdapters.RegistrucasaTableAdapter registrucasaTableAdapter;
        private System.Windows.Forms.BindingSource datasetfinalBindingSource;
        private System.Windows.Forms.BindingSource unitateBindingSource;
        private datasetfinalTableAdapters.unitateTableAdapter unitateTableAdapter;
        private System.Windows.Forms.BindingSource unitateBindingSource1;
        private System.Windows.Forms.BindingSource unitateBindingSource2;
    }
}