using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Extimpex
{
    public partial class frmCadEntEsto : Form
    {
        decimal num1 = 0, num2 = 0;
        decimal result;
        decimal BasCal = 0;
        decimal ValIc1 = 6, ValIc2 = 100;
        decimal Porcent;
        decimal resultValIc;
        decimal TotNot;

        public frmCadEntEsto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalv_Click(object sender, EventArgs e)
        {

            SqlConnection AbrirBanc = new SqlConnection("Data Source=(local);Initial Catalog=BancoExtimpex;Integrated Security=True");
            string NotFisc = ("Insert Into Nota_Fiscal (Id_Fornecedor, Nota_Fiscal, Chave_de_Acesso, CFOP, Data_de_Emissao, Base_de_Calculo_ICMS, Valor_dp_ICMS, Valor_Total_da_Nota, Data_de_Entrada) Values (@IdForn, @NotFisc, @ChavAcss, @CFOP, @DtaEmss, @BasCalIcms, @ValIcms, @ValTotNot, @DtaEnt)");
            string NotPro = ("Insert Into Notas_Produto (Nota_Fiscal, Codigo, Nome_do_Produto, Quantidade, Valor_do_Produto, Valor_Total_do_Produto) Values (@NotFisc, @Cod, @NomPro, @Quant, @ValPro, @ValTotPro)");
            string UpdateQuery = ("UPDATE Produto SET Quantidade = Quantidade + @Quant WHERE Id_Produto = @Produto");
            SqlCommand exeUpd = new SqlCommand(UpdateQuery, AbrirBanc);
            SqlCommand exeFisc = new SqlCommand(NotFisc, AbrirBanc);
            SqlCommand execult = new SqlCommand(NotPro, AbrirBanc);
            AbrirBanc.Open();

            exeFisc.Parameters.AddWithValue("@IdForn", cmbForn.SelectedValue);
            exeFisc.Parameters.AddWithValue("@NotFisc", txtNotFisc.Text);
            exeFisc.Parameters.AddWithValue("@ChavAcss", txtChavAcss.Text);
            exeFisc.Parameters.AddWithValue("@CFOP", cmbCFOP.Text);
            exeFisc.Parameters.AddWithValue("@DtaEmss", dtDtaEmss.Text);
            exeFisc.Parameters.AddWithValue("@BasCalIcms", decimal.Parse(txtBasCalICMS.Text));
            exeFisc.Parameters.AddWithValue("@ValIcms", decimal.Parse(txtValIcms.Text));
            exeFisc.Parameters.AddWithValue("ValTotNot", decimal.Parse(txtValTotNot.Text));
            exeFisc.Parameters.AddWithValue("@DtaEnt", dtDtaEnt.Text);
            exeFisc.ExecuteNonQuery();


            for (int i = 0; i < dtaDetalhes.Rows.Count - 0; i++)
            {
                execult.Parameters.Clear();
                execult.Parameters.AddWithValue("@NotFisc", dtaDetalhes.Rows[i].Cells[0].Value);
                execult.Parameters.AddWithValue("@Cod", dtaDetalhes.Rows[i].Cells[1].Value);
                execult.Parameters.AddWithValue("@NomPro", dtaDetalhes.Rows[i].Cells[2].Value);
                execult.Parameters.AddWithValue("@Quant", dtaDetalhes.Rows[i].Cells[3].Value);
                execult.Parameters.AddWithValue("@ValPro", dtaDetalhes.Rows[i].Cells[4].Value);
                execult.Parameters.AddWithValue("@ValTotPro", dtaDetalhes.Rows[i].Cells[5].Value);

                execult.ExecuteNonQuery();
                //Codigo para dar update na tablela de Produtos
                exeUpd.Parameters.Clear();
                exeUpd.Parameters.AddWithValue("@Quant", dtaDetalhes.Rows[i].Cells[3].Value);
                exeUpd.Parameters.AddWithValue("@Produto", dtaDetalhes.Rows[i].Cells[6].Value);

                exeUpd.ExecuteNonQuery();
            }
            AbrirBanc.Close();
            MessageBox.Show("Nota Fiscal Cadastrada com Sucesso!");

            
        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            dtaDetalhes.Rows.Add(txtNotFisc.Text, txtCod.Text, cmbNomPro.Text, txtQuant.Text, txtValPro.Text, txtValTotPro.Text, cmbNomPro.SelectedValue);
            //Calculos Impostos
            BasCal = BasCal + decimal.Parse(txtValTotPro.Text);
            txtBasCalICMS.Text = ("") + BasCal;

            Porcent = ValIc1 / ValIc2;
            resultValIc = BasCal * Porcent;
            txtValIcms.Text = ("") + resultValIc;

            TotNot = BasCal + resultValIc;
            txtValTotNot.Text = ("") + TotNot;
        }

        private void txtValPro_TextChanged(object sender, EventArgs e)
        {
            if (txtValPro.Text != (""))
            {
                num1 = decimal.Parse(txtQuant.Text);
                num2 = decimal.Parse(txtValPro.Text);
                result = num1 * num2;
                txtValTotPro.Text = ("") + result;
            }
            else
                MessageBox.Show("Valor do Produto não pode ficar vazio!");
        }

        private void btnInci_Click(object sender, EventArgs e)
        {
 
            gbDadNot.Enabled = true;
            gbDadPro.Enabled = true;
            gbDadTriFisc.Enabled = true;
            btnSalv.Enabled = true;

            this.extimpex_FornecedorTableAdapter.Fill(this.bancoExtimpexDataSet.Extimpex_Fornecedor);
            this.produtoTableAdapter.Fill(this.bancoExtimpexDataSet.Produto);
        }

        private void txtIdNotFisc_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadEntEsto_Load(object sender, EventArgs e)
        {

        }
    }
}
