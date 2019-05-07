using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extimpex
{

    public partial class frmORCAMENTO : Form
    {
        frmVenda Instancia;
        int Nota, NotaVenda, Parcela;
        decimal Juro;
        string Cliente, Bandeira, FormaPag, ProdutosRelate;
        decimal ValorTotalDesconto = 0, ValorTotalcomDesc = 0, Quantidade = 0, Preco = 0, PrecoTotal = 0, Desconto = 0;

        decimal JUROCONVERT = 0;


        //Forma de Pagamento

        //Dinheiro
        decimal ValPrecoTotal = 0;

        //Variavel que recebe o Juros
        decimal JurRessult, ValParc1 = 0;
        decimal Linha = 0, Val = 0, Exclur = 0;
        decimal ValDescResult = 0;
        //
        decimal Val1Desc = 0, Val2Desc = 0, Val3Desc = 0;

        public frmORCAMENTO(frmVenda InstanciaVendas)
        {
            InitializeComponent();
            Instancia = InstanciaVendas;
            Nota = int.Parse(InstanciaVendas.dtaGridRelate.CurrentRow.Cells[3].Value.ToString());
            FormaPag = InstanciaVendas.dtaGridRelate.CurrentRow.Cells[8].Value.ToString();
            Bandeira = InstanciaVendas.dtaGridRelate.CurrentRow.Cells[10].Value.ToString();
            Parcela = int.Parse(InstanciaVendas.dtaGridRelate.CurrentRow.Cells[12].Value.ToString());
            Juro = decimal.Parse(InstanciaVendas.dtaGridRelate.CurrentRow.Cells[13].Value.ToString());
            ValorTotalDesconto = decimal.Parse(InstanciaVendas.dtaGridRelate.CurrentRow.Cells[5].Value.ToString());
            ValorTotalcomDesc = decimal.Parse(InstanciaVendas.dtaGridRelate.CurrentRow.Cells[6].Value.ToString());
            Cliente = InstanciaVendas.dtaGridRelate.CurrentRow.Cells[1].Value.ToString();
        }

        private void Iniciar_Vendas_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.bancoExtimpexDataSet.Cliente);
            this.produtoTableAdapter.Fill(this.bancoExtimpexDataSet.Produto);
            this.dados_ProdutosTableAdapter.queryNotPro(this.bancoExtimpexDataSet.Dados_Produtos, Nota);
            txtNota.Text = ("") + Nota;
            cmbFromPag.Text = FormaPag;
            cmbBad.Text = Bandeira;
            txtParc.Text = ("") + Parcela;
            txtJuro.Text = ("") + Juro;
            txtDesc.Text = ("") + ValorTotalDesconto;
            txtValTotDesc.Text = ("") + ValorTotalcomDesc;
            txtCliente.Text = Cliente;
            txtVendor.Text = ("") + Usuario._Login;

            if (cmbFromPag.Text == "Dinheiro" || cmbFromPag.Text == "Débito")
            {
                btnCadVend.Enabled = true;
            }
            else
                btnCadVend.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadVend_Click(object sender, EventArgs e)
        {          
            string UpdPro = ("UPDATE Produto SET Quantidade = Quantidade - @Quants WHERE Id_Produto = @Pro");
            string UpDet = ("UPDATE Vendas SET Situacao = @Situ WHERE Nota = @Nota");
            SqlCommand exeUpdt = new SqlCommand(UpdPro, Conexao._conexao);
            SqlCommand exeDet = new SqlCommand(UpDet, Conexao._conexao);

            Conexao._conexao.Open();

            for (int i = 0; i < dtGridDetalhes2.Rows.Count - 0; i++)
            {
                //Codigo para dar UPDATE nos produtos
                exeUpdt.Parameters.Clear();
                exeUpdt.Parameters.AddWithValue("@Quants", dtGridDetalhes2.Rows[i].Cells[4].Value);
                exeUpdt.Parameters.AddWithValue("@Pro", dtGridDetalhes2.Rows[i].Cells[7].Value);

                exeUpdt.ExecuteNonQuery();

                MessageBox.Show(("") + dtGridDetalhes2.CurrentRow.Cells[7].Value);
            }

            exeDet.Parameters.AddWithValue("@Situ", "CONCLUIDA");
            exeDet.Parameters.AddWithValue("@Nota", int.Parse(txtNota.Text));

            exeDet.ExecuteNonQuery();

            MessageBox.Show("Cadastro de Vendas Realizado com Sucesso!");
            Conexao._conexao.Close();

            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dtGridDetalhes2.Rows.Add(cmbNomPro.SelectedValue, txtCod.Text, cmbNomPro.Text, txtQuant.Text, txtValPro.Text, textValTotPro.Text, txtdescP.Text);

        }

        private void cmbFromPag_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbFromPag.Text == ("Cartão de Crédito") || cmbFromPag.Text == ("Boleto Bancario") || cmbFromPag.Text == ("Crédito Loja"))
            {
                lbBad.Visible = true;
                cmbBad.Visible = true;
                cmbBad.Enabled = true;
                lbParc.Visible = true;
                txtParc.Visible = true;
                txtParc.Enabled = true;
                lbJuro.Visible = true;
                txtJuro.Visible = true;
                btnGerFat.Visible = true;

                btnExclu.Enabled = false;
            }
            else
                if (cmbFromPag.Text == ("Dinheiro") || cmbFromPag.Text == ("Débito"))
                {
                    lbBad.Visible = false;
                    cmbBad.Visible = false;
                    lbParc.Visible = false;
                    txtParc.Visible = false;
                    lbJuro.Visible = false;
                    txtJuro.Visible = false;
                    btnGerFat.Visible = false;

                    btnExclu.Enabled = false;

                }
        }


        private void btnExclu_Click(object sender, EventArgs e)
        {

        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.queryPesquisaCliente(this.bancoExtimpexDataSet.Cliente, txtCliente.Text + "%");

        }

        private void txtdescP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerFat_Click(object sender, EventArgs e)
        {
            if (btnGerFat.Text == btnGerFat.Text)
            {
                btnExclu.Enabled = false;

                JurRessult = (ValorTotalcomDesc * Juro / 100);
                ValPrecoTotal = (ValorTotalcomDesc - JurRessult);

                ValParc1 = ValorTotalcomDesc / Parcela;


                btnExclu.Enabled = true;

                for (int i = 1; i <= Parcela; i++)
                {
                    dtaGridDadPag.Rows.Add(i, ValParc1, DateTime.Now, ("") + Juro);
                }

                btnCadVend.Enabled = true;
            }
        }
    }
}