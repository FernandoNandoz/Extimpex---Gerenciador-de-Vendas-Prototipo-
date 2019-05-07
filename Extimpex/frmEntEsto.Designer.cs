namespace Extimpex
{
    partial class frmCadEntEsto
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
            System.Windows.Forms.Label nome_do_ProdutoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valor_do_ProdutoLabel;
            System.Windows.Forms.Label valor_Total_do_ProdutoLabel;
            System.Windows.Forms.Label data_de_EntradaLabel;
            System.Windows.Forms.Label nota_FiscalLabel;
            System.Windows.Forms.Label data_de_EmissaoLabel;
            System.Windows.Forms.Label cFOPLabel;
            System.Windows.Forms.Label chave_de_AcessoLabel;
            System.Windows.Forms.Label id_FornecedorLabel;
            System.Windows.Forms.Label base_de_Calculo_ICMSLabel;
            System.Windows.Forms.Label valor_dp_ICMSLabel;
            System.Windows.Forms.Label valor_Total_da_NotaLabel;
            this.gbDadNot = new System.Windows.Forms.GroupBox();
            this.cmbForn = new System.Windows.Forms.ComboBox();
            this.extimpexFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.txtChavAcss = new System.Windows.Forms.MaskedTextBox();
            this.cmbCFOP = new System.Windows.Forms.ComboBox();
            this.dtDtaEmss = new System.Windows.Forms.DateTimePicker();
            this.txtNotFisc = new System.Windows.Forms.TextBox();
            this.dtDtaEnt = new System.Windows.Forms.DateTimePicker();
            this.nota_FiscalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notas_ProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbDadPro = new System.Windows.Forms.GroupBox();
            this.btnInser = new System.Windows.Forms.Button();
            this.txtValTotPro = new System.Windows.Forms.TextBox();
            this.txtValPro = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbNomPro = new System.Windows.Forms.ComboBox();
            this.gbDetlh = new System.Windows.Forms.GroupBox();
            this.dtaDetalhes = new System.Windows.Forms.DataGridView();
            this.Nota_Fiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Podutoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInci = new System.Windows.Forms.Button();
            this.btnSalv = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtBasCalICMS = new System.Windows.Forms.TextBox();
            this.txtValIcms = new System.Windows.Forms.TextBox();
            this.txtValTotNot = new System.Windows.Forms.TextBox();
            this.gbDadTriFisc = new System.Windows.Forms.GroupBox();
            this.gbOpco = new System.Windows.Forms.GroupBox();
            this.notas_ProdutoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Notas_ProdutoTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.extimpex_FornecedorTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Extimpex_FornecedorTableAdapter();
            this.nota_FiscalTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Nota_FiscalTableAdapter();
            this.produtoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.ProdutoTableAdapter();
            nome_do_ProdutoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valor_do_ProdutoLabel = new System.Windows.Forms.Label();
            valor_Total_do_ProdutoLabel = new System.Windows.Forms.Label();
            data_de_EntradaLabel = new System.Windows.Forms.Label();
            nota_FiscalLabel = new System.Windows.Forms.Label();
            data_de_EmissaoLabel = new System.Windows.Forms.Label();
            cFOPLabel = new System.Windows.Forms.Label();
            chave_de_AcessoLabel = new System.Windows.Forms.Label();
            id_FornecedorLabel = new System.Windows.Forms.Label();
            base_de_Calculo_ICMSLabel = new System.Windows.Forms.Label();
            valor_dp_ICMSLabel = new System.Windows.Forms.Label();
            valor_Total_da_NotaLabel = new System.Windows.Forms.Label();
            this.gbDadNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extimpexFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_FiscalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_ProdutoBindingSource)).BeginInit();
            this.gbDadPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.gbDetlh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaDetalhes)).BeginInit();
            this.gbDadTriFisc.SuspendLayout();
            this.gbOpco.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome_do_ProdutoLabel
            // 
            nome_do_ProdutoLabel.AutoSize = true;
            nome_do_ProdutoLabel.Location = new System.Drawing.Point(13, 21);
            nome_do_ProdutoLabel.Name = "nome_do_ProdutoLabel";
            nome_do_ProdutoLabel.Size = new System.Drawing.Size(93, 13);
            nome_do_ProdutoLabel.TabIndex = 0;
            nome_do_ProdutoLabel.Text = "Nome do Produto:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(289, 21);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(13, 61);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valor_do_ProdutoLabel
            // 
            valor_do_ProdutoLabel.AutoSize = true;
            valor_do_ProdutoLabel.Location = new System.Drawing.Point(131, 61);
            valor_do_ProdutoLabel.Name = "valor_do_ProdutoLabel";
            valor_do_ProdutoLabel.Size = new System.Drawing.Size(89, 13);
            valor_do_ProdutoLabel.TabIndex = 6;
            valor_do_ProdutoLabel.Text = "Valor do Produto:";
            // 
            // valor_Total_do_ProdutoLabel
            // 
            valor_Total_do_ProdutoLabel.AutoSize = true;
            valor_Total_do_ProdutoLabel.Location = new System.Drawing.Point(244, 61);
            valor_Total_do_ProdutoLabel.Name = "valor_Total_do_ProdutoLabel";
            valor_Total_do_ProdutoLabel.Size = new System.Drawing.Size(116, 13);
            valor_Total_do_ProdutoLabel.TabIndex = 8;
            valor_Total_do_ProdutoLabel.Text = "Valor Total do Produto:";
            // 
            // data_de_EntradaLabel
            // 
            data_de_EntradaLabel.AutoSize = true;
            data_de_EntradaLabel.Location = new System.Drawing.Point(180, 19);
            data_de_EntradaLabel.Name = "data_de_EntradaLabel";
            data_de_EntradaLabel.Size = new System.Drawing.Size(88, 13);
            data_de_EntradaLabel.TabIndex = 0;
            data_de_EntradaLabel.Text = "Data de Entrada:";
            // 
            // nota_FiscalLabel
            // 
            nota_FiscalLabel.AutoSize = true;
            nota_FiscalLabel.Location = new System.Drawing.Point(13, 19);
            nota_FiscalLabel.Name = "nota_FiscalLabel";
            nota_FiscalLabel.Size = new System.Drawing.Size(63, 13);
            nota_FiscalLabel.TabIndex = 2;
            nota_FiscalLabel.Text = "Nota Fiscal:";
            // 
            // data_de_EmissaoLabel
            // 
            data_de_EmissaoLabel.AutoSize = true;
            data_de_EmissaoLabel.Location = new System.Drawing.Point(79, 19);
            data_de_EmissaoLabel.Name = "data_de_EmissaoLabel";
            data_de_EmissaoLabel.Size = new System.Drawing.Size(90, 13);
            data_de_EmissaoLabel.TabIndex = 4;
            data_de_EmissaoLabel.Text = "Data de Emissao:";
            // 
            // cFOPLabel
            // 
            cFOPLabel.AutoSize = true;
            cFOPLabel.Location = new System.Drawing.Point(282, 19);
            cFOPLabel.Name = "cFOPLabel";
            cFOPLabel.Size = new System.Drawing.Size(38, 13);
            cFOPLabel.TabIndex = 6;
            cFOPLabel.Text = "CFOP:";
            // 
            // chave_de_AcessoLabel
            // 
            chave_de_AcessoLabel.AutoSize = true;
            chave_de_AcessoLabel.Location = new System.Drawing.Point(13, 58);
            chave_de_AcessoLabel.Name = "chave_de_AcessoLabel";
            chave_de_AcessoLabel.Size = new System.Drawing.Size(94, 13);
            chave_de_AcessoLabel.TabIndex = 8;
            chave_de_AcessoLabel.Text = "Chave de Acesso:";
            // 
            // id_FornecedorLabel
            // 
            id_FornecedorLabel.AutoSize = true;
            id_FornecedorLabel.Location = new System.Drawing.Point(13, 97);
            id_FornecedorLabel.Name = "id_FornecedorLabel";
            id_FornecedorLabel.Size = new System.Drawing.Size(64, 13);
            id_FornecedorLabel.TabIndex = 10;
            id_FornecedorLabel.Text = "Fornecedor:";
            // 
            // base_de_Calculo_ICMSLabel
            // 
            base_de_Calculo_ICMSLabel.AutoSize = true;
            base_de_Calculo_ICMSLabel.Location = new System.Drawing.Point(13, 20);
            base_de_Calculo_ICMSLabel.Name = "base_de_Calculo_ICMSLabel";
            base_de_Calculo_ICMSLabel.Size = new System.Drawing.Size(116, 13);
            base_de_Calculo_ICMSLabel.TabIndex = 1;
            base_de_Calculo_ICMSLabel.Text = "Base de Calculo ICMS:";
            // 
            // valor_dp_ICMSLabel
            // 
            valor_dp_ICMSLabel.AutoSize = true;
            valor_dp_ICMSLabel.Location = new System.Drawing.Point(132, 20);
            valor_dp_ICMSLabel.Name = "valor_dp_ICMSLabel";
            valor_dp_ICMSLabel.Size = new System.Drawing.Size(78, 13);
            valor_dp_ICMSLabel.TabIndex = 3;
            valor_dp_ICMSLabel.Text = "Valor do ICMS:";
            // 
            // valor_Total_da_NotaLabel
            // 
            valor_Total_da_NotaLabel.AutoSize = true;
            valor_Total_da_NotaLabel.Location = new System.Drawing.Point(244, 20);
            valor_Total_da_NotaLabel.Name = "valor_Total_da_NotaLabel";
            valor_Total_da_NotaLabel.Size = new System.Drawing.Size(102, 13);
            valor_Total_da_NotaLabel.TabIndex = 5;
            valor_Total_da_NotaLabel.Text = "Valor Total da Nota:";
            // 
            // gbDadNot
            // 
            this.gbDadNot.Controls.Add(id_FornecedorLabel);
            this.gbDadNot.Controls.Add(this.cmbForn);
            this.gbDadNot.Controls.Add(chave_de_AcessoLabel);
            this.gbDadNot.Controls.Add(this.txtChavAcss);
            this.gbDadNot.Controls.Add(cFOPLabel);
            this.gbDadNot.Controls.Add(this.cmbCFOP);
            this.gbDadNot.Controls.Add(data_de_EmissaoLabel);
            this.gbDadNot.Controls.Add(this.dtDtaEmss);
            this.gbDadNot.Controls.Add(nota_FiscalLabel);
            this.gbDadNot.Controls.Add(this.txtNotFisc);
            this.gbDadNot.Controls.Add(data_de_EntradaLabel);
            this.gbDadNot.Controls.Add(this.dtDtaEnt);
            this.gbDadNot.Enabled = false;
            this.gbDadNot.Location = new System.Drawing.Point(5, 0);
            this.gbDadNot.Name = "gbDadNot";
            this.gbDadNot.Size = new System.Drawing.Size(373, 150);
            this.gbDadNot.TabIndex = 0;
            this.gbDadNot.TabStop = false;
            this.gbDadNot.Text = "Dados de Nota Fiscal";
            // 
            // cmbForn
            // 
            this.cmbForn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpexFornecedorBindingSource, "Nome_Razao_Social", true));
            this.cmbForn.DataSource = this.extimpexFornecedorBindingSource;
            this.cmbForn.DisplayMember = "Nome_Razao_Social";
            this.cmbForn.FormattingEnabled = true;
            this.cmbForn.Location = new System.Drawing.Point(16, 113);
            this.cmbForn.Name = "cmbForn";
            this.cmbForn.Size = new System.Drawing.Size(344, 21);
            this.cmbForn.TabIndex = 11;
            this.cmbForn.ValueMember = "Id_Fornecedor";
            // 
            // extimpexFornecedorBindingSource
            // 
            this.extimpexFornecedorBindingSource.DataMember = "Extimpex_Fornecedor";
            this.extimpexFornecedorBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtChavAcss
            // 
            this.txtChavAcss.Location = new System.Drawing.Point(16, 74);
            this.txtChavAcss.Mask = "0000.0000.0000.0000.0000.0000.0000.0000.0000.0000.0000";
            this.txtChavAcss.Name = "txtChavAcss";
            this.txtChavAcss.Size = new System.Drawing.Size(344, 20);
            this.txtChavAcss.TabIndex = 9;
            // 
            // cmbCFOP
            // 
            this.cmbCFOP.FormattingEnabled = true;
            this.cmbCFOP.Items.AddRange(new object[] {
            "5102",
            "6201",
            "5404"});
            this.cmbCFOP.Location = new System.Drawing.Point(285, 34);
            this.cmbCFOP.Name = "cmbCFOP";
            this.cmbCFOP.Size = new System.Drawing.Size(75, 21);
            this.cmbCFOP.TabIndex = 7;
            // 
            // dtDtaEmss
            // 
            this.dtDtaEmss.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDtaEmss.Location = new System.Drawing.Point(82, 35);
            this.dtDtaEmss.Name = "dtDtaEmss";
            this.dtDtaEmss.Size = new System.Drawing.Size(95, 20);
            this.dtDtaEmss.TabIndex = 5;
            // 
            // txtNotFisc
            // 
            this.txtNotFisc.Location = new System.Drawing.Point(16, 35);
            this.txtNotFisc.Name = "txtNotFisc";
            this.txtNotFisc.Size = new System.Drawing.Size(60, 20);
            this.txtNotFisc.TabIndex = 3;
            // 
            // dtDtaEnt
            // 
            this.dtDtaEnt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDtaEnt.Location = new System.Drawing.Point(183, 35);
            this.dtDtaEnt.Name = "dtDtaEnt";
            this.dtDtaEnt.Size = new System.Drawing.Size(96, 20);
            this.dtDtaEnt.TabIndex = 1;
            // 
            // nota_FiscalBindingSource
            // 
            this.nota_FiscalBindingSource.DataMember = "Nota_Fiscal";
            this.nota_FiscalBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // notas_ProdutoBindingSource
            // 
            this.notas_ProdutoBindingSource.DataMember = "Notas_Produto";
            this.notas_ProdutoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // gbDadPro
            // 
            this.gbDadPro.Controls.Add(this.btnInser);
            this.gbDadPro.Controls.Add(valor_Total_do_ProdutoLabel);
            this.gbDadPro.Controls.Add(this.txtValTotPro);
            this.gbDadPro.Controls.Add(valor_do_ProdutoLabel);
            this.gbDadPro.Controls.Add(this.txtValPro);
            this.gbDadPro.Controls.Add(quantidadeLabel);
            this.gbDadPro.Controls.Add(this.txtQuant);
            this.gbDadPro.Controls.Add(codigoLabel);
            this.gbDadPro.Controls.Add(this.txtCod);
            this.gbDadPro.Controls.Add(nome_do_ProdutoLabel);
            this.gbDadPro.Controls.Add(this.cmbNomPro);
            this.gbDadPro.Enabled = false;
            this.gbDadPro.Location = new System.Drawing.Point(5, 156);
            this.gbDadPro.Name = "gbDadPro";
            this.gbDadPro.Size = new System.Drawing.Size(373, 137);
            this.gbDadPro.TabIndex = 0;
            this.gbDadPro.TabStop = false;
            this.gbDadPro.Text = "Dados do Produto";
            // 
            // btnInser
            // 
            this.btnInser.Location = new System.Drawing.Point(16, 103);
            this.btnInser.Name = "btnInser";
            this.btnInser.Size = new System.Drawing.Size(344, 23);
            this.btnInser.TabIndex = 10;
            this.btnInser.Text = "Inserir";
            this.btnInser.UseVisualStyleBackColor = true;
            this.btnInser.Click += new System.EventHandler(this.btnInser_Click);
            // 
            // txtValTotPro
            // 
            this.txtValTotPro.Location = new System.Drawing.Point(247, 77);
            this.txtValTotPro.Name = "txtValTotPro";
            this.txtValTotPro.ReadOnly = true;
            this.txtValTotPro.Size = new System.Drawing.Size(113, 20);
            this.txtValTotPro.TabIndex = 9;
            // 
            // txtValPro
            // 
            this.txtValPro.Location = new System.Drawing.Point(134, 77);
            this.txtValPro.Name = "txtValPro";
            this.txtValPro.Size = new System.Drawing.Size(107, 20);
            this.txtValPro.TabIndex = 7;
            this.txtValPro.TextChanged += new System.EventHandler(this.txtValPro_TextChanged);
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(16, 77);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(112, 20);
            this.txtQuant.TabIndex = 5;
            // 
            // txtCod
            // 
            this.txtCod.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Codigo", true));
            this.txtCod.Location = new System.Drawing.Point(292, 37);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(68, 20);
            this.txtCod.TabIndex = 3;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // cmbNomPro
            // 
            this.cmbNomPro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notas_ProdutoBindingSource, "Nome_do_Produto", true));
            this.cmbNomPro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.notas_ProdutoBindingSource, "Nome_do_Produto", true));
            this.cmbNomPro.DataSource = this.produtoBindingSource;
            this.cmbNomPro.DisplayMember = "Nome_do_Produto";
            this.cmbNomPro.FormattingEnabled = true;
            this.cmbNomPro.Location = new System.Drawing.Point(16, 37);
            this.cmbNomPro.Name = "cmbNomPro";
            this.cmbNomPro.Size = new System.Drawing.Size(270, 21);
            this.cmbNomPro.TabIndex = 1;
            this.cmbNomPro.ValueMember = "Id_Produto";
            // 
            // gbDetlh
            // 
            this.gbDetlh.Controls.Add(this.dtaDetalhes);
            this.gbDetlh.Location = new System.Drawing.Point(384, 0);
            this.gbDetlh.Name = "gbDetlh";
            this.gbDetlh.Size = new System.Drawing.Size(464, 293);
            this.gbDetlh.TabIndex = 1;
            this.gbDetlh.TabStop = false;
            this.gbDetlh.Text = "Detalhes";
            // 
            // dtaDetalhes
            // 
            this.dtaDetalhes.AllowUserToAddRows = false;
            this.dtaDetalhes.AllowUserToDeleteRows = false;
            this.dtaDetalhes.AllowUserToResizeColumns = false;
            this.dtaDetalhes.AllowUserToResizeRows = false;
            this.dtaDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaDetalhes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nota_Fiscal,
            this.C0,
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.Id_Podutoss});
            this.dtaDetalhes.Location = new System.Drawing.Point(15, 21);
            this.dtaDetalhes.MultiSelect = false;
            this.dtaDetalhes.Name = "dtaDetalhes";
            this.dtaDetalhes.ReadOnly = true;
            this.dtaDetalhes.RowHeadersVisible = false;
            this.dtaDetalhes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaDetalhes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaDetalhes.Size = new System.Drawing.Size(438, 258);
            this.dtaDetalhes.TabIndex = 0;
            // 
            // Nota_Fiscal
            // 
            this.Nota_Fiscal.HeaderText = "Nota Fiscal";
            this.Nota_Fiscal.Name = "Nota_Fiscal";
            this.Nota_Fiscal.ReadOnly = true;
            this.Nota_Fiscal.Visible = false;
            // 
            // C0
            // 
            this.C0.HeaderText = "Codigo";
            this.C0.Name = "C0";
            this.C0.ReadOnly = true;
            this.C0.Width = 60;
            // 
            // C1
            // 
            this.C1.HeaderText = "Nome";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 150;
            // 
            // C2
            // 
            this.C2.HeaderText = "Quantidade";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 70;
            // 
            // C3
            // 
            this.C3.HeaderText = "Valor";
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            this.C3.Width = 70;
            // 
            // C4
            // 
            this.C4.HeaderText = "Valor Total";
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.Width = 85;
            // 
            // Id_Podutoss
            // 
            this.Id_Podutoss.HeaderText = "Id_Produto";
            this.Id_Podutoss.Name = "Id_Podutoss";
            this.Id_Podutoss.ReadOnly = true;
            this.Id_Podutoss.Visible = false;
            // 
            // btnInci
            // 
            this.btnInci.Location = new System.Drawing.Point(26, 20);
            this.btnInci.Name = "btnInci";
            this.btnInci.Size = new System.Drawing.Size(126, 34);
            this.btnInci.TabIndex = 0;
            this.btnInci.Text = "Iniciar";
            this.btnInci.UseVisualStyleBackColor = true;
            this.btnInci.Click += new System.EventHandler(this.btnInci_Click);
            // 
            // btnSalv
            // 
            this.btnSalv.Enabled = false;
            this.btnSalv.Location = new System.Drawing.Point(158, 20);
            this.btnSalv.Name = "btnSalv";
            this.btnSalv.Size = new System.Drawing.Size(157, 34);
            this.btnSalv.TabIndex = 1;
            this.btnSalv.Text = "Salvar";
            this.btnSalv.UseVisualStyleBackColor = true;
            this.btnSalv.Click += new System.EventHandler(this.btnSalv_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(321, 20);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 34);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtBasCalICMS
            // 
            this.txtBasCalICMS.Location = new System.Drawing.Point(16, 36);
            this.txtBasCalICMS.Name = "txtBasCalICMS";
            this.txtBasCalICMS.ReadOnly = true;
            this.txtBasCalICMS.Size = new System.Drawing.Size(112, 20);
            this.txtBasCalICMS.TabIndex = 2;
            // 
            // txtValIcms
            // 
            this.txtValIcms.Location = new System.Drawing.Point(135, 36);
            this.txtValIcms.Name = "txtValIcms";
            this.txtValIcms.ReadOnly = true;
            this.txtValIcms.Size = new System.Drawing.Size(106, 20);
            this.txtValIcms.TabIndex = 4;
            // 
            // txtValTotNot
            // 
            this.txtValTotNot.Location = new System.Drawing.Point(247, 36);
            this.txtValTotNot.Name = "txtValTotNot";
            this.txtValTotNot.ReadOnly = true;
            this.txtValTotNot.Size = new System.Drawing.Size(113, 20);
            this.txtValTotNot.TabIndex = 6;
            // 
            // gbDadTriFisc
            // 
            this.gbDadTriFisc.Controls.Add(valor_Total_da_NotaLabel);
            this.gbDadTriFisc.Controls.Add(this.txtBasCalICMS);
            this.gbDadTriFisc.Controls.Add(this.txtValTotNot);
            this.gbDadTriFisc.Controls.Add(base_de_Calculo_ICMSLabel);
            this.gbDadTriFisc.Controls.Add(valor_dp_ICMSLabel);
            this.gbDadTriFisc.Controls.Add(this.txtValIcms);
            this.gbDadTriFisc.Enabled = false;
            this.gbDadTriFisc.Location = new System.Drawing.Point(5, 299);
            this.gbDadTriFisc.Name = "gbDadTriFisc";
            this.gbDadTriFisc.Size = new System.Drawing.Size(373, 71);
            this.gbDadTriFisc.TabIndex = 3;
            this.gbDadTriFisc.TabStop = false;
            this.gbDadTriFisc.Text = "Dados de Tributação Fiscal";
            // 
            // gbOpco
            // 
            this.gbOpco.Controls.Add(this.btnInci);
            this.gbOpco.Controls.Add(this.btnSalv);
            this.gbOpco.Controls.Add(this.btnSair);
            this.gbOpco.Location = new System.Drawing.Point(384, 299);
            this.gbOpco.Name = "gbOpco";
            this.gbOpco.Size = new System.Drawing.Size(464, 71);
            this.gbOpco.TabIndex = 4;
            this.gbOpco.TabStop = false;
            this.gbOpco.Text = "Opções";
            // 
            // notas_ProdutoTableAdapter
            // 
            this.notas_ProdutoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Dados_ProdutosTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.Extimpex_FornecedorTableAdapter = this.extimpex_FornecedorTableAdapter;
            this.tableAdapterManager.Fluxo_de_CaixaTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Grupo_ProdutoTableAdapter = null;
            this.tableAdapterManager.LojaTableAdapter = null;
            this.tableAdapterManager.Nota_FiscalTableAdapter = this.nota_FiscalTableAdapter;
            this.tableAdapterManager.Notas_ProdutoTableAdapter = this.notas_ProdutoTableAdapter;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VendasTableAdapter = null;
            this.tableAdapterManager.VendedorTableAdapter = null;
            // 
            // extimpex_FornecedorTableAdapter
            // 
            this.extimpex_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // nota_FiscalTableAdapter
            // 
            this.nota_FiscalTableAdapter.ClearBeforeFill = true;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadEntEsto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 378);
            this.ControlBox = false;
            this.Controls.Add(this.gbOpco);
            this.Controls.Add(this.gbDadTriFisc);
            this.Controls.Add(this.gbDetlh);
            this.Controls.Add(this.gbDadPro);
            this.Controls.Add(this.gbDadNot);
            this.Name = "frmCadEntEsto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Nota Fiscal";
            this.Load += new System.EventHandler(this.frmCadEntEsto_Load);
            this.gbDadNot.ResumeLayout(false);
            this.gbDadNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extimpexFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota_FiscalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notas_ProdutoBindingSource)).EndInit();
            this.gbDadPro.ResumeLayout(false);
            this.gbDadPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.gbDetlh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaDetalhes)).EndInit();
            this.gbDadTriFisc.ResumeLayout(false);
            this.gbDadTriFisc.PerformLayout();
            this.gbOpco.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadNot;
        private System.Windows.Forms.GroupBox gbDadPro;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource notas_ProdutoBindingSource;
        private BancoExtimpexDataSetTableAdapters.Notas_ProdutoTableAdapter notas_ProdutoTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dtDtaEnt;
        private System.Windows.Forms.Button btnInser;
        private System.Windows.Forms.TextBox txtValTotPro;
        private System.Windows.Forms.TextBox txtValPro;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.ComboBox cmbNomPro;
        private System.Windows.Forms.GroupBox gbDetlh;
        private System.Windows.Forms.DataGridView dtaDetalhes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalv;
        private System.Windows.Forms.Button btnInci;
        private BancoExtimpexDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private BancoExtimpexDataSetTableAdapters.Nota_FiscalTableAdapter nota_FiscalTableAdapter;
        private System.Windows.Forms.BindingSource nota_FiscalBindingSource;
        private System.Windows.Forms.ComboBox cmbForn;
        private System.Windows.Forms.MaskedTextBox txtChavAcss;
        private System.Windows.Forms.ComboBox cmbCFOP;
        private System.Windows.Forms.DateTimePicker dtDtaEmss;
        private System.Windows.Forms.TextBox txtNotFisc;
        private BancoExtimpexDataSetTableAdapters.Extimpex_FornecedorTableAdapter extimpex_FornecedorTableAdapter;
        private System.Windows.Forms.BindingSource extimpexFornecedorBindingSource;
        private System.Windows.Forms.TextBox txtValTotNot;
        private System.Windows.Forms.TextBox txtValIcms;
        private System.Windows.Forms.TextBox txtBasCalICMS;
        private System.Windows.Forms.GroupBox gbDadTriFisc;
        private System.Windows.Forms.GroupBox gbOpco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota_Fiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn C0;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Podutoss;
    }
}