namespace Extimpex
{
    partial class frmVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbConNotFisc = new System.Windows.Forms.GroupBox();
            this.rdSitu = new System.Windows.Forms.RadioButton();
            this.rdNota = new System.Windows.Forms.RadioButton();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtPesqu = new System.Windows.Forms.TextBox();
            this.gbDtlh = new System.Windows.Forms.GroupBox();
            this.dtaGridRelate = new System.Windows.Forms.DataGridView();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.detalhesVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.vendasTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.VendasTableAdapter();
            this.detalhes_VendaTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Detalhes_VendaTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Razao_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLojaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadeEmissaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordoDescontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotalDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formadePagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bandeiradoCartaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDadosProdutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantdeParcelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConNotFisc.SuspendLayout();
            this.gbDtlh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridRelate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConNotFisc
            // 
            this.gbConNotFisc.BackColor = System.Drawing.SystemColors.Control;
            this.gbConNotFisc.Controls.Add(this.rdSitu);
            this.gbConNotFisc.Controls.Add(this.rdNota);
            this.gbConNotFisc.Controls.Add(this.btnPesq);
            this.gbConNotFisc.Controls.Add(this.txtPesqu);
            this.gbConNotFisc.Location = new System.Drawing.Point(12, 2);
            this.gbConNotFisc.Name = "gbConNotFisc";
            this.gbConNotFisc.Size = new System.Drawing.Size(486, 118);
            this.gbConNotFisc.TabIndex = 1;
            this.gbConNotFisc.TabStop = false;
            this.gbConNotFisc.Text = "Consulta de Nota Fiscal";
            // 
            // rdSitu
            // 
            this.rdSitu.AutoSize = true;
            this.rdSitu.BackColor = System.Drawing.Color.Transparent;
            this.rdSitu.Location = new System.Drawing.Point(19, 53);
            this.rdSitu.Name = "rdSitu";
            this.rdSitu.Size = new System.Drawing.Size(67, 17);
            this.rdSitu.TabIndex = 6;
            this.rdSitu.TabStop = true;
            this.rdSitu.Text = "Situação";
            this.rdSitu.UseVisualStyleBackColor = false;
            // 
            // rdNota
            // 
            this.rdNota.AutoSize = true;
            this.rdNota.BackColor = System.Drawing.Color.Transparent;
            this.rdNota.Location = new System.Drawing.Point(19, 29);
            this.rdNota.Name = "rdNota";
            this.rdNota.Size = new System.Drawing.Size(48, 17);
            this.rdNota.TabIndex = 4;
            this.rdNota.TabStop = true;
            this.rdNota.Text = "Nota";
            this.rdNota.UseVisualStyleBackColor = false;
            // 
            // btnPesq
            // 
            this.btnPesq.BackColor = System.Drawing.Color.Transparent;
            this.btnPesq.Location = new System.Drawing.Point(382, 82);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(85, 21);
            this.btnPesq.TabIndex = 3;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = false;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // txtPesqu
            // 
            this.txtPesqu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesqu.Location = new System.Drawing.Point(15, 83);
            this.txtPesqu.Name = "txtPesqu";
            this.txtPesqu.Size = new System.Drawing.Size(361, 20);
            this.txtPesqu.TabIndex = 2;
            // 
            // gbDtlh
            // 
            this.gbDtlh.BackColor = System.Drawing.SystemColors.Control;
            this.gbDtlh.Controls.Add(this.dtaGridRelate);
            this.gbDtlh.Location = new System.Drawing.Point(12, 122);
            this.gbDtlh.Name = "gbDtlh";
            this.gbDtlh.Size = new System.Drawing.Size(488, 255);
            this.gbDtlh.TabIndex = 3;
            this.gbDtlh.TabStop = false;
            this.gbDtlh.Text = "Detalhes";
            // 
            // dtaGridRelate
            // 
            this.dtaGridRelate.AllowUserToAddRows = false;
            this.dtaGridRelate.AllowUserToDeleteRows = false;
            this.dtaGridRelate.AllowUserToResizeColumns = false;
            this.dtaGridRelate.AllowUserToResizeRows = false;
            this.dtaGridRelate.AutoGenerateColumns = false;
            this.dtaGridRelate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridRelate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nome_Razao_Social,
            this.idLojaDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn,
            this.datadeEmissaoDataGridViewTextBoxColumn,
            this.valordoDescontoDataGridViewTextBoxColumn,
            this.valorTotalDescDataGridViewTextBoxColumn,
            this.vendedorDataGridViewTextBoxColumn,
            this.formadePagamentoDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn,
            this.bandeiradoCartaoDataGridViewTextBoxColumn,
            this.idDadosProdutosDataGridViewTextBoxColumn,
            this.quantdeParcelaDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn});
            this.dtaGridRelate.DataSource = this.vendasBindingSource;
            this.dtaGridRelate.Location = new System.Drawing.Point(18, 19);
            this.dtaGridRelate.MultiSelect = false;
            this.dtaGridRelate.Name = "dtaGridRelate";
            this.dtaGridRelate.ReadOnly = true;
            this.dtaGridRelate.RowHeadersVisible = false;
            this.dtaGridRelate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridRelate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridRelate.Size = new System.Drawing.Size(453, 220);
            this.dtaGridRelate.TabIndex = 0;
            this.dtaGridRelate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridRelate_CellContentClick);
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalhesVendaBindingSource
            // 
            this.detalhesVendaBindingSource.DataMember = "Detalhes_Venda";
            this.detalhesVendaBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Nova Venda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(375, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 42);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Concluir Orçamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 42);
            this.button4.TabIndex = 10;
            this.button4.Text = "Reeprimir Venda";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cadastro_de_Categorias_de_DespesasTableAdapter = null;
            this.tableAdapterManager.Cargos_AdministrativosTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Consulta_de_ProdutoTableAdapter = null;
            this.tableAdapterManager.Conta_a_ReceberTableAdapter = null;
            this.tableAdapterManager.Controle_de_EstoqueTableAdapter = null;
            this.tableAdapterManager.Dados_ProdutosTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.Extimpex_FornecedorTableAdapter = null;
            this.tableAdapterManager.Fluxo_de_CaixaTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Grupo_ProdutoTableAdapter = null;
            this.tableAdapterManager.LojaTableAdapter = null;
            this.tableAdapterManager.Nota_FiscalTableAdapter = null;
            this.tableAdapterManager.Notas_ProdutoTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VendasTableAdapter = null;
            this.tableAdapterManager.VendedorTableAdapter = null;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // detalhes_VendaTableAdapter
            // 
            this.detalhes_VendaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Vendas";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Vendas";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Nome_Razao_Social
            // 
            this.Nome_Razao_Social.DataPropertyName = "Nome_Razao_Social";
            this.Nome_Razao_Social.HeaderText = "Nome_Razao_Social";
            this.Nome_Razao_Social.Name = "Nome_Razao_Social";
            this.Nome_Razao_Social.ReadOnly = true;
            this.Nome_Razao_Social.Visible = false;
            // 
            // idLojaDataGridViewTextBoxColumn
            // 
            this.idLojaDataGridViewTextBoxColumn.DataPropertyName = "Id_Loja";
            this.idLojaDataGridViewTextBoxColumn.HeaderText = "Id_Loja";
            this.idLojaDataGridViewTextBoxColumn.Name = "idLojaDataGridViewTextBoxColumn";
            this.idLojaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLojaDataGridViewTextBoxColumn.Visible = false;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            this.notaDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaDataGridViewTextBoxColumn.Width = 80;
            // 
            // datadeEmissaoDataGridViewTextBoxColumn
            // 
            this.datadeEmissaoDataGridViewTextBoxColumn.DataPropertyName = "Data_de_Emissao";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.datadeEmissaoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.datadeEmissaoDataGridViewTextBoxColumn.HeaderText = "Data de Emissao";
            this.datadeEmissaoDataGridViewTextBoxColumn.Name = "datadeEmissaoDataGridViewTextBoxColumn";
            this.datadeEmissaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datadeEmissaoDataGridViewTextBoxColumn.Width = 130;
            // 
            // valordoDescontoDataGridViewTextBoxColumn
            // 
            this.valordoDescontoDataGridViewTextBoxColumn.DataPropertyName = "Valor_do_Desconto";
            this.valordoDescontoDataGridViewTextBoxColumn.HeaderText = "Valor_do_Desconto";
            this.valordoDescontoDataGridViewTextBoxColumn.Name = "valordoDescontoDataGridViewTextBoxColumn";
            this.valordoDescontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valordoDescontoDataGridViewTextBoxColumn.Visible = false;
            // 
            // valorTotalDescDataGridViewTextBoxColumn
            // 
            this.valorTotalDescDataGridViewTextBoxColumn.DataPropertyName = "Valor_Total_Desc";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.valorTotalDescDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.valorTotalDescDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            this.valorTotalDescDataGridViewTextBoxColumn.Name = "valorTotalDescDataGridViewTextBoxColumn";
            this.valorTotalDescDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorTotalDescDataGridViewTextBoxColumn.Width = 110;
            // 
            // vendedorDataGridViewTextBoxColumn
            // 
            this.vendedorDataGridViewTextBoxColumn.DataPropertyName = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.HeaderText = "Vendedor";
            this.vendedorDataGridViewTextBoxColumn.Name = "vendedorDataGridViewTextBoxColumn";
            this.vendedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.vendedorDataGridViewTextBoxColumn.Visible = false;
            // 
            // formadePagamentoDataGridViewTextBoxColumn
            // 
            this.formadePagamentoDataGridViewTextBoxColumn.DataPropertyName = "Forma_de_Pagamento";
            this.formadePagamentoDataGridViewTextBoxColumn.HeaderText = "Forma_de_Pagamento";
            this.formadePagamentoDataGridViewTextBoxColumn.Name = "formadePagamentoDataGridViewTextBoxColumn";
            this.formadePagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formadePagamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            this.situacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.situacaoDataGridViewTextBoxColumn.Width = 130;
            // 
            // bandeiradoCartaoDataGridViewTextBoxColumn
            // 
            this.bandeiradoCartaoDataGridViewTextBoxColumn.DataPropertyName = "Bandeira_do_Cartao";
            this.bandeiradoCartaoDataGridViewTextBoxColumn.HeaderText = "Bandeira_do_Cartao";
            this.bandeiradoCartaoDataGridViewTextBoxColumn.Name = "bandeiradoCartaoDataGridViewTextBoxColumn";
            this.bandeiradoCartaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.bandeiradoCartaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDadosProdutosDataGridViewTextBoxColumn
            // 
            this.idDadosProdutosDataGridViewTextBoxColumn.DataPropertyName = "Id_Dados_Produtos";
            this.idDadosProdutosDataGridViewTextBoxColumn.HeaderText = "Id_Dados_Produtos";
            this.idDadosProdutosDataGridViewTextBoxColumn.Name = "idDadosProdutosDataGridViewTextBoxColumn";
            this.idDadosProdutosDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDadosProdutosDataGridViewTextBoxColumn.Visible = false;
            // 
            // quantdeParcelaDataGridViewTextBoxColumn
            // 
            this.quantdeParcelaDataGridViewTextBoxColumn.DataPropertyName = "Quant_de_Parcela";
            this.quantdeParcelaDataGridViewTextBoxColumn.HeaderText = "Quant_de_Parcela";
            this.quantdeParcelaDataGridViewTextBoxColumn.Name = "quantdeParcelaDataGridViewTextBoxColumn";
            this.quantdeParcelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantdeParcelaDataGridViewTextBoxColumn.Visible = false;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            this.jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            this.jurosDataGridViewTextBoxColumn.ReadOnly = true;
            this.jurosDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 443);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbDtlh);
            this.Controls.Add(this.gbConNotFisc);
            this.DoubleBuffered = true;
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEntEsto_Load);
            this.gbConNotFisc.ResumeLayout(false);
            this.gbConNotFisc.PerformLayout();
            this.gbDtlh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridRelate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalhesVendaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConNotFisc;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbDtlh;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox txtPesqu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private BancoExtimpexDataSetTableAdapters.VendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rdSitu;
        private System.Windows.Forms.RadioButton rdNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detalhesVendaBindingSource;
        private BancoExtimpexDataSetTableAdapters.Detalhes_VendaTableAdapter detalhes_VendaTableAdapter;
        public System.Windows.Forms.DataGridView dtaGridRelate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Razao_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLojaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadeEmissaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordoDescontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotalDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formadePagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandeiradoCartaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDadosProdutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantdeParcelaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
    }
}