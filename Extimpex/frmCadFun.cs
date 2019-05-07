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
    public partial class frmCadFun : Form
    {
        public frmCadFun()
        {
            InitializeComponent();
        }

        private void btnCadFunSair_Click(object sender, EventArgs e)
        {
            //
            //comando para fechar o formulario.
            //
            this.Close();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            //
            //comando para habilitar os button do formulario.
            //
            gbDaPess.Enabled = true;
            gbDaBanc.Enabled = true;
            gbEnd.Enabled = true;
            btnSalFun.Enabled = true;
            //
            //comando para abrir as tabelas do banco de dados no formulario.
            //
            this.funcionarioTableAdapter.Fill(this.bancoExtimpexDataSet.Funcionario);
            this.funcionarioBindingSource.AddNew();
            this.paisTableAdapter.Fill(this.bancoExtimpexDataSet.Pais);
            this.estadoTableAdapter.Fill(this.bancoExtimpexDataSet.Estado);
            this.cidadeTableAdapter.Fill(this.bancoExtimpexDataSet.Cidade);   
        }

        private void btnSalFun_Click(object sender, EventArgs e)
        {
            //
            //comando para fechar o banco de dados e salvar os dados acrecentados no formulario no banco de dados.
            this.Validate();
            this.funcionarioBindingSource.EndEdit();
            this.funcionarioTableAdapter.Update(bancoExtimpexDataSet);
            MessageBox.Show("Funcionário Cadastrado com Sucesso!");
        }

        private void frmCadFun_Load(object sender, EventArgs e)
        {

        }

        private void inserir_FotoPictureBox_Click(object sender, EventArgs e)
        {
          
        }
    }
}
