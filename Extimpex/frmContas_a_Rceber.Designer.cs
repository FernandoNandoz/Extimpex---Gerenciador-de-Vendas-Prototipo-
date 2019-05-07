namespace Extimpex
{
    partial class frmContas_a_Receber
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtaGridContas = new System.Windows.Forms.DataGridView();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.btnPesq = new System.Windows.Forms.Button();
            this.rdDatVenc = new System.Windows.Forms.RadioButton();
            this.rdSitua = new System.Windows.Forms.RadioButton();
            this.rdClient = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conta_a_ReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.conta_a_ReceberTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Conta_a_ReceberTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conta_a_ReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdClient);
            this.groupBox1.Controls.Add(this.rdSitua);
            this.groupBox1.Controls.Add(this.rdDatVenc);
            this.groupBox1.Controls.Add(this.btnPesq);
            this.groupBox1.Controls.Add(this.txtDescr);
            this.groupBox1.Controls.Add(this.dtaGridContas);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 413);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Contas a Receber";
            // 
            // dtaGridContas
            // 
            this.dtaGridContas.AllowUserToAddRows = false;
            this.dtaGridContas.AllowUserToDeleteRows = false;
            this.dtaGridContas.AllowUserToResizeColumns = false;
            this.dtaGridContas.AllowUserToResizeRows = false;
            this.dtaGridContas.AutoGenerateColumns = false;
            this.dtaGridContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dtaGridContas.DataSource = this.conta_a_ReceberBindingSource;
            this.dtaGridContas.Location = new System.Drawing.Point(18, 139);
            this.dtaGridContas.MultiSelect = false;
            this.dtaGridContas.Name = "dtaGridContas";
            this.dtaGridContas.ReadOnly = true;
            this.dtaGridContas.RowHeadersVisible = false;
            this.dtaGridContas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridContas.Size = new System.Drawing.Size(633, 258);
            this.dtaGridContas.TabIndex = 10;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(18, 103);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(456, 20);
            this.txtDescr.TabIndex = 11;
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(480, 101);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(171, 23);
            this.btnPesq.TabIndex = 12;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            // 
            // rdDatVenc
            // 
            this.rdDatVenc.AutoSize = true;
            this.rdDatVenc.Location = new System.Drawing.Point(18, 74);
            this.rdDatVenc.Name = "rdDatVenc";
            this.rdDatVenc.Size = new System.Drawing.Size(122, 17);
            this.rdDatVenc.TabIndex = 13;
            this.rdDatVenc.TabStop = true;
            this.rdDatVenc.Text = "Data de Vencimento";
            this.rdDatVenc.UseVisualStyleBackColor = true;
            // 
            // rdSitua
            // 
            this.rdSitua.AutoSize = true;
            this.rdSitua.Location = new System.Drawing.Point(18, 51);
            this.rdSitua.Name = "rdSitua";
            this.rdSitua.Size = new System.Drawing.Size(67, 17);
            this.rdSitua.TabIndex = 14;
            this.rdSitua.TabStop = true;
            this.rdSitua.Text = "Situação";
            this.rdSitua.UseVisualStyleBackColor = true;
            // 
            // rdClient
            // 
            this.rdClient.AutoSize = true;
            this.rdClient.Location = new System.Drawing.Point(18, 28);
            this.rdClient.Name = "rdClient";
            this.rdClient.Size = new System.Drawing.Size(57, 17);
            this.rdClient.TabIndex = 15;
            this.rdClient.TabStop = true;
            this.rdClient.Text = "Cliente";
            this.rdClient.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(530, 421);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 36);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Conta_a_Rceber";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Conta_a_Rceber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Situacao";
            this.dataGridViewTextBoxColumn6.HeaderText = "Situacão";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Forma_de_Pagamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pagamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_de_Vencimento";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de Vencimento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor_a_Rceber";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor a Receber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // conta_a_ReceberBindingSource
            // 
            this.conta_a_ReceberBindingSource.DataMember = "Conta_a_Receber";
            this.conta_a_ReceberBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conta_a_ReceberTableAdapter
            // 
            this.conta_a_ReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cadastro_de_Categorias_de_DespesasTableAdapter = null;
            this.tableAdapterManager.Cargos_AdministrativosTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = null;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_de_ProdutoTableAdapter = null;
            this.tableAdapterManager.Conta_a_ReceberTableAdapter = this.conta_a_ReceberTableAdapter;
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
            // frmContas_a_Receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 464);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmContas_a_Receber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.frmContas_a_Receber_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conta_a_ReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource conta_a_ReceberBindingSource;
        private BancoExtimpexDataSetTableAdapters.Conta_a_ReceberTableAdapter conta_a_ReceberTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdClient;
        private System.Windows.Forms.RadioButton rdSitua;
        private System.Windows.Forms.RadioButton rdDatVenc;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.DataGridView dtaGridContas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnSair;
    }
}