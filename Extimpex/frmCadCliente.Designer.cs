namespace Extimpex
{
    partial class frmCadCliente
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
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label labTelSecu;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label observacaoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labRazSocial = new System.Windows.Forms.Label();
            this.labNomeCom = new System.Windows.Forms.Label();
            this.labRG = new System.Windows.Forms.Label();
            this.labIncriEstad = new System.Windows.Forms.Label();
            this.labIncriMuni = new System.Windows.Forms.Label();
            this.labCNPJ = new System.Windows.Forms.Label();
            this.radPessJuri = new System.Windows.Forms.RadioButton();
            this.labCPF = new System.Windows.Forms.Label();
            this.radPessFisica = new System.Windows.Forms.RadioButton();
            this.txtInscrMuni = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.txtInscrEstad = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtRazSoci = new System.Windows.Forms.TextBox();
            this.txtIdClien = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEstad = new System.Windows.Forms.ComboBox();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbCidd = new System.Windows.Forms.ComboBox();
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnSalveCliente = new System.Windows.Forms.Button();
            this.btnSairCliente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.ClienteTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.paisTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.PaisTableAdapter();
            this.estadoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.EstadoTableAdapter();
            this.cidadeTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.CidadeTableAdapter();
            this.txtTelSecund = new System.Windows.Forms.TextBox();
            id_ClienteLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            labTelSecu = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(6, 16);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(54, 13);
            id_ClienteLabel.TabIndex = 0;
            id_ClienteLabel.Text = "Id Cliente:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(6, 16);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 0;
            enderecoLabel.Text = "Endereco:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(5, 53);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(30, 13);
            paisLabel.TabIndex = 15;
            paisLabel.Text = "Pais:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(133, 53);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 16;
            estadoLabel.Text = "Estado:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(272, 53);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 17;
            cidadeLabel.Text = "Cidade:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(10, 20);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 0;
            telefoneLabel.Text = "Telefone:";
            // 
            // labTelSecu
            // 
            labTelSecu.AutoSize = true;
            labTelSecu.Location = new System.Drawing.Point(196, 20);
            labTelSecu.Name = "labTelSecu";
            labTelSecu.Size = new System.Drawing.Size(109, 13);
            labTelSecu.TabIndex = 2;
            labTelSecu.Text = "Telefone Secúndario:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(10, 59);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(10, 98);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 6;
            observacaoLabel.Text = "Observacao:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labRazSocial);
            this.groupBox1.Controls.Add(this.labNomeCom);
            this.groupBox1.Controls.Add(this.labRG);
            this.groupBox1.Controls.Add(this.labIncriEstad);
            this.groupBox1.Controls.Add(this.labIncriMuni);
            this.groupBox1.Controls.Add(this.labCNPJ);
            this.groupBox1.Controls.Add(this.radPessJuri);
            this.groupBox1.Controls.Add(this.labCPF);
            this.groupBox1.Controls.Add(this.radPessFisica);
            this.groupBox1.Controls.Add(this.txtInscrMuni);
            this.groupBox1.Controls.Add(this.txtInscrEstad);
            this.groupBox1.Controls.Add(this.txtRG);
            this.groupBox1.Controls.Add(this.txtCNPJ);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.txtRazSoci);
            this.groupBox1.Controls.Add(id_ClienteLabel);
            this.groupBox1.Controls.Add(this.txtIdClien);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // labRazSocial
            // 
            this.labRazSocial.AutoSize = true;
            this.labRazSocial.Location = new System.Drawing.Point(6, 93);
            this.labRazSocial.Name = "labRazSocial";
            this.labRazSocial.Size = new System.Drawing.Size(70, 13);
            this.labRazSocial.TabIndex = 22;
            this.labRazSocial.Text = "Razão Social";
            this.labRazSocial.Visible = false;
            // 
            // labNomeCom
            // 
            this.labNomeCom.AutoSize = true;
            this.labNomeCom.Location = new System.Drawing.Point(6, 93);
            this.labNomeCom.Name = "labNomeCom";
            this.labNomeCom.Size = new System.Drawing.Size(82, 13);
            this.labNomeCom.TabIndex = 20;
            this.labNomeCom.Text = "Nome Completo";
            // 
            // labRG
            // 
            this.labRG.AutoSize = true;
            this.labRG.Location = new System.Drawing.Point(192, 131);
            this.labRG.Name = "labRG";
            this.labRG.Size = new System.Drawing.Size(23, 13);
            this.labRG.TabIndex = 15;
            this.labRG.Text = "RG";
            // 
            // labIncriEstad
            // 
            this.labIncriEstad.AutoSize = true;
            this.labIncriEstad.Location = new System.Drawing.Point(268, 131);
            this.labIncriEstad.Name = "labIncriEstad";
            this.labIncriEstad.Size = new System.Drawing.Size(94, 13);
            this.labIncriEstad.TabIndex = 19;
            this.labIncriEstad.Text = "Inscrição Estadual";
            this.labIncriEstad.Visible = false;
            // 
            // labIncriMuni
            // 
            this.labIncriMuni.AutoSize = true;
            this.labIncriMuni.Location = new System.Drawing.Point(137, 131);
            this.labIncriMuni.Name = "labIncriMuni";
            this.labIncriMuni.Size = new System.Drawing.Size(98, 13);
            this.labIncriMuni.TabIndex = 18;
            this.labIncriMuni.Text = "Inscrição Municipal";
            this.labIncriMuni.Visible = false;
            // 
            // labCNPJ
            // 
            this.labCNPJ.AutoSize = true;
            this.labCNPJ.Location = new System.Drawing.Point(5, 132);
            this.labCNPJ.Name = "labCNPJ";
            this.labCNPJ.Size = new System.Drawing.Size(34, 13);
            this.labCNPJ.TabIndex = 17;
            this.labCNPJ.Text = "CNPJ";
            this.labCNPJ.Visible = false;
            // 
            // radPessJuri
            // 
            this.radPessJuri.AutoSize = true;
            this.radPessJuri.Enabled = false;
            this.radPessJuri.Location = new System.Drawing.Point(107, 58);
            this.radPessJuri.Name = "radPessJuri";
            this.radPessJuri.Size = new System.Drawing.Size(101, 17);
            this.radPessJuri.TabIndex = 16;
            this.radPessJuri.TabStop = true;
            this.radPessJuri.Text = "Pessoa Jurídica";
            this.radPessJuri.UseVisualStyleBackColor = true;
            this.radPessJuri.CheckedChanged += new System.EventHandler(this.radPessJuri_CheckedChanged);
            // 
            // labCPF
            // 
            this.labCPF.AutoSize = true;
            this.labCPF.Location = new System.Drawing.Point(6, 130);
            this.labCPF.Name = "labCPF";
            this.labCPF.Size = new System.Drawing.Size(27, 13);
            this.labCPF.TabIndex = 14;
            this.labCPF.Text = "CPF";
            // 
            // radPessFisica
            // 
            this.radPessFisica.AutoSize = true;
            this.radPessFisica.Enabled = false;
            this.radPessFisica.Location = new System.Drawing.Point(9, 58);
            this.radPessFisica.Name = "radPessFisica";
            this.radPessFisica.Size = new System.Drawing.Size(92, 17);
            this.radPessFisica.TabIndex = 15;
            this.radPessFisica.TabStop = true;
            this.radPessFisica.Text = "Pessoa Física";
            this.radPessFisica.UseVisualStyleBackColor = true;
            this.radPessFisica.CheckedChanged += new System.EventHandler(this.radPessFisica_CheckedChanged);
            // 
            // txtInscrMuni
            // 
            this.txtInscrMuni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscrMuni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Inscricao_Municipal", true));
            this.txtInscrMuni.Enabled = false;
            this.txtInscrMuni.Location = new System.Drawing.Point(271, 148);
            this.txtInscrMuni.Name = "txtInscrMuni";
            this.txtInscrMuni.Size = new System.Drawing.Size(125, 20);
            this.txtInscrMuni.TabIndex = 9;
            this.txtInscrMuni.Visible = false;
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
            // txtInscrEstad
            // 
            this.txtInscrEstad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInscrEstad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Inscricao_Estadual", true));
            this.txtInscrEstad.Enabled = false;
            this.txtInscrEstad.Location = new System.Drawing.Point(140, 148);
            this.txtInscrEstad.Name = "txtInscrEstad";
            this.txtInscrEstad.Size = new System.Drawing.Size(125, 20);
            this.txtInscrEstad.TabIndex = 7;
            this.txtInscrEstad.Visible = false;
            // 
            // txtRG
            // 
            this.txtRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "RG", true));
            this.txtRG.Enabled = false;
            this.txtRG.Location = new System.Drawing.Point(195, 147);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(205, 20);
            this.txtRG.TabIndex = 13;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCNPJ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CNPJ", true));
            this.txtCNPJ.Enabled = false;
            this.txtCNPJ.Location = new System.Drawing.Point(9, 147);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(125, 20);
            this.txtCNPJ.TabIndex = 5;
            this.txtCNPJ.Visible = false;
            // 
            // txtCPF
            // 
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.txtCPF.Enabled = false;
            this.txtCPF.Location = new System.Drawing.Point(9, 147);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(180, 20);
            this.txtCPF.TabIndex = 11;
            // 
            // txtRazSoci
            // 
            this.txtRazSoci.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazSoci.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome_Razao_Social", true));
            this.txtRazSoci.Enabled = false;
            this.txtRazSoci.Location = new System.Drawing.Point(9, 109);
            this.txtRazSoci.Name = "txtRazSoci";
            this.txtRazSoci.Size = new System.Drawing.Size(391, 20);
            this.txtRazSoci.TabIndex = 3;
            // 
            // txtIdClien
            // 
            this.txtIdClien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Id_Cliente", true));
            this.txtIdClien.Enabled = false;
            this.txtIdClien.Location = new System.Drawing.Point(9, 32);
            this.txtIdClien.Name = "txtIdClien";
            this.txtIdClien.ReadOnly = true;
            this.txtIdClien.Size = new System.Drawing.Size(53, 20);
            this.txtIdClien.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEstad);
            this.groupBox2.Controls.Add(cidadeLabel);
            this.groupBox2.Controls.Add(this.cmbCidd);
            this.groupBox2.Controls.Add(estadoLabel);
            this.groupBox2.Controls.Add(paisLabel);
            this.groupBox2.Controls.Add(this.cmbPais);
            this.groupBox2.Controls.Add(enderecoLabel);
            this.groupBox2.Controls.Add(this.txtEnd);
            this.groupBox2.Location = new System.Drawing.Point(7, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço do Cliente";
            // 
            // cmbEstad
            // 
            this.cmbEstad.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "Estado", true));
            this.cmbEstad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Estado", true));
            this.cmbEstad.DataSource = this.estadoBindingSource;
            this.cmbEstad.DisplayMember = "Estado";
            this.cmbEstad.Enabled = false;
            this.cmbEstad.FormattingEnabled = true;
            this.cmbEstad.Location = new System.Drawing.Point(136, 69);
            this.cmbEstad.Name = "cmbEstad";
            this.cmbEstad.Size = new System.Drawing.Size(129, 21);
            this.cmbEstad.TabIndex = 19;
            this.cmbEstad.ValueMember = "Id_Estado";
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // cmbCidd
            // 
            this.cmbCidd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "Cidade", true));
            this.cmbCidd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cidade", true));
            this.cmbCidd.DataSource = this.cidadeBindingSource;
            this.cmbCidd.DisplayMember = "Cidade";
            this.cmbCidd.Enabled = false;
            this.cmbCidd.FormattingEnabled = true;
            this.cmbCidd.Location = new System.Drawing.Point(275, 69);
            this.cmbCidd.Name = "cmbCidd";
            this.cmbCidd.Size = new System.Drawing.Size(125, 21);
            this.cmbCidd.TabIndex = 18;
            this.cmbCidd.ValueMember = "Id_Cidade";
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "Cidade";
            this.cidadeBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // cmbPais
            // 
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Pais", true));
            this.cmbPais.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "Pais", true));
            this.cmbPais.DataSource = this.paisBindingSource;
            this.cmbPais.DisplayMember = "Pais";
            this.cmbPais.Enabled = false;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(9, 69);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.TabIndex = 16;
            this.cmbPais.ValueMember = "Id_Pais";
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "Pais";
            this.paisBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // txtEnd
            // 
            this.txtEnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Endereco", true));
            this.txtEnd.Enabled = false;
            this.txtEnd.Location = new System.Drawing.Point(9, 30);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(391, 20);
            this.txtEnd.TabIndex = 1;
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(65, 493);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(96, 33);
            this.btnCadCliente.TabIndex = 2;
            this.btnCadCliente.Text = "Novo Cadastro ";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnSalveCliente
            // 
            this.btnSalveCliente.Enabled = false;
            this.btnSalveCliente.Location = new System.Drawing.Point(167, 493);
            this.btnSalveCliente.Name = "btnSalveCliente";
            this.btnSalveCliente.Size = new System.Drawing.Size(99, 33);
            this.btnSalveCliente.TabIndex = 3;
            this.btnSalveCliente.Text = "Salvar Dados ";
            this.btnSalveCliente.UseVisualStyleBackColor = true;
            this.btnSalveCliente.Click += new System.EventHandler(this.btnSalveCliente_Click);
            // 
            // btnSairCliente
            // 
            this.btnSairCliente.Location = new System.Drawing.Point(272, 493);
            this.btnSairCliente.Name = "btnSairCliente";
            this.btnSairCliente.Size = new System.Drawing.Size(94, 33);
            this.btnSairCliente.TabIndex = 4;
            this.btnSairCliente.Text = "Sair";
            this.btnSairCliente.UseVisualStyleBackColor = true;
            this.btnSairCliente.Click += new System.EventHandler(this.btnSairCliente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTelSecund);
            this.groupBox3.Controls.Add(observacaoLabel);
            this.groupBox3.Controls.Add(this.txtObs);
            this.groupBox3.Controls.Add(emailLabel);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(labTelSecu);
            this.groupBox3.Controls.Add(telefoneLabel);
            this.groupBox3.Controls.Add(this.txtTel);
            this.groupBox3.Location = new System.Drawing.Point(7, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 178);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato do Cliente";
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Observacao", true));
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(13, 114);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(387, 44);
            this.txtObs.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(13, 75);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(387, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTel
            // 
            this.txtTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefone", true));
            this.txtTel.Enabled = false;
            this.txtTel.Location = new System.Drawing.Point(13, 36);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(180, 20);
            this.txtTel.TabIndex = 1;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cadastro_de_Categorias_de_DespesasTableAdapter = null;
            this.tableAdapterManager.Cargos_AdministrativosTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = this.clienteTableAdapter;
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
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // txtTelSecund
            // 
            this.txtTelSecund.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Telefone_Secundario", true));
            this.txtTelSecund.Enabled = false;
            this.txtTelSecund.Location = new System.Drawing.Point(199, 36);
            this.txtTelSecund.Name = "txtTelSecund";
            this.txtTelSecund.Size = new System.Drawing.Size(201, 20);
            this.txtTelSecund.TabIndex = 8;
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 538);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSairCliente);
            this.Controls.Add(this.btnSalveCliente);
            this.Controls.Add(this.btnCadCliente);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private BancoExtimpexDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtInscrMuni;
        private System.Windows.Forms.TextBox txtInscrEstad;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtRazSoci;
        private System.Windows.Forms.TextBox txtIdClien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnSalveCliente;
        private System.Windows.Forms.Button btnSairCliente;
        private System.Windows.Forms.ComboBox cmbCidd;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.RadioButton radPessJuri;
        private System.Windows.Forms.RadioButton radPessFisica;
        private System.Windows.Forms.Label labCPF;
        private System.Windows.Forms.Label labRG;
        private System.Windows.Forms.Label labIncriEstad;
        private System.Windows.Forms.Label labIncriMuni;
        private System.Windows.Forms.Label labCNPJ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label labNomeCom;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private BancoExtimpexDataSetTableAdapters.PaisTableAdapter paisTableAdapter;
        private System.Windows.Forms.ComboBox cmbEstad;
        private BancoExtimpexDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        private BancoExtimpexDataSetTableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private System.Windows.Forms.Label labRazSocial;
        private System.Windows.Forms.TextBox txtTelSecund;

    }
}