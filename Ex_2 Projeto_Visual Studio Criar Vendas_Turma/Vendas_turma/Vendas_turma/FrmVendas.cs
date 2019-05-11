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
    public partial class FrmVendas : Form
    {
        public FrmVendas()
        {
            InitializeComponent();
        }


        ConexaoBD bd = new ConexaoBD();
        String sql;

        public int codigo_produto;


        public void comboboxProduto()
        {
            sql = "Select * from produto";
            cbx_produto.DataSource = bd.executarconsulta(sql);
            cbx_produto.ValueMember = "cod_produto";
            cbx_produto.DisplayMember = "descricao";
            cbx_produto.Refresh();
        }


        public void preencherdtg()
        {
            sql = string.Format(@"select prodvenda.cod_prod as codigo, produto.descricao as produto, prodvenda.quantidade as quantidade, produto.preco as  preco from prodvenda join produto
            on prodvenda.cod_prod = produto.cod_produto where prodvenda.cod_venda = '{0}'", txt_codvenda.Text);

            dtg_pesqVendas.DataSource = bd.executarconsulta(sql);
        }


        public void CalcularTotal() 
        {
            sql = string.Format(@"select Sum(prodvenda.quantidade *  produto.preco) as total
            from prodvenda join produto on prodvenda.cod_prod = produto.cod_produto where prodvenda.cod_venda = '{0}'; ", txt_codvenda.Text);

            DataTable dt = new DataTable();
            dt = bd.executarconsulta(sql);

            if (dt.Rows.Count > 0)
            {
                txt_valorTotal.Text = dt.Rows[0]["total"].ToString();

            }

            else
            {
                txt_valorTotal.Text = "0";
            }

        }


        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            DateTime data = DateTime.Now;
            int cod = 0;

            sql = "Select max(cod_venda) as maior from venda";

            DataTable dt = new DataTable();
            dt = bd.executarconsulta(sql);


            if (dt.Rows.Count > 0)
            {
                cod = int.Parse(dt.Rows[0]["maior"].ToString());
            }
            else
            {
                cod = 0;
            }

            txt_codvenda.Text = (cod + 1).ToString();
            txt_dataVenda.Text = data.ToString("dd/MM/yyyy");


            sql = string.Format("insert into venda values ('{0}', '{1}')", txt_codvenda.Text, data.ToString("yyyy-MM-dd"));
            bd.executarcomandos(sql);
            btn_pesquisar.Enabled = false;

         }
        
        private void FrmVendas_Load_1(object sender, EventArgs e)
        {
            txt_codvenda.Enabled = false;
            txt_dataVenda.Enabled = false;
            txt_valorunitario.Enabled = false;
            txt_valorTotal.Enabled = false;
            comboboxProduto();
        }

        private void cbx_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = string.Format("select * from produto where cod_produto = '{0}'", cbx_produto.SelectedValue);
            DataTable dt = new DataTable();
            dt = bd.executarconsulta(sql);

            if (dt.Rows.Count > 0)
            {
                txt_valorunitario.Text = dt.Rows[0]["preco"].ToString();
            }

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (txt_Qtd.Text != "")
            {
                sql = string.Format("insert into  prodvenda values ('{0}', '{1}', '{2}')", cbx_produto.SelectedValue, txt_codvenda.Text, txt_Qtd.Text);
                bd.executarcomandos(sql);
                preencherdtg();
                CalcularTotal();




            }
            else
            {
                MessageBox.Show("Favor preencher a quantidade de produtos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void dtg_pesqVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo_produto = int.Parse(dtg_pesqVendas.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from prodvenda where cod_venda = '{0}' and cod_prod = '{1}'", txt_codvenda.Text, codigo_produto);
            bd.executarcomandos(sql);
            preencherdtg();
            CalcularTotal();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("o valor total a pagar é: " + double.Parse(txt_valorTotal.Text).ToString("C"), "venda finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txt_codvenda.Clear();
            txt_dataVenda.Clear();
            txt_Qtd.Clear();
            txt_valorTotal.Clear();
            btn_pesquisar.Enabled = true;
            dtg_pesqVendas.DataSource = null;
        }
    }
}
