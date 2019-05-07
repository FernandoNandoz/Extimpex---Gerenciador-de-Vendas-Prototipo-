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
    public partial class frmVendas : Form
    {
        decimal preco, desconto, Quant, precoFinal, resultDesconto;


        //Forma de Pagamento

        //Dinheiro
        decimal ValDinh1 = 0;

        //Variavel que recebe o Juros
        decimal Jur = 0, JurRessult, Periodo = 0, ValParc1 = 0;
        decimal Linha = 0, Val = 0, Exclur = 0;
        decimal ValDesc = 0, ValDescResult = 0;
        decimal ValorProduto = 0;
        //
        decimal Val1Desc = 0, Val2Desc = 0, Val3Desc = 0, ValorTotalcomDesc = 0;
        //

        public frmVendas()
        {
            InitializeComponent();

        }

        private void Iniciar_Vendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoExtimpexDataSet1.Funcionario' table. You can move, or remove it, as needed.
            this.produtoTableAdapter.Fill(this.bancoExtimpexDataSet.Produto);
            this.dados_ProdutosTableAdapter.Fill(this.bancoExtimpexDataSet.Dados_Produtos);
            txtVendor.Text = ("") + Usuario._Login;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadVend_Click(object sender, EventArgs e)
        {
            

            SqlConnection AbrirBanc = new SqlConnection("Data Source=(local);Initial Catalog=BancoExtimpex;Integrated Security=True");
            string Vendas = ("Insert Into Vendas (Nota, Data_de_Emissao, Valor_do_Desconto, Valor_Total_Desc, Vendedor, Forma_de_Pagamento, Id_Loja, Situacao, Quant_de_Parcela, Bandeira_do_Cartao, Juros, Nome_Razao_Social) Values (@Nota, @DtaEmss, @ValDesc, @ValTotDesc, @IdVedd, @ForPag, @Loja, @Situ, @QuantParc, @Bad, @Juros, @NomRaz)");
            string DadPro = ("Insert Into Dados_Produtos (Codigo, Nome_do_Produto, Quantidade, Valor_do_Produto, Valor_Total_Produto, Nota, Desconto) Values (@Cod, @NomPro, @Quant, @ValPro, @ValTotPro, @Nota, @Desc)");
            string UpdPro = (" UPDATE Produto SET Quantidade = Quantidade - @Quants WHERE Id_Produto = @Pro");
            SqlCommand exeUpdt = new SqlCommand(UpdPro, AbrirBanc);
            SqlCommand execult = new SqlCommand(Vendas, AbrirBanc);
            SqlCommand execult1 = new SqlCommand(DadPro, AbrirBanc);
            AbrirBanc.Open();

            execult.Parameters.AddWithValue("@Nota", int.Parse(txtNota.Text));
            execult.Parameters.AddWithValue("@DtaEmss", DateTime.Now);
            execult.Parameters.AddWithValue("@ValTotDesc", decimal.Parse(txtValTotDesc.Text));
            execult.Parameters.AddWithValue("@ForPag", cmbFromPag.Text);
            execult.Parameters.AddWithValue("@ValDesc", decimal.Parse(txtDesc.Text));
            execult.Parameters.AddWithValue("@NomRaz", dtaGridCliente.CurrentRow.Cells[1].Value.ToString());
            execult.Parameters.AddWithValue("@IdVedd", txtVendor.Text);
            execult.Parameters.AddWithValue("@Loja", "1");
            execult.Parameters.AddWithValue("@Situ", ("CONCLUIDA"));
            execult.Parameters.AddWithValue("@QuantParc", int.Parse(txtParc.Text));
            execult.Parameters.AddWithValue("@Bad", cmbBad.Text);
            execult.Parameters.AddWithValue("@Juros", decimal.Parse(txtJuro.Text));
            execult.ExecuteNonQuery();

            for (int i = 0; i < dtGridDetalhes.Rows.Count - 0; i++)
            {
                execult1.Parameters.Clear();
                execult1.Parameters.AddWithValue("@Cod", dtGridDetalhes.Rows[i].Cells[0].Value);
                execult1.Parameters.AddWithValue("@NomPro", dtGridDetalhes.Rows[i].Cells[1].Value);
                execult1.Parameters.AddWithValue("@Quant", decimal.Parse(dtGridDetalhes.Rows[i].Cells[2].Value.ToString()));
                execult1.Parameters.AddWithValue("@ValPro", decimal.Parse(dtGridDetalhes.Rows[i].Cells[3].Value.ToString()));
                execult1.Parameters.AddWithValue("@ValTotPro", decimal.Parse(dtGridDetalhes.Rows[i].Cells[4].Value.ToString()));
                execult1.Parameters.AddWithValue("@Desc", decimal.Parse(dtGridDetalhes.Rows[i].Cells[6].Value.ToString()));

                execult1.Parameters.AddWithValue("@Nota", decimal.Parse(txtNota.Text));
                execult1.ExecuteNonQuery();

                //Codigo para dar UPDATE nos produtos
                exeUpdt.Parameters.Clear();
                exeUpdt.Parameters.AddWithValue("@Quants", dtGridDetalhes.Rows[i].Cells[2].Value);
                exeUpdt.Parameters.AddWithValue("@Pro", dtGridDetalhes.Rows[i].Cells[5].Value);

                exeUpdt.ExecuteNonQuery();
            }
            MessageBox.Show("Cadastro de Vendas Realizado com Sucesso!");

            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dtGridDetalhes.Rows.Add(txtCod.Text, cmbNomPro.Text, txtQuant.Text, txtValPro.Text, textValTotPro.Text, cmbNomPro.SelectedValue, txtdescP.Text);
            //Valor total do produto
            ValDinh1 = ValDinh1 + decimal.Parse(textValTotPro.Text);

            ValorProduto = decimal.Parse(txtValPro.Text);
            ValDesc = decimal.Parse(txtdescP.Text.ToString());
            ValDescResult = ValDescResult + (ValorProduto * ValDesc / 100 * Quant);

            txtDesc.Text = ("") + ValDescResult;

            txtValTotDesc.Text = ("") + ValDinh1;

        }

        private void cmbFromPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCadVend.Enabled = true;
            btnIniCad.Enabled = true;

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
                    cmbBad.Text = "0";
                    txtParc.Text = ("") + 0;
                    txtJuro.Text = ("") + 0;
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
            Val1Desc = decimal.Parse(dtGridDetalhes.CurrentRow.Cells[3].Value.ToString());
            Val2Desc = (Val1Desc - Linha);
            Val3Desc = decimal.Parse(txtDesc.Text);
            ValDescResult = (Val3Desc - Val2Desc);
            txtDesc.Text = ("") + ValDescResult;


            Linha = decimal.Parse(dtGridDetalhes.CurrentRow.Cells[4].Value.ToString());
            Val = decimal.Parse(txtValTotDesc.Text);
            Exclur = (Val - Linha);

            txtValTotDesc.Text = ("") + Exclur;

            int x = dtGridDetalhes.CurrentRow.Index;

            dtGridDetalhes.Rows.Remove(this.dtGridDetalhes.Rows[x]);

        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            this.clienteTableAdapter.queryPesquisaCliente(this.bancoExtimpexDataSet.Cliente, txtCliente.Text + "%");

            cmbFromPag.Enabled = true;
            cmbBad.Enabled = true;
            txtParc.Enabled = true;
            txtJuro.Enabled = true;
            btnGerFat.Enabled = true;
            dtaGridDadPag.Enabled = true;
        }

        private void txtdescP_TextChanged(object sender, EventArgs e)
        {
            if (txtdescP.Text != (""))
            {
                Quant = decimal.Parse(txtQuant.Text);
                preco = decimal.Parse(txtValPro.Text);
                desconto = decimal.Parse(txtdescP.Text);
                //resultQuantPrec = preco * Quant;
                resultDesconto = (preco * desconto / 100 * Quant);
                precoFinal = (preco * Quant - resultDesconto);

                textValTotPro.Text = ("" + precoFinal);
            }
            else
                MessageBox.Show("Desconto não pode estar Vazio!");
        }

        private void btnGerFat_Click(object sender, EventArgs e)
        {
            btnExclu.Enabled = false;


            Jur = decimal.Parse(txtJuro.Text);
            JurRessult = (ValDinh1 * Jur / 100);
            ValDinh1 = (ValDinh1 + JurRessult);

            Periodo = decimal.Parse(txtParc.Text);
            ValParc1 = ValDinh1 / Periodo;


            txtValTotDesc.Text = ("") + ValDinh1;

            btnExclu.Enabled = true;

            for (int i = 1; i <= int.Parse(txtParc.Text.ToString()); i++)
            {
                dtaGridDadPag.Rows.Add(i, ValParc1, DateTime.Now, txtJuro.Text);
            }
        }

        private void btnIniCad_Click(object sender, EventArgs e)
        {
                 if (btnIniCad.Text == btnIniCad.Text)
                    {
                        string Vendas = ("Insert Into Vendas (Nota, Data_de_Emissao, Valor_do_Desconto, Valor_Total_Desc, Vendedor, Forma_de_Pagamento, Id_Loja, Situacao, Quant_de_Parcela, Bandeira_do_Cartao, Juros, Nome_Razao_Social) Values (@Nota, @DtaEmss, @ValDesc, @ValTotDesc, @IdVedd, @ForPag, @Loja, @Situ, @QuantParc, @Bad, @Juros, @NomRaz)");
                        string DadPro = ("Insert Into Dados_Produtos (Codigo, Nome_do_Produto, Quantidade, Valor_do_Produto, Valor_Total_Produto, Nota, Desconto, IdProduto) Values (@Cod, @NomPro, @Quant, @ValPro, @ValTotPro, @Nota, @Desc, @IdProduto)");
                        string UpdPro = (" UPDATE Produto SET Quantidade = Quantidade - @Quants WHERE Id_Produto = @Pro");

                        SqlCommand exeUpdt = new SqlCommand(UpdPro, Conexao._conexao);
                        SqlCommand execult = new SqlCommand(Vendas, Conexao._conexao);
                        SqlCommand execult1 = new SqlCommand(DadPro, Conexao._conexao);

                        Conexao._conexao.Open();

                        execult.Parameters.AddWithValue("@Nota", int.Parse(txtNota.Text));
                        execult.Parameters.AddWithValue("@DtaEmss", DateTime.Now);
                        execult.Parameters.AddWithValue("@ValTotDesc", decimal.Parse(txtValTotDesc.Text));
                        execult.Parameters.AddWithValue("@ForPag", cmbFromPag.Text);
                        execult.Parameters.AddWithValue("@ValDesc", decimal.Parse(txtDesc.Text));
                        execult.Parameters.AddWithValue("@NomRaz", dtaGridCliente.CurrentRow.Cells[1].Value);
                        execult.Parameters.AddWithValue("@IdVedd", txtVendor.Text);
                        execult.Parameters.AddWithValue("@Loja", "1");
                        execult.Parameters.AddWithValue("@Situ", "ORÇAMENTO");
                        execult.Parameters.AddWithValue("@QuantParc", int.Parse(txtParc.Text));
                        execult.Parameters.AddWithValue("@Bad", cmbBad.Text);
                        execult.Parameters.AddWithValue("@Juros", decimal.Parse(txtJuro.Text));

                        execult.ExecuteNonQuery();

                        for (int i = 0; i < dtGridDetalhes.Rows.Count - 0; i++)
                        {
                            execult1.Parameters.Clear();
                            execult1.Parameters.AddWithValue("@Cod", dtGridDetalhes.Rows[i].Cells[0].Value);
                            execult1.Parameters.AddWithValue("@NomPro", dtGridDetalhes.Rows[i].Cells[1].Value);
                            execult1.Parameters.AddWithValue("@Quant", decimal.Parse(dtGridDetalhes.Rows[i].Cells[2].Value.ToString()));
                            execult1.Parameters.AddWithValue("@ValPro", decimal.Parse(dtGridDetalhes.Rows[i].Cells[3].Value.ToString()));
                            execult1.Parameters.AddWithValue("@ValTotPro", decimal.Parse(dtGridDetalhes.Rows[i].Cells[4].Value.ToString()));
                            execult1.Parameters.AddWithValue("@Desc", decimal.Parse(dtGridDetalhes.Rows[i].Cells[6].Value.ToString()));
                            execult1.Parameters.AddWithValue("@IdProduto", cmbNomPro.SelectedValue);

                            execult1.Parameters.AddWithValue("@Nota", decimal.Parse(txtNota.Text));

                            execult1.ExecuteNonQuery();
                        }
                        MessageBox.Show("ORÇAMENTO Realizado com Sucesso!");

                        this.Close();
                    }
            }
        }
    }