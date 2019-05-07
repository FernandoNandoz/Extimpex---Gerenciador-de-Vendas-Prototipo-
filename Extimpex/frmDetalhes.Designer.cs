namespace Extimpex
{
    partial class frmDetalhes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Relatorio_DetalhesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.Nota_FiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Notas_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extimpexFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Nota_FiscalTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Nota_FiscalTableAdapter();
            this.Notas_ProdutoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Notas_ProdutoTableAdapter();
            this.extimpex_FornecedorTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Extimpex_FornecedorTableAdapter();
            this.Extimpex_FornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Relatorio_DetalhesTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Relatorio_DetalhesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Relatorio_DetalhesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancoExtimpexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nota_FiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notas_ProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extimpexFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Extimpex_FornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Relatorio_DetalhesBindingSource
            // 
            this.Relatorio_DetalhesBindingSource.DataMember = "Relatorio_Detalhes";
            this.Relatorio_DetalhesBindingSource.DataSource = this.BancoExtimpexDataSet;
            // 
            // BancoExtimpexDataSet
            // 
            this.BancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.BancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Nota_FiscalBindingSource
            // 
            this.Nota_FiscalBindingSource.DataMember = "Nota_Fiscal";
            this.Nota_FiscalBindingSource.DataSource = this.BancoExtimpexDataSet;
            // 
            // Notas_ProdutoBindingSource
            // 
            this.Notas_ProdutoBindingSource.DataMember = "Notas_Produto";
            this.Notas_ProdutoBindingSource.DataSource = this.BancoExtimpexDataSet;
            // 
            // extimpexFornecedorBindingSource
            // 
            this.extimpexFornecedorBindingSource.DataMember = "Extimpex_Fornecedor";
            this.extimpexFornecedorBindingSource.DataSource = this.BancoExtimpexDataSet;
            // 
            // Nota_FiscalTableAdapter
            // 
            this.Nota_FiscalTableAdapter.ClearBeforeFill = true;
            // 
            // Notas_ProdutoTableAdapter
            // 
            this.Notas_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // extimpex_FornecedorTableAdapter
            // 
            this.extimpex_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // Extimpex_FornecedorBindingSource
            // 
            this.Extimpex_FornecedorBindingSource.DataMember = "Extimpex_Fornecedor";
            this.Extimpex_FornecedorBindingSource.DataSource = this.BancoExtimpexDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "Classe_de_Notas";
            reportDataSource2.Value = this.Relatorio_DetalhesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Extimpex.repDetalhes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(816, 553);
            this.reportViewer1.TabIndex = 0;
            // 
            // Relatorio_DetalhesTableAdapter
            // 
            this.Relatorio_DetalhesTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetalhes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 553);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalhes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes de Entrada";
            this.Load += new System.EventHandler(this.frmDetalhes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Relatorio_DetalhesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BancoExtimpexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nota_FiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notas_ProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extimpexFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Extimpex_FornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource Nota_FiscalBindingSource;
        private BancoExtimpexDataSet BancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource Notas_ProdutoBindingSource;
        private BancoExtimpexDataSetTableAdapters.Nota_FiscalTableAdapter Nota_FiscalTableAdapter;
        private BancoExtimpexDataSetTableAdapters.Notas_ProdutoTableAdapter Notas_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource extimpexFornecedorBindingSource;
        private BancoExtimpexDataSetTableAdapters.Extimpex_FornecedorTableAdapter extimpex_FornecedorTableAdapter;
        private System.Windows.Forms.BindingSource Extimpex_FornecedorBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Relatorio_DetalhesBindingSource;
        private BancoExtimpexDataSetTableAdapters.Relatorio_DetalhesTableAdapter Relatorio_DetalhesTableAdapter;
    }
}