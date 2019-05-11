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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ConexaoBD bd = new ConexaoBD();
        String sql;

        public void limpar()
        {
            txt_codigo.Clear();
            txt_descricao.Clear();
            txt_preco.Clear();
            txt_qtd.Clear();
            txt_codigo.Focus();
        }


        private void btn_novo_Click(object sender, EventArgs e)
        {
            sql = string.Format("insert into produto values('{0}','{1}','{2}','{3}')", txt_codigo.Text, txt_descricao.Text, txt_qtd.Text, txt_preco.Text);
            if (bd.executarcomandos(sql) > 0)
            {
                MessageBox.Show("Produto Cadastrado com sucesso...");
                limpar();
            }
        }



        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            sql = string.Format("update produto set descricao = '{0}', quantidade = '{1}', preco = '{2}' where cod_produto = '{3}'", txt_descricao.Text, txt_qtd.Text, txt_preco.Text, txt_codigo.Text);

            if (bd.executarcomandos(sql) > 0)
            {
                MessageBox.Show("Produto alterado com sucesso!!!");
                limpar();
            }
        }




        private void btn_buscar_Click(object sender, EventArgs e)
        {
            sql = string.Format("select * from produto where cod_produto = '{0}'", txt_codigo.Text);
            DataTable dt = bd.executarconsulta(sql);

            if (dt.Rows.Count > 0)
            {
                txt_descricao.Text = dt.Rows[0]["descricao"].ToString();
               txt_qtd.Text = dt.Rows[0]["quantidade"].ToString();
                txt_preco.Text = dt.Rows[0]["preco"].ToString();

            }

            else
            {
                MessageBox.Show("Registro não encontrato.");
                limpar();
            }


        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            sql = string.Format("delete from produto where cod_produto = '{0}'", txt_codigo.Text);
            if (bd.executarcomandos(sql) > 0)
            {
                MessageBox.Show("produto excluído com sucesso");
                limpar();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
