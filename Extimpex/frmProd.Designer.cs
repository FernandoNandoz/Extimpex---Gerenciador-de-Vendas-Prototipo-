namespace Extimpex
{
    partial class frmProd
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
            this.gbProPes = new System.Windows.Forms.GroupBox();
            this.rdPesq = new System.Windows.Forms.Button();
            this.lbDescr = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.rdCod = new System.Windows.Forms.RadioButton();
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.controle_de_EstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controle_de_EstoqueTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Controle_de_EstoqueTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnProSair = new System.Windows.Forms.Button();
            this.gbInfPro = new System.Windows.Forms.GroupBox();
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.ProdutoTableAdapter();
            this.gbProPes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_EstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            this.gbInfPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProPes
            // 
            this.gbProPes.Controls.Add(this.rdPesq);
            this.gbProPes.Controls.Add(this.lbDescr);
            this.gbProPes.Controls.Add(this.txtDescr);
            this.gbProPes.Controls.Add(this.rdNome);
            this.gbProPes.Controls.Add(this.rdCod);
            this.gbProPes.Location = new System.Drawing.Point(4, 2);
            this.gbProPes.Name = "gbProPes";
            this.gbProPes.Size = new System.Drawing.Size(470, 136);
            this.gbProPes.TabIndex = 0;
            this.gbProPes.TabStop = false;
            this.gbProPes.Text = "Pesquisar Produto";
            // 
            // rdPesq
            // 
            this.rdPesq.Location = new System.Drawing.Point(361, 97);
            this.rdPesq.Name = "rdPesq";
            this.rdPesq.Size = new System.Drawing.Size(95, 23);
            this.rdPesq.TabIndex = 4;
            this.rdPesq.Text = "Pesquisar";
            this.rdPesq.UseVisualStyleBackColor = true;
            this.rdPesq.Click += new System.EventHandler(this.rdPesq_Click);
            // 
            // lbDescr
            // 
            this.lbDescr.AutoSize = true;
            this.lbDescr.Location = new System.Drawing.Point(19, 81);
            this.lbDescr.Name = "lbDescr";
            this.lbDescr.Size = new System.Drawing.Size(55, 13);
            this.lbDescr.TabIndex = 3;
            this.lbDescr.Text = "Descrição";
            // 
            // txtDescr
            // 
            this.txtDescr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescr.Location = new System.Drawing.Point(22, 97);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(333, 20);
            this.txtDescr.TabIndex = 2;
            // 
            // rdNome
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Location = new System.Drawing.Point(22, 52);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(126, 17);
            this.rdNome.TabIndex = 1;
            this.rdNome.TabStop = true;
            this.rdNome.Text = "Pesquisar Pelo Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            // 
            // rdCod
            // 
            this.rdCod.AutoSize = true;
            this.rdCod.Location = new System.Drawing.Point(22, 29);
            this.rdCod.Name = "rdCod";
            this.rdCod.Size = new System.Drawing.Size(131, 17);
            this.rdCod.TabIndex = 0;
            this.rdCod.TabStop = true;
            this.rdCod.Text = "Pesquisar Pelo Codigo";
            this.rdCod.UseVisualStyleBackColor = true;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controle_de_EstoqueBindingSource
            // 
            this.controle_de_EstoqueBindingSource.DataMember = "Controle_de_Estoque";
            this.controle_de_EstoqueBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // controle_de_EstoqueTableAdapter
            // 
            this.controle_de_EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cadastro_de_Categorias_de_DespesasTableAdapter = null;
            this.tableAdapterManager.Cargos_AdministrativosTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_de_ProdutoTableAdapter = null;
            this.tableAdapterManager.Controle_de_EstoqueTableAdapter = this.controle_de_EstoqueTableAdapter;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.Extimpex_FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Grupo_ProdutoTableAdapter = null;
            this.tableAdapterManager.Nota_FiscalTableAdapter = null;
            this.tableAdapterManager.Notas_ProdutoTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "Produto";
            this.produtoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // btnProSair
            // 
            this.btnProSair.Location = new System.Drawing.Point(354, 381);
            this.btnProSair.Name = "btnProSair";
            this.btnProSair.Size = new System.Drawing.Size(106, 32);
            this.btnProSair.TabIndex = 1;
            this.btnProSair.Text = "Sair";
            this.btnProSair.UseVisualStyleBackColor = true;
            this.btnProSair.Click += new System.EventHandler(this.btnProSair_Click);
            // 
            // gbInfPro
            // 
            this.gbInfPro.Controls.Add(this.produtoDataGridView);
            this.gbInfPro.Location = new System.Drawing.Point(4, 144);
            this.gbInfPro.Name = "gbInfPro";
            this.gbInfPro.Size = new System.Drawing.Size(470, 231);
            this.gbInfPro.TabIndex = 5;
            this.gbInfPro.TabStop = false;
            this.gbInfPro.Text = "Informações do Produto";
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.AllowUserToAddRows = false;
            this.produtoDataGridView.AllowUserToDeleteRows = false;
            this.produtoDataGridView.AllowUserToResizeColumns = false;
            this.produtoDataGridView.AllowUserToResizeRows = false;
            this.produtoDataGridView.AutoGenerateColumns = false;
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.produtoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.produtoDataGridView.DataSource = this.produtoBindingSource;
            this.produtoDataGridView.Location = new System.Drawing.Point(8, 19);
            this.produtoDataGridView.MultiSelect = false;
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.ReadOnly = true;
            this.produtoDataGridView.RowHeadersVisible = false;
            this.produtoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.produtoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produtoDataGridView.Size = new System.Drawing.Size(448, 193);
            this.produtoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nome_do_Produto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome do Produto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Preço";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 90;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // frmProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 425);
            this.ControlBox = false;
            this.Controls.Add(this.gbInfPro);
            this.Controls.Add(this.btnProSair);
            this.Controls.Add(this.gbProPes);
            this.Name = "frmProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProd_Load);
            this.gbProPes.ResumeLayout(false);
            this.gbProPes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controle_de_EstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            this.gbInfPro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProPes;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource controle_de_EstoqueBindingSource;
        private BancoExtimpexDataSetTableAdapters.Controle_de_EstoqueTableAdapter controle_de_EstoqueTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.Button btnProSair;
        private System.Windows.Forms.Button rdPesq;
        private System.Windows.Forms.Label lbDescr;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.RadioButton rdCod;
        private System.Windows.Forms.GroupBox gbInfPro;
        private System.Windows.Forms.DataGridView produtoDataGridView;
        private BancoExtimpexDataSetTableAdapters.ProdutoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}