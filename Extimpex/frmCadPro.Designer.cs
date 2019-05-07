namespace Extimpex
{
    partial class frmCadPro
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
            System.Windows.Forms.Label id_ProdutoLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label nome_do_ProdutoLabel;
            System.Windows.Forms.Label precoLabel;
            System.Windows.Forms.Label nCMLabel;
            System.Windows.Forms.Label cTLLabel;
            System.Windows.Forms.Label observacaoLabel;
            System.Windows.Forms.Label grupo_de_PrecoLabel;
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.grupo_de_PrecoComboBox = new System.Windows.Forms.ComboBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grupoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.observacaoTextBox = new System.Windows.Forms.TextBox();
            this.cTLTextBox = new System.Windows.Forms.TextBox();
            this.nCMTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.nome_do_ProdutoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.id_ProdutoTextBox = new System.Windows.Forms.TextBox();
            this.btnCadpro = new System.Windows.Forms.Button();
            this.btnSalv = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.produtoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.ProdutoTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.grupo_ProdutoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Grupo_ProdutoTableAdapter();
            id_ProdutoLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            nome_do_ProdutoLabel = new System.Windows.Forms.Label();
            precoLabel = new System.Windows.Forms.Label();
            nCMLabel = new System.Windows.Forms.Label();
            cTLLabel = new System.Windows.Forms.Label();
            observacaoLabel = new System.Windows.Forms.Label();
            grupo_de_PrecoLabel = new System.Windows.Forms.Label();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ProdutoLabel
            // 
            id_ProdutoLabel.AutoSize = true;
            id_ProdutoLabel.Location = new System.Drawing.Point(8, 30);
            id_ProdutoLabel.Name = "id_ProdutoLabel";
            id_ProdutoLabel.Size = new System.Drawing.Size(59, 13);
            id_ProdutoLabel.TabIndex = 0;
            id_ProdutoLabel.Text = "Id Produto:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(8, 69);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(43, 13);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(8, 108);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // nome_do_ProdutoLabel
            // 
            nome_do_ProdutoLabel.AutoSize = true;
            nome_do_ProdutoLabel.Location = new System.Drawing.Point(95, 108);
            nome_do_ProdutoLabel.Name = "nome_do_ProdutoLabel";
            nome_do_ProdutoLabel.Size = new System.Drawing.Size(93, 13);
            nome_do_ProdutoLabel.TabIndex = 6;
            nome_do_ProdutoLabel.Text = "Nome do Produto:";
            // 
            // precoLabel
            // 
            precoLabel.AutoSize = true;
            precoLabel.Location = new System.Drawing.Point(8, 147);
            precoLabel.Name = "precoLabel";
            precoLabel.Size = new System.Drawing.Size(38, 13);
            precoLabel.TabIndex = 8;
            precoLabel.Text = "Preco:";
            // 
            // nCMLabel
            // 
            nCMLabel.AutoSize = true;
            nCMLabel.Location = new System.Drawing.Point(131, 147);
            nCMLabel.Name = "nCMLabel";
            nCMLabel.Size = new System.Drawing.Size(34, 13);
            nCMLabel.TabIndex = 10;
            nCMLabel.Text = "NCM:";
            // 
            // cTLLabel
            // 
            cTLLabel.AutoSize = true;
            cTLLabel.Location = new System.Drawing.Point(269, 147);
            cTLLabel.Name = "cTLLabel";
            cTLLabel.Size = new System.Drawing.Size(30, 13);
            cTLLabel.TabIndex = 12;
            cTLLabel.Text = "CTL:";
            // 
            // observacaoLabel
            // 
            observacaoLabel.AutoSize = true;
            observacaoLabel.Location = new System.Drawing.Point(8, 186);
            observacaoLabel.Name = "observacaoLabel";
            observacaoLabel.Size = new System.Drawing.Size(68, 13);
            observacaoLabel.TabIndex = 14;
            observacaoLabel.Text = "Observacao:";
            // 
            // grupo_de_PrecoLabel
            // 
            grupo_de_PrecoLabel.AutoSize = true;
            grupo_de_PrecoLabel.Location = new System.Drawing.Point(131, 69);
            grupo_de_PrecoLabel.Name = "grupo_de_PrecoLabel";
            grupo_de_PrecoLabel.Size = new System.Drawing.Size(85, 13);
            grupo_de_PrecoLabel.TabIndex = 16;
            grupo_de_PrecoLabel.Text = "Grupo de Preco:";
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(grupo_de_PrecoLabel);
            this.gbDados.Controls.Add(this.grupo_de_PrecoComboBox);
            this.gbDados.Controls.Add(observacaoLabel);
            this.gbDados.Controls.Add(this.observacaoTextBox);
            this.gbDados.Controls.Add(cTLLabel);
            this.gbDados.Controls.Add(this.cTLTextBox);
            this.gbDados.Controls.Add(nCMLabel);
            this.gbDados.Controls.Add(this.nCMTextBox);
            this.gbDados.Controls.Add(precoLabel);
            this.gbDados.Controls.Add(this.precoTextBox);
            this.gbDados.Controls.Add(nome_do_ProdutoLabel);
            this.gbDados.Controls.Add(this.nome_do_ProdutoTextBox);
            this.gbDados.Controls.Add(quantidadeLabel);
            this.gbDados.Controls.Add(this.quantidadeTextBox);
            this.gbDados.Controls.Add(codigoLabel);
            this.gbDados.Controls.Add(this.codigoTextBox);
            this.gbDados.Controls.Add(id_ProdutoLabel);
            this.gbDados.Controls.Add(this.id_ProdutoTextBox);
            this.gbDados.Enabled = false;
            this.gbDados.Location = new System.Drawing.Point(4, 2);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(412, 255);
            this.gbDados.TabIndex = 0;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Dados do Produto";
            // 
            // grupo_de_PrecoComboBox
            // 
            this.grupo_de_PrecoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Grupo_de_Preco", true));
            this.grupo_de_PrecoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produtoBindingSource1, "Grupo_de_Preco", true));
            this.grupo_de_PrecoComboBox.DataSource = this.grupoProdutoBindingSource;
            this.grupo_de_PrecoComboBox.DisplayMember = "Nome_do_Grupo";
            this.grupo_de_PrecoComboBox.FormattingEnabled = true;
            this.grupo_de_PrecoComboBox.Location = new System.Drawing.Point(134, 84);
            this.grupo_de_PrecoComboBox.Name = "grupo_de_PrecoComboBox";
            this.grupo_de_PrecoComboBox.Size = new System.Drawing.Size(130, 21);
            this.grupo_de_PrecoComboBox.TabIndex = 17;
            this.grupo_de_PrecoComboBox.ValueMember = "Id_Grupo";
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "Produto";
            this.produtoBindingSource1.DataSource = this.bancoExtimpexDataSet;
            // 
            // grupoProdutoBindingSource
            // 
            this.grupoProdutoBindingSource.DataMember = "Grupo_Produto";
            this.grupoProdutoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // observacaoTextBox
            // 
            this.observacaoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.observacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Observacao", true));
            this.observacaoTextBox.Location = new System.Drawing.Point(11, 202);
            this.observacaoTextBox.Multiline = true;
            this.observacaoTextBox.Name = "observacaoTextBox";
            this.observacaoTextBox.Size = new System.Drawing.Size(393, 43);
            this.observacaoTextBox.TabIndex = 15;
            // 
            // cTLTextBox
            // 
            this.cTLTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cTLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "CTL", true));
            this.cTLTextBox.Location = new System.Drawing.Point(272, 163);
            this.cTLTextBox.Name = "cTLTextBox";
            this.cTLTextBox.Size = new System.Drawing.Size(132, 20);
            this.cTLTextBox.TabIndex = 13;
            // 
            // nCMTextBox
            // 
            this.nCMTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nCMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "NCM", true));
            this.nCMTextBox.Location = new System.Drawing.Point(134, 163);
            this.nCMTextBox.Name = "nCMTextBox";
            this.nCMTextBox.Size = new System.Drawing.Size(132, 20);
            this.nCMTextBox.TabIndex = 11;
            // 
            // precoTextBox
            // 
            this.precoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Preco", true));
            this.precoTextBox.Location = new System.Drawing.Point(11, 163);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(117, 20);
            this.precoTextBox.TabIndex = 9;
            // 
            // nome_do_ProdutoTextBox
            // 
            this.nome_do_ProdutoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_do_ProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Nome_do_Produto", true));
            this.nome_do_ProdutoTextBox.Location = new System.Drawing.Point(98, 124);
            this.nome_do_ProdutoTextBox.Name = "nome_do_ProdutoTextBox";
            this.nome_do_ProdutoTextBox.Size = new System.Drawing.Size(306, 20);
            this.nome_do_ProdutoTextBox.TabIndex = 7;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.quantidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Quantidade", true));
            this.quantidadeTextBox.Location = new System.Drawing.Point(11, 124);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(81, 20);
            this.quantidadeTextBox.TabIndex = 5;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(11, 85);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(117, 20);
            this.codigoTextBox.TabIndex = 3;
            // 
            // id_ProdutoTextBox
            // 
            this.id_ProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Id_Produto", true));
            this.id_ProdutoTextBox.Location = new System.Drawing.Point(11, 46);
            this.id_ProdutoTextBox.Name = "id_ProdutoTextBox";
            this.id_ProdutoTextBox.ReadOnly = true;
            this.id_ProdutoTextBox.Size = new System.Drawing.Size(81, 20);
            this.id_ProdutoTextBox.TabIndex = 1;
            // 
            // btnCadpro
            // 
            this.btnCadpro.Location = new System.Drawing.Point(44, 263);
            this.btnCadpro.Name = "btnCadpro";
            this.btnCadpro.Size = new System.Drawing.Size(109, 37);
            this.btnCadpro.TabIndex = 1;
            this.btnCadpro.Text = "Cadastrar Produto";
            this.btnCadpro.UseVisualStyleBackColor = true;
            this.btnCadpro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalv
            // 
            this.btnSalv.Enabled = false;
            this.btnSalv.Location = new System.Drawing.Point(159, 263);
            this.btnSalv.Name = "btnSalv";
            this.btnSalv.Size = new System.Drawing.Size(109, 37);
            this.btnSalv.TabIndex = 2;
            this.btnSalv.Text = "Salvar Cadastro";
            this.btnSalv.UseVisualStyleBackColor = true;
            this.btnSalv.Click += new System.EventHandler(this.btnSalv_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(274, 263);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 37);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cadastro_de_Categorias_de_DespesasTableAdapter = null;
            this.tableAdapterManager.Cargos_AdministrativosTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_de_ProdutoTableAdapter = null;
            this.tableAdapterManager.Controle_de_EstoqueTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.Extimpex_FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Grupo_ProdutoTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // grupo_ProdutoTableAdapter
            // 
            this.grupo_ProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 308);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalv);
            this.Controls.Add(this.btnCadpro);
            this.Controls.Add(this.gbDados);
            this.Name = "frmCadPro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.frmCadPro_Load);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDados;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private BancoExtimpexDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox observacaoTextBox;
        private System.Windows.Forms.TextBox cTLTextBox;
        private System.Windows.Forms.TextBox nCMTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.TextBox nome_do_ProdutoTextBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox id_ProdutoTextBox;
        private System.Windows.Forms.Button btnCadpro;
        private System.Windows.Forms.Button btnSalv;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox grupo_de_PrecoComboBox;
        private System.Windows.Forms.BindingSource grupoProdutoBindingSource;
        private BancoExtimpexDataSetTableAdapters.Grupo_ProdutoTableAdapter grupo_ProdutoTableAdapter;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
    }
}