using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas_turma
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void ptb_pesq_Click(object sender, EventArgs e)
        {
            frmPesqProduto pesqprodutos = new frmPesqProduto();
            pesqprodutos.ShowDialog();
        }

        private void ptb_vendas_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.ShowDialog();
        }

        private void ptb_produtos_Click(object sender, EventArgs e)
        {
            Form1 produtos = new Form1();
            produtos.ShowDialog();
        }
    }
}
