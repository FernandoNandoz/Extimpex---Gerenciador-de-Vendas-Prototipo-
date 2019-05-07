namespace Extimpex
{
    partial class frmCadForn
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
            System.Windows.Forms.Label id_FornecedorLabel;
            System.Windows.Forms.Label nome_Razao_SocialLabel;
            System.Windows.Forms.Label cNPJLabel;
            System.Windows.Forms.Label inscricao_EstadualLabel;
            System.Windows.Forms.Label inscricao_MunicipalLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label telefone_SecundarioLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label responsavelLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inscricao_MunicipalTextBox = new System.Windows.Forms.TextBox();
            this.extimpex_FornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.inscricao_EstadualTextBox = new System.Windows.Forms.TextBox();
            this.cNPJTextBox = new System.Windows.Forms.TextBox();
            this.nome_Razao_SocialTextBox = new System.Windows.Forms.TextBox();
            this.id_FornecedorTextBox = new System.Windows.Forms.TextBox();
            this.extimpex_FornecedorTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Extimpex_FornecedorTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.cidadeTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.CidadeTableAdapter();
            this.estadoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.EstadoTableAdapter();
            this.paisTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.PaisTableAdapter();
            this.gbForn = new System.Windows.Forms.GroupBox();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisComboBox = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.responsavelTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.telefone_SecundarioTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.btnCadForCad = new System.Windows.Forms.Button();
            this.btnCadForSalv = new System.Windows.Forms.Button();
            this.btnCadForSair = new System.Windows.Forms.Button();
            id_FornecedorLabel = new System.Windows.Forms.Label();
            nome_Razao_SocialLabel = new System.Windows.Forms.Label();
            cNPJLabel = new System.Windows.Forms.Label();
            inscricao_EstadualLabel = new System.Windows.Forms.Label();
            inscricao_MunicipalLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            telefone_SecundarioLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            responsavelLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extimpex_FornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            this.gbForn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_FornecedorLabel
            // 
            id_FornecedorLabel.AutoSize = true;
            id_FornecedorLabel.Location = new System.Drawing.Point(3, 16);
            id_FornecedorLabel.Name = "id_FornecedorLabel";
            id_FornecedorLabel.Size = new System.Drawing.Size(76, 13);
            id_FornecedorLabel.TabIndex = 0;
            id_FornecedorLabel.Text = "Id Fornecedor:";
            // 
            // nome_Razao_SocialLabel
            // 
            nome_Razao_SocialLabel.AutoSize = true;
            nome_Razao_SocialLabel.Location = new System.Drawing.Point(3, 66);
            nome_Razao_SocialLabel.Name = "nome_Razao_SocialLabel";
            nome_Razao_SocialLabel.Size = new System.Drawing.Size(104, 13);
            nome_Razao_SocialLabel.TabIndex = 2;
            nome_Razao_SocialLabel.Text = "Nome Razao Social:";
            // 
            // cNPJLabel
            // 
            cNPJLabel.AutoSize = true;
            cNPJLabel.Location = new System.Drawing.Point(3, 105);
            cNPJLabel.Name = "cNPJLabel";
            cNPJLabel.Size = new System.Drawing.Size(37, 13);
            cNPJLabel.TabIndex = 4;
            cNPJLabel.Text = "CNPJ:";
            // 
            // inscricao_EstadualLabel
            // 
            inscricao_EstadualLabel.AutoSize = true;
            inscricao_EstadualLabel.Location = new System.Drawing.Point(282, 105);
            inscricao_EstadualLabel.Name = "inscricao_EstadualLabel";
            inscricao_EstadualLabel.Size = new System.Drawing.Size(97, 13);
            inscricao_EstadualLabel.TabIndex = 6;
            inscricao_EstadualLabel.Text = "Inscricao Estadual:";
            // 
            // inscricao_MunicipalLabel
            // 
            inscricao_MunicipalLabel.AutoSize = true;
            inscricao_MunicipalLabel.Location = new System.Drawing.Point(142, 105);
            inscricao_MunicipalLabel.Name = "inscricao_MunicipalLabel";
            inscricao_MunicipalLabel.Size = new System.Drawing.Size(101, 13);
            inscricao_MunicipalLabel.TabIndex = 10;
            inscricao_MunicipalLabel.Text = "Inscricao Municipal:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(3, 16);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 0;
            enderecoLabel.Text = "Endereco:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(3, 55);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 2;
            paisLabel.Text = "Pais:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(142, 55);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 4;
            estadoLabel.Text = "Estado:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(282, 55);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 6;
            cidadeLabel.Text = "Cidade:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(3, 16);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 0;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefone_SecundarioLabel
            // 
            telefone_SecundarioLabel.AutoSize = true;
            telefone_SecundarioLabel.Location = new System.Drawing.Point(213, 16);
            telefone_SecundarioLabel.Name = "telefone_SecundarioLabel";
            telefone_SecundarioLabel.Size = new System.Drawing.Size(109, 13);
            telefone_SecundarioLabel.TabIndex = 2;
            telefone_SecundarioLabel.Text = "Telefone Secundario:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(3, 55);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // responsavelLabel
            // 
            responsavelLabel.AutoSize = true;
            responsavelLabel.Location = new System.Drawing.Point(3, 94);
            responsavelLabel.Name = "responsavelLabel";
            responsavelLabel.Size = new System.Drawing.Size(72, 13);
            responsavelLabel.TabIndex = 6;
            responsavelLabel.Text = "Responsavel:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(inscricao_MunicipalLabel);
            this.groupBox1.Controls.Add(this.inscricao_MunicipalTextBox);
            this.groupBox1.Controls.Add(inscricao_EstadualLabel);
            this.groupBox1.Controls.Add(this.inscricao_EstadualTextBox);
            this.groupBox1.Controls.Add(cNPJLabel);
            this.groupBox1.Controls.Add(this.cNPJTextBox);
            this.groupBox1.Controls.Add(nome_Razao_SocialLabel);
            this.groupBox1.Controls.Add(this.nome_Razao_SocialTextBox);
            this.groupBox1.Controls.Add(id_FornecedorLabel);
            this.groupBox1.Controls.Add(this.id_FornecedorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Fornecedor";
            // 
            // inscricao_MunicipalTextBox
            // 
            this.inscricao_MunicipalTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inscricao_MunicipalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Inscricao_Municipal", true));
            this.inscricao_MunicipalTextBox.Enabled = false;
            this.inscricao_MunicipalTextBox.Location = new System.Drawing.Point(145, 121);
            this.inscricao_MunicipalTextBox.Name = "inscricao_MunicipalTextBox";
            this.inscricao_MunicipalTextBox.Size = new System.Drawing.Size(134, 20);
            this.inscricao_MunicipalTextBox.TabIndex = 11;
            // 
            // extimpex_FornecedorBindingSource
            // 
            this.extimpex_FornecedorBindingSource.DataMember = "Extimpex_Fornecedor";
            this.extimpex_FornecedorBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscricao_EstadualTextBox
            // 
            this.inscricao_EstadualTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inscricao_EstadualTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Inscricao_Estadual", true));
            this.inscricao_EstadualTextBox.Enabled = false;
            this.inscricao_EstadualTextBox.Location = new System.Drawing.Point(285, 121);
            this.inscricao_EstadualTextBox.Name = "inscricao_EstadualTextBox";
            this.inscricao_EstadualTextBox.Size = new System.Drawing.Size(143, 20);
            this.inscricao_EstadualTextBox.TabIndex = 7;
            // 
            // cNPJTextBox
            // 
            this.cNPJTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cNPJTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "CNPJ", true));
            this.cNPJTextBox.Enabled = false;
            this.cNPJTextBox.Location = new System.Drawing.Point(6, 121);
            this.cNPJTextBox.Name = "cNPJTextBox";
            this.cNPJTextBox.Size = new System.Drawing.Size(133, 20);
            this.cNPJTextBox.TabIndex = 5;
            // 
            // nome_Razao_SocialTextBox
            // 
            this.nome_Razao_SocialTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_Razao_SocialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Nome_Razao_Social", true));
            this.nome_Razao_SocialTextBox.Enabled = false;
            this.nome_Razao_SocialTextBox.Location = new System.Drawing.Point(6, 82);
            this.nome_Razao_SocialTextBox.Name = "nome_Razao_SocialTextBox";
            this.nome_Razao_SocialTextBox.Size = new System.Drawing.Size(422, 20);
            this.nome_Razao_SocialTextBox.TabIndex = 3;
            // 
            // id_FornecedorTextBox
            // 
            this.id_FornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Id_Fornecedor", true));
            this.id_FornecedorTextBox.Enabled = false;
            this.id_FornecedorTextBox.Location = new System.Drawing.Point(6, 32);
            this.id_FornecedorTextBox.Name = "id_FornecedorTextBox";
            this.id_FornecedorTextBox.ReadOnly = true;
            this.id_FornecedorTextBox.Size = new System.Drawing.Size(80, 20);
            this.id_FornecedorTextBox.TabIndex = 1;
            // 
            // extimpex_FornecedorTableAdapter
            // 
            this.extimpex_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cadastro_de_Categorias_de_DespesasTableAdapter = null;
            this.tableAdapterManager.Cargos_AdministrativosTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = this.cidadeTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_de_ProdutoTableAdapter = null;
            this.tableAdapterManager.Conta_a_ReceberTableAdapter = null;
            this.tableAdapterManager.Controle_de_EstoqueTableAdapter = null;
            this.tableAdapterManager.Dados_ProdutosTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = this.estadoTableAdapter;
            this.tableAdapterManager.Extimpex_FornecedorTableAdapter = null;
            this.tableAdapterManager.Fluxo_de_CaixaTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Grupo_ProdutoTableAdapter = null;
            this.tableAdapterManager.LojaTableAdapter = null;
            this.tableAdapterManager.Nota_FiscalTableAdapter = null;
            this.tableAdapterManager.Notas_ProdutoTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = this.paisTableAdapter;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            this.tableAdapterManager.VendasTableAdapter = null;
            this.tableAdapterManager.VendedorTableAdapter = null;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // gbForn
            // 
            this.gbForn.Controls.Add(cidadeLabel);
            this.gbForn.Controls.Add(this.cidadeComboBox);
            this.gbForn.Controls.Add(estadoLabel);
            this.gbForn.Controls.Add(this.estadoComboBox);
            this.gbForn.Controls.Add(paisLabel);
            this.gbForn.Controls.Add(this.paisComboBox);
            this.gbForn.Controls.Add(enderecoLabel);
            this.gbForn.Controls.Add(this.enderecoTextBox);
            this.gbForn.Location = new System.Drawing.Point(9, 166);
            this.gbForn.Name = "gbForn";
            this.gbForn.Size = new System.Drawing.Size(441, 112);
            this.gbForn.TabIndex = 12;
            this.gbForn.TabStop = false;
            this.gbForn.Text = "Endereço do Fornecedor";
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.extimpex_FornecedorBindingSource, "Cidade", true));
            this.cidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Cidade", true));
            this.cidadeComboBox.DataSource = this.cidadeBindingSource;
            this.cidadeComboBox.DisplayMember = "Cidade";
            this.cidadeComboBox.Enabled = false;
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Location = new System.Drawing.Point(285, 71);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(143, 21);
            this.cidadeComboBox.TabIndex = 7;
            this.cidadeComboBox.ValueMember = "Id_Cidade";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "Cidade";
            this.cidadeBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.extimpex_FornecedorBindingSource, "Estado", true));
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Estado", true));
            this.estadoComboBox.DataSource = this.estadoBindingSource;
            this.estadoComboBox.DisplayMember = "Estado";
            this.estadoComboBox.Enabled = false;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(145, 71);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(134, 21);
            this.estadoComboBox.TabIndex = 5;
            this.estadoComboBox.ValueMember = "Id_Estado";
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // paisComboBox
            // 
            this.paisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.extimpex_FornecedorBindingSource, "Pais", true));
            this.paisComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Pais", true));
            this.paisComboBox.DataSource = this.paisBindingSource;
            this.paisComboBox.DisplayMember = "Pais";
            this.paisComboBox.Enabled = false;
            this.paisComboBox.FormattingEnabled = true;
            this.paisComboBox.Location = new System.Drawing.Point(6, 71);
            this.paisComboBox.Name = "paisComboBox";
            this.paisComboBox.Size = new System.Drawing.Size(133, 21);
            this.paisComboBox.TabIndex = 3;
            this.paisComboBox.ValueMember = "Id_Pais";
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "Pais";
            this.paisBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Endereco", true));
            this.enderecoTextBox.Enabled = false;
            this.enderecoTextBox.Location = new System.Drawing.Point(6, 32);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(422, 20);
            this.enderecoTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(responsavelLabel);
            this.groupBox2.Controls.Add(this.responsavelTextBox);
            this.groupBox2.Controls.Add(emailLabel);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(telefone_SecundarioLabel);
            this.groupBox2.Controls.Add(this.telefone_SecundarioTextBox);
            this.groupBox2.Controls.Add(telefoneLabel);
            this.groupBox2.Controls.Add(this.telefoneTextBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 140);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato do Fornecedor";
            // 
            // responsavelTextBox
            // 
            this.responsavelTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.responsavelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Responsavel", true));
            this.responsavelTextBox.Enabled = false;
            this.responsavelTextBox.Location = new System.Drawing.Point(6, 110);
            this.responsavelTextBox.Name = "responsavelTextBox";
            this.responsavelTextBox.Size = new System.Drawing.Size(422, 20);
            this.responsavelTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Email", true));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(6, 71);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(422, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // telefone_SecundarioTextBox
            // 
            this.telefone_SecundarioTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telefone_SecundarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Telefone_Secundario", true));
            this.telefone_SecundarioTextBox.Enabled = false;
            this.telefone_SecundarioTextBox.Location = new System.Drawing.Point(216, 32);
            this.telefone_SecundarioTextBox.Name = "telefone_SecundarioTextBox";
            this.telefone_SecundarioTextBox.Size = new System.Drawing.Size(212, 20);
            this.telefone_SecundarioTextBox.TabIndex = 3;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extimpex_FornecedorBindingSource, "Telefone", true));
            this.telefoneTextBox.Enabled = false;
            this.telefoneTextBox.Location = new System.Drawing.Point(6, 32);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(204, 20);
            this.telefoneTextBox.TabIndex = 1;
            // 
            // btnCadForCad
            // 
            this.btnCadForCad.Location = new System.Drawing.Point(40, 442);
            this.btnCadForCad.Name = "btnCadForCad";
            this.btnCadForCad.Size = new System.Drawing.Size(120, 34);
            this.btnCadForCad.TabIndex = 14;
            this.btnCadForCad.Text = "Cadastrar Fornecedor";
            this.btnCadForCad.UseVisualStyleBackColor = true;
            this.btnCadForCad.Click += new System.EventHandler(this.btnCadForCad_Click);
            // 
            // btnCadForSalv
            // 
            this.btnCadForSalv.Enabled = false;
            this.btnCadForSalv.Location = new System.Drawing.Point(166, 442);
            this.btnCadForSalv.Name = "btnCadForSalv";
            this.btnCadForSalv.Size = new System.Drawing.Size(120, 34);
            this.btnCadForSalv.TabIndex = 15;
            this.btnCadForSalv.Text = "Salvar Cadastro";
            this.btnCadForSalv.UseVisualStyleBackColor = true;
            this.btnCadForSalv.Click += new System.EventHandler(this.btnCadForSalv_Click);
            // 
            // btnCadForSair
            // 
            this.btnCadForSair.Location = new System.Drawing.Point(292, 442);
            this.btnCadForSair.Name = "btnCadForSair";
            this.btnCadForSair.Size = new System.Drawing.Size(120, 34);
            this.btnCadForSair.TabIndex = 16;
            this.btnCadForSair.Text = "Sair";
            this.btnCadForSair.UseVisualStyleBackColor = true;
            this.btnCadForSair.Click += new System.EventHandler(this.btnCadForSair_Click);
            // 
            // frmCadForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 488);
            this.ControlBox = false;
            this.Controls.Add(this.btnCadForSair);
            this.Controls.Add(this.btnCadForSalv);
            this.Controls.Add(this.btnCadForCad);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbForn);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.Load += new System.EventHandler(this.frmCadForn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extimpex_FornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            this.gbForn.ResumeLayout(false);
            this.gbForn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource extimpex_FornecedorBindingSource;
        private BancoExtimpexDataSetTableAdapters.Extimpex_FornecedorTableAdapter extimpex_FornecedorTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox inscricao_EstadualTextBox;
        private System.Windows.Forms.TextBox cNPJTextBox;
        private System.Windows.Forms.TextBox nome_Razao_SocialTextBox;
        private System.Windows.Forms.TextBox id_FornecedorTextBox;
        private System.Windows.Forms.TextBox inscricao_MunicipalTextBox;
        private System.Windows.Forms.GroupBox gbForn;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.ComboBox paisComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox telefone_SecundarioTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox responsavelTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button btnCadForCad;
        private System.Windows.Forms.Button btnCadForSalv;
        private System.Windows.Forms.Button btnCadForSair;
        private BancoExtimpexDataSetTableAdapters.PaisTableAdapter paisTableAdapter;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private BancoExtimpexDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private BancoExtimpexDataSetTableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
    }
}