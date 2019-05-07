using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extimpex
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bancoExtimpexDataSet);

        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if(btnCadastrarUsuario.Text == btnCadastrarUsuario.Text)
            {
                id_UsuarioTextBox.Enabled = true;
                nome_CompletoTextBox.Enabled = true;
                loginTextBox.Enabled = true;
                senhaTextBox.Enabled = true;
                textBox1.Enabled = true;
                btnSalvarSenha.Enabled = true;
            }
            this.usuarioTableAdapter.Fill(this.bancoExtimpexDataSet.Usuario);
            this.usuarioBindingSource.AddNew();
            
        }

        private void btnSalvarSenha_Click(object sender, EventArgs e)
        {
            if (senhaTextBox.Text == textBox1.Text)
            {
                this.Validate();
                this.usuarioBindingSource.EndEdit();
                this.usuarioTableAdapter.Update(bancoExtimpexDataSet);
                MessageBox.Show("Cadastro feito com sucesso.");
            }
            else
                MessageBox.Show("Suas senhas não então iguais."); 
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
