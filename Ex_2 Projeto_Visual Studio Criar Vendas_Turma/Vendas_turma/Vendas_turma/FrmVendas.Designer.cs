namespace Vendas_turma
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_valortotal = new System.Windows.Forms.Label();
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.lbl_datavenda = new System.Windows.Forms.Label();
            this.txt_dataVenda = new System.Windows.Forms.TextBox();
            this.lblcodvenda = new System.Windows.Forms.Label();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_codvenda = new System.Windows.Forms.TextBox();
            this.dtg_pesqVendas = new System.Windows.Forms.DataGridView();
            this.cbx_produto = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.txt_Qtd = new System.Windows.Forms.TextBox();
            this.txt_valorunitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pesqVendas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_valortotal);
            this.panel1.Controls.Add(this.txt_valorTotal);
            this.panel1.Controls.Add(this.lbl_datavenda);
            this.panel1.Controls.Add(this.txt_dataVenda);
            this.panel1.Controls.Add(this.lblcodvenda);
            this.panel1.Controls.Add(this.btn_pesquisar);
            this.panel1.Controls.Add(this.txt_codvenda);
            this.panel1.Location = new System.Drawing.Point(23, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 53);
            this.panel1.TabIndex = 1;
            // 
            // lbl_valortotal
            // 
            this.lbl_valortotal.AutoSize = true;
            this.lbl_valortotal.Location = new System.Drawing.Point(411, 19);
            this.lbl_valortotal.Name = "lbl_valortotal";
            this.lbl_valortotal.Size = new System.Drawing.Size(58, 13);
            this.lbl_valortotal.TabIndex = 9;
            this.lbl_valortotal.Text = "Valor Total";
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.Location = new System.Drawing.Point(481, 16);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.Size = new System.Drawing.Size(117, 20);
            this.txt_valorTotal.TabIndex = 8;
            // 
            // lbl_datavenda
            // 
            this.lbl_datavenda.AutoSize = true;
            this.lbl_datavenda.Location = new System.Drawing.Point(218, 19);
            this.lbl_datavenda.Name = "lbl_datavenda";
            this.lbl_datavenda.Size = new System.Drawing.Size(64, 13);
            this.lbl_datavenda.TabIndex = 7;
            this.lbl_datavenda.Text = "Data Venda";
            // 
            // txt_dataVenda
            // 
            this.txt_dataVenda.Location = new System.Drawing.Point(288, 16);
            this.txt_dataVenda.Name = "txt_dataVenda";
            this.txt_dataVenda.Size = new System.Drawing.Size(117, 20);
            this.txt_dataVenda.TabIndex = 6;
            // 
            // lblcodvenda
            // 
            this.lblcodvenda.AutoSize = true;
            this.lblcodvenda.Location = new System.Drawing.Point(15, 19);
            this.lblcodvenda.Name = "lblcodvenda";
            this.lblcodvenda.Size = new System.Drawing.Size(74, 13);
            this.lblcodvenda.TabIndex = 5;
            this.lblcodvenda.Text = "Código Venda";
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(604, 9);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(92, 33);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Iniciar Vendas";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txt_codvenda
            // 
            this.txt_codvenda.Location = new System.Drawing.Point(95, 16);
            this.txt_codvenda.Name = "txt_codvenda";
            this.txt_codvenda.Size = new System.Drawing.Size(117, 20);
            this.txt_codvenda.TabIndex = 3;
            // 
            // dtg_pesqVendas
            // 
            this.dtg_pesqVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_pesqVendas.Location = new System.Drawing.Point(23, 96);
            this.dtg_pesqVendas.Name = "dtg_pesqVendas";
            this.dtg_pesqVendas.Size = new System.Drawing.Size(424, 345);
            this.dtg_pesqVendas.TabIndex = 2;
            this.dtg_pesqVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_pesqVendas_CellClick);
            // 
            // cbx_produto
            // 
            this.cbx_produto.FormattingEnabled = true;
            this.cbx_produto.Location = new System.Drawing.Point(27, 40);
            this.cbx_produto.Name = "cbx_produto";
            this.cbx_produto.Size = new System.Drawing.Size(185, 21);
            this.cbx_produto.TabIndex = 3;
            this.cbx_produto.SelectedIndexChanged += new System.EventHandler(this.cbx_produto_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_finalizar);
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.btn_Remover);
            this.panel2.Controls.Add(this.btn_adicionar);
            this.panel2.Controls.Add(this.txt_Qtd);
            this.panel2.Controls.Add(this.txt_valorunitario);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbx_produto);
            this.panel2.Location = new System.Drawing.Point(463, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 345);
            this.panel2.TabIndex = 4;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_finalizar.Image")));
            this.btn_finalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finalizar.Location = new System.Drawing.Point(131, 275);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(112, 49);
            this.btn_finalizar.TabIndex = 12;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_voltar.Location = new System.Drawing.Point(13, 275);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(112, 49);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Image = ((System.Drawing.Image)(resources.GetObject("btn_Remover.Image")));
            this.btn_Remover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Remover.Location = new System.Drawing.Point(132, 199);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(121, 49);
            this.btn_Remover.TabIndex = 10;
            this.btn_Remover.Text = "Remover Item";
            this.btn_Remover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.Image")));
            this.btn_adicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adicionar.Location = new System.Drawing.Point(13, 199);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(112, 49);
            this.btn_adicionar.TabIndex = 9;
            this.btn_adicionar.Text = "Adicionar Item";
            this.btn_adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // txt_Qtd
            // 
            this.txt_Qtd.Location = new System.Drawing.Point(27, 159);
            this.txt_Qtd.Name = "txt_Qtd";
            this.txt_Qtd.Size = new System.Drawing.Size(185, 20);
            this.txt_Qtd.TabIndex = 8;
            // 
            // txt_valorunitario
            // 
            this.txt_valorunitario.Location = new System.Drawing.Point(27, 97);
            this.txt_valorunitario.Name = "txt_valorunitario";
            this.txt_valorunitario.Size = new System.Drawing.Size(185, 20);
            this.txt_valorunitario.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor Unitário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produto";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtg_pesqVendas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmVendas";
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_pesqVendas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_valortotal;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.Label lbl_datavenda;
        private System.Windows.Forms.TextBox txt_dataVenda;
        private System.Windows.Forms.Label lblcodvenda;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_codvenda;
        private System.Windows.Forms.DataGridView dtg_pesqVendas;
        private System.Windows.Forms.ComboBox cbx_produto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox txt_Qtd;
        private System.Windows.Forms.TextBox txt_valorunitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}