using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Extimpex
{
    public partial class frmCadOrg : Form
    {
        public frmCadOrg()
        {
            InitializeComponent();
        }

        private void btnCadOrgSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFaCad_Click(object sender, EventArgs e)
        {

            gbTipCad.Enabled = true;
            gbDaCad.Enabled = true;
            btnSalCad.Enabled = true;
            this.paisTableAdapter.Fill(this.bancoExtimpexDataSet.Pais);
            this.estadoTableAdapter.Fill(this.bancoExtimpexDataSet.Estado);
            this.cidadeTableAdapter.Fill(this.bancoExtimpexDataSet.Cidade);
            this.cargos_AdministrativosTableAdapter.Fill(this.bancoExtimpexDataSet.Cargos_Administrativos);
            this.cadastro_de_Categorias_de_DespesasTableAdapter.Fill(this.bancoExtimpexDataSet.Cadastro_de_Categorias_de_Despesas);
        }

        private void btnSalCad_Click(object sender, EventArgs e)
        {
            //Comando para abrir o banco de dados
            SqlConnection Abrirnexo = new SqlConnection("Data Source=(local);Initial Catalog=BancoExtimpex;Integrated Security=True");
            //variavel que vai receber o codigo SQL
            string sqlPais = ("Insert Into Pais (Pais) Values (@Descricao)");
            string sqlEstado = ("Insert Into Estado (Estado) Values (@Descricao)");
            string sqlCidade = ("Insert Into Cidade (Cidade) Values (@Descricao)");
            string sqlCargo = ("Insert Into Cargos_Administrativos (Cargo_Administrativo) Values (@Descricao)");
            string sqlDespesas = ("Insert Into Cadastro_de_Categorias_de_Despesas (Categoria_de_Despesas) Values (@Descricao)");
            string sqlGrupo = ("Insert Into Grupo_Produto (Nome_do_Grupo) Values (@Descricao)");
            string sqlVendedor = ("Inserte Into Vendedor (Nome_do_Vendedor) Values (@Descricao)");
            string sqlLoja = ("Insert Into Loja (Nome_da_Loja) Values (@Descricao)");
            //comando que execulta o Radion button
            if (rbCadPais.Checked)
            {
                //comando que vai execultar a conexão SQL
                SqlCommand execult = new SqlCommand(sqlPais, Abrirnexo);
                //Comando que vai abrir conexão com o banco
                Abrirnexo.Open();
                //Comando para iserir os parametros no Banco Dados
                execult.Parameters.AddWithValue("@Descricao", txtNom.Text);
                //comando que vai execultar o codigo SQL
                execult.ExecuteNonQuery();
                MessageBox.Show("País Cadastrado com Sucesso!");
                txtNom.Text = ("");
            }
            else
                if (rbCadEst.Checked)
                {
                    SqlCommand execult = new SqlCommand(sqlEstado, Abrirnexo);
                    Abrirnexo.Open();
                    execult.Parameters.AddWithValue("@Descricao", txtNom.Text);
                    execult.ExecuteNonQuery();
                    MessageBox.Show("Estado Cadastrado com Sucesso!");
                    txtNom.Text = ("");
                }
            else
                    if (rbCadCdd.Checked)
                    {
                        SqlCommand execult = new SqlCommand(sqlCidade, Abrirnexo);
                        Abrirnexo.Open();
                        execult.Parameters.AddWithValue("@Descricao", txtNom.Text);
                        execult.ExecuteNonQuery();
                        MessageBox.Show("Cidade Cadastrada com Sucesso!");
                        txtNom.Text = ("");
                    }
            else
                        if (rbCadCarg.Checked)
                        {
                            SqlCommand execult = new SqlCommand(sqlCargo, Abrirnexo);
                            Abrirnexo.Open();
                            execult.Parameters.AddWithValue("@Descricao", txtNom.Text);
                            execult.ExecuteNonQuery();
                            MessageBox.Show("Cargo Cadastrado com Sucesso!");
                            txtNom.Text = ("");
                        }
            else
                            if (rbCadResDesp.Checked)
                            {
                                SqlCommand execult = new SqlCommand(sqlDespesas, Abrirnexo);
                                Abrirnexo.Open();
                                execult.Parameters.AddWithValue("@Descricao", txtNom.Text);
                                execult.ExecuteNonQuery();
                                MessageBox.Show("Categoria de Despesa Cadastrada com Sucesso!");
                                txtNom.Text = ("");
                            }
            else
                                if (rdCadGrup.Checked)
                                {
                                    SqlCommand execult = new SqlCommand(sqlGrupo, Abrirnexo);
                                    Abrirnexo.Open();
                                    execult.Parameters.AddWithValue("@Descricao", txtNom.Text);
                                    execult.ExecuteNonQuery();
                                    MessageBox.Show("Grupo de Produtos Cadastrado com sucesso!");
                                    txtNom.Text = ("");
                                }
                                else
                                    if (rdLoja.Checked)
                                    {
                                        SqlCommand execult = new SqlCommand(sqlLoja, Abrirnexo);
                                        Abrirnexo.Open();
                                        execult.Parameters.AddWithValue("@Descricao", txtNom.Text);
                                        execult.ExecuteNonQuery();
                                        MessageBox.Show("Loja Cadastrada com Sucesso!");
                                        txtNom.Text = ("");
                                    }
                                    else
                                        if (rdVend.Checked)
                                        {
                                            SqlCommand execult = new SqlCommand(sqlVendedor, Abrirnexo);
                                            Abrirnexo.Open();
                                            execult.Parameters.AddWithValue("@Descricao", txtNom.Text);
                                            MessageBox.Show("Vendedor Cadastrado com Sucesso!");
                                            txtNom.Text = ("");
                                        }
        }

        private void frmCadOrg_Load(object sender, EventArgs e)
        {

        }

    }
}
