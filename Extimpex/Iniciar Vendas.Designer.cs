namespace Extimpex
{
    partial class frmVendas
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
            System.Windows.Forms.Label notaLabel;
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label id_VendedorLabel;
            System.Windows.Forms.Label nome_do_ProdutoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valor_do_ProdutoLabel;
            System.Windows.Forms.Label valor_do_DescontoLabel;
            System.Windows.Forms.Label valor_Total_DescLabel;
            System.Windows.Forms.Label forma_de_PagamentoLabel;
            System.Windows.Forms.Label valor_Total_ProdutoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDadVend = new System.Windows.Forms.GroupBox();
            this.dtaGridCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lojaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbNomPro = new System.Windows.Forms.GroupBox();
            this.btnExclu = new System.Windows.Forms.Button();
            this.txtdescP = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dtGridDetalhes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Dados_Produtos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textValTotPro = new System.Windows.Forms.TextBox();
            this.dados_ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtValPro = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNomPro = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.gbDadPag = new System.Windows.Forms.GroupBox();
            this.dtaGridDadPag = new System.Windows.Forms.DataGridView();
            this.QdP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vlr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtVnc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JrD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lbJuro = new System.Windows.Forms.Label();
            this.txtJuro = new System.Windows.Forms.TextBox();
            this.lbParc = new System.Windows.Forms.Label();
            this.btnGerFat = new System.Windows.Forms.Button();
            this.lbBad = new System.Windows.Forms.Label();
            this.cmbBad = new System.Windows.Forms.ComboBox();
            this.txtValTotDesc = new System.Windows.Forms.TextBox();
            this.txtParc = new System.Windows.Forms.TextBox();
            this.cmbFromPag = new System.Windows.Forms.ComboBox();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.btnIniCad = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadVend = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.dados_ProdutosTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Dados_ProdutosTableAdapter();
            this.produtoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.ProdutoTableAdapter();
            this.clienteTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.ClienteTableAdapter();
            this.lojaTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.LojaTableAdapter();
            this.vendedorTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.VendedorTableAdapter();
            this.vendasTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.VendasTableAdapter();
            notaLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            id_VendedorLabel = new System.Windows.Forms.Label();
            nome_do_ProdutoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valor_do_ProdutoLabel = new System.Windows.Forms.Label();
            valor_do_DescontoLabel = new System.Windows.Forms.Label();
            valor_Total_DescLabel = new System.Windows.Forms.Label();
            forma_de_PagamentoLabel = new System.Windows.Forms.Label();
            valor_Total_ProdutoLabel = new System.Windows.Forms.Label();
            this.gbDadVend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaBindingSource)).BeginInit();
            this.gbNomPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDetalhes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_ProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.gbDadPag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDadPag)).BeginInit();
            this.gbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // notaLabel
            // 
            notaLabel.AutoSize = true;
            notaLabel.Location = new System.Drawing.Point(15, 17);
            notaLabel.Name = "notaLabel";
            notaLabel.Size = new System.Drawing.Size(33, 13);
            notaLabel.TabIndex = 0;
            notaLabel.Text = "Nota:";
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(495, 16);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(42, 13);
            id_ClienteLabel.TabIndex = 15;
            id_ClienteLabel.Text = "Cliente:";
            // 
            // id_VendedorLabel
            // 
            id_VendedorLabel.AutoSize = true;
            id_VendedorLabel.Location = new System.Drawing.Point(110, 16);
            id_VendedorLabel.Name = "id_VendedorLabel";
            id_VendedorLabel.Size = new System.Drawing.Size(56, 13);
            id_VendedorLabel.TabIndex = 16;
            id_VendedorLabel.Text = "Vendedor:";
            // 
            // nome_do_ProdutoLabel
            // 
            nome_do_ProdutoLabel.AutoSize = true;
            nome_do_ProdutoLabel.Location = new System.Drawing.Point(14, 17);
            nome_do_ProdutoLabel.Name = "nome_do_ProdutoLabel";
            nome_do_ProdutoLabel.Size = new System.Drawing.Size(93, 13);
            nome_do_ProdutoLabel.TabIndex = 0;
            nome_do_ProdutoLabel.Text = "Nome do Produto:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(353, 18);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(13, 57);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valor_do_ProdutoLabel
            // 
            valor_do_ProdutoLabel.AutoSize = true;
            valor_do_ProdutoLabel.Location = new System.Drawing.Point(110, 57);
            valor_do_ProdutoLabel.Name = "valor_do_ProdutoLabel";
            valor_do_ProdutoLabel.Size = new System.Drawing.Size(38, 13);
            valor_do_ProdutoLabel.TabIndex = 6;
            valor_do_ProdutoLabel.Text = "Preço:";
            // 
            // valor_do_DescontoLabel
            // 
            valor_do_DescontoLabel.AutoSize = true;
            valor_do_DescontoLabel.Location = new System.Drawing.Point(249, 57);
            valor_do_DescontoLabel.Name = "valor_do_DescontoLabel";
            valor_do_DescontoLabel.Size = new System.Drawing.Size(72, 13);
            valor_do_DescontoLabel.TabIndex = 2;
            valor_do_DescontoLabel.Text = "Desconto/ %:";
            // 
            // valor_Total_DescLabel
            // 
            valor_Total_DescLabel.AutoSize = true;
            valor_Total_DescLabel.Location = new System.Drawing.Point(199, 213);
            valor_Total_DescLabel.Name = "valor_Total_DescLabel";
            valor_Total_DescLabel.Size = new System.Drawing.Size(61, 13);
            valor_Total_DescLabel.TabIndex = 4;
            valor_Total_DescLabel.Text = "Valor Total:";
            // 
            // forma_de_PagamentoLabel
            // 
            forma_de_PagamentoLabel.AutoSize = true;
            forma_de_PagamentoLabel.Location = new System.Drawing.Point(13, 20);
            forma_de_PagamentoLabel.Name = "forma_de_PagamentoLabel";
            forma_de_PagamentoLabel.Size = new System.Drawing.Size(111, 13);
            forma_de_PagamentoLabel.TabIndex = 8;
            forma_de_PagamentoLabel.Text = "Forma de Pagamento:";
            // 
            // valor_Total_ProdutoLabel
            // 
            valor_Total_ProdutoLabel.AutoSize = true;
            valor_Total_ProdutoLabel.Location = new System.Drawing.Point(353, 57);
            valor_Total_ProdutoLabel.Name = "valor_Total_ProdutoLabel";
            valor_Total_ProdutoLabel.Size = new System.Drawing.Size(61, 13);
            valor_Total_ProdutoLabel.TabIndex = 18;
            valor_Total_ProdutoLabel.Text = "Valor Total:";
            // 
            // gbDadVend
            // 
            this.gbDadVend.BackColor = System.Drawing.SystemColors.Control;
            this.gbDadVend.Controls.Add(this.dtaGridCliente);
            this.gbDadVend.Controls.Add(this.txtCliente);
            this.gbDadVend.Controls.Add(this.btnPesq);
            this.gbDadVend.Controls.Add(this.txtVendor);
            this.gbDadVend.Controls.Add(id_VendedorLabel);
            this.gbDadVend.Controls.Add(id_ClienteLabel);
            this.gbDadVend.Controls.Add(notaLabel);
            this.gbDadVend.Controls.Add(this.txtNota);
            this.gbDadVend.Location = new System.Drawing.Point(8, 2);
            this.gbDadVend.Name = "gbDadVend";
            this.gbDadVend.Size = new System.Drawing.Size(894, 205);
            this.gbDadVend.TabIndex = 0;
            this.gbDadVend.TabStop = false;
            this.gbDadVend.Text = "Dados de Venda";
            // 
            // dtaGridCliente
            // 
            this.dtaGridCliente.AllowUserToAddRows = false;
            this.dtaGridCliente.AllowUserToDeleteRows = false;
            this.dtaGridCliente.AllowUserToResizeColumns = false;
            this.dtaGridCliente.AllowUserToResizeRows = false;
            this.dtaGridCliente.AutoGenerateColumns = false;
            this.dtaGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dtaGridCliente.DataSource = this.clienteBindingSource;
            this.dtaGridCliente.Location = new System.Drawing.Point(498, 63);
            this.dtaGridCliente.MultiSelect = false;
            this.dtaGridCliente.Name = "dtaGridCliente";
            this.dtaGridCliente.ReadOnly = true;
            this.dtaGridCliente.RowHeadersVisible = false;
            this.dtaGridCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridCliente.Size = new System.Drawing.Size(376, 122);
            this.dtaGridCliente.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Razao_Social";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 242;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CNPJ";
            this.dataGridViewTextBoxColumn3.HeaderText = "CNPJ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Inscricao_Estadual";
            this.dataGridViewTextBoxColumn4.HeaderText = "Inscricao_Estadual";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Inscricao_Municipal";
            this.dataGridViewTextBoxColumn5.HeaderText = "Inscricao_Municipal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn6.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RG";
            this.dataGridViewTextBoxColumn7.HeaderText = "RG";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn8.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn9.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn10.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn12.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn14.HeaderText = "Email";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Observacao";
            this.dataGridViewTextBoxColumn15.HeaderText = "Observacao";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Location = new System.Drawing.Point(498, 32);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(296, 20);
            this.txtCliente.TabIndex = 20;
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(800, 30);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(74, 23);
            this.btnPesq.TabIndex = 19;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // txtVendor
            // 
            this.txtVendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVendor.Location = new System.Drawing.Point(113, 32);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(370, 20);
            this.txtVendor.TabIndex = 10;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(18, 32);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(89, 20);
            this.txtNota.TabIndex = 1;
            // 
            // vendasBindingSource
            // 
            this.vendasBindingSource.DataMember = "Vendas";
            this.vendasBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // vendedorBindingSource
            // 
            this.vendedorBindingSource.DataMember = "Vendedor";
            this.vendedorBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // lojaBindingSource
            // 
            this.lojaBindingSource.DataMember = "Loja";
            this.lojaBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // gbNomPro
            // 
            this.gbNomPro.BackColor = System.Drawing.SystemColors.Control;
            this.gbNomPro.Controls.Add(this.btnExclu);
            this.gbNomPro.Controls.Add(this.txtdescP);
            this.gbNomPro.Controls.Add(valor_Total_ProdutoLabel);
            this.gbNomPro.Controls.Add(this.btnInserir);
            this.gbNomPro.Controls.Add(this.dtGridDetalhes);
            this.gbNomPro.Controls.Add(this.textValTotPro);
            this.gbNomPro.Controls.Add(valor_do_ProdutoLabel);
            this.gbNomPro.Controls.Add(valor_do_DescontoLabel);
            this.gbNomPro.Controls.Add(this.txtValPro);
            this.gbNomPro.Controls.Add(quantidadeLabel);
            this.gbNomPro.Controls.Add(this.txtQuant);
            this.gbNomPro.Controls.Add(codigoLabel);
            this.gbNomPro.Controls.Add(this.txtCod);
            this.gbNomPro.Controls.Add(nome_do_ProdutoLabel);
            this.gbNomPro.Controls.Add(this.cmbNomPro);
            this.gbNomPro.Location = new System.Drawing.Point(8, 61);
            this.gbNomPro.Name = "gbNomPro";
            this.gbNomPro.Size = new System.Drawing.Size(490, 426);
            this.gbNomPro.TabIndex = 1;
            this.gbNomPro.TabStop = false;
            this.gbNomPro.Text = "Dados do Produto";
            // 
            // btnExclu
            // 
            this.btnExclu.Location = new System.Drawing.Point(13, 379);
            this.btnExclu.Name = "btnExclu";
            this.btnExclu.Size = new System.Drawing.Size(457, 27);
            this.btnExclu.TabIndex = 15;
            this.btnExclu.Text = "Excluir Produtos";
            this.btnExclu.UseVisualStyleBackColor = true;
            this.btnExclu.Click += new System.EventHandler(this.btnExclu_Click);
            // 
            // txtdescP
            // 
            this.txtdescP.Location = new System.Drawing.Point(249, 73);
            this.txtdescP.Name = "txtdescP";
            this.txtdescP.Size = new System.Drawing.Size(101, 20);
            this.txtdescP.TabIndex = 20;
            this.txtdescP.TextChanged += new System.EventHandler(this.txtdescP_TextChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(17, 99);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(453, 27);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dtGridDetalhes
            // 
            this.dtGridDetalhes.AllowUserToAddRows = false;
            this.dtGridDetalhes.AllowUserToDeleteRows = false;
            this.dtGridDetalhes.AllowUserToResizeColumns = false;
            this.dtGridDetalhes.AllowUserToResizeRows = false;
            this.dtGridDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGridDetalhes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Quantidade,
            this.Valor,
            this.Valor_Total,
            this.Id_Dados_Produtos,
            this.Column1});
            this.dtGridDetalhes.Location = new System.Drawing.Point(16, 141);
            this.dtGridDetalhes.MultiSelect = false;
            this.dtGridDetalhes.Name = "dtGridDetalhes";
            this.dtGridDetalhes.ReadOnly = true;
            this.dtGridDetalhes.RowHeadersVisible = false;
            this.dtGridDetalhes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGridDetalhes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridDetalhes.Size = new System.Drawing.Size(454, 232);
            this.dtGridDetalhes.TabIndex = 4;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 55;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 160;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 70;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 80;
            // 
            // Valor_Total
            // 
            this.Valor_Total.HeaderText = "Valor Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            this.Valor_Total.Width = 85;
            // 
            // Id_Dados_Produtos
            // 
            this.Id_Dados_Produtos.HeaderText = "Id_Dados_Produtos";
            this.Id_Dados_Produtos.Name = "Id_Dados_Produtos";
            this.Id_Dados_Produtos.ReadOnly = true;
            this.Id_Dados_Produtos.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Desconto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // textValTotPro
            // 
            this.textValTotPro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dados_ProdutosBindingSource, "Valor_Total_Produto", true));
            this.textValTotPro.Location = new System.Drawing.Point(356, 73);
            this.textValTotPro.Name = "textValTotPro";
            this.textValTotPro.ReadOnly = true;
            this.textValTotPro.Size = new System.Drawing.Size(114, 20);
            this.textValTotPro.TabIndex = 19;
            // 
            // dados_ProdutosBindingSource
            // 
            this.dados_ProdutosBindingSource.DataMember = "Dados_Produtos";
            this.dados_ProdutosBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // txtValPro
            // 
            this.txtValPro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dados_ProdutosBindingSource, "Valor_do_Produto", true));
            this.txtValPro.Location = new System.Drawing.Point(113, 73);
            this.txtValPro.Name = "txtValPro";
            this.txtValPro.Size = new System.Drawing.Size(130, 20);
            this.txtValPro.TabIndex = 7;
            // 
            // txtQuant
            // 
            this.txtQuant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dados_ProdutosBindingSource, "Quantidade", true));
            this.txtQuant.Location = new System.Drawing.Point(17, 73);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(91, 20);
            this.txtQuant.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Codigo", true));
            this.txtCod.Location = new System.Drawing.Point(356, 34);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(114, 20);
            this.txtCod.TabIndex = 3;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // cmbNomPro
            // 
            this.cmbNomPro.DataSource = this.produtoBindingSource;
            this.cmbNomPro.DisplayMember = "Nome_do_Produto";
            this.cmbNomPro.FormattingEnabled = true;
            this.cmbNomPro.Location = new System.Drawing.Point(17, 33);
            this.cmbNomPro.Name = "cmbNomPro";
            this.cmbNomPro.Size = new System.Drawing.Size(333, 21);
            this.cmbNomPro.TabIndex = 1;
            this.cmbNomPro.ValueMember = "Id_Produto";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(16, 229);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(180, 45);
            this.txtDesc.TabIndex = 3;
            // 
            // gbDadPag
            // 
            this.gbDadPag.BackColor = System.Drawing.SystemColors.Control;
            this.gbDadPag.Controls.Add(this.dtaGridDadPag);
            this.gbDadPag.Controls.Add(this.label1);
            this.gbDadPag.Controls.Add(this.lbJuro);
            this.gbDadPag.Controls.Add(this.txtJuro);
            this.gbDadPag.Controls.Add(this.lbParc);
            this.gbDadPag.Controls.Add(this.btnGerFat);
            this.gbDadPag.Controls.Add(this.lbBad);
            this.gbDadPag.Controls.Add(this.cmbBad);
            this.gbDadPag.Controls.Add(this.txtValTotDesc);
            this.gbDadPag.Controls.Add(this.txtParc);
            this.gbDadPag.Controls.Add(this.txtDesc);
            this.gbDadPag.Controls.Add(valor_Total_DescLabel);
            this.gbDadPag.Controls.Add(forma_de_PagamentoLabel);
            this.gbDadPag.Controls.Add(this.cmbFromPag);
            this.gbDadPag.Location = new System.Drawing.Point(494, 199);
            this.gbDadPag.Name = "gbDadPag";
            this.gbDadPag.Size = new System.Drawing.Size(408, 288);
            this.gbDadPag.TabIndex = 2;
            this.gbDadPag.TabStop = false;
            this.gbDadPag.Text = "Dados de pagamento";
            // 
            // dtaGridDadPag
            // 
            this.dtaGridDadPag.AllowUserToAddRows = false;
            this.dtaGridDadPag.AllowUserToDeleteRows = false;
            this.dtaGridDadPag.AllowUserToResizeColumns = false;
            this.dtaGridDadPag.AllowUserToResizeRows = false;
            this.dtaGridDadPag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridDadPag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QdP,
            this.Vlr,
            this.DtVnc,
            this.JrD});
            this.dtaGridDadPag.Enabled = false;
            this.dtaGridDadPag.Location = new System.Drawing.Point(16, 60);
            this.dtaGridDadPag.MultiSelect = false;
            this.dtaGridDadPag.Name = "dtaGridDadPag";
            this.dtaGridDadPag.ReadOnly = true;
            this.dtaGridDadPag.RowHeadersVisible = false;
            this.dtaGridDadPag.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridDadPag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridDadPag.Size = new System.Drawing.Size(376, 149);
            this.dtaGridDadPag.TabIndex = 18;
            // 
            // QdP
            // 
            this.QdP.HeaderText = "Nº  Parcela";
            this.QdP.Name = "QdP";
            this.QdP.ReadOnly = true;
            // 
            // Vlr
            // 
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Vlr.DefaultCellStyle = dataGridViewCellStyle4;
            this.Vlr.HeaderText = "Valor";
            this.Vlr.Name = "Vlr";
            this.Vlr.ReadOnly = true;
            this.Vlr.Width = 86;
            // 
            // DtVnc
            // 
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.DtVnc.DefaultCellStyle = dataGridViewCellStyle5;
            this.DtVnc.HeaderText = "Vencimento";
            this.DtVnc.Name = "DtVnc";
            this.DtVnc.ReadOnly = true;
            this.DtVnc.Width = 105;
            // 
            // JrD
            // 
            dataGridViewCellStyle6.Format = "                %";
            dataGridViewCellStyle6.NullValue = "1";
            this.JrD.DefaultCellStyle = dataGridViewCellStyle6;
            this.JrD.HeaderText = "Juros";
            this.JrD.Name = "JrD";
            this.JrD.ReadOnly = true;
            this.JrD.Width = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Desconto (R$)";
            // 
            // lbJuro
            // 
            this.lbJuro.AutoSize = true;
            this.lbJuro.Location = new System.Drawing.Point(266, 19);
            this.lbJuro.Name = "lbJuro";
            this.lbJuro.Size = new System.Drawing.Size(49, 13);
            this.lbJuro.TabIndex = 16;
            this.lbJuro.Text = "Juros (%)";
            this.lbJuro.Visible = false;
            // 
            // txtJuro
            // 
            this.txtJuro.Enabled = false;
            this.txtJuro.Location = new System.Drawing.Point(269, 35);
            this.txtJuro.Multiline = true;
            this.txtJuro.Name = "txtJuro";
            this.txtJuro.Size = new System.Drawing.Size(44, 21);
            this.txtJuro.TabIndex = 15;
            this.txtJuro.Visible = false;
            // 
            // lbParc
            // 
            this.lbParc.AutoSize = true;
            this.lbParc.Location = new System.Drawing.Point(215, 19);
            this.lbParc.Name = "lbParc";
            this.lbParc.Size = new System.Drawing.Size(48, 13);
            this.lbParc.TabIndex = 6;
            this.lbParc.Text = "Parcelas";
            this.lbParc.Visible = false;
            // 
            // btnGerFat
            // 
            this.btnGerFat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerFat.Enabled = false;
            this.btnGerFat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerFat.Location = new System.Drawing.Point(319, 33);
            this.btnGerFat.Name = "btnGerFat";
            this.btnGerFat.Size = new System.Drawing.Size(73, 24);
            this.btnGerFat.TabIndex = 14;
            this.btnGerFat.Text = "Faturar";
            this.btnGerFat.UseVisualStyleBackColor = false;
            this.btnGerFat.Visible = false;
            this.btnGerFat.Click += new System.EventHandler(this.btnGerFat_Click);
            // 
            // lbBad
            // 
            this.lbBad.AutoSize = true;
            this.lbBad.Location = new System.Drawing.Point(126, 19);
            this.lbBad.Name = "lbBad";
            this.lbBad.Size = new System.Drawing.Size(49, 13);
            this.lbBad.TabIndex = 13;
            this.lbBad.Text = "Bandeira";
            this.lbBad.Visible = false;
            // 
            // cmbBad
            // 
            this.cmbBad.Enabled = false;
            this.cmbBad.FormattingEnabled = true;
            this.cmbBad.Items.AddRange(new object[] {
            "Visa",
            "Master Card",
            "Elo",
            "Outros"});
            this.cmbBad.Location = new System.Drawing.Point(130, 35);
            this.cmbBad.Name = "cmbBad";
            this.cmbBad.Size = new System.Drawing.Size(82, 21);
            this.cmbBad.TabIndex = 11;
            this.cmbBad.Visible = false;
            // 
            // txtValTotDesc
            // 
            this.txtValTotDesc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtValTotDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValTotDesc.ForeColor = System.Drawing.Color.Red;
            this.txtValTotDesc.Location = new System.Drawing.Point(202, 229);
            this.txtValTotDesc.Multiline = true;
            this.txtValTotDesc.Name = "txtValTotDesc";
            this.txtValTotDesc.ReadOnly = true;
            this.txtValTotDesc.Size = new System.Drawing.Size(190, 45);
            this.txtValTotDesc.TabIndex = 5;
            // 
            // txtParc
            // 
            this.txtParc.Enabled = false;
            this.txtParc.Location = new System.Drawing.Point(218, 35);
            this.txtParc.Multiline = true;
            this.txtParc.Name = "txtParc";
            this.txtParc.Size = new System.Drawing.Size(45, 21);
            this.txtParc.TabIndex = 10;
            this.txtParc.Visible = false;
            // 
            // cmbFromPag
            // 
            this.cmbFromPag.Enabled = false;
            this.cmbFromPag.FormattingEnabled = true;
            this.cmbFromPag.Items.AddRange(new object[] {
            "Dinheiro",
            "Débito",
            "Cartão de Crédito",
            "Boleto Bancario",
            "Crédito Loja"});
            this.cmbFromPag.Location = new System.Drawing.Point(16, 35);
            this.cmbFromPag.Name = "cmbFromPag";
            this.cmbFromPag.Size = new System.Drawing.Size(108, 21);
            this.cmbFromPag.TabIndex = 7;
            this.cmbFromPag.SelectedIndexChanged += new System.EventHandler(this.cmbFromPag_SelectedIndexChanged);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.btnIniCad);
            this.gbOpcoes.Controls.Add(this.btnSair);
            this.gbOpcoes.Controls.Add(this.btnCadVend);
            this.gbOpcoes.Location = new System.Drawing.Point(8, 488);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(894, 60);
            this.gbOpcoes.TabIndex = 3;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // btnIniCad
            // 
            this.btnIniCad.Enabled = false;
            this.btnIniCad.Location = new System.Drawing.Point(193, 15);
            this.btnIniCad.Name = "btnIniCad";
            this.btnIniCad.Size = new System.Drawing.Size(171, 36);
            this.btnIniCad.TabIndex = 4;
            this.btnIniCad.Text = "Gerar Orçamento";
            this.btnIniCad.UseVisualStyleBackColor = true;
            this.btnIniCad.Click += new System.EventHandler(this.btnIniCad_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(552, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 36);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadVend
            // 
            this.btnCadVend.Enabled = false;
            this.btnCadVend.Location = new System.Drawing.Point(370, 15);
            this.btnCadVend.Name = "btnCadVend";
            this.btnCadVend.Size = new System.Drawing.Size(176, 36);
            this.btnCadVend.TabIndex = 5;
            this.btnCadVend.Text = "Salvar Venda";
            this.btnCadVend.UseVisualStyleBackColor = true;
            this.btnCadVend.Click += new System.EventHandler(this.btnCadVend_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cadastro_de_Categorias_de_DespesasTableAdapter = null;
            this.tableAdapterManager.Cargos_AdministrativosTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_de_ProdutoTableAdapter = null;
            this.tableAdapterManager.Conta_a_ReceberTableAdapter = null;
            this.tableAdapterManager.Controle_de_EstoqueTableAdapter = null;
            this.tableAdapterManager.Dados_ProdutosTableAdapter = this.dados_ProdutosTableAdapter;
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
            // dados_ProdutosTableAdapter
            // 
            this.dados_ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // lojaTableAdapter
            // 
            this.lojaTableAdapter.ClearBeforeFill = true;
            // 
            // vendedorTableAdapter
            // 
            this.vendedorTableAdapter.ClearBeforeFill = true;
            // 
            // vendasTableAdapter
            // 
            this.vendasTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 556);
            this.ControlBox = false;
            this.Controls.Add(this.gbNomPro);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.gbDadPag);
            this.Controls.Add(this.gbDadVend);
            this.DoubleBuffered = true;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Iniciar_Vendas_Load);
            this.gbDadVend.ResumeLayout(false);
            this.gbDadVend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lojaBindingSource)).EndInit();
            this.gbNomPro.ResumeLayout(false);
            this.gbNomPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDetalhes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dados_ProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.gbDadPag.ResumeLayout(false);
            this.gbDadPag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDadPag)).EndInit();
            this.gbOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadVend;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNota;
        private BancoExtimpexDataSetTableAdapters.Dados_ProdutosTableAdapter dados_ProdutosTableAdapter;
        private System.Windows.Forms.BindingSource dados_ProdutosBindingSource;
        private System.Windows.Forms.GroupBox gbNomPro;
        private System.Windows.Forms.TextBox txtValPro;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.ComboBox cmbNomPro;
        private System.Windows.Forms.GroupBox gbDadPag;
        private System.Windows.Forms.TextBox txtValTotDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIniCad;
        private System.Windows.Forms.Button btnCadVend;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private BancoExtimpexDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.TextBox textValTotPro;
        private System.Windows.Forms.ComboBox cmbFromPag;
        private System.Windows.Forms.Label lbParc;
        private System.Windows.Forms.Button btnGerFat;
        private System.Windows.Forms.Label lbBad;
        private System.Windows.Forms.ComboBox cmbBad;
        private System.Windows.Forms.TextBox txtParc;
        private System.Windows.Forms.Button btnExclu;
        private System.Windows.Forms.Label lbJuro;
        private System.Windows.Forms.TextBox txtJuro;
        private System.Windows.Forms.Button btnPesq;
        private BancoExtimpexDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView dtaGridCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource lojaBindingSource;
        private BancoExtimpexDataSetTableAdapters.LojaTableAdapter lojaTableAdapter;
        private System.Windows.Forms.BindingSource vendedorBindingSource;
        private BancoExtimpexDataSetTableAdapters.VendedorTableAdapter vendedorTableAdapter;
        private System.Windows.Forms.TextBox txtVendor;
        private BancoExtimpexDataSetTableAdapters.VendasTableAdapter vendasTableAdapter;
        private System.Windows.Forms.TextBox txtdescP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtaGridDadPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn QdP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vlr;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtVnc;
        private System.Windows.Forms.DataGridViewTextBoxColumn JrD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        public System.Windows.Forms.DataGridView dtGridDetalhes;
        private System.Windows.Forms.BindingSource vendasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Dados_Produtos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}