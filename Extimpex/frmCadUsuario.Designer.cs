namespace Extimpex
{
    partial class frmCadUsuario
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
            System.Windows.Forms.Label id_UsuarioLabel;
            System.Windows.Forms.Label nome_CompletoLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label senhaLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoExtimpexDataSet = new Extimpex.BancoExtimpexDataSet();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.nome_CompletoTextBox = new System.Windows.Forms.TextBox();
            this.id_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTableAdapter = new Extimpex.BancoExtimpexDataSetTableAdapters.UsuarioTableAdapter();
            this.tableAdapterManager = new Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager();
            this.btnCadastrarUsuario = new System.Windows.Forms.Button();
            this.btnSalvarSenha = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            id_UsuarioLabel = new System.Windows.Forms.Label();
            nome_CompletoLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_UsuarioLabel
            // 
            id_UsuarioLabel.AutoSize = true;
            id_UsuarioLabel.Location = new System.Drawing.Point(8, 16);
            id_UsuarioLabel.Name = "id_UsuarioLabel";
            id_UsuarioLabel.Size = new System.Drawing.Size(58, 13);
            id_UsuarioLabel.TabIndex = 0;
            id_UsuarioLabel.Text = "Id Usuario:";
            // 
            // nome_CompletoLabel
            // 
            nome_CompletoLabel.AutoSize = true;
            nome_CompletoLabel.Location = new System.Drawing.Point(8, 55);
            nome_CompletoLabel.Name = "nome_CompletoLabel";
            nome_CompletoLabel.Size = new System.Drawing.Size(85, 13);
            nome_CompletoLabel.TabIndex = 2;
            nome_CompletoLabel.Text = "Nome Completo:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(8, 94);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(36, 13);
            loginLabel.TabIndex = 4;
            loginLabel.Text = "Login:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(8, 133);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(41, 13);
            senhaLabel.TabIndex = 6;
            senhaLabel.Text = "Senha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(senhaLabel);
            this.groupBox1.Controls.Add(this.senhaTextBox);
            this.groupBox1.Controls.Add(loginLabel);
            this.groupBox1.Controls.Add(this.loginTextBox);
            this.groupBox1.Controls.Add(nome_CompletoLabel);
            this.groupBox1.Controls.Add(this.nome_CompletoTextBox);
            this.groupBox1.Controls.Add(id_UsuarioLabel);
            this.groupBox1.Controls.Add(this.id_UsuarioTextBox);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Repetir Senha:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(201, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Senha", true));
            this.senhaTextBox.Enabled = false;
            this.senhaTextBox.Location = new System.Drawing.Point(11, 149);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(166, 20);
            this.senhaTextBox.TabIndex = 7;
            this.senhaTextBox.UseSystemPasswordChar = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.bancoExtimpexDataSet;
            // 
            // bancoExtimpexDataSet
            // 
            this.bancoExtimpexDataSet.DataSetName = "BancoExtimpexDataSet";
            this.bancoExtimpexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTextBox
            // 
            this.loginTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.loginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Login", true));
            this.loginTextBox.Enabled = false;
            this.loginTextBox.Location = new System.Drawing.Point(11, 110);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(166, 20);
            this.loginTextBox.TabIndex = 5;
            // 
            // nome_CompletoTextBox
            // 
            this.nome_CompletoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nome_CompletoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nome_Completo", true));
            this.nome_CompletoTextBox.Enabled = false;
            this.nome_CompletoTextBox.Location = new System.Drawing.Point(11, 71);
            this.nome_CompletoTextBox.Name = "nome_CompletoTextBox";
            this.nome_CompletoTextBox.Size = new System.Drawing.Size(356, 20);
            this.nome_CompletoTextBox.TabIndex = 3;
            // 
            // id_UsuarioTextBox
            // 
            this.id_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Id_Usuario", true));
            this.id_UsuarioTextBox.Enabled = false;
            this.id_UsuarioTextBox.Location = new System.Drawing.Point(11, 32);
            this.id_UsuarioTextBox.Name = "id_UsuarioTextBox";
            this.id_UsuarioTextBox.ReadOnly = true;
            this.id_UsuarioTextBox.Size = new System.Drawing.Size(82, 20);
            this.id_UsuarioTextBox.TabIndex = 1;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Fluxo_de_CaixaTableAdapter = null;
            this.tableAdapterManager.FuncionarioTableAdapter = null;
            this.tableAdapterManager.Grupo_ProdutoTableAdapter = null;
            this.tableAdapterManager.LojaTableAdapter = null;
            this.tableAdapterManager.Nota_FiscalTableAdapter = null;
            this.tableAdapterManager.Notas_ProdutoTableAdapter = null;
            this.tableAdapterManager.PaisTableAdapter = null;
            this.tableAdapterManager.ProdutoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Extimpex.BancoExtimpexDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = this.usuarioTableAdapter;
            this.tableAdapterManager.VendasTableAdapter = null;
            this.tableAdapterManager.VendedorTableAdapter = null;
            // 
            // btnCadastrarUsuario
            // 
            this.btnCadastrarUsuario.Location = new System.Drawing.Point(10, 191);
            this.btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            this.btnCadastrarUsuario.Size = new System.Drawing.Size(112, 35);
            this.btnCadastrarUsuario.TabIndex = 1;
            this.btnCadastrarUsuario.Text = "Cadastrar Usuário";
            this.btnCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btnCadastrarUsuario.Click += new System.EventHandler(this.btnCadastrarUsuario_Click);
            // 
            // btnSalvarSenha
            // 
            this.btnSalvarSenha.Enabled = false;
            this.btnSalvarSenha.Location = new System.Drawing.Point(143, 191);
            this.btnSalvarSenha.Name = "btnSalvarSenha";
            this.btnSalvarSenha.Size = new System.Drawing.Size(112, 35);
            this.btnSalvarSenha.TabIndex = 2;
            this.btnSalvarSenha.Text = "Salvar Senha";
            this.btnSalvarSenha.UseVisualStyleBackColor = true;
            this.btnSalvarSenha.Click += new System.EventHandler(this.btnSalvarSenha_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(267, 191);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 235);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvarSenha);
            this.Controls.Add(this.btnCadastrarUsuario);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.Load += new System.EventHandler(this.frmCadUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoExtimpexDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BancoExtimpexDataSet bancoExtimpexDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private BancoExtimpexDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private BancoExtimpexDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox nome_CompletoTextBox;
        private System.Windows.Forms.TextBox id_UsuarioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCadastrarUsuario;
        private System.Windows.Forms.Button btnSalvarSenha;
        private System.Windows.Forms.Button btnSair;
    }
}