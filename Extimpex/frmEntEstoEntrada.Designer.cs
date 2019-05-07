namespace Extimpex
{
    partial class frmEntEsto
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
            this.txtPequ = new System.Windows.Forms.TextBox();
            this.gbConNotFisc = new System.Windows.Forms.GroupBox();
            this.rdNotFisc = new System.Windows.Forms.RadioButton();
            this.rdForn = new System.Windows.Forms.RadioButton();
            this.btnCons = new System.Windows.Forms.Button();
            this.gbDtlh = new System.Windows.Forms.GroupBox();
            this.dtaGridRelat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relacao_EstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.btnCadNotFisc = new System.Windows.Forms.Button();
            this.btnDtllhNot = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.extimpexFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extimpex_FornecedorTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Extimpex_FornecedorTableAdapter();
            this.relacao_EstoqueTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Relacao_EstoqueTableAdapter();
            this.gbConNotFisc.SuspendLayout();
            this.gbDtlh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridRelat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacao_EstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extimpexFornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPequ
            // 
            this.txtPequ.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPequ.Location = new System.Drawing.Point(25, 84);
            this.txtPequ.Name = "txtPequ";
            this.txtPequ.Size = new System.Drawing.Size(331, 20);
            this.txtPequ.TabIndex = 0;
            // 
            // gbConNotFisc
            // 
            this.gbConNotFisc.Controls.Add(this.rdNotFisc);
            this.gbConNotFisc.Controls.Add(this.rdForn);
            this.gbConNotFisc.Controls.Add(this.btnCons);
            this.gbConNotFisc.Controls.Add(this.txtPequ);
            this.gbConNotFisc.Location = new System.Drawing.Point(12, 2);
            this.gbConNotFisc.Name = "gbConNotFisc";
            this.gbConNotFisc.Size = new System.Drawing.Size(486, 120);
            this.gbConNotFisc.TabIndex = 1;
            this.gbConNotFisc.TabStop = false;
            this.gbConNotFisc.Text = "Consulta de Nota Fiscal";
            // 
            // rdNotFisc
            // 
            this.rdNotFisc.AutoSize = true;
            this.rdNotFisc.Location = new System.Drawing.Point(25, 52);
            this.rdNotFisc.Name = "rdNotFisc";
            this.rdNotFisc.Size = new System.Drawing.Size(81, 17);
            this.rdNotFisc.TabIndex = 4;
            this.rdNotFisc.TabStop = true;
            this.rdNotFisc.Text = "Nota_Fiscal";
            this.rdNotFisc.UseVisualStyleBackColor = true;
            // 
            // rdForn
            // 
            this.rdForn.AutoSize = true;
            this.rdForn.Location = new System.Drawing.Point(25, 29);
            this.rdForn.Name = "rdForn";
            this.rdForn.Size = new System.Drawing.Size(79, 17);
            this.rdForn.TabIndex = 3;
            this.rdForn.TabStop = true;
            this.rdForn.Text = "Fornecedor";
            this.rdForn.UseVisualStyleBackColor = true;
            // 
            // btnCons
            // 
            this.btnCons.Location = new System.Drawing.Point(362, 83);
            this.btnCons.Name = "btnCons";
            this.btnCons.Size = new System.Drawing.Size(112, 21);
            this.btnCons.TabIndex = 1;
            this.btnCons.Text = "Consultar";
            this.btnCons.UseVisualStyleBackColor = true;
            this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
            // 
            // gbDtlh
            // 
            this.gbDtlh.Controls.Add(this.dtaGridRelat);
            this.gbDtlh.Location = new System.Drawing.Point(12, 128);
            this.gbDtlh.Name = "gbDtlh";
            this.gbDtlh.Size = new System.Drawing.Size(488, 255);
            this.gbDtlh.TabIndex = 3;
            this.gbDtlh.TabStop = false;
            this.gbDtlh.Text = "Detalhes";
            // 
            // dtaGridRelat
            // 
            this.dtaGridRelat.AllowUserToAddRows = false;
            this.dtaGridRelat.AllowUserToDeleteRows = false;
            this.dtaGridRelat.AllowUserToResizeColumns = false;
            this.dtaGridRelat.AllowUserToResizeRows = false;
            this.dtaGridRelat.AutoGenerateColumns = false;
            this.dtaGridRelat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridRelat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5});
            this.dtaGridRelat.DataSource = this.relacao_EstoqueBindingSource;
            this.dtaGridRelat.Location = new System.Drawing.Point(18, 19);
            this.dtaGridRelat.MultiSelect = false;
            this.dtaGridRelat.Name = "dtaGridRelat";
            this.dtaGridRelat.ReadOnly = true;
            this.dtaGridRelat.RowHeadersVisible = false;
            this.dtaGridRelat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridRelat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridRelat.Size = new System.Drawing.Size(453, 220);
            this.dtaGridRelat.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Fornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Fornecedor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_Nota_Fiscal";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_Nota_Fiscal";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nota_Fiscal";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nota Fiscal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome_Razao_Social";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fornecedor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor_Total_da_Nota";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // relacao_EstoqueBindingSource
            // 
            this.relacao_EstoqueBindingSource.DataMember = "Relacao_Estoque";
            this.relacao_EstoqueBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCadNotFisc
            // 
            this.btnCadNotFisc.Location = new System.Drawing.Point(183, 399);
            this.btnCadNotFisc.Name = "btnCadNotFisc";
            this.btnCadNotFisc.Size = new System.Drawing.Size(153, 42);
            this.btnCadNotFisc.TabIndex = 4;
            this.btnCadNotFisc.Text = "Cadastrar Nota Fiscal";
            this.btnCadNotFisc.UseVisualStyleBackColor = true;
            this.btnCadNotFisc.Click += new System.EventHandler(this.btnCadNotFisc_Click_1);
            // 
            // btnDtllhNot
            // 
            this.btnDtllhNot.Location = new System.Drawing.Point(59, 399);
            this.btnDtllhNot.Name = "btnDtllhNot";
            this.btnDtllhNot.Size = new System.Drawing.Size(118, 42);
            this.btnDtllhNot.TabIndex = 5;
            this.btnDtllhNot.Text = "Detalhes da Nota";
            this.btnDtllhNot.UseVisualStyleBackColor = true;
            this.btnDtllhNot.Click += new System.EventHandler(this.btnDtllhNot_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(342, 399);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(119, 42);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            this.tableAdapterManager.Controle_de_EstoqueTableAdapter = null;
            this.tableAdapterManager.Dados_ProdutosTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = null;
            this.tableAdapterManager.Extimpex_FornecedorTableAdapter = null;
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
            // extimpexFornecedorBindingSource
            // 
            this.extimpexFornecedorBindingSource.DataMember = "Extimpex_Fornecedor";
            this.extimpexFornecedorBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // extimpex_FornecedorTableAdapter
            // 
            this.extimpex_FornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // relacao_EstoqueTableAdapter
            // 
            this.relacao_EstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // frmEntEsto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gbDtlh);
            this.Controls.Add(this.gbConNotFisc);
            this.Controls.Add(this.btnDtllhNot);
            this.Controls.Add(this.btnCadNotFisc);
            this.Name = "frmEntEsto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEntEsto_Load);
            this.gbConNotFisc.ResumeLayout(false);
            this.gbConNotFisc.PerformLayout();
            this.gbDtlh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridRelat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relacao_EstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extimpexFornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPequ;
        private System.Windows.Forms.GroupBox gbConNotFisc;
        private System.Windows.Forms.Button btnCons;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbDtlh;
        private System.Windows.Forms.Button btnCadNotFisc;
        private System.Windows.Forms.Button btnDtllhNot;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.RadioButton rdNotFisc;
        private System.Windows.Forms.RadioButton rdForn;
        private System.Windows.Forms.BindingSource extimpexFornecedorBindingSource;
        private BancoExtimpexDataSetTableAdapters.Extimpex_FornecedorTableAdapter extimpex_FornecedorTableAdapter;
        private System.Windows.Forms.BindingSource relacao_EstoqueBindingSource;
        private BancoExtimpexDataSetTableAdapters.Relacao_EstoqueTableAdapter relacao_EstoqueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        public System.Windows.Forms.DataGridView dtaGridRelat;
    }
}