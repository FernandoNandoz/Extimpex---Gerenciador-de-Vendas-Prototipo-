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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            //comando para fechar o formulario.
            //
            this.Close();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //
            //comando para abrir os formularios.
            //
            frmCadUsuario AbrirCadastrarUsuario = new frmCadUsuario();
            AbrirCadastrarUsuario.ShowDialog();
            AbrirCadastrarUsuario.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente AbrirCliente = new frmCadCliente();
            AbrirCliente.ShowDialog();
            AbrirCliente.Dispose();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadForn AbrirCadatrarFornecedor = new frmCadForn();
            AbrirCadatrarFornecedor.ShowDialog();
            AbrirCadatrarFornecedor.Dispose();
        }

        private void foolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadOrg AbrirCadastrosOrganizacionais = new frmCadOrg();
            AbrirCadastrosOrganizacionais.ShowDialog();
            AbrirCadastrosOrganizacionais.Dispose();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFun AbrirCadastrarFuncionario = new frmCadFun();
            AbrirCadastrarFuncionario.ShowDialog();
            AbrirCadastrarFuncionario.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPro AbrirCadastroProduto = new frmCadPro();
            AbrirCadastroProduto.ShowDialog();
            AbrirCadastroProduto.Dispose();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProd AbrirProduto = new frmProd();
            AbrirProduto.ShowDialog();
            AbrirProduto.Dispose();
        }

        private void entradaDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntEsto AbrirEntradadeEstoque = new frmEntEsto();
            AbrirEntradadeEstoque.ShowDialog();
            AbrirEntradadeEstoque.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Usu.Text = ("") + Usuario._Login;
        }

        private void iniciarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda AbrirVendas = new frmVenda();
            AbrirVendas.ShowDialog();
            AbrirVendas.Dispose();
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmContas_a_Receber AbrirContaAreceber = new frmContas_a_Receber();
            AbrirContaAreceber.ShowDialog();
            AbrirContaAreceber.Dispose();
        }

        private void fluxoDeCaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFluxo_de_Caixa AbrirFluxo = new frmFluxo_de_Caixa();
            AbrirFluxo.ShowDialog();
            AbrirFluxo.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Usu_Click(object sender, EventArgs e)
        {

        }
    }
}
