﻿namespace LojaTeste
{
    partial class frmItemPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCodigoPedido = new System.Windows.Forms.TextBox();
            this.TbCodigoProduto = new System.Windows.Forms.TextBox();
            this.TbQuantidadePedido = new System.Windows.Forms.TextBox();
            this.TbValorPedido = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Pedido";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // TbCodigoPedido
            // 
            this.TbCodigoPedido.Location = new System.Drawing.Point(15, 25);
            this.TbCodigoPedido.Name = "TbCodigoPedido";
            this.TbCodigoPedido.Size = new System.Drawing.Size(100, 20);
            this.TbCodigoPedido.TabIndex = 3;
            // 
            // TbCodigoProduto
            // 
            this.TbCodigoProduto.Location = new System.Drawing.Point(15, 75);
            this.TbCodigoProduto.Name = "TbCodigoProduto";
            this.TbCodigoProduto.Size = new System.Drawing.Size(100, 20);
            this.TbCodigoProduto.TabIndex = 3;
            // 
            // TbQuantidadePedido
            // 
            this.TbQuantidadePedido.Location = new System.Drawing.Point(15, 129);
            this.TbQuantidadePedido.Name = "TbQuantidadePedido";
            this.TbQuantidadePedido.Size = new System.Drawing.Size(100, 20);
            this.TbQuantidadePedido.TabIndex = 3;
            // 
            // TbValorPedido
            // 
            this.TbValorPedido.Location = new System.Drawing.Point(15, 183);
            this.TbValorPedido.Name = "TbValorPedido";
            this.TbValorPedido.Size = new System.Drawing.Size(100, 20);
            this.TbValorPedido.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::LojaTeste.Properties.Resources.ImgSair;
            this.btnSair.Location = new System.Drawing.Point(134, 364);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 95);
            this.btnSair.TabIndex = 13;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = global::LojaTeste.Properties.Resources.ImgConfirmar;
            this.btnConfirmar.Location = new System.Drawing.Point(12, 364);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(101, 95);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // frmItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 471);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.TbValorPedido);
            this.Controls.Add(this.TbQuantidadePedido);
            this.Controls.Add(this.TbCodigoProduto);
            this.Controls.Add(this.TbCodigoPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmItemPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemPedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbCodigoPedido;
        private System.Windows.Forms.TextBox TbCodigoProduto;
        private System.Windows.Forms.TextBox TbQuantidadePedido;
        private System.Windows.Forms.TextBox TbValorPedido;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConfirmar;
    }
}