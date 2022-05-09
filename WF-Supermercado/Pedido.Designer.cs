namespace WF_Supermercado
{
    partial class Pedido
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
            this.lbxPedido = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxParcelas = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxPedido
            // 
            this.lbxPedido.FormattingEnabled = true;
            this.lbxPedido.ItemHeight = 20;
            this.lbxPedido.Location = new System.Drawing.Point(133, 89);
            this.lbxPedido.Name = "lbxPedido";
            this.lbxPedido.Size = new System.Drawing.Size(223, 24);
            this.lbxPedido.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(174, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Forma de Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pagamento:";
            // 
            // cbxPagamento
            // 
            this.cbxPagamento.FormattingEnabled = true;
            this.cbxPagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "Pix"});
            this.cbxPagamento.Location = new System.Drawing.Point(232, 220);
            this.cbxPagamento.Name = "cbxPagamento";
            this.cbxPagamento.Size = new System.Drawing.Size(164, 28);
            this.cbxPagamento.TabIndex = 8;
            this.cbxPagamento.SelectedIndexChanged += new System.EventHandler(this.cbxPagamento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Parcelas:";
            // 
            // cbxParcelas
            // 
            this.cbxParcelas.FormattingEnabled = true;
            this.cbxParcelas.Location = new System.Drawing.Point(232, 274);
            this.cbxParcelas.Name = "cbxParcelas";
            this.cbxParcelas.Size = new System.Drawing.Size(94, 28);
            this.cbxParcelas.TabIndex = 8;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(173, 345);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(132, 32);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 445);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.cbxParcelas);
            this.Controls.Add(this.cbxPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxParcelas;
        private System.Windows.Forms.Button btnPagar;
    }
}