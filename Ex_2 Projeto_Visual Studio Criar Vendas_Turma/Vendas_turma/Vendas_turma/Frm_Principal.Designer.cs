namespace Vendas_turma
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.ptb_pesq = new System.Windows.Forms.PictureBox();
            this.ptb_vendas = new System.Windows.Forms.PictureBox();
            this.ptb_produtos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pesq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_pesq
            // 
            this.ptb_pesq.Image = ((System.Drawing.Image)(resources.GetObject("ptb_pesq.Image")));
            this.ptb_pesq.Location = new System.Drawing.Point(12, 67);
            this.ptb_pesq.Name = "ptb_pesq";
            this.ptb_pesq.Size = new System.Drawing.Size(243, 208);
            this.ptb_pesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_pesq.TabIndex = 0;
            this.ptb_pesq.TabStop = false;
            this.ptb_pesq.Click += new System.EventHandler(this.ptb_pesq_Click);
            // 
            // ptb_vendas
            // 
            this.ptb_vendas.Image = ((System.Drawing.Image)(resources.GetObject("ptb_vendas.Image")));
            this.ptb_vendas.Location = new System.Drawing.Point(286, 67);
            this.ptb_vendas.Name = "ptb_vendas";
            this.ptb_vendas.Size = new System.Drawing.Size(283, 208);
            this.ptb_vendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_vendas.TabIndex = 1;
            this.ptb_vendas.TabStop = false;
            this.ptb_vendas.Click += new System.EventHandler(this.ptb_vendas_Click);
            // 
            // ptb_produtos
            // 
            this.ptb_produtos.Image = ((System.Drawing.Image)(resources.GetObject("ptb_produtos.Image")));
            this.ptb_produtos.Location = new System.Drawing.Point(614, 67);
            this.ptb_produtos.Name = "ptb_produtos";
            this.ptb_produtos.Size = new System.Drawing.Size(256, 208);
            this.ptb_produtos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_produtos.TabIndex = 2;
            this.ptb_produtos.TabStop = false;
            this.ptb_produtos.Click += new System.EventHandler(this.ptb_produtos_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 368);
            this.Controls.Add(this.ptb_produtos);
            this.Controls.Add(this.ptb_vendas);
            this.Controls.Add(this.ptb_pesq);
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_pesq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_pesq;
        private System.Windows.Forms.PictureBox ptb_vendas;
        private System.Windows.Forms.PictureBox ptb_produtos;
    }
}