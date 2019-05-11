namespace Vendas_turma
{
    partial class frmPesqProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesqProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.rdb_preco = new System.Windows.Forms.RadioButton();
            this.rdb_desc = new System.Windows.Forms.RadioButton();
            this.rdb_todos = new System.Windows.Forms.RadioButton();
            this.dtg_PesqProduto = new System.Windows.Forms.DataGridView();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PesqProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_pesquisar);
            this.panel1.Controls.Add(this.txt_pesquisar);
            this.panel1.Controls.Add(this.rdb_preco);
            this.panel1.Controls.Add(this.rdb_desc);
            this.panel1.Controls.Add(this.rdb_todos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 47);
            this.panel1.TabIndex = 0;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.Location = new System.Drawing.Point(453, 9);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(92, 33);
            this.btn_pesquisar.TabIndex = 4;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(316, 17);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(117, 20);
            this.txt_pesquisar.TabIndex = 3;
            // 
            // rdb_preco
            // 
            this.rdb_preco.AutoSize = true;
            this.rdb_preco.Location = new System.Drawing.Point(224, 17);
            this.rdb_preco.Name = "rdb_preco";
            this.rdb_preco.Size = new System.Drawing.Size(53, 17);
            this.rdb_preco.TabIndex = 2;
            this.rdb_preco.TabStop = true;
            this.rdb_preco.Text = "Preço";
            this.rdb_preco.UseVisualStyleBackColor = true;
            // 
            // rdb_desc
            // 
            this.rdb_desc.AutoSize = true;
            this.rdb_desc.Location = new System.Drawing.Point(121, 17);
            this.rdb_desc.Name = "rdb_desc";
            this.rdb_desc.Size = new System.Drawing.Size(73, 17);
            this.rdb_desc.TabIndex = 1;
            this.rdb_desc.TabStop = true;
            this.rdb_desc.Text = "Descrição";
            this.rdb_desc.UseVisualStyleBackColor = true;
            // 
            // rdb_todos
            // 
            this.rdb_todos.AutoSize = true;
            this.rdb_todos.Location = new System.Drawing.Point(24, 17);
            this.rdb_todos.Name = "rdb_todos";
            this.rdb_todos.Size = new System.Drawing.Size(55, 17);
            this.rdb_todos.TabIndex = 0;
            this.rdb_todos.TabStop = true;
            this.rdb_todos.Text = "Todos";
            this.rdb_todos.UseVisualStyleBackColor = true;
            // 
            // dtg_PesqProduto
            // 
            this.dtg_PesqProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_PesqProduto.Location = new System.Drawing.Point(12, 81);
            this.dtg_PesqProduto.Name = "dtg_PesqProduto";
            this.dtg_PesqProduto.Size = new System.Drawing.Size(548, 256);
            this.dtg_PesqProduto.TabIndex = 5;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnvoltar.Location = new System.Drawing.Point(472, 343);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(88, 33);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmPesqProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 406);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.dtg_PesqProduto);
            this.Controls.Add(this.panel1);
            this.Name = "frmPesqProduto";
            this.Text = "Pesquisar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_PesqProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_PesqProduto;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.RadioButton rdb_preco;
        private System.Windows.Forms.RadioButton rdb_desc;
        private System.Windows.Forms.RadioButton rdb_todos;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}