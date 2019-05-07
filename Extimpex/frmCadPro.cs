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
    public partial class frmCadPro : Form
    {
        public frmCadPro()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void frmCadPro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoExtimpexDataSet.Grupo_Produto' table. You can move, or remove it, as needed.
            this.grupo_ProdutoTableAdapter.Fill(this.bancoExtimpexDataSet.Grupo_Produto);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbDados.Enabled = true;
            btnSalv.Enabled = true;
            btnCadpro.Enabled = false;
            this.produtoTableAdapter.Fill(this.bancoExtimpexDataSet.Produto);
            this.produtoBindingSource.AddNew();
        }

        private void btnSalv_Click(object sender, EventArgs e)
        {
            btnSalv.Enabled = false;
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.produtoTableAdapter.Update(bancoExtimpexDataSet);
            MessageBox.Show("Produto Cadastrado Com Sucesso.");
            btnCadpro.Enabled = true;
        }
    }
}
