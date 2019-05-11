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
    public partial class frmPesqProduto : Form
    {
        public frmPesqProduto()
        {
            InitializeComponent();
        }


        ConexaoBD bd = new ConexaoBD();
        String sql;

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            sql = "select * from produto";

            if (txt_pesquisar.Text != "")
            {
                if (rdb_desc.Checked)
                {
                    sql = string.Format("select * from produto where descricao = '{0}' ", txt_pesquisar.Text);
                }
                else if (rdb_preco.Checked)
                {
                    sql = string.Format(" select * from produto where preco = '{0}'", txt_pesquisar.Text);
                }

            }
            dtg_PesqProduto.DataSource = bd.executarconsulta(sql);


        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
