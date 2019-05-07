namespace Extimpex
{
    partial class frmDetalhesVendas
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
            this.Detalhes_VendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Detalhes_VendaTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Detalhes_VendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Detalhes_VendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancoExtimpexDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Detalhes_VendaBindingSource
            // 
            this.Detalhes_VendaBindingSource.DataMember = "Detalhes_Venda";
            this.Detalhes_VendaBindingSource.DataSource = this.BancoExtimpexDataSet;
            // 
            // BancoExtimpexDataSet
            // 
            this.BancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.BancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Detalhes_VendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Extimpex.detVendas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(806, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // Detalhes_VendaTableAdapter
            // 
            this.Detalhes_VendaTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetalhesVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 504);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalhesVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes de Vendas";
            this.Load += new System.EventHandler(this.frmDetalhesVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detalhes_VendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancoExtimpexDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BancoExtimpexDataSet BancoExtimpexDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Detalhes_VendaBindingSource;
        private BancoExtimpexDataSetTableAdapters.Detalhes_VendaTableAdapter Detalhes_VendaTableAdapter;
    }
}