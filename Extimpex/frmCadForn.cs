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
    public partial class frmCadForn : Form
    {
        public frmCadForn()
        {
            InitializeComponent();
        }

        private void btnCadForSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadForCad_Click(object sender, EventArgs e)
        {
            if (btnCadForCad.Text == btnCadForCad.Text)
            {
                id_FornecedorTextBox.Enabled = true;
                nome_Razao_SocialTextBox.Enabled = true;
                cNPJTextBox.Enabled = true;
                inscricao_MunicipalTextBox.Enabled = true;
                inscricao_EstadualTextBox.Enabled = true;
                paisComboBox.Enabled = true;
                estadoComboBox.Enabled = true;
                cidadeComboBox.Enabled = true;
                enderecoTextBox.Enabled = true;
                telefoneTextBox.Enabled = true;
                telefone_SecundarioTextBox.Enabled = true;
                emailTextBox.Enabled = true;
                responsavelTextBox.Enabled = true;
                btnCadForSalv.Enabled = true;
            }
                this.extimpex_FornecedorTableAdapter.Fill(this.bancoExtimpexDataSet.Extimpex_Fornecedor);
                this.extimpex_FornecedorBindingSource.AddNew();
                this.paisTableAdapter.Fill(this.bancoExtimpexDataSet.Pais);
                this.estadoTableAdapter.Fill(this.bancoExtimpexDataSet.Estado);
                this.cidadeTableAdapter.Fill(this.bancoExtimpexDataSet.Cidade);
               
            btnCadForCad.Enabled = false;
        }

        private void btnCadForSalv_Click(object sender, EventArgs e)
        {
            btnCadForSalv.Enabled = false;

            this.Validate();
            this.extimpex_FornecedorBindingSource.EndEdit();
            this.extimpex_FornecedorTableAdapter.Update(bancoExtimpexDataSet);
            MessageBox.Show("Fornecedor cadastrado com sucesso.");
            
            btnCadForCad.Enabled = true;
        }

        private void frmCadForn_Load(object sender, EventArgs e)
        {

        }
    }
}
