namespace Extimpex
{
    partial class frmFluxo_de_Caixa
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
            this.dtaGridFluxo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fluxo_de_CaixaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.rdData = new System.Windows.Forms.RadioButton();
            this.rdDescr = new System.Windows.Forms.RadioButton();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.fluxo_de_CaixaTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Fluxo_de_CaixaTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridFluxo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluxo_de_CaixaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtaGridFluxo);
            this.groupBox1.Controls.Add(this.rdData);
            this.groupBox1.Controls.Add(this.rdDescr);
            this.groupBox1.Controls.Add(this.btnPesq);
            this.groupBox1.Controls.Add(this.txtDescr);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Conta a Pagar";
            // 
            // dtaGridFluxo
            // 
            this.dtaGridFluxo.AllowUserToAddRows = false;
            this.dtaGridFluxo.AllowUserToDeleteRows = false;
            this.dtaGridFluxo.AllowUserToResizeColumns = false;
            this.dtaGridFluxo.AllowUserToResizeRows = false;
            this.dtaGridFluxo.AutoGenerateColumns = false;
            this.dtaGridFluxo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridFluxo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtaGridFluxo.DataSource = this.fluxo_de_CaixaBindingSource;
            this.dtaGridFluxo.Location = new System.Drawing.Point(17, 115);
            this.dtaGridFluxo.MultiSelect = false;
            this.dtaGridFluxo.Name = "dtaGridFluxo";
            this.dtaGridFluxo.ReadOnly = true;
            this.dtaGridFluxo.RowHeadersVisible = false;
            this.dtaGridFluxo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtaGridFluxo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaGridFluxo.Size = new System.Drawing.Size(504, 220);
            this.dtaGridFluxo.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Fluxo_de_Caixa";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Fluxo_de_Caixa";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Movimento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Credito";
            this.dataGridViewTextBoxColumn3.HeaderText = "Credito";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Debito";
            this.dataGridViewTextBoxColumn4.HeaderText = "Debito";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // fluxo_de_CaixaBindingSource
            // 
            this.fluxo_de_CaixaBindingSource.DataMember = "Fluxo_de_Caixa";
            this.fluxo_de_CaixaBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdData
            // 
            this.rdData.AutoSize = true;
            this.rdData.Location = new System.Drawing.Point(17, 27);
            this.rdData.Name = "rdData";
            this.rdData.Size = new System.Drawing.Size(105, 17);
            this.rdData.TabIndex = 4;
            this.rdData.TabStop = true;
            this.rdData.Text = "Data de Emissão";
            this.rdData.UseVisualStyleBackColor = true;
            // 
            // rdDescr
            // 
            this.rdDescr.AutoSize = true;
            this.rdDescr.Location = new System.Drawing.Point(17, 50);
            this.rdDescr.Name = "rdDescr";
            this.rdDescr.Size = new System.Drawing.Size(129, 17);
            this.rdDescr.TabIndex = 3;
            this.rdDescr.TabStop = true;
            this.rdDescr.Text = "Cliente ou Fornecedor";
            this.rdDescr.UseVisualStyleBackColor = true;
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(324, 79);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(75, 23);
            this.btnPesq.TabIndex = 1;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(17, 82);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(301, 20);
            this.txtDescr.TabIndex = 0;
            // 
            // fluxo_de_CaixaTableAdapter
            // 
            this.fluxo_de_CaixaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Extimpex_FornecedorTableAdapter = null;
            this.tableAdapterManager.Fluxo_de_CaixaTableAdapter = this.fluxo_de_CaixaTableAdapter;
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
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(405, 366);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 36);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmFluxo_de_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 413);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFluxo_de_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluxo de Caixa";
            this.Load += new System.EventHandler(this.frmFluxo_de_Caixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridFluxo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluxo_de_CaixaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdData;
        private System.Windows.Forms.RadioButton rdDescr;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox txtDescr;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource fluxo_de_CaixaBindingSource;
        private BancoExtimpexDataSetTableAdapters.Fluxo_de_CaixaTableAdapter fluxo_de_CaixaTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dtaGridFluxo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnSair;
    }
}