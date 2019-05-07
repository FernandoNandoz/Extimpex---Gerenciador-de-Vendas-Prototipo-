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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnSairCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            if (btnCadCliente.Text == btnCadCliente.Text)
            {
                txtIdClien.Enabled = true;
                radPessFisica.Enabled = true;
                radPessJuri.Enabled = true;
                txtRazSoci.Enabled = true;
                txtCPF.Enabled = true;
                txtRG.Enabled = true;
                txtCNPJ.Enabled = true;
                txtInscrMuni.Enabled = true;
                txtInscrEstad.Enabled = true;
                txtEnd.Enabled = true;
                cmbPais.Enabled = true;
                cmbEstad.Enabled = true;
                cmbCidd.Enabled = true;
                txtTel.Enabled = true;
                txtTelSecund.Enabled = true;
                txtEmail.Enabled = true;
                txtObs.Enabled = true;
                btnSalveCliente.Enabled = true;
            }

            this.cidadeTableAdapter.Fill(this.bancoExtimpexDataSet.Cidade);
            this.estadoTableAdapter.Fill(this.bancoExtimpexDataSet.Estado);
            this.paisTableAdapter.Fill(this.bancoExtimpexDataSet.Pais);
            this.clienteTableAdapter.Fill(this.bancoExtimpexDataSet.Cliente);
            this.clienteBindingSource.AddNew();

            btnCadCliente.Enabled = false;
        }

        private void btnSalveCliente_Click(object sender, EventArgs e)
        {
            
            btnSalveCliente.Enabled = false;
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.clienteTableAdapter.Update(bancoExtimpexDataSet);
            MessageBox.Show("Cadastro feito com sucesso.");

            btnCadCliente.Enabled = true;
        }

        private void radPessFisica_CheckedChanged(object sender, EventArgs e)
        {
            labNomeCom.Visible = true;
            txtRazSoci.Visible = true;
            labCPF.Visible = true;
            txtCPF.Visible = true;
            labRG.Visible = true;
            txtRG.Visible = true;
            labRazSocial.Visible = false;
            labCNPJ.Visible = false;
            txtCNPJ.Visible = false;
            labIncriMuni.Visible = false;
            txtInscrMuni.Visible = false;
            labIncriEstad.Visible = false;
            txtInscrEstad.Visible = false; 
        }

        private void radPessJuri_CheckedChanged(object sender, EventArgs e)
        {
            labRazSocial.Visible = true;
            txtRazSoci.Visible = true;
            labCNPJ.Visible = true;
            txtCNPJ.Visible = true;
            labIncriMuni.Visible = true;
            txtInscrMuni.Visible = true;
            labIncriEstad.Visible = true;
            txtInscrEstad.Visible = true;
            labNomeCom.Visible = false;
            labCPF.Visible = false;
            txtCPF.Visible = false;
            labRG.Visible = false;
            txtRG.Visible = false;
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
