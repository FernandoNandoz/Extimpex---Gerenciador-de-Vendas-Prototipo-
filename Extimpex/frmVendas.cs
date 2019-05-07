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
    public partial class frmVenda : Form
    {
        string dtaGridRelata;
       

        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            
        }

        private void frmEntEsto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoExtimpexDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.bancoExtimpexDataSet.Vendas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            if (rdNota.Checked)
            {
                this.vendasTableAdapter.queryNOTA(this.bancoExtimpexDataSet.Vendas, int.Parse(txtPesqu.Text));
            }
            else
                if (rdSitu.Checked)
                {
                    this.vendasTableAdapter.queryOrcamento(this.bancoExtimpexDataSet.Vendas, txtPesqu.Text);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVendas AbrirVendas = new frmVendas();
            AbrirVendas.ShowDialog();
            AbrirVendas.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtaGridRelata = dtaGridRelate.CurrentRow.Cells[9].Value.ToString();
    
            if (dtaGridRelata == ("ORÇAMENTO"))
            {
                frmORCAMENTO AbrirOrcamento = new frmORCAMENTO(this);
                AbrirOrcamento.ShowDialog();
                AbrirOrcamento.Dispose();
            }
            else

            MessageBox.Show("Selecione um ORÇAMENTO!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDetalhesVendas AbrirDetalhes = new frmDetalhesVendas(this);
            AbrirDetalhes.ShowDialog();
            AbrirDetalhes.Dispose();
        }

        private void dtaGridRelate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
