namespace Extimpex
{
    partial class frmCadOrg
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
            this.gbTipCad = new System.Windows.Forms.GroupBox();
            this.rdLoja = new System.Windows.Forms.RadioButton();
            this.rdVend = new System.Windows.Forms.RadioButton();
            this.rdCadGrup = new System.Windows.Forms.RadioButton();
            this.rbCadPais = new System.Windows.Forms.RadioButton();
            this.rbCadResDesp = new System.Windows.Forms.RadioButton();
            this.rbCadCarg = new System.Windows.Forms.RadioButton();
            this.rbCadEst = new System.Windows.Forms.RadioButton();
            this.rbCadCdd = new System.Windows.Forms.RadioButton();
            this.gbDaCad = new System.Windows.Forms.GroupBox();
            this.lbIdNon = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cadastro_de_Categorias_de_DespesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.cargos_AdministrativosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadeTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.CidadeTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.estadoTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.EstadoTableAdapter();
            this.paisTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.PaisTableAdapter();
            this.btnCadOrgSair = new System.Windows.Forms.Button();
            this.btnFaCad = new System.Windows.Forms.Button();
            this.btnSalCad = new System.Windows.Forms.Button();
            this.cargos_AdministrativosTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Cargos_AdministrativosTableAdapter();
            this.cadastro_de_Categorias_de_DespesasTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.Cadastro_de_Categorias_de_DespesasTableAdapter();
            this.gbTipCad.SuspendLayout();
            this.gbDaCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_de_Categorias_de_DespesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargos_AdministrativosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTipCad
            // 
            this.gbTipCad.Controls.Add(this.rdLoja);
            this.gbTipCad.Controls.Add(this.rdVend);
            this.gbTipCad.Controls.Add(this.rdCadGrup);
            this.gbTipCad.Controls.Add(this.rbCadPais);
            this.gbTipCad.Controls.Add(this.rbCadResDesp);
            this.gbTipCad.Controls.Add(this.rbCadCarg);
            this.gbTipCad.Controls.Add(this.rbCadEst);
            this.gbTipCad.Controls.Add(this.rbCadCdd);
            this.gbTipCad.Enabled = false;
            this.gbTipCad.Location = new System.Drawing.Point(5, 3);
            this.gbTipCad.Name = "gbTipCad";
            this.gbTipCad.Size = new System.Drawing.Size(380, 206);
            this.gbTipCad.TabIndex = 0;
            this.gbTipCad.TabStop = false;
            this.gbTipCad.Text = "Tipos de Cadastro";
            // 
            // rdLoja
            // 
            this.rdLoja.AutoSize = true;
            this.rdLoja.Location = new System.Drawing.Point(17, 19);
            this.rdLoja.Name = "rdLoja";
            this.rdLoja.Size = new System.Drawing.Size(45, 17);
            this.rdLoja.TabIndex = 17;
            this.rdLoja.TabStop = true;
            this.rdLoja.Text = "Loja";
            this.rdLoja.UseVisualStyleBackColor = true;
            // 
            // rdVend
            // 
            this.rdVend.AutoSize = true;
            this.rdVend.Location = new System.Drawing.Point(17, 111);
            this.rdVend.Name = "rdVend";
            this.rdVend.Size = new System.Drawing.Size(71, 17);
            this.rdVend.TabIndex = 16;
            this.rdVend.TabStop = true;
            this.rdVend.Text = "Vendedor";
            this.rdVend.UseVisualStyleBackColor = true;
            // 
            // rdCadGrup
            // 
            this.rdCadGrup.AutoSize = true;
            this.rdCadGrup.Location = new System.Drawing.Point(17, 134);
            this.rdCadGrup.Name = "rdCadGrup";
            this.rdCadGrup.Size = new System.Drawing.Size(109, 17);
            this.rdCadGrup.TabIndex = 15;
            this.rdCadGrup.TabStop = true;
            this.rdCadGrup.Text = "Grupo de Produto";
            this.rdCadGrup.UseVisualStyleBackColor = true;
            // 
            // rbCadPais
            // 
            this.rbCadPais.AutoSize = true;
            this.rbCadPais.Location = new System.Drawing.Point(17, 42);
            this.rbCadPais.Name = "rbCadPais";
            this.rbCadPais.Size = new System.Drawing.Size(47, 17);
            this.rbCadPais.TabIndex = 14;
            this.rbCadPais.TabStop = true;
            this.rbCadPais.Text = "País";
            this.rbCadPais.UseVisualStyleBackColor = true;
            // 
            // rbCadResDesp
            // 
            this.rbCadResDesp.AutoSize = true;
            this.rbCadResDesp.Location = new System.Drawing.Point(17, 180);
            this.rbCadResDesp.Name = "rbCadResDesp";
            this.rbCadResDesp.Size = new System.Drawing.Size(135, 17);
            this.rbCadResDesp.TabIndex = 4;
            this.rbCadResDesp.TabStop = true;
            this.rbCadResDesp.Text = "Categoria de Despesas";
            this.rbCadResDesp.UseVisualStyleBackColor = true;
            // 
            // rbCadCarg
            // 
            this.rbCadCarg.AutoSize = true;
            this.rbCadCarg.Location = new System.Drawing.Point(17, 157);
            this.rbCadCarg.Name = "rbCadCarg";
            this.rbCadCarg.Size = new System.Drawing.Size(131, 17);
            this.rbCadCarg.TabIndex = 3;
            this.rbCadCarg.TabStop = true;
            this.rbCadCarg.Text = "Cargos Administrativos";
            this.rbCadCarg.UseVisualStyleBackColor = true;
            // 
            // rbCadEst
            // 
            this.rbCadEst.AutoSize = true;
            this.rbCadEst.Location = new System.Drawing.Point(17, 65);
            this.rbCadEst.Name = "rbCadEst";
            this.rbCadEst.Size = new System.Drawing.Size(58, 17);
            this.rbCadEst.TabIndex = 1;
            this.rbCadEst.TabStop = true;
            this.rbCadEst.Text = "Estado";
            this.rbCadEst.UseVisualStyleBackColor = true;
            // 
            // rbCadCdd
            // 
            this.rbCadCdd.AutoSize = true;
            this.rbCadCdd.Location = new System.Drawing.Point(17, 88);
            this.rbCadCdd.Name = "rbCadCdd";
            this.rbCadCdd.Size = new System.Drawing.Size(58, 17);
            this.rbCadCdd.TabIndex = 0;
            this.rbCadCdd.TabStop = true;
            this.rbCadCdd.Text = "Cidade";
            this.rbCadCdd.UseVisualStyleBackColor = true;
            // 
            // gbDaCad
            // 
            this.gbDaCad.Controls.Add(this.lbIdNon);
            this.gbDaCad.Controls.Add(this.txtNom);
            this.gbDaCad.Enabled = false;
            this.gbDaCad.Location = new System.Drawing.Point(5, 215);
            this.gbDaCad.Name = "gbDaCad";
            this.gbDaCad.Size = new System.Drawing.Size(380, 78);
            this.gbDaCad.TabIndex = 1;
            this.gbDaCad.TabStop = false;
            this.gbDaCad.Text = "Dados de Cadastro";
            // 
            // lbIdNon
            // 
            this.lbIdNon.AutoSize = true;
            this.lbIdNon.Location = new System.Drawing.Point(15, 26);
            this.lbIdNon.Name = "lbIdNon";
            this.lbIdNon.Size = new System.Drawing.Size(58, 13);
            this.lbIdNon.TabIndex = 15;
            this.lbIdNon.Text = "Descrição:";
            // 
            // txtNom
            // 
            this.txtNom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNom.Location = new System.Drawing.Point(17, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(340, 20);
            this.txtNom.TabIndex = 1;
            // 
            // cadastro_de_Categorias_de_DespesasBindingSource
            // 
            this.cadastro_de_Categorias_de_DespesasBindingSource.DataMember = "Cadastro_de_Categorias_de_Despesas";
            this.cadastro_de_Categorias_de_DespesasBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cargos_AdministrativosBindingSource
            // 
            this.cargos_AdministrativosBindingSource.DataMember = "Cargos_Administrativos";
            this.cargos_AdministrativosBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // paisBindingSource
            // 
            this.paisBindingSource.DataMember = "Pais";
            this.paisBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            this.estadoBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // cidadeBindingSource
            // 
            this.cidadeBindingSource.DataMember = "Cidade";
            this.cidadeBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // cidadeTableAdapter
            // 
            this.cidadeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cadastro_de_Categorias_de_DespesasTableAdapter = null;
            this.tableAdapterManager.Cargos_AdministrativosTableAdapter = null;
            this.tableAdapterManager.CidadeTableAdapter = this.cidadeTableAdapter;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Consulta_de_ProdutoTableAdapter = null;
            this.tableAdapterManager.Controle_de_EstoqueTableAdapter = null;
            this.tableAdapterManager.Dados_ProdutosTableAdapter = null;
            this.tableAdapterManager.EstadoTableAdapter = this.estadoTableAdapter;
            this.tableAdapterManager.Extimpex_FornecedorTableAdapter = null;
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
            // estadoTableAdapter
            // 
            this.estadoTableAdapter.ClearBeforeFill = true;
            // 
            // paisTableAdapter
            // 
            this.paisTableAdapter.ClearBeforeFill = true;
            // 
            // btnCadOrgSair
            // 
            this.btnCadOrgSair.Location = new System.Drawing.Point(246, 308);
            this.btnCadOrgSair.Name = "btnCadOrgSair";
            this.btnCadOrgSair.Size = new System.Drawing.Size(99, 35);
            this.btnCadOrgSair.TabIndex = 7;
            this.btnCadOrgSair.Text = "Sair";
            this.btnCadOrgSair.UseVisualStyleBackColor = true;
            this.btnCadOrgSair.Click += new System.EventHandler(this.btnCadOrgSair_Click);
            // 
            // btnFaCad
            // 
            this.btnFaCad.Location = new System.Drawing.Point(34, 308);
            this.btnFaCad.Name = "btnFaCad";
            this.btnFaCad.Size = new System.Drawing.Size(105, 35);
            this.btnFaCad.TabIndex = 12;
            this.btnFaCad.Text = "Fazer Cadastro";
            this.btnFaCad.UseVisualStyleBackColor = true;
            this.btnFaCad.Click += new System.EventHandler(this.btnFaCad_Click);
            // 
            // btnSalCad
            // 
            this.btnSalCad.Enabled = false;
            this.btnSalCad.Location = new System.Drawing.Point(145, 308);
            this.btnSalCad.Name = "btnSalCad";
            this.btnSalCad.Size = new System.Drawing.Size(95, 35);
            this.btnSalCad.TabIndex = 13;
            this.btnSalCad.Text = "Salvar Cadastro";
            this.btnSalCad.UseVisualStyleBackColor = true;
            this.btnSalCad.Click += new System.EventHandler(this.btnSalCad_Click);
            // 
            // cargos_AdministrativosTableAdapter
            // 
            this.cargos_AdministrativosTableAdapter.ClearBeforeFill = true;
            // 
            // cadastro_de_Categorias_de_DespesasTableAdapter
            // 
            this.cadastro_de_Categorias_de_DespesasTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 360);
            this.ControlBox = false;
            this.Controls.Add(this.btnFaCad);
            this.Controls.Add(this.btnSalCad);
            this.Controls.Add(this.btnCadOrgSair);
            this.Controls.Add(this.gbDaCad);
            this.Controls.Add(this.gbTipCad);
            this.Name = "frmCadOrg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros Organizacionais";
            this.Load += new System.EventHandler(this.frmCadOrg_Load);
            this.gbTipCad.ResumeLayout(false);
            this.gbTipCad.PerformLayout();
            this.gbDaCad.ResumeLayout(false);
            this.gbDaCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro_de_Categorias_de_DespesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargos_AdministrativosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTipCad;
        private System.Windows.Forms.RadioButton rbCadResDesp;
        private System.Windows.Forms.RadioButton rbCadCarg;
        private System.Windows.Forms.RadioButton rbCadEst;
        private System.Windows.Forms.RadioButton rbCadCdd;
        private System.Windows.Forms.GroupBox gbDaCad;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource cidadeBindingSource;
        private BancoExtimpexDataSetTableAdapters.CidadeTableAdapter cidadeTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnCadOrgSair;
        private BancoExtimpexDataSetTableAdapters.EstadoTableAdapter estadoTableAdapter;
        private System.Windows.Forms.BindingSource estadoBindingSource;
        private BancoExtimpexDataSetTableAdapters.PaisTableAdapter paisTableAdapter;
        private System.Windows.Forms.BindingSource paisBindingSource;
        private System.Windows.Forms.Button btnFaCad;
        private System.Windows.Forms.Button btnSalCad;
        private System.Windows.Forms.RadioButton rbCadPais;
        private System.Windows.Forms.BindingSource cargos_AdministrativosBindingSource;
        private BancoExtimpexDataSetTableAdapters.Cargos_AdministrativosTableAdapter cargos_AdministrativosTableAdapter;
        private System.Windows.Forms.BindingSource cadastro_de_Categorias_de_DespesasBindingSource;
        private BancoExtimpexDataSetTableAdapters.Cadastro_de_Categorias_de_DespesasTableAdapter cadastro_de_Categorias_de_DespesasTableAdapter;
        private System.Windows.Forms.Label lbIdNon;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.RadioButton rdCadGrup;
        private System.Windows.Forms.RadioButton rdLoja;
        private System.Windows.Forms.RadioButton rdVend;
    }
}